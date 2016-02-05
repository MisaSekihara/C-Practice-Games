using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Collection.GameLogic.Tetris;
using Point = System.Drawing.Point;

namespace Collection.Pages
{
    public partial class TetrisPage
    {
        private readonly TetrisGame game;
        public const int PixelSize = 32;
        private bool isPauseOn = false;
        private int rotationCount;
        
        public TetrisPage()
        {
            InitializeComponent();
            game = new TetrisGame(this);
            game.Init();
        }

        public void DrawGrid()
        {
            for (int i = PixelSize; i < GridCanvas.Height; i += PixelSize)
            {
                var line = new Line
                {
                    Stroke = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF303030")),
                    X1 = 0,
                    Y1 = i,
                    X2 = GridCanvas.Width,
                    Y2 = i,
                    StrokeThickness = 1
                };

                GridCanvas.Children.Add(line);
            }

            for (int i = PixelSize; i < GridCanvas.Width; i += PixelSize)
            {
                var line = new Line
                {
                    Stroke = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF303030")),
                    X1 = i,
                    Y1 = 0,
                    X2 = i,
                    Y2 = GridCanvas.Height,
                    StrokeThickness = 1
                };

                GridCanvas.Children.Add(line);
            }
        }

        public void DrawBlock()
        {
            foreach (var position in game.CurrentMino.FourPositions)
            {
                var tempShape = game.GetBlock(game.CurrentMino.Block.Stroke, game.CurrentMino.Block.Fill);
                Canvas.SetLeft(tempShape, position.X);
                Canvas.SetTop(tempShape, position.Y);
                MainCanvas.Children.Add(tempShape);
            }

            foreach (var cell in game.Grid)
            {
                if (cell != null)
                {
                    var piece = new Rectangle
                    {
                        Stroke = cell.Block.Stroke,
                        Fill = cell.Block.Fill,
                        StrokeThickness = 2,
                        Width = PixelSize,
                        Height = PixelSize
                    };
                    Canvas.SetLeft(piece, cell.GridCoordination.X);
                    Canvas.SetTop(piece, cell.GridCoordination.Y);
                    LandedCanvas.Children.Add(piece);
                }
            }
        }

        public void CleanCanvas()
        {
            MainCanvas.Children.Clear();
            LandedCanvas.Children.Clear();
        }

        private void DownButton_Click(object sender, RoutedEventArgs e)
        {
            var currentPositions = game.CurrentMino.FourPositions;

            bool isMovable = game.IsMovable("Down");
            while (isMovable)
            {
                MainCanvas.Children.Clear();
                for (int index = 0; index < 4; index++)
                {
                    var tempShape = game.GetBlock(game.CurrentMino.Block.Stroke, game.CurrentMino.Block.Fill);
                    Canvas.SetLeft(tempShape, currentPositions[index].X);
                    Canvas.SetTop(tempShape, currentPositions[index].Y + PixelSize);
                    MainCanvas.Children.Add(tempShape);
                    game.CurrentMino.FourPositions[index] = new Point(currentPositions[index].X, currentPositions[index].Y + PixelSize);
                }
                isMovable = game.IsMovable("Down");
            }
        }

        private void MoveHorrizontal(string button)
        {
            var currentPositions = game.CurrentMino.FourPositions;
            int x = 0;
            bool isMovable = true; 
            foreach (var position in currentPositions)
            {
                if (button == "Left")
                {
                    x = position.X - PixelSize;
                }
                if (button == "Right")
                {
                    x = position.X + PixelSize;
                }

                if (x >= MainCanvas.Width || (x < 0))
                {
                    isMovable = false;
                    break;
                }
            }

            if (isMovable)
            {
                MainCanvas.Children.Clear();
                for (int index = 0; index < 4; index++)
                {
                    var tempShape = game.GetBlock(game.CurrentMino.Block.Stroke, game.CurrentMino.Block.Fill);
                    if (button == "Left")
                    {
                        x = currentPositions[index].X - PixelSize;
                    }
                    if (button == "Right")
                    {
                        x = currentPositions[index].X + PixelSize;
                    }
                    Canvas.SetLeft(tempShape, x);
                    Canvas.SetTop(tempShape, currentPositions[index].Y);
                    MainCanvas.Children.Add(tempShape);
                    game.CurrentMino.FourPositions[index] = new Point(x, currentPositions[index].Y);
                }
            }
        }

        private void LeftButton_Click(object sender, RoutedEventArgs e)
        {
            MoveHorrizontal("Left");
        }        
        
        private void RightButton_Click(object sender, RoutedEventArgs e)
        {
            MoveHorrizontal("Right");
        }
       
        private void UpButton_Click(object sender, RoutedEventArgs e)
        {
            switch (rotationCount)
            {
                case 0 :
                    game.CreateTetrisBlock(game.CurrentBlock, game.CurrentBlock.Coordinate2);
                    rotationCount++;
                    break;

                case 1 :
                    game.CreateTetrisBlock(game.CurrentBlock, game.CurrentBlock.Coordinate3);
                    rotationCount++;
                    break;                
                
                case 2 :
                    game.CreateTetrisBlock(game.CurrentBlock, game.CurrentBlock.Coordinate4);
                    rotationCount++;
                    break;

                case 3:
                    game.CreateTetrisBlock(game.CurrentBlock, game.CurrentBlock.Coordinate1);
                    rotationCount = 0;
                    break;
            }
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            if (isPauseOn)
            {
                game.TetrisTimer.Start();
                PauseButton.Content = "Pause";
                isPauseOn = false;
            }
            else if (!isPauseOn)
            {
                game.TetrisTimer.Stop();
                PauseButton.Content = "Start";
                isPauseOn = true;
            }
        }

        private void RestButton_Click(object sender, RoutedEventArgs e)
        {
            var navigationService = NavigationService;
            if (navigationService != null) navigationService.Refresh();
        }
    }
}
