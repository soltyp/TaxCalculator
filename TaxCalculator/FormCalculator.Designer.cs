namespace TaxCalculator
{
    partial class FormCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculator));
            calculateButton = new Button();
            label1 = new Label();
            label2 = new Label();
            taxResultLabel = new Label();
            netIncomeResultLabel = new Label();
            incomeTextBox = new TextBox();
            countryComboBox = new ComboBox();
            SuspendLayout();
            // 
            // calculateButton
            // 
            calculateButton.Anchor = AnchorStyles.None;
            calculateButton.BackColor = Color.Purple;
            calculateButton.Cursor = Cursors.Hand;
            calculateButton.FlatAppearance.BorderColor = Color.Indigo;
            calculateButton.FlatAppearance.BorderSize = 0;
            calculateButton.FlatAppearance.MouseDownBackColor = Color.Indigo;
            calculateButton.FlatAppearance.MouseOverBackColor = Color.Indigo;
            calculateButton.FlatStyle = FlatStyle.Flat;
            calculateButton.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            calculateButton.ForeColor = Color.GhostWhite;
            calculateButton.Location = new Point(416, 324);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(246, 31);
            calculateButton.TabIndex = 0;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(414, 153);
            label1.Name = "label1";
            label1.Size = new Size(224, 24);
            label1.TabIndex = 1;
            label1.Text = "Choose your country";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(414, 243);
            label2.Name = "label2";
            label2.Size = new Size(248, 24);
            label2.TabIndex = 2;
            label2.Text = "How much you earned";
            // 
            // taxResultLabel
            // 
            taxResultLabel.Anchor = AnchorStyles.None;
            taxResultLabel.AutoSize = true;
            taxResultLabel.BackColor = Color.Transparent;
            taxResultLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            taxResultLabel.Location = new Point(416, 404);
            taxResultLabel.Name = "taxResultLabel";
            taxResultLabel.Size = new Size(42, 24);
            taxResultLabel.TabIndex = 3;
            taxResultLabel.Text = "Tax";
            // 
            // netIncomeResultLabel
            // 
            netIncomeResultLabel.Anchor = AnchorStyles.None;
            netIncomeResultLabel.AutoSize = true;
            netIncomeResultLabel.BackColor = Color.Transparent;
            netIncomeResultLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            netIncomeResultLabel.Location = new Point(414, 370);
            netIncomeResultLabel.Name = "netIncomeResultLabel";
            netIncomeResultLabel.Size = new Size(132, 24);
            netIncomeResultLabel.TabIndex = 4;
            netIncomeResultLabel.Text = "Net income";
            // 
            // incomeTextBox
            // 
            incomeTextBox.Anchor = AnchorStyles.None;
            incomeTextBox.BackColor = Color.DarkGray;
            incomeTextBox.BorderStyle = BorderStyle.None;
            incomeTextBox.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            incomeTextBox.Location = new Point(416, 281);
            incomeTextBox.Name = "incomeTextBox";
            incomeTextBox.Size = new Size(246, 26);
            incomeTextBox.TabIndex = 5;
            // 
            // countryComboBox
            // 
            countryComboBox.Anchor = AnchorStyles.None;
            countryComboBox.BackColor = Color.Purple;
            countryComboBox.FlatStyle = FlatStyle.Flat;
            countryComboBox.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            countryComboBox.ForeColor = SystemColors.HighlightText;
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Items.AddRange(new object[] { "France", "USA", "United Kingdom", "Poland", "Germany" });
            countryComboBox.Location = new Point(416, 197);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(246, 30);
            countryComboBox.TabIndex = 6;
            // 
            // FormCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(24, 24, 24);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1058, 588);
            Controls.Add(countryComboBox);
            Controls.Add(incomeTextBox);
            Controls.Add(netIncomeResultLabel);
            Controls.Add(taxResultLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(calculateButton);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlDark;
            Name = "FormCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormCalculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calculateButton;
        private Label label1;
        private Label label2;
        private Label taxResultLabel;
        private Label netIncomeResultLabel;
        private TextBox incomeTextBox;
        private ComboBox countryComboBox;
    }
}