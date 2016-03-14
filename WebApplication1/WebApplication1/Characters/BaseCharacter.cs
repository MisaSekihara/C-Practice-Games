using System.Drawing;

namespace WebApplication1.Characters
{
    public abstract class BaseCharacter
    {
        public Point Position;
        public int Height;
        public int Width;
        public string Colour;
        public string Name;
        

        public void SetPosition(int x, int y)
        {
            Position = new Point(x, y);
        }

        public Point GetPosition()
        {
            return Position;
        }

        public int GetHeight()
        {
            return Height;
        }

        public int GetWidth()
        {
            return Width;
        }        
        
        public void GetColour(string newColour)
        {
            Colour = newColour;
        }

        public string GetColour()
        {
            return Colour;
        }


    }
}