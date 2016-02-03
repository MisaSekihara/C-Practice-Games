using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MT_WinForm.Forms
{
    public partial class FormHistoryOpen : IForm
    {
        private List<LoadFile> allRecentFiles = new List<LoadFile>();

        public FormHistoryOpen()
        {
            InitializeComponent();
            GetDataFromFile();
            UpdateButtonPreview();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            TitlePage.Show();
        }

        private void GetDataFromFile()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\MT_WinForm\Resources\history.txt");
            List<string> allLines = File.ReadAllLines(filePath).ToList();

            while (allLines.Count > 4)
            {
                allLines.RemoveAt(0);
            }

            foreach (var line in allLines)
            {
                LoadFile file = new LoadFile();
                string[] namePath = new string[2];
                namePath = line.Split('#');

                if (namePath[1] == ("DefaultLevel"))
                {
                    file.FileName = namePath[0];
                    file.FilePath = namePath[1];
                    file.FileContent = DefaultLevel.SelectMap(Int32.Parse(file.FileName));
                }
                else
                {
                    file.FileName = namePath[0];
                    file.FilePath = namePath[1];
                    file.FileContent = File.ReadAllLines(namePath[1]);
                }
                allRecentFiles.Add(file);
            }
        }

        private void UpdateButtonPreview()
        {
            List<string> allPreviews = new List<string>();

            // get all button preview map
            for (int i = 0; i < allRecentFiles.Count; i++)
            {
                string content = string.Empty;
                foreach (var line in allRecentFiles[i].FileContent)
                {
                    content += line + "\n";
                }
                allPreviews.Add(content);
            }

            // assign map previews to radio buttons
            RadioButtonHistory1.Text = allPreviews[0];
            RadioButtonHistory2.Text = allPreviews[1];
            RadioButtonHistory3.Text = allPreviews[2];
            RadioButtonHistory4.Text = allPreviews[3];
        }

        private void ButtonGameStart_Click(object sender, EventArgs e)
        {
            if (RadioButtonHistory1.Checked)
            {
                FileHistory.CurrentFile = allRecentFiles[0];
                FormGameScreen gameScreen = new FormGameScreen();
                gameScreen.SetTitlePage(TitlePage);
                Hide();
                gameScreen.ShowDialog();
            }

            if (RadioButtonHistory2.Checked)
            {
                FileHistory.CurrentFile = allRecentFiles[1];
                FormGameScreen gameScreen = new FormGameScreen();
                gameScreen.SetTitlePage(TitlePage);
                Hide();
                gameScreen.ShowDialog();
            }

            if (RadioButtonHistory3.Checked)
            {
                FileHistory.CurrentFile = allRecentFiles[2];
                FormGameScreen gameScreen = new FormGameScreen();
                gameScreen.SetTitlePage(TitlePage);
                Hide();
                gameScreen.ShowDialog();
            }

            if (RadioButtonHistory4.Checked)
            {
                FileHistory.CurrentFile = allRecentFiles[3];
                FormGameScreen gameScreen = new FormGameScreen();
                gameScreen.SetTitlePage(TitlePage);
                Hide();
                gameScreen.ShowDialog();
            }
        }

    }
}
