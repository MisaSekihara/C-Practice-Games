using System;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Shapes;
using Point = System.Drawing.Point;
using System.Windows.Media;
using System.Windows.Threading;
using Collection.Pages;


namespace Collection.Effect_and_logic
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

    // 凸 凹 凸 □ 凸   TETRIS TETRIMINOS   凸 凹 凸 □ 凸
    public class Tetriminos
    {
        public Rectangle Block { get; set; }
        public Point[] FourPositions = new Point [4];
    }

    // 凸 凹 凸 □ 凸   TETRIS BLUEPRINT   凸 凹 凸 □ 凸
    public static class TetrisBluePrint
    {
        private static TetrisBlock TetrisI = new TetrisBlock
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

        private static TetrisBlock TetrisJ = new TetrisBlock
        {
            Coordinate1 = new int[,]
            {
                { 0, 1, 1, 0 },
                { 0, 1, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, 0, 0 }
            },
            Coordinate2 = new int[,]
            {
                { 0, 0, 0, 0 },
                { 1, 1, 1, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, 0, 0 }
            },
            Coordinate3 = new int[,]
            {
                { 0, 1, 0, 0 },
                { 0, 1, 0, 0 },
                { 1, 1, 0, 0 },
                { 0, 0, 0, 0 }
            },
            Coordinate4 = new int[,]
            {
                { 1, 0, 0, 0 },
                { 1, 1, 1, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            },
            FillColour = Brushes.Blue,
            StrokeColour = Brushes.DarkBlue
        };

        private static TetrisBlock TetrisL = new TetrisBlock
        {
            Coordinate1 = new int[,]
            {
                { 1, 1, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, 0, 0 }
            },
            Coordinate2 = new int[,]
            {
                { 0, 0, 1, 0 },
                { 1, 1, 1, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            },
            Coordinate3 = new int[,]
            {
                { 0, 1, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 1, 1, 0 },
                { 0, 0, 0, 0 }
            },
            Coordinate4 = new int[,]
            {
                { 0, 0, 0, 0 },
                { 1, 1, 1, 0 },
                { 1, 0, 0, 0 },
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
                { 1, 0, 0, 0 },
                { 1, 1, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, 0, 0 }
            },
            Coordinate2 = new int[,]
            {
                { 0, 1, 1, 0 },
                { 1, 1, 0, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            },
            Coordinate3 = new int[,]
            {
                { 0, 1, 0, 0 },
                { 0, 1, 1, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, 0, 0 }
            },
            Coordinate4 = new int[,]
            {
                { 0, 0, 0, 0 },
                { 0, 1, 1, 0 },
                { 1, 1, 0, 0 },
                { 0, 0, 0, 0 }
            },
            FillColour = Brushes.ForestGreen,
            StrokeColour = Brushes.DarkSlateGray
        };

        private static TetrisBlock TetrisT = new TetrisBlock
        {
            Coordinate1 = new int[,]
            {
                { 0, 0, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 1, 1, 0 },
                { 0, 1, 0, 0 }
            },
            Coordinate2 = new int[,]
            {
                { 0, 0, 0, 0 },
                { 1, 1, 1, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, 0, 0 }
            },
            Coordinate3 = new int[,]
            {
                { 0, 1, 0, 0 },
                { 0, 1, 0, 0 },
                { 1, 1, 0, 0 },
                { 0, 0, 0, 0 }
            },
            Coordinate4 = new int[,]
            {
                { 1, 0, 0, 0 },
                { 1, 1, 1, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            },
            FillColour = Brushes.Fuchsia,
            StrokeColour = Brushes.DarkMagenta
        };

        public static TetrisBlock[] BluePrints = { TetrisI, TetrisJ, TetrisL, TetrisO, TetrisS, TetrisT, TetrisZ };
    }

    // 凸 凹 凸 □ 凸    TETRIS GAME     凸 凹 凸 □ 凸
    public class TetrisGame
    {
        private readonly TetrisPage page;
        public Tetriminos[,] Grid;
        public Tetriminos CurrentMino = new Tetriminos();
        private readonly DispatcherTimer tetrisTimer = new DispatcherTimer();

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

        public void GravityOn()
        {
            tetrisTimer.Tick += tetrisTimer_Tick;
            tetrisTimer.Interval = new TimeSpan(0, 0, 0, 1);
            tetrisTimer.Start();
        }

        private void tetrisTimer_Tick(object sender, EventArgs e)
        {
            var currentPositions = CurrentMino.FourPositions;
            bool isMovable = currentPositions.All(position => !(position.Y >= page.MainCanvas.Height - TetrisPage.PixelSize));

            if (isMovable)
            {
                Fall();
            }
        }

        private void Fall()
        {
            page.MainCanvas.Children.Clear();
            var currentPositions = CurrentMino.FourPositions;
            for (int index = 0; index < 4; index++)
            {
                var tempShape = GetBlock(CurrentMino.Block.Stroke, CurrentMino.Block.Fill);
                Canvas.SetLeft(tempShape, currentPositions[index].X);
                Canvas.SetTop(tempShape, currentPositions[index].Y + TetrisPage.PixelSize);
                page.MainCanvas.Children.Add(tempShape);
                CurrentMino.FourPositions[index] = new Point(currentPositions[index].X, currentPositions[index].Y + TetrisPage.PixelSize);
            }
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

        public TetrisBlock GetRandomBlock()
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(7);
            return TetrisBluePrint.BluePrints[randomIndex];
        }

        public void CreateTetrisBlock(TetrisBlock nextBlock, int[,] bluePrint)
        {
            var block = new Rectangle
            {
                Stroke = nextBlock.StrokeColour,
                Fill = nextBlock.FillColour,
                StrokeThickness = 2,
                Width = TetrisPage.PixelSize,
                Height = TetrisPage.PixelSize
            };

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
