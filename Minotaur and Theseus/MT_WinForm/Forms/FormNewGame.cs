using System;

namespace MT_WinForm.Forms
{
    public partial class FormNewGame : IForm
    {
        public FormNewGame()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            TitlePage.Show();
        }

        private void ButtonGameStart_Click(object sender, EventArgs e)
        {
            Hide();
            if (RadioButtonSelectALevel.Checked)
            {
                LoadFile file = new LoadFile();
                var selectedItem = ComboBoxLevelSelection.SelectedItem;
                file.FileName = selectedItem.ToString();
                file.FilePath = "DefaultLevel";
                file.FileContent = DefaultLevel.SelectMap(Convert.ToInt16(file.FileName));
                FileHistory.CurrentFile = file;
                FileHistory.AllFiles.Add(file);
                FormGameScreen gameScreen = new FormGameScreen();
                gameScreen.SetTitlePage(TitlePage);
                gameScreen.ShowDialog();
            }

            if (RadioButtonPlayFromBeginning.Checked)
            {
                LoadFile file = new LoadFile {FileName = "1", FilePath = "DefaultLevel"};
                file.FileContent = DefaultLevel.SelectMap(Convert.ToInt16(file.FileName));
                FileHistory.CurrentFile = file;
                FileHistory.AllFiles.Add(file);
                FormGameScreen gameScreen = new FormGameScreen();
                gameScreen.SetTitlePage(TitlePage);
                gameScreen.ShowDialog();
            }
        }

        private void RadioButtonPlayFromBeginning_CheckedChanged(object sender, EventArgs e)
        {
            ButtonGameStart.Enabled = RadioButtonPlayFromBeginning.Checked;
        }

        private void RadioButtonSelectALevel_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxLevelSelection.Enabled = RadioButtonSelectALevel.Checked;
        }

        private void ComboBoxLevelSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxLevelSelection.SelectedIndex > -1)
            {
                ButtonGameStart.Enabled = true;
            }
        }
    }
}
