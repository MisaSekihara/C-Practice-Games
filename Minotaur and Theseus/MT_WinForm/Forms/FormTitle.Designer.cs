namespace MT_WinForm.Forms
{
    partial class FormTitle : IForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTitle));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonNewGame = new System.Windows.Forms.Button();
            this.ButtonLoadGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 29F);
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 147);
            this.label1.TabIndex = 10;
            this.label1.Text = "Minotaur \r\n    and \r\nTheseus";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(271, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(385, 337);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonNewGame
            // 
            this.ButtonNewGame.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonNewGame.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNewGame.Location = new System.Drawing.Point(49, 255);
            this.ButtonNewGame.Name = "ButtonNewGame";
            this.ButtonNewGame.Size = new System.Drawing.Size(165, 51);
            this.ButtonNewGame.TabIndex = 6;
            this.ButtonNewGame.Text = "Start Game";
            this.ButtonNewGame.UseVisualStyleBackColor = false;
            this.ButtonNewGame.Click += new System.EventHandler(this.OpenNewGameScreen);
            // 
            // ButtonLoadGame
            // 
            this.ButtonLoadGame.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonLoadGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonLoadGame.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLoadGame.Location = new System.Drawing.Point(49, 330);
            this.ButtonLoadGame.Name = "ButtonLoadGame";
            this.ButtonLoadGame.Size = new System.Drawing.Size(165, 51);
            this.ButtonLoadGame.TabIndex = 7;
            this.ButtonLoadGame.Text = "Load Game";
            this.ButtonLoadGame.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ButtonLoadGame.UseVisualStyleBackColor = false;
            this.ButtonLoadGame.Click += new System.EventHandler(this.ButtonLoadGame_Click);
            // 
            // FormTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonLoadGame);
            this.Controls.Add(this.ButtonNewGame);
            this.Name = "FormTitle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MT_WinForm.Properties.Resources.MazeBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtonNewGame;
        private System.Windows.Forms.Button ButtonLoadGame;
    }
}
