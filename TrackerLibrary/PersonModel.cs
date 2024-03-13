using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
  public class Person
  {
    /// <summary>
    /// First name of Person.
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Last name of Person.
    /// </summary>
    public string LastName { get; set; }
    
    /// <summary>
    /// Email address of Person.
    /// Used to notify by email.
    /// </summary>
    public string EmailAddress { get; set; }
    
    /// <summary>
    /// Cell phone number of Person.
    /// Used to notify by text.
    /// </summary>
    public string CellPhoneNumber { get; set; }
  }
}
