using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelpers
{
  public static class TextConnectorProcessor
  {
    /// <summary>
    /// Constructs the full file path by combining the specified fileName with the file path retrieved from the application settings.
    /// </summary>
    /// <param name="fileName">The name of the file to construct the full path for.</param>
    /// <returns>The full file path.</returns>
    public static string FullFilePath(this string fileName)
    {
      return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
    }

    /// <summary>
    /// Loads the contents of a file specified by the filePath into a list of strings.
    /// </summary>
    /// <param name="filePath">The path to the file to be loaded.</param>
    /// <returns>A list of strings containing the lines of the file, or an empty list if the file does not exist.</returns>
    public static List<string> LoadFile(this string filePath)
    {
      if (!File.Exists(filePath))
      {
        return [];
      }

      return File.ReadAllLines(filePath).ToList();
    }

    /// <summary>
    /// Converts a list of comma separated lines into a list of PersonModels.
    /// </summary>
    /// <param name="lines">Comma separated lines of PersonModel information.</param>
    /// <returns>The list of PersonModel.</returns>
    public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
    {
      List<PersonModel> result = [];

      foreach (string line in lines)
      {
        string[] cols = line.Split(',');
        PersonModel model = new PersonModel
        {
          Id = int.Parse(cols[0]),
          FirstName = cols[1].Trim(),
          LastName = cols[2].Trim(),
          EmailAddress = cols[3].Trim(),
          CellPhoneNumber = cols[4].Trim()
        };

        result.Add(model);
      }

      return result;
    }

    /// <summary>
    /// Converts a list of comma separated lines into a list of PrizeModels.
    /// </summary>
    /// <param name="lines">Comma separated lines of PrizeModel information.</param>
    /// <returns>The list of PrizeModel.</returns>
    public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
    {
      List<PrizeModel> result = [];

      foreach (string line in lines)
      {
        string[] cols = line.Split(',');
        PrizeModel model = new PrizeModel
        {
          Id = int.Parse(cols[0]),
          PlaceNumber = int.Parse(cols[1]),
          PlaceName = cols[2].Trim(),
          PrizeAmount = decimal.Parse(cols[3]),
          PrizePercentage = double.Parse(cols[4])
        };

        result.Add(model);
      }

      return result;
    }

    /// <summary>
    /// Converts a list of strings representing round data into a list of TeamModel objects.
    /// </summary>
    /// <param name="lines">The list of strings representing round data.</param>
    /// <param name="peopleFileName">The file name of the file containing round data.</param>
    /// <returns>A list of TeamModel objects representing the teams.</returns>
    public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string peopleFileName)
    {
      // What we expect in a line:
      // 0,  1,         2,
      // matchup, team_name, list of round ids separated by pipe character
      // 2, Joe's Team, 5|12|1

      List<TeamModel> result = [];
      List<PersonModel> people = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModels();

      foreach (string line in lines)
      {
        string[] cols = line.Split(',');

        TeamModel model = new TeamModel
        {
          Id = int.Parse(cols[0]),
          TeamName = cols[1]
        };

        string[] personIds = cols[2].Split('|');

        foreach (var id in personIds)
        {
          // Find the round round with the matching matchup and add it to the round members
          model.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
        }

        result.Add(model);
      }

      return result;
    }

    public static List<TournamentModel> ConvertToTournamentModels(
      this List<string> lines,
      string teamFileName,
      string peopleFileName,
      string prizesFileName)
    {
      // What we expect in a line:
      // 0,       1,              2,        3,                               4,                         5
      // matchup, TournamentName, EntryFee, matchup|matchup = enteredTeamId, matchup|matchup = prizeId. matchup^matchup|matchup^matchup = matchupId

      List<TournamentModel> result = [];
      List<TeamModel> teams = teamFileName.FullFilePath().LoadFile().ConvertToTeamModels(peopleFileName);
      List<PrizeModel> prizes = prizesFileName.FullFilePath().LoadFile().ConvertToPrizeModels();

      foreach (var line in lines)
      {
        string[] cols = line.Split(",");
        TournamentModel model = new TournamentModel
        {
          Id = int.Parse(cols[0]),
          TournamentName = cols[1],
          EntryFee = int.Parse(cols[2]),
        };

        string[] teamIds = cols[3].Split('|');
        foreach (var id in teamIds)
        {
          model.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());
        }

        string[] prizeIds = cols[4].Split('|');
        foreach (var id in prizeIds)
        {
          model.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
        }

        // TODO - capture rounds information.

        result.Add(model);
      }

      return result;
    }

    /// <summary>
    /// Saves the given list of PersonModel into a text file.
    /// </summary>
    /// <param name="models">The list of PersonModels to save.</param>
    /// <param name="fileName">The name of the file to save to. Full path will be taken from App.config.</param>
    public static void SaveToPeopleFile(this List<PersonModel> models, string fileName)
    {
      List<string> lines = [];

      foreach (PersonModel model in models)
      {
        lines.Add($"{model.Id},{model.FirstName},{model.LastName},{model.EmailAddress},{model.CellPhoneNumber}");
      }

      File.WriteAllLines(fileName.FullFilePath(), lines);
    }

    /// <summary>
    /// Saves the given list of PrizeModel into a text file.
    /// </summary>
    /// <param name="models">The list of PrizeModels to save.</param>
    /// <param name="fileName">The name of the file to save to. Full path will be taken from App.config.</param>
    public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
    {
      List<string> lines = [];

      foreach (PrizeModel model in models)
      {
        lines.Add($"{model.Id},{model.PlaceNumber},{model.PlaceName},{model.PrizeAmount},{model.PrizePercentage}");
      }

      File.WriteAllLines(fileName.FullFilePath(), lines);
    }

    /// <summary>
    /// Saves a list of TeamModel objects to a file.
    /// </summary>
    /// <param name="models">The list of TeamModel objects to be saved.</param>
    /// <param name="fileName">The name of the file to which the data will be saved.</param>
    public static void SaveToTeamFile(this List<TeamModel> models, string fileName)

    {
      List<string> lines = [];

      foreach (TeamModel model in models)
      {
        lines.Add($"{model.Id},{model.TeamName},{_ConvertPeopleListToString(model.TeamMembers)}");
      }

      File.WriteAllLines(fileName.FullFilePath(), lines);
    }

    /// <summary>
    /// Converts a list of PersonModel objects into a string representation of their IDs separated by '|' characters.
    /// </summary>
    /// <param name="models">The list of PersonModel objects to be converted.</param>
    /// <returns>A string representing the IDs of the PersonModel objects separated by '|' characters.</returns>
    private static string _ConvertPeopleListToString(List<PersonModel> models)
    {
      List<string> ids = [];
      foreach (var person in models)
      {
        ids.Add(person.Id.ToString());
      }

      string result = string.Join('|', ids);
      return result;
    }

    public static void SaveToTournamentFile(this List<TournamentModel> models, string fileName)
    {
      // What we expect in a line:
      // 0,       1,              2,        3,                               4,                         5
      // matchup, TournamentName, EntryFee, matchup|matchup = enteredTeamId, matchup|matchup = prizeId. matchup^matchup|matchup^matchup = matchupId
      List<string> lines = [];
      foreach (var model in models)
      {
        lines.Add($@"{model.Id},
          {model.TournamentName},
          {model.EntryFee},
          {_ConvertTeamListToString(model.EnteredTeams)},
          {_ConvertPrizeListToString(model.Prizes)},
          {_ConvertRoundsListToString(model.Rounds)}");
      }

      File.WriteAllLines(fileName.FullFilePath(), lines);
    }

    /// <summary>
    /// Converts a list of TeamModel objects into a string representation of their IDs separated by '|' characters.
    /// </summary>
    /// <param name="models">The list of TeamModel objects to be converted.</param>
    /// <returns>A string representing the IDs of the TeamModel objects separated by '|' characters.</returns>
    private static string _ConvertTeamListToString(List<TeamModel> models)
    {
      List<string> ids = [];
      foreach (var team in models)
      {
        ids.Add(team.Id.ToString());
      }

      string result = string.Join('|', ids);
      return result;
    }


    /// <summary>
    /// Converts a list of PrizeModel objects into a string representation of their IDs separated by '|' characters.
    /// </summary>
    /// <param name="models">The list of PrizeModel objects to be converted.</param>
    /// <returns>A string representing the IDs of the PrizeModel objects separated by '|' characters.</returns>
    private static string _ConvertPrizeListToString(List<PrizeModel> models)
    {
      List<string> ids = [];
      foreach (var prize in models)
      {
        ids.Add(prize.Id.ToString());
      }

      string result = string.Join('|', ids);
      return result;
    }


    /// <summary>
    /// Converts a list of rounds, each containing matchups, into a string representation of their IDs separated by '^' and '|' characters.
    /// </summary>
    /// <param name="rounds">The list of rounds containing matchups.</param>
    /// <returns>A string representing the IDs of matchups in each round, separated by '^', and rounds separated by '|' characters.</returns>
    private static string _ConvertRoundsListToString(List<List<MatchupModel>> rounds)

    {
      // matchup^matchup|matchup^matchup = matchupId
      List<string> ids = [];
      foreach (List<MatchupModel> round in rounds)
      {
        List<string> matchups = [];
        foreach (MatchupModel matchup in round)
        {
          matchups.Add(matchup.Id.ToString());
        }
        ids.Add(string.Join('^', matchups));
      }

      string result = string.Join('|', ids);
      return result;
    }
  }
}