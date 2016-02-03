namespace MT_WinForm.Forms
{
    partial class FormNewGame : IForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewGame));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.PictureBox();
            this.ComboBoxLevelSelection = new System.Windows.Forms.ComboBox();
            this.RadioButtonSelectALevel = new System.Windows.Forms.RadioButton();
            this.LabelFileName = new System.Windows.Forms.Label();
            this.RadioButtonPlayFromBeginning = new System.Windows.Forms.RadioButton();
            this.ButtonGameStart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.ComboBoxLevelSelection);
            this.panel1.Controls.Add(this.RadioButtonSelectALevel);
            this.panel1.Controls.Add(this.LabelFileName);
            this.panel1.Controls.Add(this.RadioButtonPlayFromBeginning);
            this.panel1.Controls.Add(this.ButtonGameStart);
            this.panel1.Location = new System.Drawing.Point(34, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 411);
            this.panel1.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackButton.BackgroundImage")));
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.Location = new System.Drawing.Point(23, 30);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(50, 35);
            this.BackButton.TabIndex = 7;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ComboBoxLevelSelection
            // 
            this.ComboBoxLevelSelection.Enabled = false;
            this.ComboBoxLevelSelection.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.ComboBoxLevelSelection.FormattingEnabled = true;
            this.ComboBoxLevelSelection.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.ComboBoxLevelSelection.Location = new System.Drawing.Point(338, 231);
            this.ComboBoxLevelSelection.Name = "ComboBoxLevelSelection";
            this.ComboBoxLevelSelection.Size = new System.Drawing.Size(86, 28);
            this.ComboBoxLevelSelection.TabIndex = 5;
            this.ComboBoxLevelSelection.Text = "  Level";
            this.ComboBoxLevelSelection.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLevelSelection_SelectedIndexChanged);
            // 
            // RadioButtonSelectALevel
            // 
            this.RadioButtonSelectALevel.AutoSize = true;
            this.RadioButtonSelectALevel.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.RadioButtonSelectALevel.Location = new System.Drawing.Point(138, 231);
            this.RadioButtonSelectALevel.Name = "RadioButtonSelectALevel";
            this.RadioButtonSelectALevel.Size = new System.Drawing.Size(144, 24);
            this.RadioButtonSelectALevel.TabIndex = 4;
            this.RadioButtonSelectALevel.TabStop = true;
            this.RadioButtonSelectALevel.Text = "Select a lavel";
            this.RadioButtonSelectALevel.UseVisualStyleBackColor = true;
            this.RadioButtonSelectALevel.CheckedChanged += new System.EventHandler(this.RadioButtonSelectALevel_CheckedChanged);
            // 
            // LabelFileName
            // 
            this.LabelFileName.AutoSize = true;
            this.LabelFileName.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Italic);
            this.LabelFileName.Location = new System.Drawing.Point(107, 172);
            this.LabelFileName.Name = "LabelFileName";
            this.LabelFileName.Size = new System.Drawing.Size(0, 20);
            this.LabelFileName.TabIndex = 3;
            // 
            // RadioButtonPlayFromBeginning
            // 
            this.RadioButtonPlayFromBeginning.AutoSize = true;
            this.RadioButtonPlayFromBeginning.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonPlayFromBeginning.Location = new System.Drawing.Point(138, 145);
            this.RadioButtonPlayFromBeginning.Name = "RadioButtonPlayFromBeginning";
            this.RadioButtonPlayFromBeginning.Size = new System.Drawing.Size(208, 24);
            this.RadioButtonPlayFromBeginning.TabIndex = 1;
            this.RadioButtonPlayFromBeginning.TabStop = true;
            this.RadioButtonPlayFromBeginning.Text = "Play from beginning";
            this.RadioButtonPlayFromBeginning.UseVisualStyleBackColor = true;
            this.RadioButtonPlayFromBeginning.CheckedChanged += new System.EventHandler(this.RadioButtonPlayFromBeginning_CheckedChanged);
            // 
            // ButtonGameStart
            // 
            this.ButtonGameStart.Enabled = false;
            this.ButtonGameStart.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGameStart.Location = new System.Drawing.Point(486, 349);
            this.ButtonGameStart.Name = "ButtonGameStart";
            this.ButtonGameStart.Size = new System.Drawing.Size(106, 38);
            this.ButtonGameStart.TabIndex = 0;
            this.ButtonGameStart.Text = "Start";
            this.ButtonGameStart.UseVisualStyleBackColor = true;
            this.ButtonGameStart.Click += new System.EventHandler(this.ButtonGameStart_Click);
            // 
            // FormNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.panel1);
            this.Name = "FormNewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minotaur and Theseus - New Game";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            this.ResumeLayout(false);
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MT_WinForm.Properties.Resources.MazeBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonGameStart;
        private System.Windows.Forms.RadioButton RadioButtonPlayFromBeginning;
        private System.Windows.Forms.ComboBox ComboBoxLevelSelection;
        private System.Windows.Forms.RadioButton RadioButtonSelectALevel;
        private System.Windows.Forms.Label LabelFileName;
        private System.Windows.Forms.PictureBox BackButton;
    }
}
