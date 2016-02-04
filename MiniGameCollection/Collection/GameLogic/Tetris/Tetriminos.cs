using System.Drawing;
using Rectangle = System.Windows.Shapes.Rectangle;

namespace Collection.GameLogic.Tetris
{
    // 凸 凹 凸 □ 凸   TETRIS TETRIMINOS   凸 凹 凸 □ 凸
    public class Tetriminos
    {
        public Rectangle Block { get; set; }
        public Point[] FourPositions = new Point[4];
        public Point GridCoordination;
    }
}
