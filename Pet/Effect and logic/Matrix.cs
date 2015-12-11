using System;
using System.Drawing;
using Pet.Pages;
using Brush = System.Windows.Media.Brush;
using Brushes = System.Windows.Media.Brushes;

namespace Pet.Effect_and_logic
{
    public class Matrix
    {
        private char _ahplaNumeric;
        public MatrixPage MatrixPage;

        private char GetRandomLetters()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            char letter = chars[random.Next(chars.Length)];
            return letter;
        }

        public void StartMatrix()
        {

        }


    }
}
