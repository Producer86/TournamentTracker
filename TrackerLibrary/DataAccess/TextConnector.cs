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
      // Add new record with id+1
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
  }
}
