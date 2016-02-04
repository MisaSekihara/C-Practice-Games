using System.Drawing;

namespace Collection.GameLogic.Snake
{
    // ～>ﾟ ～～～～～～～～　SNAKE DIRECTION　～～～～～～～～ ﾟ<～
    public static class SnakeDirection
    {
        public static Point Up = new Point(0, -20);
        public static Point Down = new Point(0, 20);
        public static Point Left = new Point(-20, 0);
        public static Point Right = new Point(20, 0);
    }
}

