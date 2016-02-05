using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;
using Collection.Pages;
using Brush = System.Windows.Media.Brush;
using Point = System.Drawing.Point;
using Rectangle = System.Windows.Shapes.Rectangle;

namespace Collection.GameLogic.Tetris
{
    // 凸 凹 凸 □ 凸    TETRIS GAME     凸 凹 凸 □ 凸
    public class TetrisGame
    {
        private readonly TetrisPage page;
        public Tetriminos[,] Grid;
        public Tetriminos CurrentMino = new Tetriminos();
        public DispatcherTimer TetrisTimer = new DispatcherTimer();
        public TetrisBlock CurrentBlock = new TetrisBlock();
        private int width;
        private int height;


        public TetrisGame(TetrisPage tetrisPage)
        {
            page = tetrisPage;
        }

        public void Init()
        {
            width = (int)(page.MainCanvas.Width / TetrisPage.PixelSize);
            height = (int)(page.MainCanvas.Height / TetrisPage.PixelSize);
            Grid = new Tetriminos[width, height];

            page.DrawGrid();

            CurrentBlock = GetRandomBlock();
            CreateTetrisBlock(CurrentBlock, CurrentBlock.Coordinate1);
            page.DrawBlock();
            GravityOn();
            Update();
        }

        public void GravityOn()
        {
            TetrisTimer.Tick += tetrisTimer_Tick;
            TetrisTimer.Interval = new TimeSpan(0, 0, 0, 1);
            TetrisTimer.Start();
        }

        private void tetrisTimer_Tick(object sender, EventArgs e)
        {
            var currentPositions = CurrentMino.FourPositions;
            bool isMovable = IsMovable("Down");

            if (isMovable)
            {
                page.MainCanvas.Children.Clear();
                Fall();
            }
            if (!isMovable)
            {
                for (int index = 0; index < 4; index++)
                {
                    int x = currentPositions[index].X / TetrisPage.PixelSize;
                    int y = currentPositions[index].Y / TetrisPage.PixelSize;
                    Grid[x, y] = new Tetriminos
                    {
                        Block = CurrentMino.Block,
                        GridCoordination = currentPositions[index]
                    };
                }

                CheckLines();
            }
        }

        private void CheckLines()
        {
            // Check all rows. Check from bottom lines
            for (int y = height-1; y >= 0; y--)
            {
                int count = 0;
                int currentRow = y;
                for (int x = 0; x <= width-1; x++)
                {
                    if (Grid[x, y] != null)
                    {
                        count += 1;
                    }
                }
                if (count >= width)
                {
                    MessageBox.Show(String.Format("Clearing row {0}", currentRow));
                    ClearLine(currentRow);
                    page.CleanCanvas();
                }
            }
            Update();
        }

        // Check horizontal lines if there are any lines that are filled and clear them.
        private void CheckAllBlocks()
        {
            
        }

        private void ClearLine(int whichRow)
        {
            // Remove all blocks from the row
            for (int x = 0; x < width; x++)
            {
                Grid[x, whichRow] = null;
            }
            
            // Move all other blocks above the specified rows downwards
            var newGrid = new Tetriminos[width, height];
            for (int x = 0; x < width; x++)
            {
                for (int y = height-1; y > 0; y--)
                {
                    if (y > whichRow)
                    {
                        newGrid[x, y] = Grid[x, y];
                    }
                    else
                    {
                        newGrid[x, y] = Grid[x, y-1];
                    }
                    if (newGrid[x, y] != null)
                    {
                        newGrid[x, y].GridCoordination = new Point(
                            x * TetrisPage.PixelSize,
                            y * TetrisPage.PixelSize);
                    }

                }
            }
            Grid = newGrid;

            var player = new MediaPlayer();
            player.Open(new Uri("../../Sound/se_clear1.wav", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        private void IsMultiClear()
        {
            
            
        }

        // Check if 4 lines are filled
        private void ClearTetris()
        {

            var player = new MediaPlayer();
            player.Open(new Uri("../../Sound/se_clear3.wav", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        private void Fall()
        {
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

        // Update(redraw) the screen
        public void Update()
        {
            CurrentBlock = GetRandomBlock();
            CreateTetrisBlock(CurrentBlock, CurrentBlock.Coordinate1);
            page.DrawBlock();
        }

        public bool IsMovable(string direction)
        {
            if (direction == "Down")
            {
                foreach (var position in CurrentMino.FourPositions)
                {
                    if (position.Y >= page.MainCanvas.Height - TetrisPage.PixelSize)
                    {
                        return false;
                    }
                    int x = position.X/TetrisPage.PixelSize;
                    int y = (position.Y / TetrisPage.PixelSize) + 1;
                    if (Grid[x, y] != null)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
