namespace MT_WinForm.Forms
{
    partial class FormGameScreen : IForm
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
            this.GameMessageBox = new System.Windows.Forms.TextBox();
            this.ButtonNextMap = new System.Windows.Forms.Button();
            this.ButtonPreviousMap = new System.Windows.Forms.Button();
            this.ButtonRestart = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonLoad = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.GameDisplay = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameMessageBox
            // 
            this.GameMessageBox.BackColor = System.Drawing.Color.White;
            this.GameMessageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameMessageBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.GameMessageBox.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameMessageBox.Location = new System.Drawing.Point(34, 433);
            this.GameMessageBox.Multiline = true;
            this.GameMessageBox.Name = "GameMessageBox";
            this.GameMessageBox.ReadOnly = true;
            this.GameMessageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GameMessageBox.Size = new System.Drawing.Size(575, 90);
            this.GameMessageBox.TabIndex = 3;
            this.GameMessageBox.Text = "Press ARROW keys or W A S D keys to move Theseus. \r\nSPACE for skip(delay) move.\r\n" +
    "";
            // 
            // ButtonNextMap
            // 
            this.ButtonNextMap.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNextMap.Location = new System.Drawing.Point(663, 22);
            this.ButtonNextMap.Name = "ButtonNextMap";
            this.ButtonNextMap.Size = new System.Drawing.Size(150, 55);
            this.ButtonNextMap.TabIndex = 5;
            this.ButtonNextMap.Text = "Next Map";
            this.ButtonNextMap.UseVisualStyleBackColor = true;
            this.ButtonNextMap.Click += new System.EventHandler(this.ButtonNextMap_Click);
            // 
            // ButtonPreviousMap
            // 
            this.ButtonPreviousMap.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPreviousMap.Location = new System.Drawing.Point(663, 113);
            this.ButtonPreviousMap.Name = "ButtonPreviousMap";
            this.ButtonPreviousMap.Size = new System.Drawing.Size(150, 55);
            this.ButtonPreviousMap.TabIndex = 6;
            this.ButtonPreviousMap.Text = "Previous Map";
            this.ButtonPreviousMap.UseVisualStyleBackColor = true;
            this.ButtonPreviousMap.Click += new System.EventHandler(this.ButtonPreviousMap_Click);
            // 
            // ButtonRestart
            // 
            this.ButtonRestart.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRestart.Location = new System.Drawing.Point(663, 204);
            this.ButtonRestart.Name = "ButtonRestart";
            this.ButtonRestart.Size = new System.Drawing.Size(150, 55);
            this.ButtonRestart.TabIndex = 7;
            this.ButtonRestart.Text = "Restart";
            this.ButtonRestart.UseVisualStyleBackColor = true;
            this.ButtonRestart.Click += new System.EventHandler(this.ButtonRestart_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.Location = new System.Drawing.Point(663, 386);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(150, 55);
            this.ButtonSave.TabIndex = 8;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLoad.Location = new System.Drawing.Point(663, 468);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(150, 55);
            this.ButtonLoad.TabIndex = 9;
            this.ButtonLoad.Text = "Load";
            this.ButtonLoad.UseVisualStyleBackColor = true;
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // GameDisplay
            // 
            this.GameDisplay.BackColor = System.Drawing.Color.White;
            this.GameDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GameDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.GameDisplay.Enabled = false;
            this.GameDisplay.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameDisplay.Location = new System.Drawing.Point(24, 19);
            this.GameDisplay.Multiline = true;
            this.GameDisplay.Name = "GameDisplay";
            this.GameDisplay.ReadOnly = true;
            this.GameDisplay.Size = new System.Drawing.Size(518, 367);
            this.GameDisplay.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.GameDisplay);
            this.panel1.Location = new System.Drawing.Point(34, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 404);
            this.panel1.TabIndex = 4;
            // 
            // FormGameScreen
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MT_WinForm.Properties.Resources.MazeBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 562);
            this.Controls.Add(this.ButtonLoad);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonRestart);
            this.Controls.Add(this.ButtonPreviousMap);
            this.Controls.Add(this.ButtonNextMap);
            this.Controls.Add(this.GameMessageBox);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "FormGameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GameMessageBox;
        private System.Windows.Forms.Button ButtonNextMap;
        private System.Windows.Forms.Button ButtonPreviousMap;
        private System.Windows.Forms.Button ButtonRestart;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonLoad;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox GameDisplay;
        private System.Windows.Forms.Panel panel1;

    }
}
