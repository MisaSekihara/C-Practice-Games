using System.Drawing;

namespace MT_WinForm.Model
{
    public static class Direction
    {
        public static Point Up = new Point(0, -1);
        public static Point Down = new Point(0, 1);
        public static Point Left = new Point(-1, 0);
        public static Point Right = new Point(1, 0);
        public static Point Skip = new Point(0, 0);
    }
}
