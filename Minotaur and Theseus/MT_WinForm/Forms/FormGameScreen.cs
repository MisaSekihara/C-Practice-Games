using System;
using System.Windows.Forms;
using MT_WinForm.Model;
using System.IO;

namespace MT_WinForm.Forms
{
    public partial class FormGameScreen : IForm
    {
        private Game gameModel;

        public TextBox GameText
        {
            get { return GameMessageBox; }
            set { GameMessageBox = value; }
        }

        public TextBox LevelDisplay
        {
            get { return GameDisplay; }
            set { GameDisplay = value; }
        }

        public FormGameScreen()
        {
            gameModel = new Game(this);
            InitializeComponent();
            InitializeScreen();
        }

        public void InitializeScreen()
        {
            // GameMessageBox.Text = string.Empty;
            gameModel.LoadMapFromFiler(FileHistory.CurrentFile.FileContent);
            gameModel.PrintMap();
            
            GameMessageBox.AppendText(Environment.NewLine);
            GameMessageBox.AppendText(string.Format("Loaded {0}", FileHistory.CurrentFile.FileName));
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys key)
        {
            if (!gameModel.IsGameEnd)
            {
                if (key == Keys.Left || key == Keys.A)
                {
                    gameModel.MoveTheseus(Keys.Left.ToString());
                }
                if (key == Keys.Right || key == Keys.D)
                {
                    gameModel.MoveTheseus(Keys.Right.ToString());
                }
                if (key == Keys.Up || key == Keys.W)
                {
                    gameModel.MoveTheseus(Keys.Up.ToString());
                }
                if (key == Keys.Down || key == Keys.S)
                {
                    gameModel.MoveTheseus(Keys.Down.ToString());
                }
                if (key == Keys.Space)
                {
                    gameModel.MoveTheseus(Keys.Space.ToString());
                }
            }
            return base.ProcessCmdKey(ref msg, key);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save Current Game Into A Text File";
            saveFileDialog1.Filter = "TXT files|*.txt";
            saveFileDialog1.InitialDirectory = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\MT_WinForm\Resources\");
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var currentState = gameModel.AsciiMap;
            string fileName = saveFileDialog1.FileName;
            File.WriteAllText(saveFileDialog1.FileName, String.Empty);
            File.AppendAllLines(fileName, currentState);
            GameMessageBox.AppendText(Environment.NewLine);
            GameMessageBox.AppendText(string.Format("Current state is saved at {0}", saveFileDialog1.FileName));
        }

        private void ButtonNextMap_Click(object sender, EventArgs e)
        {
            gameModel.NextMap();
            GameMessageBox.AppendText(Environment.NewLine);
            GameMessageBox.AppendText(string.Format("Loaded next map {0}", FileHistory.CurrentFile.FileName));
        }

        private void ButtonPreviousMap_Click(object sender, EventArgs e)
        {
            gameModel.PreviousMap();
            GameMessageBox.AppendText(Environment.NewLine);
            GameMessageBox.AppendText(string.Format("Loaded previous map {0}", FileHistory.CurrentFile.FileName));
        }

        private void ButtonRestart_Click(object sender, EventArgs e)
        {
            gameModel.Restart();
            GameMessageBox.Text = string.Empty;
            GameMessageBox.AppendText(string.Format("Restarted {0}", FileHistory.CurrentFile.FileName));
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            FormBrowseFile loadFile = new FormBrowseFile();
            loadFile.ShowDialog();
            gameModel.LoadMapFromFiler(FileHistory.CurrentFile.FileContent);
            gameModel.PrintMap();
            GameMessageBox.AppendText(Environment.NewLine);
            GameMessageBox.AppendText(string.Format("Loaded file {0}", FileHistory.CurrentFile.FileName));
        }

    }
}
