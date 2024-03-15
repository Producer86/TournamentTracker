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
    public static string FullFilePath(this string fileName)
    {
      return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
    }

    public static List<string> LoadFile(this string fileName)
    { 
      if (!File.Exists(fileName))
      {
        return new List<string>();
      }

      return File.ReadAllLines(fileName).ToList();
    }

    public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
    {
      List<PrizeModel> result = new List<PrizeModel>();

      foreach (string line in lines)
      {
        string[] cols = line.Split(',');
        PrizeModel model = new PrizeModel();
        model.Id = int.Parse(cols[0]);
        model.PlaceNumber = int.Parse(cols[1]);
        model.PlaceName = cols[2];
        model.PrizeAmount = decimal.Parse(cols[3]);
        model.PrizePercentage = double.Parse(cols[4]);

        result.Add(model);
      }

      return result;
    }

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
