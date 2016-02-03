namespace MT_WinForm.Forms
{
    partial class FormHistoryOpen : IForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistoryOpen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.RadioButtonHistory4 = new System.Windows.Forms.RadioButton();
            this.RadioButtonHistory3 = new System.Windows.Forms.RadioButton();
            this.RadioButtonHistory2 = new System.Windows.Forms.RadioButton();
            this.RadioButtonHistory1 = new System.Windows.Forms.RadioButton();
            this.ButtonGameStart = new System.Windows.Forms.Button();
            this.LabelSaveData = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.PictureBox();
            this.LabelFileName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.RadioButtonHistory4);
            this.panel1.Controls.Add(this.RadioButtonHistory3);
            this.panel1.Controls.Add(this.RadioButtonHistory2);
            this.panel1.Controls.Add(this.RadioButtonHistory1);
            this.panel1.Controls.Add(this.ButtonGameStart);
            this.panel1.Controls.Add(this.LabelSaveData);
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.LabelFileName);
            this.panel1.Location = new System.Drawing.Point(32, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 594);
            this.panel1.TabIndex = 15;
            // 
            // RadioButtonHistory4
            // 
            this.RadioButtonHistory4.AutoSize = true;
            this.RadioButtonHistory4.Font = new System.Drawing.Font("Courier New", 6F);
            this.RadioButtonHistory4.Location = new System.Drawing.Point(373, 367);
            this.RadioButtonHistory4.Name = "RadioButtonHistory4";
            this.RadioButtonHistory4.Size = new System.Drawing.Size(14, 13);
            this.RadioButtonHistory4.TabIndex = 24;
            this.RadioButtonHistory4.TabStop = true;
            this.RadioButtonHistory4.UseVisualStyleBackColor = true;
            // 
            // RadioButtonHistory3
            // 
            this.RadioButtonHistory3.AutoSize = true;
            this.RadioButtonHistory3.Font = new System.Drawing.Font("Courier New", 6F);
            this.RadioButtonHistory3.Location = new System.Drawing.Point(75, 367);
            this.RadioButtonHistory3.Name = "RadioButtonHistory3";
            this.RadioButtonHistory3.Size = new System.Drawing.Size(14, 13);
            this.RadioButtonHistory3.TabIndex = 23;
            this.RadioButtonHistory3.TabStop = true;
            this.RadioButtonHistory3.UseVisualStyleBackColor = true;
            // 
            // RadioButtonHistory2
            // 
            this.RadioButtonHistory2.AutoSize = true;
            this.RadioButtonHistory2.Font = new System.Drawing.Font("Courier New", 6F);
            this.RadioButtonHistory2.Location = new System.Drawing.Point(373, 151);
            this.RadioButtonHistory2.Name = "RadioButtonHistory2";
            this.RadioButtonHistory2.Size = new System.Drawing.Size(14, 13);
            this.RadioButtonHistory2.TabIndex = 22;
            this.RadioButtonHistory2.TabStop = true;
            this.RadioButtonHistory2.UseVisualStyleBackColor = true;
            // 
            // RadioButtonHistory1
            // 
            this.RadioButtonHistory1.AutoSize = true;
            this.RadioButtonHistory1.Font = new System.Drawing.Font("Courier New", 6F);
            this.RadioButtonHistory1.Location = new System.Drawing.Point(75, 129);
            this.RadioButtonHistory1.Name = "RadioButtonHistory1";
            this.RadioButtonHistory1.Size = new System.Drawing.Size(14, 13);
            this.RadioButtonHistory1.TabIndex = 21;
            this.RadioButtonHistory1.TabStop = true;
            this.RadioButtonHistory1.UseVisualStyleBackColor = true;
            // 
            // ButtonGameStart
            // 
            this.ButtonGameStart.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGameStart.Location = new System.Drawing.Point(530, 539);
            this.ButtonGameStart.Name = "ButtonGameStart";
            this.ButtonGameStart.Size = new System.Drawing.Size(106, 38);
            this.ButtonGameStart.TabIndex = 0;
            this.ButtonGameStart.Text = "Select";
            this.ButtonGameStart.UseVisualStyleBackColor = true;
            this.ButtonGameStart.Click += new System.EventHandler(this.ButtonGameStart_Click);
            // 
            // LabelSaveData
            // 
            this.LabelSaveData.AutoSize = true;
            this.LabelSaveData.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Italic);
            this.LabelSaveData.Location = new System.Drawing.Point(164, 129);
            this.LabelSaveData.Name = "LabelSaveData";
            this.LabelSaveData.Size = new System.Drawing.Size(0, 20);
            this.LabelSaveData.TabIndex = 16;
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
            this.LabelFileName.Location = new System.Drawing.Point(164, 206);
            this.LabelFileName.Name = "LabelFileName";
            this.LabelFileName.Size = new System.Drawing.Size(0, 20);
            this.LabelFileName.TabIndex = 3;
            // 
            // FormHistoryOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(752, 631);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "FormHistoryOpen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Minotaur and Theseus - Recently Played";
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
        private System.Windows.Forms.Label LabelSaveData;
        private System.Windows.Forms.PictureBox BackButton;
        private System.Windows.Forms.Label LabelFileName;
        private System.Windows.Forms.Button ButtonGameStart;
        private System.Windows.Forms.RadioButton RadioButtonHistory1;
        private System.Windows.Forms.RadioButton RadioButtonHistory4;
        private System.Windows.Forms.RadioButton RadioButtonHistory3;
        private System.Windows.Forms.RadioButton RadioButtonHistory2;
    }
}
