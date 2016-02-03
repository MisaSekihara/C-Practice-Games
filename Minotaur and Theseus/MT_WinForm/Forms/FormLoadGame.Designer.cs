namespace MT_WinForm.Forms
{
    partial class FormLoadGame : IForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoadGame));
            this.ButtonRecentlyPlayedGame = new System.Windows.Forms.Button();
            this.RadioButtonRecentlyPlayedGame = new System.Windows.Forms.RadioButton();
            this.ButtonOpenTxtFile = new System.Windows.Forms.Button();
            this.RadioButtonLoadAMapFromFile = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.PictureBox();
            this.LabelFileName = new System.Windows.Forms.Label();
            this.ButtonGameStart = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonRecentlyPlayedGame
            // 
            this.ButtonRecentlyPlayedGame.Enabled = false;
            this.ButtonRecentlyPlayedGame.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRecentlyPlayedGame.Location = new System.Drawing.Point(397, 233);
            this.ButtonRecentlyPlayedGame.Name = "ButtonRecentlyPlayedGame";
            this.ButtonRecentlyPlayedGame.Size = new System.Drawing.Size(80, 38);
            this.ButtonRecentlyPlayedGame.TabIndex = 13;
            this.ButtonRecentlyPlayedGame.Text = "Open";
            this.ButtonRecentlyPlayedGame.UseVisualStyleBackColor = true;
            this.ButtonRecentlyPlayedGame.Click += new System.EventHandler(this.ButtonRecentlyPlayedGame_Click);
            // 
            // RadioButtonRecentlyPlayedGame
            // 
            this.RadioButtonRecentlyPlayedGame.AutoSize = true;
            this.RadioButtonRecentlyPlayedGame.BackColor = System.Drawing.Color.Transparent;
            this.RadioButtonRecentlyPlayedGame.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.RadioButtonRecentlyPlayedGame.Location = new System.Drawing.Point(99, 240);
            this.RadioButtonRecentlyPlayedGame.Name = "RadioButtonRecentlyPlayedGame";
            this.RadioButtonRecentlyPlayedGame.Size = new System.Drawing.Size(265, 24);
            this.RadioButtonRecentlyPlayedGame.TabIndex = 12;
            this.RadioButtonRecentlyPlayedGame.TabStop = true;
            this.RadioButtonRecentlyPlayedGame.Text = "Load recently played game";
            this.RadioButtonRecentlyPlayedGame.UseVisualStyleBackColor = false;
            this.RadioButtonRecentlyPlayedGame.CheckedChanged += new System.EventHandler(this.RadioButtonRecentlyPlayedGame_CheckedChanged);
            // 
            // ButtonOpenTxtFile
            // 
            this.ButtonOpenTxtFile.Enabled = false;
            this.ButtonOpenTxtFile.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOpenTxtFile.Location = new System.Drawing.Point(480, 132);
            this.ButtonOpenTxtFile.Name = "ButtonOpenTxtFile";
            this.ButtonOpenTxtFile.Size = new System.Drawing.Size(94, 38);
            this.ButtonOpenTxtFile.TabIndex = 11;
            this.ButtonOpenTxtFile.Text = "Browse";
            this.ButtonOpenTxtFile.UseVisualStyleBackColor = true;
            this.ButtonOpenTxtFile.Click += new System.EventHandler(this.ButtonOpenTxtFile_Click);
            // 
            // RadioButtonLoadAMapFromFile
            // 
            this.RadioButtonLoadAMapFromFile.AutoSize = true;
            this.RadioButtonLoadAMapFromFile.BackColor = System.Drawing.Color.Transparent;
            this.RadioButtonLoadAMapFromFile.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.RadioButtonLoadAMapFromFile.Location = new System.Drawing.Point(99, 139);
            this.RadioButtonLoadAMapFromFile.Name = "RadioButtonLoadAMapFromFile";
            this.RadioButtonLoadAMapFromFile.Size = new System.Drawing.Size(350, 24);
            this.RadioButtonLoadAMapFromFile.TabIndex = 10;
            this.RadioButtonLoadAMapFromFile.TabStop = true;
            this.RadioButtonLoadAMapFromFile.Text = "Load map or save data from text file";
            this.RadioButtonLoadAMapFromFile.UseVisualStyleBackColor = false;
            this.RadioButtonLoadAMapFromFile.CheckedChanged += new System.EventHandler(this.RadioButtonLoadAMapFromFile_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ButtonRecentlyPlayedGame);
            this.panel1.Controls.Add(this.RadioButtonRecentlyPlayedGame);
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.LabelFileName);
            this.panel1.Controls.Add(this.ButtonOpenTxtFile);
            this.panel1.Controls.Add(this.RadioButtonLoadAMapFromFile);
            this.panel1.Controls.Add(this.ButtonGameStart);
            this.panel1.Location = new System.Drawing.Point(32, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 411);
            this.panel1.TabIndex = 14;
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
            // LabelFileName
            // 
            this.LabelFileName.AutoSize = true;
            this.LabelFileName.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Italic);
            this.LabelFileName.Location = new System.Drawing.Point(121, 166);
            this.LabelFileName.Name = "LabelFileName";
            this.LabelFileName.Size = new System.Drawing.Size(0, 20);
            this.LabelFileName.TabIndex = 3;
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "MyGame.txt";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // FormLoadGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.panel1);
            this.Name = "FormLoadGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minotaur and Theseus - Load Game";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            this.ResumeLayout(false);
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MT_WinForm.Properties.Resources.MazeBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        #endregion

        private System.Windows.Forms.Button ButtonRecentlyPlayedGame;
        private System.Windows.Forms.RadioButton RadioButtonRecentlyPlayedGame;
        private System.Windows.Forms.Button ButtonOpenTxtFile;
        private System.Windows.Forms.RadioButton RadioButtonLoadAMapFromFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox BackButton;
        private System.Windows.Forms.Label LabelFileName;
        private System.Windows.Forms.Button ButtonGameStart;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

    }
}
