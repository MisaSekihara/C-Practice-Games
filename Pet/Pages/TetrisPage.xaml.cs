using System;
using System.Linq;
using System.Threading;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;
using Collection.Effect_and_logic;
using Point = System.Drawing.Point;

namespace Collection.Pages
{
    public partial class TetrisPage
    {
        private readonly TetrisGame game;
        public const int PixelSize = 32;
        private readonly DispatcherTimer tetrisTimer = new DispatcherTimer();

        public TetrisPage()
        {
            InitializeComponent();
            game = new TetrisGame(this);
            game.Init();
            Play();
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

        public void Play()
        {
            game.CreateTetrisBlock(TetrisBluePrint.TetrisI);
            DrawBlock();
            GravityOn();
        }

        private void tetrisTimer_Tick(object sender, EventArgs e)
        {
            var currentPositions = game.CurrentMino.FourPositions;
            bool isMovable = currentPositions.All(position => !(position.Y >= MainCanvas.Height - PixelSize));

            if (isMovable)
            {
                Fall();
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
        }
        
        public void GravityOn()
        {
            tetrisTimer.Tick += tetrisTimer_Tick;
            tetrisTimer.Interval = new TimeSpan(0, 0, 0, 1);
            tetrisTimer.Start();
        }

        private void Fall()
        {
            MainCanvas.Children.Clear();
            var currentPositions = game.CurrentMino.FourPositions;
            for (int index = 0; index < 4; index++)
            {
                var tempShape = game.GetBlock(game.CurrentMino.Block.Stroke, game.CurrentMino.Block.Fill);
                Canvas.SetLeft(tempShape, currentPositions[index].X);
                Canvas.SetTop(tempShape, currentPositions[index].Y + PixelSize);
                MainCanvas.Children.Add(tempShape);
                game.CurrentMino.FourPositions[index] = new Point(currentPositions[index].X, currentPositions[index].Y + PixelSize);
            }
        }

        private void DownButton_Click(object sender, RoutedEventArgs e)
        {
            var currentPositions = game.CurrentMino.FourPositions;

            bool isMovable = currentPositions.All(position => !(position.Y >= MainCanvas.Height - PixelSize));

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
                isMovable = currentPositions.All(position => !(position.Y >= MainCanvas.Height - PixelSize));
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
            throw new NotImplementedException();
        }
    }
}
