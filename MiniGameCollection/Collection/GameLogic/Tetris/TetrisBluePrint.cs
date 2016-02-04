using System.Windows.Media;

namespace Collection.GameLogic.Tetris
{
    // 凸 凹 凸 □ 凸   TETRIS BLUEPRINT   凸 凹 凸 □ 凸
    public static class TetrisBluePrint
    {
        private static TetrisBlock TetrisI = new TetrisBlock
        {
            Coordinate1 = new int[,] 
            {
                { 0, 1, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 1, 0, 0 }
            },
            Coordinate2 = new int[,]
            {
                { 0, 0, 0, 0 },
                { 1, 1, 1, 1 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            },
            Coordinate3 = new int[,]
            {
                { 0, 0, 1, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, 1, 0 }
            },
            Coordinate4 = new int[,]
            {
                { 0, 0, 0, 0 },
                { 1, 1, 1, 1 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            },
            FillColour = Brushes.LightSkyBlue,
            StrokeColour = Brushes.CornflowerBlue
        };

        private static TetrisBlock TetrisJ = new TetrisBlock
        {
            Coordinate1 = new int[,]
            {
                { 1, 0, 0, 0 },
                { 1, 1, 1, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }                
            },
            Coordinate2 = new int[,]
            {
                { 0, 1, 0, 0 },
                { 0, 1, 0, 0 },
                { 1, 1, 0, 0 },
                { 0, 0, 0, 0 }
            },
            Coordinate3 = new int[,]
            {
                { 0, 0, 0, 0 },
                { 1, 1, 1, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, 0, 0 }
            },
            Coordinate4 = new int[,]
            {
                { 0, 1, 1, 0 },
                { 0, 1, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, 0, 0 }
            },
            FillColour = Brushes.Blue,
            StrokeColour = Brushes.DarkBlue
        };

        private static TetrisBlock TetrisL = new TetrisBlock
        {
            Coordinate1 = new int[,]
            {
                { 0, 0, 0, 0 },
                { 1, 1, 1, 0 },
                { 1, 0, 0, 0 },
                { 0, 0, 0, 0 }
            },
            Coordinate2 = new int[,]
            {
                { 0, 1, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 1, 1, 0 },
                { 0, 0, 0, 0 }
            },
            Coordinate3 = new int[,]
            {
                { 0, 0, 1, 0 },
                { 1, 1, 1, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            },
            Coordinate4 = new int[,]
            {
                { 1, 1, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, 0, 0 }
            },
            FillColour = Brushes.Orange,
            StrokeColour = Brushes.Chocolate
        };

        private static TetrisBlock TetrisO = new TetrisBlock
        {
            Coordinate1 = new int[,]
            {
                {0, 0, 0, 0},
                {0, 1, 1, 0},
                {0, 1, 1, 0},
                {0, 0, 0, 0}
            },
            Coordinate2 = new int[,]
            {
                {0, 0, 0, 0},
                {0, 1, 1, 0},
                {0, 1, 1, 0},
                {0, 0, 0, 0}
            },
            Coordinate3 = new int[,]
            {
                {0, 0, 0, 0},
                {0, 1, 1, 0},
                {0, 1, 1, 0},
                {0, 0, 0, 0}
            },
            Coordinate4 = new int[,]
            {
                {0, 0, 0, 0},
                {0, 1, 1, 0},
                {0, 1, 1, 0},
                {0, 0, 0, 0}
            },
            FillColour = Brushes.Yellow,
            StrokeColour = Brushes.Gold
            //StrokeColour = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF111111")
        };

        private static TetrisBlock TetrisZ = new TetrisBlock
        {
            Coordinate1 = new int[,]
            {
                { 0, 1, 0, 0 },
                { 1, 1, 0, 0 },
                { 1, 0, 0, 0 },
                { 0, 0, 0, 0 }
            },
            Coordinate2 = new int[,]
            {
                { 1, 1, 0, 0 },
                { 0, 1, 1, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            },
            Coordinate3 = new int[,]
            {
                { 0, 0, 1, 0 },
                { 0, 1, 1, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, 0, 0 }
            },
            Coordinate4 = new int[,]
            {
                { 0, 0, 0, 0 },
                { 1, 1, 0, 0 },
                { 0, 1, 1, 0 },
                { 0, 0, 0, 0 }
            },
            FillColour = Brushes.Red,
            StrokeColour = Brushes.Maroon
        };

        private static TetrisBlock TetrisS = new TetrisBlock
        {
            Coordinate1 = new int[,]
            {
                { 0, 1, 0, 0 },
                { 0, 1, 1, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, 0, 0 }
            },
            Coordinate2 = new int[,]
            {
                { 0, 0, 0, 0 },
                { 0, 1, 1, 0 },
                { 1, 1, 0, 0 },
                { 0, 0, 0, 0 }
            },
            Coordinate3 = new int[,]
            {
                { 1, 0, 0, 0 },
                { 1, 1, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, 0, 0 }
            },
            Coordinate4 = new int[,]
            {
                { 0, 1, 1, 0 },
                { 1, 1, 0, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            },
            FillColour = Brushes.ForestGreen,
            StrokeColour = Brushes.DarkSlateGray
        };

        private static TetrisBlock TetrisT = new TetrisBlock
        {
            Coordinate1 = new int[,]
            {
                { 0, 1, 0, 0 },
                { 1, 1, 1, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            },
            Coordinate2 = new int[,]
            {
                { 0, 1, 0, 0 },
                { 1, 1, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, 0, 0 }
            },
            Coordinate3 = new int[,]
            {
                { 0, 0, 0, 0 },
                { 1, 1, 1, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, 0, 0 }
            },
            Coordinate4 = new int[,]
            {
                { 0, 1, 0, 0 },
                { 0, 1, 1, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, 0, 0 }
            },
            FillColour = Brushes.Fuchsia,
            StrokeColour = Brushes.DarkMagenta
        };

        public static TetrisBlock[] BluePrints = { TetrisI, TetrisJ, TetrisL, TetrisO, TetrisS, TetrisT, TetrisZ };
    }
}
