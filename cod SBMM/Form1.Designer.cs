namespace cod_SBMM
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.gameComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.regionComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pathToGameTextbox = new System.Windows.Forms.TextBox();
            this.enable_button = new System.Windows.Forms.Button();
            this.disable_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "game label";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select which game";
            // 
            // gameComboBox
            // 
            this.gameComboBox.FormattingEnabled = true;
            this.gameComboBox.Items.AddRange(new object[] {
            "Call Of Duty Vanguard",
            "Call Of Duty Modern Warfare / Warzone Caldera",
            "Call Of Duty Modern Warfare 2 / Warzone 2.0",
            "Call Of Duty Modern Warfare 3 Beta"});
            this.gameComboBox.Location = new System.Drawing.Point(12, 27);
            this.gameComboBox.Name = "gameComboBox";
            this.gameComboBox.Size = new System.Drawing.Size(397, 23);
            this.gameComboBox.TabIndex = 1;
            gameComboBox.SelectedIndexChanged += gameComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select where to limit your matchmaking to\r\n";
            // 
            // regionComboBox
            // 
            this.regionComboBox.FormattingEnabled = true;
            this.regionComboBox.Items.AddRange(new object[] {
            "United Kingdom and Netherlands",
            "United Kingdom and Germany",
            "Germany and France",
            "France and Netherlands",
            "Germany and Netherlands",
            "United States of America",
            "United Kingdom",
            "Germany ",
            "France",
            "Europe",
            "Brazil",
            "Singapore",
            "East Coast of United States of America",
            "West Coast of United States of America",
            "Texas",
            "Spain",
            "Italy"});
            this.regionComboBox.Location = new System.Drawing.Point(12, 82);
            this.regionComboBox.Name = "regionComboBox";
            this.regionComboBox.Size = new System.Drawing.Size(397, 23);
            this.regionComboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(459, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter the full path to your cod executable (If this is wrong the geoblock will no" +
    "t work!)\r\n";
            // 
            // pathToGameTextbox
            // 
            this.pathToGameTextbox.Location = new System.Drawing.Point(12, 138);
            this.pathToGameTextbox.Name = "pathToGameTextbox";
            this.pathToGameTextbox.Size = new System.Drawing.Size(568, 23);
            this.pathToGameTextbox.TabIndex = 5;
            // 
            // enable_button
            // 
            this.enable_button.BackColor = System.Drawing.Color.Green;
            this.enable_button.ForeColor = System.Drawing.SystemColors.Control;
            this.enable_button.Location = new System.Drawing.Point(602, 182);
            this.enable_button.Name = "enable_button";
            this.enable_button.Size = new System.Drawing.Size(75, 23);
            this.enable_button.TabIndex = 6;
            this.enable_button.Text = "ENABLE";
            this.enable_button.UseVisualStyleBackColor = false;
            this.enable_button.Click += new System.EventHandler(this.enable_button_Click);
            // 
            // disable_button
            // 
            this.disable_button.BackColor = System.Drawing.Color.Red;
            this.disable_button.ForeColor = System.Drawing.SystemColors.Control;
            this.disable_button.Location = new System.Drawing.Point(505, 182);
            this.disable_button.Name = "disable_button";
            this.disable_button.Size = new System.Drawing.Size(75, 23);
            this.disable_button.TabIndex = 7;
            this.disable_button.Text = "DISABLE";
            this.disable_button.UseVisualStyleBackColor = false;
            this.disable_button.Click += new System.EventHandler(this.disable_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 217);
            this.Controls.Add(this.disable_button);
            this.Controls.Add(this.enable_button);
            this.Controls.Add(this.pathToGameTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.regionComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gameComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "COD SBMM Negator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox gameComboBox;
        private Label label2;
        private ComboBox regionComboBox;
        private Label label3;
        private TextBox pathToGameTextbox;
        private Button enable_button;
        private Button disable_button;
    }
}