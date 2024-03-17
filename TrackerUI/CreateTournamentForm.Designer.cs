namespace TrackerUI
{
  partial class CreateTournamentForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      headerLabel = new Label();
      tournamentNameValue = new TextBox();
      tournamentNameLabel = new Label();
      entryFeeValue = new TextBox();
      entryFeeLabel = new Label();
      selectTeamDropDown = new ComboBox();
      selectTeamLabel = new Label();
      createNewTeamLink = new LinkLabel();
      addTeamButton = new Button();
      createPrizeButton = new Button();
      tournamentTeamsListBox = new ListBox();
      tournamentPlayersLabel = new Label();
      prizesLabel = new Label();
      prizesListBox = new ListBox();
      removePrizeButton = new Button();
      removePlayerButton = new Button();
      createTournamentButton = new Button();
      SuspendLayout();
      // 
      // headerLabel
      // 
      headerLabel.AutoSize = true;
      headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
      headerLabel.ForeColor = SystemColors.Highlight;
      headerLabel.Location = new Point(12, 9);
      headerLabel.Name = "headerLabel";
      headerLabel.Size = new Size(317, 50);
      headerLabel.TabIndex = 1;
      headerLabel.Text = "Create Tournament";
      // 
      // tournamentNameValue
      // 
      tournamentNameValue.Location = new Point(33, 140);
      tournamentNameValue.Name = "tournamentNameValue";
      tournamentNameValue.Size = new Size(330, 35);
      tournamentNameValue.TabIndex = 8;
      // 
      // tournamentNameLabel
      // 
      tournamentNameLabel.AutoSize = true;
      tournamentNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
      tournamentNameLabel.ForeColor = SystemColors.Highlight;
      tournamentNameLabel.Location = new Point(21, 100);
      tournamentNameLabel.Name = "tournamentNameLabel";
      tournamentNameLabel.Size = new Size(236, 37);
      tournamentNameLabel.TabIndex = 7;
      tournamentNameLabel.Text = "Tournament Name";
      // 
      // entryFeeValue
      // 
      entryFeeValue.Location = new Point(157, 230);
      entryFeeValue.Name = "entryFeeValue";
      entryFeeValue.Size = new Size(100, 35);
      entryFeeValue.TabIndex = 10;
      entryFeeValue.Text = "0";
      // 
      // entryFeeLabel
      // 
      entryFeeLabel.AutoSize = true;
      entryFeeLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
      entryFeeLabel.ForeColor = SystemColors.Highlight;
      entryFeeLabel.Location = new Point(21, 227);
      entryFeeLabel.Name = "entryFeeLabel";
      entryFeeLabel.Size = new Size(125, 37);
      entryFeeLabel.TabIndex = 9;
      entryFeeLabel.Text = "Entry Fee";
      // 
      // selectTeamDropDown
      // 
      selectTeamDropDown.FormattingEnabled = true;
      selectTeamDropDown.Location = new Point(33, 350);
      selectTeamDropDown.Name = "selectTeamDropDown";
      selectTeamDropDown.Size = new Size(330, 38);
      selectTeamDropDown.TabIndex = 12;
      // 
      // selectTeamLabel
      // 
      selectTeamLabel.AutoSize = true;
      selectTeamLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
      selectTeamLabel.ForeColor = SystemColors.Highlight;
      selectTeamLabel.Location = new Point(21, 310);
      selectTeamLabel.Name = "selectTeamLabel";
      selectTeamLabel.Size = new Size(156, 37);
      selectTeamLabel.TabIndex = 11;
      selectTeamLabel.Text = "Select Team";
      // 
      // createNewTeamLink
      // 
      createNewTeamLink.AutoSize = true;
      createNewTeamLink.Location = new Point(249, 316);
      createNewTeamLink.Name = "createNewTeamLink";
      createNewTeamLink.Size = new Size(114, 30);
      createNewTeamLink.TabIndex = 13;
      createNewTeamLink.TabStop = true;
      createNewTeamLink.Text = "create new";
      createNewTeamLink.LinkClicked += createNewTeamLink_LinkClicked;
      // 
      // addTeamButton
      // 
      addTeamButton.FlatAppearance.BorderColor = Color.Silver;
      addTeamButton.FlatAppearance.MouseDownBackColor = Color.Gray;
      addTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
      addTeamButton.FlatStyle = FlatStyle.Flat;
      addTeamButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
      addTeamButton.ForeColor = SystemColors.Highlight;
      addTeamButton.Location = new Point(21, 424);
      addTeamButton.Name = "addTeamButton";
      addTeamButton.Size = new Size(188, 55);
      addTeamButton.TabIndex = 14;
      addTeamButton.Text = "Add Team";
      addTeamButton.UseVisualStyleBackColor = true;
      addTeamButton.Click += addTeamButton_Click;
      // 
      // createPrizeButton
      // 
      createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
      createPrizeButton.FlatAppearance.MouseDownBackColor = Color.Gray;
      createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
      createPrizeButton.FlatStyle = FlatStyle.Flat;
      createPrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
      createPrizeButton.ForeColor = SystemColors.Highlight;
      createPrizeButton.Location = new Point(21, 514);
      createPrizeButton.Name = "createPrizeButton";
      createPrizeButton.Size = new Size(188, 55);
      createPrizeButton.TabIndex = 15;
      createPrizeButton.Text = "Create Prize";
      createPrizeButton.UseVisualStyleBackColor = true;
      createPrizeButton.Click += createPrizeButton_Click;
      // 
      // tournamentTeamsListBox
      // 
      tournamentTeamsListBox.BorderStyle = BorderStyle.FixedSingle;
      tournamentTeamsListBox.FormattingEnabled = true;
      tournamentTeamsListBox.ItemHeight = 30;
      tournamentTeamsListBox.Location = new Point(468, 140);
      tournamentTeamsListBox.Name = "tournamentTeamsListBox";
      tournamentTeamsListBox.Size = new Size(329, 182);
      tournamentTeamsListBox.TabIndex = 16;
      // 
      // tournamentPlayersLabel
      // 
      tournamentPlayersLabel.AutoSize = true;
      tournamentPlayersLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
      tournamentPlayersLabel.ForeColor = SystemColors.Highlight;
      tournamentPlayersLabel.Location = new Point(451, 100);
      tournamentPlayersLabel.Name = "tournamentPlayersLabel";
      tournamentPlayersLabel.Size = new Size(198, 37);
      tournamentPlayersLabel.TabIndex = 7;
      tournamentPlayersLabel.Text = "Teams / Players";
      // 
      // prizesLabel
      // 
      prizesLabel.AutoSize = true;
      prizesLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
      prizesLabel.ForeColor = SystemColors.Highlight;
      prizesLabel.Location = new Point(451, 347);
      prizesLabel.Name = "prizesLabel";
      prizesLabel.Size = new Size(85, 37);
      prizesLabel.TabIndex = 7;
      prizesLabel.Text = "Prizes";
      // 
      // prizesListBox
      // 
      prizesListBox.BorderStyle = BorderStyle.FixedSingle;
      prizesListBox.FormattingEnabled = true;
      prizesListBox.ItemHeight = 30;
      prizesListBox.Location = new Point(468, 387);
      prizesListBox.Name = "prizesListBox";
      prizesListBox.Size = new Size(329, 182);
      prizesListBox.TabIndex = 16;
      // 
      // removePrizeButton
      // 
      removePrizeButton.FlatAppearance.BorderColor = Color.Silver;
      removePrizeButton.FlatAppearance.MouseDownBackColor = Color.Gray;
      removePrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
      removePrizeButton.FlatStyle = FlatStyle.Flat;
      removePrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
      removePrizeButton.ForeColor = SystemColors.Highlight;
      removePrizeButton.Location = new Point(817, 445);
      removePrizeButton.Name = "removePrizeButton";
      removePrizeButton.Size = new Size(154, 75);
      removePrizeButton.TabIndex = 17;
      removePrizeButton.Text = "Remove Selected";
      removePrizeButton.UseVisualStyleBackColor = true;
      removePrizeButton.Click += removePrizeButton_Click;
      // 
      // removePlayerButton
      // 
      removePlayerButton.FlatAppearance.BorderColor = Color.Silver;
      removePlayerButton.FlatAppearance.MouseDownBackColor = Color.Gray;
      removePlayerButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
      removePlayerButton.FlatStyle = FlatStyle.Flat;
      removePlayerButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
      removePlayerButton.ForeColor = SystemColors.Highlight;
      removePlayerButton.Location = new Point(817, 194);
      removePlayerButton.Name = "removePlayerButton";
      removePlayerButton.Size = new Size(154, 75);
      removePlayerButton.TabIndex = 17;
      removePlayerButton.Text = "Remove Selected";
      removePlayerButton.UseVisualStyleBackColor = true;
      removePlayerButton.Click += removePlayerButton_Click;
      // 
      // createTournamentButton
      // 
      createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
      createTournamentButton.FlatAppearance.MouseDownBackColor = Color.Gray;
      createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
      createTournamentButton.FlatStyle = FlatStyle.Flat;
      createTournamentButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
      createTournamentButton.ForeColor = SystemColors.Highlight;
      createTournamentButton.Location = new Point(21, 622);
      createTournamentButton.Name = "createTournamentButton";
      createTournamentButton.Size = new Size(342, 70);
      createTournamentButton.TabIndex = 18;
      createTournamentButton.Text = "Create Tournament";
      createTournamentButton.UseVisualStyleBackColor = true;
      createTournamentButton.Click += createTournamentButton_Click;
      // 
      // CreateTournamentForm
      // 
      AutoScaleDimensions = new SizeF(12F, 30F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.White;
      ClientSize = new Size(1001, 731);
      Controls.Add(createTournamentButton);
      Controls.Add(removePlayerButton);
      Controls.Add(removePrizeButton);
      Controls.Add(prizesListBox);
      Controls.Add(tournamentTeamsListBox);
      Controls.Add(createPrizeButton);
      Controls.Add(addTeamButton);
      Controls.Add(createNewTeamLink);
      Controls.Add(selectTeamDropDown);
      Controls.Add(selectTeamLabel);
      Controls.Add(entryFeeValue);
      Controls.Add(entryFeeLabel);
      Controls.Add(prizesLabel);
      Controls.Add(tournamentNameValue);
      Controls.Add(tournamentPlayersLabel);
      Controls.Add(tournamentNameLabel);
      Controls.Add(headerLabel);
      Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
      Margin = new Padding(5, 6, 5, 6);
      Name = "CreateTournamentForm";
      Text = "Create Tournament";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label headerLabel;
    private TextBox tournamentNameValue;
    private Label tournamentNameLabel;
    private TextBox entryFeeValue;
    private Label entryFeeLabel;
    private ComboBox selectTeamDropDown;
    private Label selectTeamLabel;
    private LinkLabel createNewTeamLink;
    private Button addTeamButton;
    private Button createPrizeButton;
    private ListBox tournamentTeamsListBox;
    private Label tournamentPlayersLabel;
    private Label prizesLabel;
    private ListBox prizesListBox;
    private Button removePrizeButton;
    private Button removePlayerButton;
    private Button createTournamentButton;
  }
}