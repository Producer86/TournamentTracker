using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
  public class SqlConnector : IDataConnection
  {
    private const string db = "Tournaments";
    /// <summary>
    /// Saves a new Person to the database.
    /// </summary>
    /// <param name="model">The PersonModel to save.</param>
    /// <returns>The PersonModel with it's Id set.</returns>
    public PersonModel CreatePerson(PersonModel model)
    {
      using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
      {
        var p = new DynamicParameters();
        p.Add("@FirstName", model.FirstName);
        p.Add("@LastName", model.LastName);
        p.Add("@EmailAddress", model.EmailAddress);
        p.Add("@CellPhoneNumber", model.CellPhoneNumber);
        p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

        connection.Execute("dbo.spPeople_Insert", p, commandType: CommandType.StoredProcedure);

        model.Id = p.Get<int>("@id");

        return model;
      }
    }

    /// <summary>
    /// Saves a new Prize to the database.
    /// </summary>
    /// <param name="model">The PrizeModel to save.</param>
    /// <returns>The PrizeModel with it's Id set.</returns>
    public PrizeModel CreatePrize(PrizeModel model)
    {
      using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
      {
        var p = new DynamicParameters();
        p.Add("@PlaceNumber", model.PlaceNumber);
        p.Add("@PlaceName", model.PlaceName);
        p.Add("@PrizeAmount", model.PrizeAmount);
        p.Add("@PrizePercentage", model.PrizePercentage);
        p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

        connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

        model.Id = p.Get<int>("@id");

        return model;
      }
    }

    /// <summary>
    /// Creates a new team in the database.
    /// </summary>
    /// <param name="model">The TeamModel object representing the team to be created.</param>
    /// <returns>The TeamModel object representing the created team.</returns>
    public TeamModel CreateTeam(TeamModel model)
    {
      // Establish a connection to the database.
      using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
      {
        var p = new DynamicParameters();
        p.Add("@TeamName", model.TeamName);
        p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

        // Execute the stored procedure to insert the team into the database.
        connection.Execute("dbo.spTeams_Insert", p, commandType: CommandType.StoredProcedure);

        // Retrieve the id of the newly created team from the output parameter.
        model.Id = p.Get<int>("@id");

        // Insert team members into the database.
        foreach (var person in model.TeamMembers)
        {
          p = new DynamicParameters();
          p.Add("@TeamId", model.Id);
          p.Add("@PersonId", person.Id);

          // Execute the stored procedure to insert team members into the database.
          connection.Execute("dbo.spTeamMembers_Insert", p, commandType: CommandType.StoredProcedure);
        }

        return model;
      }
    }

    public void CreateTournament(TournamentModel model)
    {
      using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
      {
        SaveTournament(model, connection);
        SaveTournamentPrizes(model, connection);
        SaveTournamentEntries(model, connection);
      }
    }

    private static void SaveTournamentEntries(TournamentModel model, IDbConnection connection)
    {
      foreach (var team in model.EnteredTeams)
      {
        var p = new DynamicParameters();
        p.Add("@TournamentId", model.Id);
        p.Add("@TeamId", team.Id);
        p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
        connection.Execute("dbo.spTournamentEntries_Insert", p, commandType: CommandType.StoredProcedure);
      }
    }

    private static void SaveTournamentPrizes(TournamentModel model, IDbConnection connection)
    {
      foreach (var prize in model.Prizes)
      {
        var p = new DynamicParameters();
        p.Add("@TournamentId", model.Id);
        p.Add("@PrizeId", prize.Id);
        p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
        connection.Execute("dbo.spTournamentPrizes_Insert", p, commandType: CommandType.StoredProcedure);
      }
    }

    private static void SaveTournament(TournamentModel model, IDbConnection connection)
    {
      var p = new DynamicParameters();
      p.Add("@TournamentName", model.TournamentName);
      p.Add("@EntryFee", model.EntryFee);
      p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

      connection.Execute("dbo.spTournament_Insert", p, commandType: CommandType.StoredProcedure);

      // Retrieve the id of the newly created team from the output parameter.
      model.Id = p.Get<int>("@id");
    }

    /// <summary>
    /// Retrieves all person records from the database.
    /// </summary>
    /// <returns>A list of PersonModel objects representing all person records.</returns>
    public List<PersonModel> GetPerson_All()
    {
      List<PersonModel> result;
      using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
      {
        result = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
      }

      return result;
    }

    /// <summary>
    /// Retrieves all team records from the database.
    /// </summary>
    /// <returns>A list of TeamModel objects representing all team records.</returns>
    public List<TeamModel> GetTeam_All()
    {
      List<TeamModel> result;
      using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
      {
        result = connection.Query<TeamModel>("dbo.spTeam_GetAll").ToList();

        foreach (var team in result)
        {
          var p = new DynamicParameters();
          p.Add("@TeamId", team.Id);
          team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();
        }
      }

      return result;
    }
  }
}
