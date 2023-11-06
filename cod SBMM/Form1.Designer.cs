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
            label1 = new Label();
            gameComboBox = new ComboBox();
            label2 = new Label();
            regionComboBox = new ComboBox();
            label3 = new Label();
            pathToGameTextbox = new TextBox();
            enable_button = new Button();
            disable_button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "Select which game";
            // 
            // gameComboBox
            // 
            gameComboBox.FormattingEnabled = true;
            gameComboBox.Items.AddRange(new object[] { "Call Of Duty Vanguard", "Call Of Duty Modern Warfare / Warzone Caldera", "Call Of Duty Modern Warfare 2 / Warzone 2.0", "Call Of Duty Modern Warfare 3" });
            gameComboBox.Location = new Point(12, 27);
            gameComboBox.Name = "gameComboBox";
            gameComboBox.Size = new Size(397, 23);
            gameComboBox.TabIndex = 1;
            gameComboBox.SelectedIndexChanged += gameComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(232, 15);
            label2.TabIndex = 2;
            label2.Text = "Select where to limit your matchmaking to\r\n";
            // 
            // regionComboBox
            // 
            regionComboBox.FormattingEnabled = true;
            regionComboBox.Items.AddRange(new object[] { "United Kingdom and Netherlands", "United Kingdom and Germany", "Germany and France", "France and Netherlands", "Germany and Netherlands", "United States of America", "United Kingdom", "Germany ", "France", "Europe", "Brazil", "Singapore", "East Coast of United States of America", "West Coast of United States of America", "Texas", "Spain", "Italy" });
            regionComboBox.Location = new Point(12, 82);
            regionComboBox.Name = "regionComboBox";
            regionComboBox.Size = new Size(397, 23);
            regionComboBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 120);
            label3.Name = "label3";
            label3.Size = new Size(459, 15);
            label3.TabIndex = 4;
            label3.Text = "Enter the full path to your cod executable (If this is wrong the geoblock will not work!)\r\n";
            // 
            // pathToGameTextbox
            // 
            pathToGameTextbox.Location = new Point(12, 138);
            pathToGameTextbox.Name = "pathToGameTextbox";
            pathToGameTextbox.Size = new Size(568, 23);
            pathToGameTextbox.TabIndex = 5;
            // 
            // enable_button
            // 
            enable_button.BackColor = Color.Green;
            enable_button.ForeColor = SystemColors.Control;
            enable_button.Location = new Point(602, 182);
            enable_button.Name = "enable_button";
            enable_button.Size = new Size(75, 23);
            enable_button.TabIndex = 6;
            enable_button.Text = "ENABLE";
            enable_button.UseVisualStyleBackColor = false;
            enable_button.Click += enable_button_Click;
            // 
            // disable_button
            // 
            disable_button.BackColor = Color.Red;
            disable_button.ForeColor = SystemColors.Control;
            disable_button.Location = new Point(505, 182);
            disable_button.Name = "disable_button";
            disable_button.Size = new Size(75, 23);
            disable_button.TabIndex = 7;
            disable_button.Text = "DISABLE";
            disable_button.UseVisualStyleBackColor = false;
            disable_button.Click += disable_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 217);
            Controls.Add(disable_button);
            Controls.Add(enable_button);
            Controls.Add(pathToGameTextbox);
            Controls.Add(label3);
            Controls.Add(regionComboBox);
            Controls.Add(label2);
            Controls.Add(gameComboBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            Text = "COD SBMM Negator";
            ResumeLayout(false);
            PerformLayout();
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