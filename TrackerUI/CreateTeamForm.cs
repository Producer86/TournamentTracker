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
  public partial class CreateTeamForm : Form
  {
    private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
    private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
    private ITeamRequester callingForm;

    public CreateTeamForm(ITeamRequester caller)
    {
      InitializeComponent();

      //CreateSampleData();

      callingForm = caller;

      wireUpLists();
    }

    private void CreateSampleData()
    {
      availableTeamMembers.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
      availableTeamMembers.Add(new PersonModel { FirstName = "John", LastName = "Doe" });

      selectedTeamMembers.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
      selectedTeamMembers.Add(new PersonModel { FirstName = "John", LastName = "Doe" });
    }

    private void wireUpLists()
    {
      // TODO - find better solution.
      selectTeamMemberDropDown.DataSource = null;

      selectTeamMemberDropDown.DataSource = availableTeamMembers;
      selectTeamMemberDropDown.DisplayMember = "FullName";

      teamMembersListBox.DataSource = null;

      teamMembersListBox.DataSource = selectedTeamMembers;
      teamMembersListBox.DisplayMember = "FullName";
    }

    private void createMemberButton_Click(object sender, EventArgs e)
    {
      if (validateForm())
      {
        PersonModel person = new PersonModel
        {
          FirstName = firstNameValue.Text,
          LastName = lastNameValue.Text,
          EmailAddress = emailValue.Text
        };

        string phoneValue = "";
        if (cellPhoneValue.Text.Length > 0) { phoneValue = cellPhoneValue.Text; }
        person.CellPhoneNumber = phoneValue;

        person = GlobalConfig.Connection.CreatePerson(person);

        availableTeamMembers.Add(person);
        wireUpLists();

        firstNameValue.Text = "";
        lastNameValue.Text = "";
        emailValue.Text = "";
        cellPhoneValue.Text = "";
      }
      else { MessageBox.Show("First Name, Last Name and Email address are required."); }
    }

    private bool validateForm()
    {
      if (firstNameValue.Text.Length == 0)
      {
        return false;
      }

      if (lastNameValue.Text.Length == 0)
      {
        return false;
      }

      if (emailValue.Text.Length == 0) { return false; }

      return true;
    }

    private void addMemberButton_Click(object sender, EventArgs e)
    {
      if (selectTeamMemberDropDown.SelectedItem is PersonModel person)
      {
        availableTeamMembers.Remove(person);
        selectedTeamMembers.Add(person);

        wireUpLists();
      }
    }

    private void removeMemberButton_Click(object sender, EventArgs e)
    {
      if (teamMembersListBox.SelectedItem is PersonModel person)
      {
        selectedTeamMembers.Remove(person);
        availableTeamMembers.Add(person);

        wireUpLists();
      }
    }

    private void createTeamButton_Click(object sender, EventArgs e)
    {
      TeamModel team = new TeamModel();
      team.TeamName = teamNameValue.Text.Trim();
      team.TeamMembers = selectedTeamMembers;

      team = GlobalConfig.Connection.CreateTeam(team);

      callingForm.TeamComplete(team);
      this.Close();
    }
  }
}
