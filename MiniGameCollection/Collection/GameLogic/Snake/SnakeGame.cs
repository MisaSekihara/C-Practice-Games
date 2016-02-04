using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using Collection.Pages;
using Point = System.Drawing.Point;
using Rectangle = System.Windows.Shapes.Rectangle;

namespace Collection.GameLogic.Snake
{
    // ～>ﾟ ～～～～～～～～～　SNAKE GAME　～～～～～～～～～ ﾟ<～
    public class SnakeGame
    {
        private SnakePage page;
        public LinkedList<SnakeBody> SnakeBodies = new LinkedList<SnakeBody>();
        private Point lastTailPosition;
        public Egg Egg;

        public SnakeGame(SnakePage snakePage)
        {
            page = snakePage;
        }

        public void Init()
        {
            CreateEgg();
            CreateSnakeHead(100,100);
        }

        public void CreateSnakeHead(int x, int y)
        {
            var head = new SnakeBody
            {
                Shape = new Rectangle
                {
                    Stroke = new SolidColorBrush(Colors.GreenYellow),
                    Fill = new SolidColorBrush(Colors.GreenYellow),
                    Width = 20,
                    Height = 20
                },
                Position = new Point(x, y)
            };
            SnakeBodies.AddFirst(head);
            page.DrawSnake(head);
        }

        public void CreateEgg()
        {
            var random = new Random();
            int maxWidth = ((int)page.MyCanvas.Width);
            int maxHeight = ((int)page.MyCanvas.Height);

            var x = random.Next(maxWidth);
            while (x % 20 != 0)
            {
                x = random.Next(maxWidth);
            }

            var y = random.Next(maxHeight);
            while (y % 20 != 0)
            {
                y = random.Next(maxHeight);
            }
            Egg = new Egg
            { 
                Shape = new Ellipse
                {
                    Stroke = new SolidColorBrush(Colors.Cornsilk),
                    Fill = new SolidColorBrush(Colors.Cornsilk),
                    Width = 16,
                    Height = 20,
                }, 
                Position = new Point(x ,y)
            };
            page.DrawEgg();
        }

        public bool CanSnakeMove(Point direction)
        {
            var currentPosition = SnakeBodies.First.Value.Position;
            var expectedPosition = new Point(currentPosition.X + direction.X, currentPosition.Y + direction.Y);
            if ((expectedPosition.X >= page.MyCanvas.Width) || (expectedPosition.Y >= page.MyCanvas.Height) || (expectedPosition.X < 0) || (expectedPosition.Y < 0))
            {
                var player = new MediaPlayer(); 
                player.Open(new Uri("../../Sound/se_wall.wav", UriKind.RelativeOrAbsolute));
                player.Play();
                return false;
            }
            return true;
        }

        public void MoveSnake(Point direction)
        {
            LinkedListNode<SnakeBody> part = SnakeBodies.First;

            if (CanSnakeMove(direction))
            {
                lastTailPosition = SnakeBodies.Last.Value.Position;

                var track = new Point();
                while (part != null)
                {
                    if (part.Previous == null)  // Head
                    {
                        track = part.Value.Position;
                        part.Value.Position = new Point(part.Value.Position.X + direction.X, part.Value.Position.Y + direction.Y);
                    }
                    else // Body
                    {
                        var newTrack = part.Value.Position;
                        part.Value.Position = track;
                        track = newTrack;
                    }
                    part = part.Next;
                }
                page.RepaintSnake();

                var player = new MediaPlayer();
                player.Open(new Uri("../../Sound/se_snake.wav", UriKind.RelativeOrAbsolute));
                player.Play();
            }

            if (!GameOver())
            {
                EatEggAndGrow(direction);
            }            
        }


        public void EatEggAndGrow(Point direction)
        {
            if (SnakeBodies.First.Value.Position == Egg.Position)
            {
                // Add a new tail to the body
                var tail = new SnakeBody
                {
                    Shape = new Rectangle
                    {
                        Stroke = new SolidColorBrush(Colors.DarkGreen),
                        Fill = new SolidColorBrush(Colors.DarkGreen),
                        Width = 20,
                        Height = 20
                    },
                    Position = lastTailPosition
                };
                SnakeBodies.AddLast(tail);

                var player = new MediaPlayer();
                player.Open(new Uri("../../Sound/se_get.wav", UriKind.RelativeOrAbsolute));
                player.Play();

                page.RepaintSnake();

                page.MyCanvas.Children.Remove(Egg.Shape);
                DisplayScore();
                CreateEgg();
            }
        }

        public void DisplayScore()
        {
            var score = Convert.ToInt16(page.ScoreLabel.Content) + 1;
            page.ScoreLabel.Content = score;
        }

        public bool GameOver()
        {
            SnakeBody head = SnakeBodies.First.Value;
            if (SnakeBodies.Count > 2)
            {
                foreach (var body in SnakeBodies)
                {
                    if (head != body && head.Position == body.Position)  // Check if snake is about to bite itself
                    {
                        var player = new MediaPlayer();
                        player.Open(new Uri("../../Sound/se_no.wav", UriKind.RelativeOrAbsolute));
                        player.Play();

                        MessageBox.Show("Ouch! Game Over");
                        page.Timer.Stop();
                    }
                }
            }
            return false;
        }
    }
}
