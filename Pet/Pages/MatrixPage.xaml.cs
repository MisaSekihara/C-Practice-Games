using Collection.Effect_and_logic;

namespace Collection.Pages
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
