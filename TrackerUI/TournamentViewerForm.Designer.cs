namespace TrackerUI
{
  partial class TournamentViewerForm
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      headerLabel = new Label();
      tournamentName = new Label();
      roundLabel = new Label();
      roundDropDown = new ComboBox();
      unplayedOnlyCheckbox = new CheckBox();
      matchupListBox = new ListBox();
      teamOneName = new Label();
      teamOneScoreLabel = new Label();
      teamOneScoreValue = new TextBox();
      teamTwoName = new Label();
      teamTwoScoreLabel = new Label();
      teamTwoScoreValue = new TextBox();
      versusLabel = new Label();
      scoreButton = new Button();
      SuspendLayout();
      // 
      // headerLabel
      // 
      headerLabel.AutoSize = true;
      headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
      headerLabel.ForeColor = SystemColors.Highlight;
      headerLabel.Location = new Point(12, 9);
      headerLabel.Name = "headerLabel";
      headerLabel.Size = new Size(214, 50);
      headerLabel.TabIndex = 0;
      headerLabel.Text = "Tournament:";
      // 
      // tournamentName
      // 
      tournamentName.AutoSize = true;
      tournamentName.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
      tournamentName.ForeColor = SystemColors.Highlight;
      tournamentName.Location = new Point(232, 9);
      tournamentName.Name = "tournamentName";
      tournamentName.Size = new Size(150, 50);
      tournamentName.TabIndex = 1;
      tournamentName.Text = "<none>";
      // 
      // roundLabel
      // 
      roundLabel.AutoSize = true;
      roundLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
      roundLabel.ForeColor = SystemColors.Highlight;
      roundLabel.Location = new Point(21, 80);
      roundLabel.Name = "roundLabel";
      roundLabel.Size = new Size(94, 37);
      roundLabel.TabIndex = 2;
      roundLabel.Text = "Round";
      // 
      // roundDropDown
      // 
      roundDropDown.FormattingEnabled = true;
      roundDropDown.Location = new Point(121, 79);
      roundDropDown.Name = "roundDropDown";
      roundDropDown.Size = new Size(229, 38);
      roundDropDown.TabIndex = 3;
      // 
      // unplayedOnlyCheckbox
      // 
      unplayedOnlyCheckbox.AutoSize = true;
      unplayedOnlyCheckbox.FlatStyle = FlatStyle.Flat;
      unplayedOnlyCheckbox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
      unplayedOnlyCheckbox.ForeColor = SystemColors.Highlight;
      unplayedOnlyCheckbox.Location = new Point(121, 123);
      unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
      unplayedOnlyCheckbox.Size = new Size(209, 41);
      unplayedOnlyCheckbox.TabIndex = 4;
      unplayedOnlyCheckbox.Text = "Unplayed Only";
      unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
      // 
      // matchupListBox
      // 
      matchupListBox.BorderStyle = BorderStyle.FixedSingle;
      matchupListBox.FormattingEnabled = true;
      matchupListBox.ItemHeight = 30;
      matchupListBox.Location = new Point(21, 185);
      matchupListBox.Name = "matchupListBox";
      matchupListBox.Size = new Size(329, 332);
      matchupListBox.TabIndex = 5;
      // 
      // teamOneName
      // 
      teamOneName.AutoSize = true;
      teamOneName.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
      teamOneName.ForeColor = SystemColors.Highlight;
      teamOneName.Location = new Point(403, 185);
      teamOneName.Name = "teamOneName";
      teamOneName.Size = new Size(165, 37);
      teamOneName.TabIndex = 2;
      teamOneName.Text = "<team one>";
      // 
      // teamOneScoreLabel
      // 
      teamOneScoreLabel.AutoSize = true;
      teamOneScoreLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
      teamOneScoreLabel.ForeColor = SystemColors.Highlight;
      teamOneScoreLabel.Location = new Point(403, 238);
      teamOneScoreLabel.Name = "teamOneScoreLabel";
      teamOneScoreLabel.Size = new Size(82, 37);
      teamOneScoreLabel.TabIndex = 2;
      teamOneScoreLabel.Text = "Score";
      // 
      // teamOneScoreValue
      // 
      teamOneScoreValue.Location = new Point(491, 241);
      teamOneScoreValue.Name = "teamOneScoreValue";
      teamOneScoreValue.Size = new Size(100, 35);
      teamOneScoreValue.TabIndex = 6;
      // 
      // teamTwoName
      // 
      teamTwoName.AutoSize = true;
      teamTwoName.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
      teamTwoName.ForeColor = SystemColors.Highlight;
      teamTwoName.Location = new Point(403, 366);
      teamTwoName.Name = "teamTwoName";
      teamTwoName.Size = new Size(165, 37);
      teamTwoName.TabIndex = 2;
      teamTwoName.Text = "<team two>";
      // 
      // teamTwoScoreLabel
      // 
      teamTwoScoreLabel.AutoSize = true;
      teamTwoScoreLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
      teamTwoScoreLabel.ForeColor = SystemColors.Highlight;
      teamTwoScoreLabel.Location = new Point(403, 419);
      teamTwoScoreLabel.Name = "teamTwoScoreLabel";
      teamTwoScoreLabel.Size = new Size(82, 37);
      teamTwoScoreLabel.TabIndex = 2;
      teamTwoScoreLabel.Text = "Score";
      // 
      // teamTwoScoreValue
      // 
      teamTwoScoreValue.Location = new Point(491, 422);
      teamTwoScoreValue.Name = "teamTwoScoreValue";
      teamTwoScoreValue.Size = new Size(100, 35);
      teamTwoScoreValue.TabIndex = 6;
      // 
      // versusLabel
      // 
      versusLabel.AutoSize = true;
      versusLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
      versusLabel.ForeColor = SystemColors.Highlight;
      versusLabel.Location = new Point(491, 309);
      versusLabel.Name = "versusLabel";
      versusLabel.Size = new Size(70, 37);
      versusLabel.TabIndex = 2;
      versusLabel.Text = "-VS-";
      // 
      // scoreButton
      // 
      scoreButton.FlatAppearance.BorderColor = Color.Silver;
      scoreButton.FlatAppearance.MouseDownBackColor = Color.Gray;
      scoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
      scoreButton.FlatStyle = FlatStyle.Flat;
      scoreButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
      scoreButton.ForeColor = SystemColors.Highlight;
      scoreButton.Location = new Point(626, 297);
      scoreButton.Name = "scoreButton";
      scoreButton.Size = new Size(154, 67);
      scoreButton.TabIndex = 7;
      scoreButton.Text = "Score";
      scoreButton.UseVisualStyleBackColor = true;
      // 
      // TournamentViewerForm
      // 
      AutoScaleDimensions = new SizeF(12F, 30F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.White;
      ClientSize = new Size(818, 556);
      Controls.Add(scoreButton);
      Controls.Add(teamTwoScoreValue);
      Controls.Add(teamOneScoreValue);
      Controls.Add(matchupListBox);
      Controls.Add(unplayedOnlyCheckbox);
      Controls.Add(teamTwoScoreLabel);
      Controls.Add(roundDropDown);
      Controls.Add(teamTwoName);
      Controls.Add(teamOneScoreLabel);
      Controls.Add(versusLabel);
      Controls.Add(teamOneName);
      Controls.Add(roundLabel);
      Controls.Add(tournamentName);
      Controls.Add(headerLabel);
      Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
      Margin = new Padding(5, 6, 5, 6);
      Name = "TournamentViewerForm";
      Text = "Tournament Viewer";
      Load += TournamentViewerForm_Load;
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label headerLabel;
    private Label tournamentName;
    private Label roundLabel;
    private ComboBox roundDropDown;
    private CheckBox unplayedOnlyCheckbox;
    private ListBox matchupListBox;
    private Label teamOneName;
    private Label teamOneScoreLabel;
    private TextBox teamOneScoreValue;
    private Label teamTwoName;
    private Label teamTwoScoreLabel;
    private TextBox teamTwoScoreValue;
    private Label versusLabel;
    private Button scoreButton;
  }
}
