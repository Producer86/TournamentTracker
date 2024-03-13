namespace TrackerUI
{
  partial class CreatePrizeForm
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
      createPrizeLabel = new Label();
      placeNumberValue = new TextBox();
      placeNumberLabel = new Label();
      placeNameLabel = new Label();
      placeNameValue = new TextBox();
      prizeAmountLabel = new Label();
      prizeAmountValue = new TextBox();
      prizePercentLabel = new Label();
      prizePercentValue = new TextBox();
      orLabel = new Label();
      createPrizeButton = new Button();
      SuspendLayout();
      // 
      // createPrizeLabel
      // 
      createPrizeLabel.AutoSize = true;
      createPrizeLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
      createPrizeLabel.ForeColor = SystemColors.Highlight;
      createPrizeLabel.Location = new Point(12, 9);
      createPrizeLabel.Name = "createPrizeLabel";
      createPrizeLabel.Size = new Size(209, 50);
      createPrizeLabel.TabIndex = 2;
      createPrizeLabel.Text = "Create Prize";
      // 
      // placeNumberValue
      // 
      placeNumberValue.Location = new Point(213, 98);
      placeNumberValue.Name = "placeNumberValue";
      placeNumberValue.Size = new Size(249, 35);
      placeNumberValue.TabIndex = 22;
      // 
      // placeNumberLabel
      // 
      placeNumberLabel.AutoSize = true;
      placeNumberLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
      placeNumberLabel.ForeColor = SystemColors.Highlight;
      placeNumberLabel.Location = new Point(12, 95);
      placeNumberLabel.Name = "placeNumberLabel";
      placeNumberLabel.Size = new Size(183, 37);
      placeNumberLabel.TabIndex = 21;
      placeNumberLabel.Text = "Place Number";
      // 
      // placeNameLabel
      // 
      placeNameLabel.AutoSize = true;
      placeNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
      placeNameLabel.ForeColor = SystemColors.Highlight;
      placeNameLabel.Location = new Point(12, 158);
      placeNameLabel.Name = "placeNameLabel";
      placeNameLabel.Size = new Size(157, 37);
      placeNameLabel.TabIndex = 21;
      placeNameLabel.Text = "Place Name";
      // 
      // placeNameValue
      // 
      placeNameValue.Location = new Point(213, 161);
      placeNameValue.Name = "placeNameValue";
      placeNameValue.Size = new Size(249, 35);
      placeNameValue.TabIndex = 22;
      // 
      // prizeAmountLabel
      // 
      prizeAmountLabel.AutoSize = true;
      prizeAmountLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
      prizeAmountLabel.ForeColor = SystemColors.Highlight;
      prizeAmountLabel.Location = new Point(12, 221);
      prizeAmountLabel.Name = "prizeAmountLabel";
      prizeAmountLabel.Size = new Size(176, 37);
      prizeAmountLabel.TabIndex = 21;
      prizeAmountLabel.Text = "Prize Amount";
      // 
      // prizeAmountValue
      // 
      prizeAmountValue.Location = new Point(213, 224);
      prizeAmountValue.Name = "prizeAmountValue";
      prizeAmountValue.Size = new Size(249, 35);
      prizeAmountValue.TabIndex = 22;
      prizeAmountValue.Text = "0";
      // 
      // prizePercentLabel
      // 
      prizePercentLabel.AutoSize = true;
      prizePercentLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
      prizePercentLabel.ForeColor = SystemColors.Highlight;
      prizePercentLabel.Location = new Point(12, 328);
      prizePercentLabel.Name = "prizePercentLabel";
      prizePercentLabel.Size = new Size(168, 37);
      prizePercentLabel.TabIndex = 21;
      prizePercentLabel.Text = "Prize Percent";
      // 
      // prizePercentValue
      // 
      prizePercentValue.Location = new Point(213, 331);
      prizePercentValue.Name = "prizePercentValue";
      prizePercentValue.Size = new Size(249, 35);
      prizePercentValue.TabIndex = 22;
      prizePercentValue.Text = "0";
      // 
      // orLabel
      // 
      orLabel.AutoSize = true;
      orLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
      orLabel.ForeColor = SystemColors.Highlight;
      orLabel.Location = new Point(305, 276);
      orLabel.Name = "orLabel";
      orLabel.Size = new Size(64, 37);
      orLabel.TabIndex = 23;
      orLabel.Text = "-or-";
      // 
      // createPrizeButton
      // 
      createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
      createPrizeButton.FlatAppearance.MouseDownBackColor = Color.Gray;
      createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
      createPrizeButton.FlatStyle = FlatStyle.Flat;
      createPrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
      createPrizeButton.ForeColor = SystemColors.Highlight;
      createPrizeButton.Location = new Point(75, 413);
      createPrizeButton.Name = "createPrizeButton";
      createPrizeButton.Size = new Size(342, 70);
      createPrizeButton.TabIndex = 24;
      createPrizeButton.Text = "Create Prize";
      createPrizeButton.UseVisualStyleBackColor = true;
      createPrizeButton.Click += createPrizeButton_Click;
      // 
      // CreatePrizeForm
      // 
      AutoScaleDimensions = new SizeF(12F, 30F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.White;
      ClientSize = new Size(501, 535);
      Controls.Add(createPrizeButton);
      Controls.Add(orLabel);
      Controls.Add(prizePercentValue);
      Controls.Add(prizePercentLabel);
      Controls.Add(prizeAmountValue);
      Controls.Add(prizeAmountLabel);
      Controls.Add(placeNameValue);
      Controls.Add(placeNameLabel);
      Controls.Add(placeNumberValue);
      Controls.Add(placeNumberLabel);
      Controls.Add(createPrizeLabel);
      Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
      Margin = new Padding(5, 6, 5, 6);
      Name = "CreatePrizeForm";
      Text = "Create Prize";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label createPrizeLabel;
    private TextBox placeNumberValue;
    private Label placeNumberLabel;
    private Label placeNameLabel;
    private TextBox placeNameValue;
    private Label prizeAmountLabel;
    private TextBox prizeAmountValue;
    private Label prizePercentLabel;
    private TextBox prizePercentValue;
    private Label orLabel;
    private Button createPrizeButton;
  }
}