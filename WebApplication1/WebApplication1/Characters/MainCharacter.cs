using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace WebApplication1.Characters
{
    public class MainCharacter : BaseCharacter
    {
        public MainCharacter(Point newPosition, int newHeight, int newWidth, string newColour, string newName)
        {
            Position = newPosition;
            Height = newHeight;
            Width = newWidth;
            Colour = newColour;
            Name = newName;
        }
    }
}