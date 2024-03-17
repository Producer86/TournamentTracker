﻿using System;
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
  public partial class CreateTournamentForm : Form
  {
    List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
    List<TeamModel> selectedTeams = [];
    List<PrizeModel> selectedPrizes = [];

    public CreateTournamentForm()
    {
      InitializeComponent();

      wireUpLists();
    }

    private void wireUpLists()
    {
      selectTeamDropDown.DataSource = null;
      selectTeamDropDown.DataSource = availableTeams;
      selectTeamDropDown.DisplayMember = "TeamName";

      tournamentTeamsListBox.DataSource = null;
      tournamentTeamsListBox.DataSource = selectedTeams;
      tournamentTeamsListBox.DisplayMember = "TeamName";

      prizesListBox.DataSource = null;
      prizesListBox.DataSource = selectedPrizes;
      prizesListBox.DisplayMember = "PlaceName";
    }

    private void addTeamButton_Click(object sender, EventArgs e)
    {
      if (selectTeamDropDown.SelectedItem is TeamModel team)
      {
        availableTeams.Remove(team);
        selectedTeams.Add(team);

        wireUpLists();
      }
    }
  }
}
