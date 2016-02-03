using System.Drawing;

namespace MT_WinForm.Model
{
    public class Thing
    {
        public Point Position;

        public Thing(int x, int y)
        {
            Position = new Point(x, y);
        }
    }
}
