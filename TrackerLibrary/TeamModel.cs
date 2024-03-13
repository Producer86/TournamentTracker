using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
  public class TeamModel
  {
    /// <summary>
    /// Person memembers of this Team.
    /// </summary>
    public List<Person> TeamMembers { get; set; } = new List<Person>();
    
    /// <summary>
    /// The name of this Team.
    /// </summary>
    public string TeamName { get; set; }
  }
}
