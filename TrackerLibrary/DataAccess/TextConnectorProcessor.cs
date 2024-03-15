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
    /// Split a text file into lines.
    /// </summary>
    /// <param name="filePath">The full path of the file.</param>
    /// <returns>Empty List<string> if the file doesn't exist.</string></returns>
    public static List<string> LoadFile(this string filePath)
    {
      if (!File.Exists(filePath))
      {
        return new List<string>();
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
      List<PersonModel> result = new List<PersonModel>();

      foreach (string line in lines)
      {
        string[] cols = line.Split(',');
        PersonModel model = new PersonModel();
        model.Id = int.Parse(cols[0]);
        model.FirstName = cols[1].Trim();
        model.LastName = cols[2].Trim();
        model.EmailAddress = cols[3].Trim();
        model.CellPhoneNumber = cols[4].Trim();

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
      List<PrizeModel> result = new List<PrizeModel>();

      foreach (string line in lines)
      {
        string[] cols = line.Split(',');
        PrizeModel model = new PrizeModel();
        model.Id = int.Parse(cols[0]);
        model.PlaceNumber = int.Parse(cols[1]);
        model.PlaceName = cols[2].Trim();
        model.PrizeAmount = decimal.Parse(cols[3]);
        model.PrizePercentage = double.Parse(cols[4]);

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
      List<string> lines = new List<string>();

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
      List<string> lines = new List<string>();

      foreach (PrizeModel model in models)
      {
        lines.Add($"{model.Id},{model.PlaceNumber},{model.PlaceName},{model.PrizeAmount},{model.PrizePercentage}");
      }

      File.WriteAllLines(fileName.FullFilePath(), lines);
    }
  }
}
