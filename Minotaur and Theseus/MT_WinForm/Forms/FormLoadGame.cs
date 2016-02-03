using System;
using System.ComponentModel;
using System.IO;

namespace MT_WinForm.Forms
{
    public partial class FormLoadGame : IForm
    {
        public FormLoadGame()
        {
            InitializeComponent();
        }

        private void RadioButtonLoadAMapFromFile_CheckedChanged(object sender, EventArgs e)
        {
            ButtonOpenTxtFile.Enabled = RadioButtonLoadAMapFromFile.Checked;
        }

        private void ButtonOpenTxtFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open Text File";
            openFileDialog1.Filter = "TXT files|*.txt";
            openFileDialog1.InitialDirectory = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\MT_WinForm\Resources\");
            openFileDialog1.ShowDialog();
        }

        private void RadioButtonRecentlyPlayedGame_CheckedChanged(object sender, EventArgs e)
        {
            ButtonRecentlyPlayedGame.Enabled = RadioButtonRecentlyPlayedGame.Checked;
        }

        private void ButtonRecentlyPlayedGame_Click(object sender, EventArgs e)
        {
            FormHistoryOpen historyForm = new FormHistoryOpen();
            historyForm.SetTitlePage(TitlePage);
            Hide();
            historyForm.ShowDialog();
        }
        
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            LoadFile file = new LoadFile();
            file.FilePath = openFileDialog1.FileName;
            file.FileName = openFileDialog1.SafeFileName;
            file.FileContent = File.ReadAllLines(file.FilePath);
            FileHistory.AllFiles.Add(file);
            FileHistory.CurrentFile = file;
            LabelFileName.Text = FileHistory.CurrentFile.FileName;
            ButtonGameStart.Enabled = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            TitlePage.Show();
        }

        private void ButtonGameStart_Click(object sender, EventArgs e)
        {
            Hide();
            if (RadioButtonLoadAMapFromFile.Checked && FileHistory.CurrentFile.FileName != null)
            {
                FormGameScreen gameScreen = new FormGameScreen();
                gameScreen.SetTitlePage(TitlePage);
                gameScreen.ShowDialog();
            }
        }
    }
}
