using System.IO;
using System.Windows.Forms;

namespace MT_WinForm.Forms
{
    public partial class IForm : Form
    {
        public FormTitle TitlePage;

        public void SetTitlePage(FormTitle title)
        {
            TitlePage = title;
        }

        private void IForm_SaveHistory(object sender, FormClosedEventArgs e)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\MT_WinForm\Resources\history.txt");
            using (StreamWriter file = new StreamWriter(filePath, true))
            {
                foreach (LoadFile history in FileHistory.AllFiles)
                {
                    file.WriteLine("{0}#{1}", history.FileName, history.FilePath);
                }
            }
        }
    }
}
