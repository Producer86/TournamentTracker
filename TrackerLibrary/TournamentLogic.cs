using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
  static public class TournamentLogic
  {
    // Tasks to do here:
    // Order our teams list randomly.
    // Check if we have 2^n teams. If no, add byes.
    // Create the first round matchups.
    // Generate remaining matchups for remaining rounds. 8 -> 4 -> 2 -> 1

    /// <summary>
    /// Creates the rounds for the tournament.
    /// </summary>
    /// <param name="tournament">The tournament for which rounds are to be created.</param>
    public static void CreateRounds(TournamentModel tournament)
    {
      List<TeamModel> randomTeams = _RandomizeTeamOrder(tournament.EnteredTeams);
      int rounds = _FindNumberOfRounds(randomTeams.Count);
      int byes = _NumberOfByes(rounds, randomTeams.Count);

      tournament.Rounds.Add(_CreateFirstRound(byes, randomTeams));

      _CreateOtherRounds(tournament, rounds);
    }

    /// <summary>
    /// Given a tournament with it's first round properly set up, creates the remaining rounds.
    /// </summary>
    /// <param name="tournament">The tournament for which rounds are to be created.</param>
    /// <param name="rounds">The total number of rounds in the tournament.</param>
    private static void _CreateOtherRounds(TournamentModel tournament, int rounds)
    {
      int round = 2;
      List<MatchupModel> previousRound = tournament.Rounds.First();
      List<MatchupModel> currentRound = [];
      MatchupModel currentMatchup = new MatchupModel();

      while (round <= rounds)
      {
        foreach (var matchup in previousRound)
        {
          currentMatchup.Entries.Add(new MatchupEntryModel { ParentMatchup = matchup });

          // If we have both our teams, next matchup.
          if (currentMatchup.Entries.Count > 1)
          {
            currentMatchup.MatchupRound = round;
            currentRound.Add(currentMatchup);
            currentMatchup = new MatchupModel();
          }
        }

        tournament.Rounds.Add(currentRound);
        previousRound = currentRound;
        currentRound = new List<MatchupModel>();
        round++;
      }
    }

    /// <summary>
    /// Creates the matchups for the first round of a tournament with the given number of byes and teams.
    /// </summary>
    /// <param name="byes">The number of byes in the first round.</param>
    /// <param name="teams">The list of teams participating in the tournament.</param>
    /// <returns>A list of matchups for the first round of the tournament.</returns>
    private static List<MatchupModel> _CreateFirstRound(int byes, List<TeamModel> teams)
    {
      List<MatchupModel> result = [];

      MatchupModel currentMatchup = new MatchupModel();
      foreach (var team in teams)
      {
        currentMatchup.Entries.Add(new MatchupEntryModel { TeamCompeting = team });

        // If we have byes left to add or the matchup is full start the next one.
        if (byes > 0 || currentMatchup.Entries.Count > 1)
        {
          currentMatchup.MatchupRound = 1;
          result.Add(currentMatchup);
          currentMatchup = new MatchupModel();
          byes--;
        }
      }

      return result;
    }

    /// <summary>
    /// Calculates the number of byes for a tournament with the given number of rounds and teams count.
    /// </summary>
    /// <param name="rounds">The number of rounds in the tournament.</param>
    /// <param name="teamsCount">The total number of teams participating in the tournament.</param>
    /// <returns>The number of byes needed in the tournament.</returns>
    private static int _NumberOfByes(int rounds, int teamsCount)
    {
      return (int)Math.Pow(2, rounds) - teamsCount;
    }

    /// <summary>
    /// Calculates the number of rounds needed for a tournament with the given number of teams.
    /// </summary>
    /// <param name="teamCount">The number of teams participating in the tournament.</param>
    /// <returns>The number of rounds required for the tournament.</returns>
    private static int _FindNumberOfRounds(int teamCount)
    {
      double rounds = Math.Log2(teamCount);
      double targetRounds = Math.Ceiling(rounds);

      return (int)targetRounds;
    }

    /// <summary>
    /// Randomizes the order of teams in the given list.
    /// </summary>
    /// <param name="teams">The list of teams to be randomized.</param>
    /// <returns>A new list containing the teams in random order.</returns>
    private static List<TeamModel> _RandomizeTeamOrder(List<TeamModel> teams)
    {
      return teams.OrderBy(t => Guid.NewGuid()).ToList();
    }
  }
}
