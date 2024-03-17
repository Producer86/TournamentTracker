using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
  public class TextConnector : IDataConnection
  {
    private const string PrizesFile = "PrizeModels.csv";
    private const string PeopleFile = "PersonModel.csv";
    private const string TeamsFile = "TeamModels.csv";

    /// <summary>
    /// Saves a new Person to a text file.
    /// </summary>
    /// <param name="model">The PersonModel to save.</param>
    /// <returns>The PersonModel with it's Id set.</returns>
    public PersonModel CreatePerson(PersonModel model)
    {
      // Load the text file
      // Convert text to List<PersonModel>
      List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

      // Find the highest id
      // Add new record with max id+1
      int currentId = 1;
      if (people.Count > 0)
      {
        currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
      }
      model.Id = currentId;

      people.Add(model);

      // Convert prizes to List<string>
      // Save List<string> to text file
      people.SaveToPeopleFile(PeopleFile);

      return model;
    }

    /// <summary>
    /// Saves a new Prize to a text file.
    /// </summary>
    /// <param name="model">The PrizeModel to save.</param>
    /// <returns>The PrizeModel with it's Id set.</returns>
    public PrizeModel CreatePrize(PrizeModel model)
    {
      // Load the text file
      // Convert text to List<PrizeModel>
      List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

      // Find the highest id
      // Add new record with max id+1
      int currentId = 1;
      if (prizes.Count > 0)
      {
        currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
      }
      model.Id = currentId;

      prizes.Add(model);

      // Convert prizes to List<string>
      // Save List<string> to text file
      prizes.SaveToPrizeFile(PrizesFile);

      return model;
    }

    /// <summary>
    /// Saves a new Team to a text file.
    /// </summary>
    /// <param name="model">The TeamModel to save.</param>
    /// <returns>The TeamModel with it's Id set.</returns>
    public TeamModel CreateTeam(TeamModel model)
    {
      // Load the text file
      // Convert text to List<TeamModel>
      List<TeamModel> teams = TeamsFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);

      // Find the highest id
      // Add new record with max id+1
      int currentId = 1;
      if (teams.Count > 0)
      {
        currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
      }
      model.Id = currentId;

      teams.Add(model);

      // Convert teams to List<string>
      // Save List<string> to text file
      teams.SaveToTeamFile(TeamsFile);
      
      return model;
    }

    /// <summary>
    /// Retrieves all person records from a file.
    /// </summary>
    /// <returns>A list of PersonModel objects representing all person records.</returns>
    public List<PersonModel> GetPerson_All()
    {
      return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
    }
  }
}
