namespace TrackerUI
{
  partial class TournamentDashboardForm
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
      tournamentDashboardLabel = new Label();
      loadTournamentDropDown = new ComboBox();
      loadTournamentLabel = new Label();
      loadTournamentButton = new Button();
      createTournamentButton = new Button();
      SuspendLayout();
      // 
      // tournamentDashboardLabel
      // 
      tournamentDashboardLabel.AutoSize = true;
      tournamentDashboardLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
      tournamentDashboardLabel.ForeColor = SystemColors.Highlight;
      tournamentDashboardLabel.Location = new Point(100, 34);
      tournamentDashboardLabel.Name = "tournamentDashboardLabel";
      tournamentDashboardLabel.Size = new Size(385, 50);
      tournamentDashboardLabel.TabIndex = 3;
      tournamentDashboardLabel.Text = "Tournament Dashboard";
      // 
      // loadTournamentDropDown
      // 
      loadTournamentDropDown.FormattingEnabled = true;
      loadTournamentDropDown.Location = new Point(74, 153);
      loadTournamentDropDown.Name = "loadTournamentDropDown";
      loadTournamentDropDown.Size = new Size(437, 38);
      loadTournamentDropDown.TabIndex = 18;
      // 
      // loadTournamentLabel
      // 
      loadTournamentLabel.AutoSize = true;
      loadTournamentLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
      loadTournamentLabel.ForeColor = SystemColors.Highlight;
      loadTournamentLabel.Location = new Point(131, 113);
      loadTournamentLabel.Name = "loadTournamentLabel";
      loadTournamentLabel.Size = new Size(322, 37);
      loadTournamentLabel.TabIndex = 17;
      loadTournamentLabel.Text = "Load Existing Tournament";
      // 
      // loadTournamentButton
      // 
      loadTournamentButton.FlatAppearance.BorderColor = Color.Silver;
      loadTournamentButton.FlatAppearance.MouseDownBackColor = Color.Gray;
      loadTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
      loadTournamentButton.FlatStyle = FlatStyle.Flat;
      loadTournamentButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
      loadTournamentButton.ForeColor = SystemColors.Highlight;
      loadTournamentButton.Location = new Point(177, 215);
      loadTournamentButton.Name = "loadTournamentButton";
      loadTournamentButton.Size = new Size(230, 55);
      loadTournamentButton.TabIndex = 19;
      loadTournamentButton.Text = "Load Tournament";
      loadTournamentButton.UseVisualStyleBackColor = true;
      // 
      // createTournamentButton
      // 
      createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
      createTournamentButton.FlatAppearance.MouseDownBackColor = Color.Gray;
      createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
      createTournamentButton.FlatStyle = FlatStyle.Flat;
      createTournamentButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
      createTournamentButton.ForeColor = SystemColors.Highlight;
      createTournamentButton.Location = new Point(121, 307);
      createTournamentButton.Name = "createTournamentButton";
      createTournamentButton.Size = new Size(342, 70);
      createTournamentButton.TabIndex = 25;
      createTournamentButton.Text = "Create Tournament";
      createTournamentButton.UseVisualStyleBackColor = true;
      // 
      // TournamentDashboardForm
      // 
      AutoScaleDimensions = new SizeF(12F, 30F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.White;
      ClientSize = new Size(584, 460);
      Controls.Add(createTournamentButton);
      Controls.Add(loadTournamentButton);
      Controls.Add(loadTournamentDropDown);
      Controls.Add(loadTournamentLabel);
      Controls.Add(tournamentDashboardLabel);
      Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
      Margin = new Padding(5, 6, 5, 6);
      Name = "TournamentDashboardForm";
      Text = "Tournament Dashboard";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label tournamentDashboardLabel;
    private ComboBox loadTournamentDropDown;
    private Label loadTournamentLabel;
    private Button loadTournamentButton;
    private Button createTournamentButton;
  }
}