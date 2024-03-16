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

    public CreateTeamForm()
    {
      InitializeComponent();

      //CreateSampleData();

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
      if (ValidateForm())
      {
        PersonModel person = new PersonModel();
        person.FirstName = firstNameValue.Text;
        person.LastName = lastNameValue.Text;
        person.EmailAddress = emailValue.Text;

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

    private bool ValidateForm()
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
      PersonModel person = selectTeamMemberDropDown.SelectedItem as PersonModel;

      if (person != null)
      {
        availableTeamMembers.Remove(person);
        selectedTeamMembers.Add(person);

        wireUpLists(); 
      }
    }

    private void removeMemberButton_Click(object sender, EventArgs e)
    {
      PersonModel person = teamMembersListBox.SelectedItem as PersonModel;

      if (person != null)
      {
        selectedTeamMembers.Remove(person);
        availableTeamMembers.Add(person);

        wireUpLists();
      }
    }
  }
}
