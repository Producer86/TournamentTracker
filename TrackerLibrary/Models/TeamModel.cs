using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
  public class TeamModel
  {
    /// <summary>
    /// The unique identifier of a team.
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// The name of this Team.
    /// </summary>
    public string TeamName { get; set; }
    /// <summary>
    /// PersonModel memembers of this Team.
    /// </summary>
    public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

  }
}
