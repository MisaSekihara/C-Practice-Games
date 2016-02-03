using System;

namespace MT_WinForm.Forms
{
    public partial class FormTitle : IForm
    {
        public FormTitle()
        {
            InitializeComponent();
            TitlePage = this;
        }

        private void OpenNewGameScreen(object sender, EventArgs e)
        {
            FormNewGame newGame = new FormNewGame();
            TitlePage.Hide();
            newGame.SetTitlePage(this);
            newGame.ShowDialog();
        }

        private void ButtonLoadGame_Click(object sender, EventArgs e)
        {
            FormLoadGame loadGame = new FormLoadGame();
            TitlePage.Hide();
            loadGame.SetTitlePage(this);
            loadGame.ShowDialog();
        }
    }
}
