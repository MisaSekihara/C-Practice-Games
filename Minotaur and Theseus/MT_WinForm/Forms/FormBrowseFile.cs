using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace MT_WinForm.Forms
{
    public partial class FormBrowseFile : Form
    {
        private LoadFile file;

        public FormBrowseFile()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            file = new LoadFile();
            file.FilePath = openFileDialog1.FileName;
            file.FileName = openFileDialog1.SafeFileName;
            file.FileContent = File.ReadAllLines(file.FilePath);
            TextBoxFilePath.Text = file.FilePath;
            ButtonBrowseFileOK.Enabled = true;
        }

        private void ButtonBrowseFileOK_Click(object sender, EventArgs e)
        {
            FileHistory.AllFiles.Add(file);
            FileHistory.CurrentFile = file;
            Close();
        }

        private void ButtonBrowseFileCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonBrowseFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open Text File";
            openFileDialog1.Filter = "TXT files|*.txt";
            openFileDialog1.InitialDirectory = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\MT_WinForm\Resources\");
            openFileDialog1.ShowDialog();
        }


    }
}
