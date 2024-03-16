using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
  public class PersonModel
  {
    /// <summary>
    /// Unique identifier for Person.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// First name of PersonModel.
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Last name of PersonModel.
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Email address of PersonModel.
    /// Used to notify by email.
    /// </summary>
    public string EmailAddress { get; set; }

    /// <summary>
    /// Cell phone number of PersonModel.
    /// Used to notify by text.
    /// </summary>
    public string CellPhoneNumber { get; set; }

    /// <summary>
    /// Gets the full name by concatenating the first name and last name properties.
    /// </summary>
    public string FullName
    {
      get
      {
        return $"{FirstName} {LastName}";
      }
    }
  }
}
