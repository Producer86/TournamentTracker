using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
  public partial class CreatePrizeForm : Form
  {
    IPrizeRequester callingForm;
    public CreatePrizeForm(IPrizeRequester caller)
    {
      InitializeComponent();
      callingForm = caller;
    }

    private void createPrizeButton_Click(object sender, EventArgs e)
    {
      if (ValidateForm())
      {
        PrizeModel model = new PrizeModel(
          placeNumberValue.Text,
          placeNameValue.Text,
          prizeAmountValue.Text,
          prizePercentValue.Text);

        GlobalConfig.Connection.CreatePrize(model);
        callingForm.PrizeComplete(model);

        this.Close();
        //placeNumberValue.Text = "";
        //placeNameValue.Text = "";
        //prizeAmountValue.Text = "0";
        //prizePercentValue.Text = "0";
      }
      else { MessageBox.Show("Invalid prize information."); }
    }

    private bool ValidateForm()
    {
      bool result = true;

      int placeNumber = 0;
      bool isValidPlaceNumber = int.TryParse(placeNumberValue.Text, out placeNumber);

      if (isValidPlaceNumber == false)
      {
        result = false;
      }

      if (placeNumber < 1) { result = false; }

      if (placeNameValue.Text.Length == 0) { result = false; }

      decimal prizeAmount = 0;
      double prizePercent = 0;

      bool isValidPrizeAmount = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
      bool isValidPrizePercent = double.TryParse(prizePercentValue.Text, out prizePercent);

      if (isValidPrizeAmount == false || isValidPrizePercent == false) { result = false; }

      if (prizeAmount <= 0 && prizePercent <= 0) { result = false; }

      if (prizePercent < 0 || prizePercent > 100) { result = false; }

      return result;
    }
  }
}
