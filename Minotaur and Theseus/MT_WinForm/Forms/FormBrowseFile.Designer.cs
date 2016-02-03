namespace MT_WinForm.Forms
{
    partial class FormBrowseFile
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ButtonBrowseFile = new System.Windows.Forms.Button();
            this.TextBoxFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonBrowseFileOK = new System.Windows.Forms.Button();
            this.ButtonBrowseFileCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "MyGame.txt";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // ButtonBrowseFile
            // 
            this.ButtonBrowseFile.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBrowseFile.Location = new System.Drawing.Point(410, 76);
            this.ButtonBrowseFile.Name = "ButtonBrowseFile";
            this.ButtonBrowseFile.Size = new System.Drawing.Size(89, 30);
            this.ButtonBrowseFile.TabIndex = 0;
            this.ButtonBrowseFile.Text = "Browse...";
            this.ButtonBrowseFile.UseVisualStyleBackColor = true;
            this.ButtonBrowseFile.Click += new System.EventHandler(this.ButtonBrowseFile_Click);
            // 
            // TextBoxFilePath
            // 
            this.TextBoxFilePath.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxFilePath.Location = new System.Drawing.Point(39, 76);
            this.TextBoxFilePath.Multiline = true;
            this.TextBoxFilePath.Name = "TextBoxFilePath";
            this.TextBoxFilePath.Size = new System.Drawing.Size(350, 30);
            this.TextBoxFilePath.TabIndex = 1;
            this.TextBoxFilePath.Text = "C:\\Game\\mygame.txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a map file to load";
            // 
            // ButtonBrowseFileOK
            // 
            this.ButtonBrowseFileOK.Enabled = false;
            this.ButtonBrowseFileOK.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBrowseFileOK.Location = new System.Drawing.Point(288, 127);
            this.ButtonBrowseFileOK.Name = "ButtonBrowseFileOK";
            this.ButtonBrowseFileOK.Size = new System.Drawing.Size(89, 30);
            this.ButtonBrowseFileOK.TabIndex = 3;
            this.ButtonBrowseFileOK.Text = "OK";
            this.ButtonBrowseFileOK.UseVisualStyleBackColor = true;
            this.ButtonBrowseFileOK.Click += new System.EventHandler(this.ButtonBrowseFileOK_Click);
            // 
            // ButtonBrowseFileCancel
            // 
            this.ButtonBrowseFileCancel.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBrowseFileCancel.Location = new System.Drawing.Point(410, 127);
            this.ButtonBrowseFileCancel.Name = "ButtonBrowseFileCancel";
            this.ButtonBrowseFileCancel.Size = new System.Drawing.Size(89, 30);
            this.ButtonBrowseFileCancel.TabIndex = 4;
            this.ButtonBrowseFileCancel.Text = "Cancel";
            this.ButtonBrowseFileCancel.UseVisualStyleBackColor = true;
            this.ButtonBrowseFileCancel.Click += new System.EventHandler(this.ButtonBrowseFileCancel_Click);
            // 
            // FormBrowseFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(516, 184);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonBrowseFileCancel);
            this.Controls.Add(this.ButtonBrowseFileOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxFilePath);
            this.Controls.Add(this.ButtonBrowseFile);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBrowseFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load A Map File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ButtonBrowseFile;
        private System.Windows.Forms.TextBox TextBoxFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonBrowseFileOK;
        private System.Windows.Forms.Button ButtonBrowseFileCancel;
    }
}