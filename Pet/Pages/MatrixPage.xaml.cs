using System;
using Pet.Effect_and_logic;

namespace Pet.Pages
{
    public partial class MatrixPage
    {
        public Matrix Matrix;

        public MatrixPage()
        {
            InitializeComponent();
            MyConsoleControl.StartProcess("cmd.exe", string.Empty);
        }

    }
}
