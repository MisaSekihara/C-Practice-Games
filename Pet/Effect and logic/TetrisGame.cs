using System.Windows.Shapes;
using Point = System.Drawing.Point;
using System.Windows.Media;
using Collection.Pages;


namespace Collection.Effect_and_logic
{
    // 凸 凹 凸 □ 凸    TETRIS BLOCK    凸 凹 凸 □ 凸
    public class TetrisBlock
    {
        public int[,] Coordinate1 { get; set; }
        public int[,] Coordinate2 { get; set; }
        public int[,] Coordinate3 { get; set; }
        public int[,] Coordinate4 { get; set; }
        public Brush FillColour { get; set; }
        public Brush StrokeColour { get; set; }
        public Rectangle Shape { get; set; }
        public Point Position { get; set; }
    }

    public class Tetriminos
    {
        public Rectangle Block { get; set; }
        public Point[] FourPositions = new Point [4];
    }
    public static class TetrisBluePrint
    {
        public static TetrisBlock TetrisI = new TetrisBlock
        {
            Coordinate1 = new int[,]
            {
                { 0, 0, 1, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, 1, 0 }
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
        
        public static TetrisBlock TetrisJ = new TetrisBlock
        {
            Coordinate1 = new int[,]
            {
                { 0, 0, 0, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, 1, 0 },
                { 0, 1, 1, 0 }
            },
            FillColour = Brushes.Blue,
            StrokeColour = Brushes.DarkBlue
        };        
                
        public static TetrisBlock TetrisL = new TetrisBlock
        {
            Coordinate1 = new int[,]
            {
                { 0, 0, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 1, 1, 0 }
            },
            FillColour = Brushes.Orange,
            StrokeColour = Brushes.Chocolate
        };

        public static TetrisBlock TetrisO = new TetrisBlock
        {
            Coordinate1 = new int[,]
            {
                {0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0},
                {0, 0, 1, 1, 0},
                {0, 0, 1, 1, 0},
                {0, 0, 0, 0, 0}
            },

            FillColour = Brushes.Yellow,
            StrokeColour = Brushes.Gold
            //StrokeColour = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF111111")
        };        

        public static TetrisBlock TetrisZ = new TetrisBlock
        {
            Coordinate1 = new int[,]
            {
                { 0, 0, 0, 0 },
                { 0, 0, 1, 0 },
                { 0, 1, 1, 0 },
                { 0, 1, 0, 0 }
            },
            FillColour = Brushes.Red,
            StrokeColour = Brushes.Maroon
        };        

        public static TetrisBlock TetrisS = new TetrisBlock
        {
            Coordinate1 = new int[,]
            {
                { 0, 0, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 1, 1, 0 },
                { 0, 0, 1, 0 }
            },
            Coordinate2 = new int[,]
            {
                { 0, 0, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 1, 1, 0 },
                { 0, 0, 1, 0 }
            },
            FillColour = Brushes.ForestGreen,
            StrokeColour = Brushes.DarkSlateGray
        };

        public static TetrisBlock TetrisT = new TetrisBlock
        {
            Coordinate1 = new int[,]
            {
                { 0, 0, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 1, 1, 0 },
                { 0, 1, 0, 0 }
            },

            FillColour = Brushes.Fuchsia,
            StrokeColour = Brushes.DarkMagenta
        };        
    }

    // 凸 凹 凸 □ 凸    TETRIS GAME     凸 凹 凸 □ 凸
    public class TetrisGame
    {
        private readonly TetrisPage page;
        public Tetriminos[,] Grid;
        public Tetriminos CurrentMino;

        public TetrisGame(TetrisPage tetrisPage)
        {
            page = tetrisPage;
        }

        public void Init()
        {
            int x = (int)(page.MainCanvas.Width / TetrisPage.PixelSize);
            int y = (int)(page.MainCanvas.Height / TetrisPage.PixelSize);
            Grid = new Tetriminos[x, y];

            page.DrawGrid();
        }

        public Rectangle GetBlock(Brush stroke, Brush fill)
        {
            var block = new Rectangle
            {
                Stroke = stroke,
                Fill = fill,
                StrokeThickness = 2,
                Width = TetrisPage.PixelSize,
                Height = TetrisPage.PixelSize
            };
            return block;
        }

        public void CreateTetrisBlock(TetrisBlock nextBlock)
        {
            CurrentMino = new Tetriminos();
            
            var block = new Rectangle
            {
                Stroke = nextBlock.StrokeColour,
                Fill = nextBlock.FillColour,
                StrokeThickness = 2,
                Width = TetrisPage.PixelSize,
                Height = TetrisPage.PixelSize
            };

            var bluePrint = nextBlock.Coordinate1;
            var positionIndex = 0;

            for (int x = 0; x < bluePrint.GetLength(0); x++)
            {
                for (int y = 0; y < bluePrint.GetLength(1); y++)
                {
                    CurrentMino.Block = block;
                    
                    if (bluePrint[x,y] == 1)
                    {
                        CurrentMino.FourPositions[positionIndex] = new Point(x * TetrisPage.PixelSize + TetrisPage.PixelSize*3, y * TetrisPage.PixelSize);
                        positionIndex++;
                    }
                }
            }
        }
    }
}
