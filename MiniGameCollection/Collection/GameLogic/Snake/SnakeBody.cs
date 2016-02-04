using System.Drawing;
using Rectangle = System.Windows.Shapes.Rectangle;

namespace Collection.GameLogic.Snake
{
    // ～>ﾟ ～～～～～～～　SNAKE BODY (NODE)　～～～～～～～ ﾟ<～
    public class SnakeBody
    {
        public Rectangle Shape { get; set; }
        public Point Position { get; set; }
    }
}
