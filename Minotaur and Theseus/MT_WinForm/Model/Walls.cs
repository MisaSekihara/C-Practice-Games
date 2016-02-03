using System;

namespace MT_WinForm.Model
{
    [Flags]
    public enum Walls
    {
        None = 0,
        Up = 1,
        Down = 2,
        Left = 4,
        Right = 8,
        Goal = 16
    }
}
