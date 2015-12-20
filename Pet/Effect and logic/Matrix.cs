using System;
using Collection.Pages;

namespace Collection.Effect_and_logic
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
