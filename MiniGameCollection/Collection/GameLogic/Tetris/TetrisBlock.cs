using System.Drawing;
using Brush = System.Windows.Media.Brush;
using Rectangle = System.Windows.Shapes.Rectangle;

namespace Collection.GameLogic.Tetris
{
    // 凸 凹 凸 □ 凸    TETRIS BLOCK    凸 凹 凸 □ 凸
    public class TetrisBlock
    {
        public int[,] Coordinate1;
        public int[,] Coordinate2;
        public int[,] Coordinate3;
        public int[,] Coordinate4;
        public Brush FillColour;
        public Brush StrokeColour;
        public Rectangle Shape;
        public Point Position;
    }
}
