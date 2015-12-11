using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;
using System.Windows.Threading;
using Pet.Effect_and_logic;

namespace Pet.Pages
{
    /// <summary>
    /// Interaction logic for SnakePage.xaml
    /// </summary>
    public partial class SnakePage : Page
    {
        private SnakeGame game;
        public DispatcherTimer Timer = new DispatcherTimer();
        private DateTime dateTime;

        public SnakePage()
        {
            InitializeComponent();
            game = new SnakeGame(this);
            game.Init();
        }

        public void DrawSnake(SnakeBody body)
        {
            Canvas.SetLeft(body.Shape, body.Position.X);
            Canvas.SetTop(body.Shape, body.Position.Y);
            MyCanvas.Children.Add(body.Shape);
        }

        public void DrawEgg()
        {
            var egg = game.Egg;
            Canvas.SetLeft(egg.Shape, egg.Position.X);
            Canvas.SetTop(egg.Shape, egg.Position.Y);
            MyCanvas.Children.Add(egg.Shape);
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this);
            if (window != null) window.KeyDown += UserControl_KeyDown;
            StartTimer();
        }

        private void StartTimer()
        {
            Timer.Tick += DisplayTimer;
            Timer.Interval = new TimeSpan(0,0,0,1);
            dateTime = DateTime.Now;
            Timer.Start();
        }

        private void DisplayTimer(object sender, EventArgs e)
        {
            var current = DateTime.Now.Subtract(dateTime);
            TimerLabel.Content = current.ToString(@"mm\:ss");
        }

        private void UserControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                game.MoveSnake(SnakeDirection.Up);
            }
            if (e.Key == Key.Down)
            {
                game.MoveSnake(SnakeDirection.Down);
            }
            if (e.Key == Key.Left)
            {
                game.MoveSnake(SnakeDirection.Left);
            }
            if (e.Key == Key.Right)
            {
                game.MoveSnake(SnakeDirection.Right);
            }
        }        
        
        public void RepaintSnake()
        {
            foreach (var body in game.SnakeBodies)
            {
                MyCanvas.Children.Remove(body.Shape);
            }
            
            LinkedListNode<SnakeBody> part = game.SnakeBodies.First;
            while (part != null)
            {
                Canvas.SetLeft(part.Value.Shape, part.Value.Position.X);
                Canvas.SetTop(part.Value.Shape, part.Value.Position.Y);
                MyCanvas.Children.Add(part.Value.Shape);
                part = part.Next;
            }

            var egg = game.Egg;
            Canvas.SetLeft(egg.Shape, egg.Position.X);
            Canvas.SetTop(egg.Shape, egg.Position.Y);
        }
    }
}
