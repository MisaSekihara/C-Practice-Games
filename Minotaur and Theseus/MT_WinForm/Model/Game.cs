using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using MT_WinForm.Forms;

namespace MT_WinForm.Model
{
    public class Game
    {
        public Tile[,] Map;
        public Minotaur Minotaur;
        public Theseus Theseus;
        public int X;
        public int Y;
        public int CurrentLevel;
        public FormGameScreen GameScreen;
        public string Key;
        public List<string> AsciiMap;
        public bool IsGameEnd = false;

        public Game(FormGameScreen gameScreen)
        {
            GameScreen = gameScreen;
        }

        public void LoadMapFromFiler(string[] asciiMap)
        {
            // Get map data from Filer
            string[] currentMap = asciiMap;
            CurrentLevel = DefaultLevel.SelectedLevel;

            // Calculate map width and height(x and y)
            List<int> countChar = currentMap.Select(t => t.Length).ToList();
            X = countChar.Max() / 4;
            Y = currentMap.Length / 2;

            // Initialise Map
            Map = new Tile[X, Y];
            for (int column = 0; column < X; column++)
            {
                for (int row = 0; row < Y; row++)
                {
                    Map[column, row] = new Tile(column, row);
                }
            }
            ConstructMapData(currentMap);
        }

        private void ConstructMapData(string[] currentMap)
        {
            var count = 0;
            for (int outerY = 0; outerY <= Y - 1; outerY++)
            {
                var firstSmallRow = SplitFirstRowByTiles(currentMap[count]);
                count++;
                var horizontal = 0;
                foreach (var cell in firstSmallRow)
                {
                    if (cell.Contains("___"))
                    {
                        Map[horizontal, outerY].FourWalls |= Walls.Up;
                    }
                    horizontal++;
                }

                var secondSmallRow = SplitSecondRowByTiles(currentMap[count]);
                count++;
                horizontal = 0;
                foreach (var cell in secondSmallRow)
                {
                    if (cell.Contains("| "))
                    {
                        Map[horizontal, outerY].FourWalls |= Walls.Left;
                    }
                    if (cell.Contains(" |"))
                    {
                        Map[horizontal, outerY].FourWalls |= Walls.Right;
                    }
                    if (cell.Contains("X"))
                    {
                        Map[horizontal, outerY].FourWalls |= Walls.Goal;
                    }
                    if (cell.Contains("M"))
                    {
                        Minotaur = new Minotaur(horizontal, outerY);
                    }
                    if (cell.Contains("T"))
                    {
                        Theseus = new Theseus(horizontal, outerY);
                    }
                    horizontal++;
                }
                
                if (outerY == Y - 1 && outerY > 0)    // if it's the last row
                {
                    var lastSmallRow = SplitFirstRowByTiles(currentMap[count]).ToList();
                    horizontal = 0;
                    foreach (var cell in lastSmallRow)
                    {
                        if (cell.Contains("___"))
                        {
                            Map[horizontal, outerY].FourWalls |= Walls.Down;
                        }
                        horizontal++;
                    }
                }
            }
        }

        private List<string> SplitFirstRowByTiles(string str)
        {
            List<string> splitString = new List<string>();
            for (int i = 0; i < str.Length - 1; i += 4)
            {
                splitString.Add(str.Substring(i, 5));
            }
            return splitString;
        }

        private List<string> SplitSecondRowByTiles(string str)
        {
            List<string> splitString = new List<string>();

            try
            {
                for (int i = 0; i < str.Length - 1; i += 4)
                {
                    if (i + 4 == str.Length - 1)
                    {
                        splitString.Add(str.Substring(i));
                        break;
                    }
                    splitString.Add(str.Substring(i, 4));
                }
            }
            catch (Exception)
            {
                throw new Exception("Invalid map data. Please select different file or fix the map. If it's a right map file, it might contain TAB or extra spaces.");
            }
            return splitString;
        }

        public void PrintMap()
        {
            AsciiMap = new List<string>();
            // Print top horizontal lines
            for (int vertical = 0; vertical <= Y-1; vertical++)
            {
                    string ascii = string.Empty;
                    for (int horizontal = 0; horizontal < X; horizontal++)
                    {
                        //if ((vertical == 0 && horizontal == 0) || (horizontal < mapWidth))
                        if (horizontal == 0)
                        {
                            ascii += ".";
                        }
                        if (!(Map[horizontal, vertical].FourWalls.HasFlag(Walls.Up)))
                        {
                            ascii += "   .";
                        }
                        if (Map[horizontal, vertical].FourWalls.HasFlag(Walls.Up))
                        {
                            ascii += "___.";
                        }
                    }
                    AsciiMap.Add(ascii);
                    
                    // Print middle horizontal lines
                    ascii = string.Empty;
                    for (int horizontal = 0; horizontal < X; horizontal++)
                    {
                        if (!(Map[horizontal, vertical].FourWalls.HasFlag(Walls.Left) ||Map[horizontal, vertical].FourWalls.HasFlag(Walls.Right)))
                        {
                            ascii += "    ";
                        }
                        if (Map[horizontal, vertical].FourWalls.HasFlag(Walls.Left) && Map[horizontal, vertical].FourWalls.HasFlag(Walls.Right))
                        {
                            ascii += "|   |";
                        }
                        else if (Map[horizontal, vertical].FourWalls.HasFlag(Walls.Left))
                        {
                            ascii += "|   ";
                        }
                        else if (Map[horizontal, vertical].FourWalls.HasFlag(Walls.Right))
                        {
                            ascii += "    |";
                        }
                        if (horizontal == Theseus.Position.X && vertical == Theseus.Position.Y)
                        {
                            StringBuilder newAscii = new StringBuilder(ascii);
                            newAscii[ascii.Length - 2] = 'T';
                            ascii = newAscii.ToString();
                        }
                        if (horizontal == Minotaur.Position.X && vertical == Minotaur.Position.Y)
                        {
                            StringBuilder newAscii = new StringBuilder(ascii);
                            newAscii[ascii.Length - 2] = 'M';
                            ascii = newAscii.ToString();
                        }
                        if (Map[horizontal, vertical].FourWalls.HasFlag(Walls.Goal))
                        {
                            StringBuilder newAscii = new StringBuilder(ascii);
                            newAscii[ascii.Length - 2] = 'X';
                            ascii = newAscii.ToString();
                        }
                    }
                    AsciiMap.Add(ascii);

                    // Print the last horizontal line
                    if (vertical == Y - 1)
                    {
                        ascii = string.Empty;
                        for (int horizontal = 0; horizontal < X; horizontal++)
                        {
                            if (horizontal == 0)
                            {
                                ascii += ".";
                            }
                            if (Map[horizontal, vertical].FourWalls.HasFlag(Walls.Down))
                            {
                                ascii += "___.";
                            }
                            if (!(Map[horizontal, vertical].FourWalls.HasFlag(Walls.Up) || Map[horizontal, vertical].FourWalls.HasFlag(Walls.Down)))
                            {
                                ascii += "   .";
                            }
                        }
                        AsciiMap.Add(ascii);
                    }
            }
            GameScreen.LevelDisplay.Text = string.Empty;
            foreach (var line in AsciiMap)
            {
                GameScreen.LevelDisplay.AppendText(line);
                GameScreen.LevelDisplay.AppendText(Environment.NewLine);
            }
        }

        public void Update()
        {
            if (IsTheseusEscaped())
            {
                PrintMap();
                GameClear();
            }
            MoveMinotaur(); // 1st move
            MoveMinotaur(); // 2nd move

            if (IsTheseusDead())
            {
                PrintMap();
                GameOver();
            }
            PrintMap();
        }
        
        private void GameClear()
        {
            GameScreen.GameText.AppendText(Environment.NewLine);
            GameScreen.GameText.AppendText("Congraturation! Theseus escaped safely");
            GameScreen.GameText.AppendText(Environment.NewLine);
            GameScreen.GameText.AppendText("Click Next Map to play next level.");
            IsGameEnd = true;
        }

        private void GameOver()
        {
            GameScreen.GameText.AppendText(Environment.NewLine);
            GameScreen.GameText.AppendText("Game over! Minotaur killed Theseus...");
            GameScreen.GameText.AppendText(Environment.NewLine);
            GameScreen.GameText.AppendText("Click Restart to restart the level.");
            IsGameEnd = true;
        }

        public void Restart()
        {
            LoadMapFromFiler(DefaultLevel.SelectMap(CurrentLevel));
            Update();
            IsGameEnd = false;
        }

        public void NextMap()
        {
            CurrentLevel += 1;
            if (CurrentLevel > 10 || CurrentLevel <= 0)
            {
                CurrentLevel = 1;
                GameScreen.GameText.Text = string.Empty;
                GameScreen.GameText.AppendText("Level selection out of bound. Loading Level 1...");
            }
            LoadFile newFile = new LoadFile
            {
                FileName = CurrentLevel.ToString(),
                FileContent = DefaultLevel.SelectMap(CurrentLevel),
                FilePath = "DefaultLevel"
            };
            FileHistory.AllFiles.Add(newFile);
            LoadMapFromFiler(DefaultLevel.SelectMap(CurrentLevel));
            PrintMap();
            FileHistory.CurrentFile = newFile;
            IsGameEnd = false;
        }

        public void PreviousMap()
        {
            CurrentLevel -= 1;
            if (CurrentLevel > 10 || CurrentLevel <= 0)
            {
                CurrentLevel = 1;
                GameScreen.GameText.Text = string.Empty;
                GameScreen.GameText.AppendText("Level selection out of bound. Loading Level 1...");
            }
            LoadFile newFile = new LoadFile
            {
                FileName = CurrentLevel.ToString(),
                FileContent = DefaultLevel.SelectMap(CurrentLevel),
                FilePath = "DefaultLevel"
            };
            FileHistory.AllFiles.Add(newFile);
            LoadMapFromFiler(DefaultLevel.SelectMap(CurrentLevel));
            PrintMap();
            FileHistory.CurrentFile = newFile;
            IsGameEnd = false;
        }

        public bool IsTheseusDead()
        {
            if (Minotaur.Position == Theseus.Position)
            {
                return true;
            }
            return false;
        }

        public bool IsTheseusEscaped()
        {
            if (Map[Theseus.Position.X, Theseus.Position.Y].FourWalls.HasFlag(Walls.Goal))
            {
                return true;
            }
            return false;
        }

        public bool CanTheseusMove()
        {
            Point direction = GetKeyDirectionValue();
            if (direction == Direction.Skip)
            {
                return true;
            }
            if (!direction.IsEmpty)
            {
                return HasCharacterMovedSuccessfully(Theseus, direction);
            }
            return false;
        }

        public void MoveTheseus(string direction)
        {
            Key = direction;
            if (CanTheseusMove())
            {
                Update();
            }
            else
            {
                GameScreen.GameText.AppendText(Environment.NewLine);
                GameScreen.GameText.AppendText("Theseus can't move that way");
            }
        }

        public Point GetKeyDirectionValue()
        {
            if (Key == "Left")
            {
                return Direction.Left;
            }            
            if (Key == "Right")
            {
                return Direction.Right;
            }            
            if (Key == "Up")
            {
                return Direction.Up;
            }            
            if (Key == "Down")
            {
                return Direction.Down;
            }
            if (Key == "Space")
            {
                return Direction.Skip;
            }
            return new Point(); // return empty
        }

        public void MoveMinotaur()
        {
            bool hasMovedX = CanMinotaurMove(true, Theseus.Position.X, Minotaur.Position.X); // X coords
           
            if (!hasMovedX)
            {
                CanMinotaurMove(false, Theseus.Position.Y, Minotaur.Position.Y); // Y coords
            }
        }

        // Move Minotaur by referencing Theseus's position
        private bool CanMinotaurMove(bool isX, int theseusPos, int minotaurPos)
        {
            Point lessThanDirection = isX ? Direction.Left : Direction.Up;  // +1 coords
            Point greaterThanDirection = isX ? Direction.Right : Direction.Down;  // -1 coords

            if (theseusPos == minotaurPos)
            {
                return false;
            }

            if (theseusPos < minotaurPos)
            {
                return HasCharacterMovedSuccessfully(Minotaur, lessThanDirection);
            }
            return HasCharacterMovedSuccessfully(Minotaur, greaterThanDirection);
        }

        // Set the new position to the character. Return true if moved successfully.
        public bool HasCharacterMovedSuccessfully(Character character, Point direction)
        {
            if (IsDirectionWall(character, direction))
            {
                return false;
            }

            // Update position
            character.Position.X += direction.X;
            character.Position.Y += direction.Y;

            return true;
        }

        // Checks if the given character's moving direction is wall or not
        public bool IsDirectionWall(Character character, Point direction)
        {
            Point targetPoint = new Point(character.Position.X + direction.X, character.Position.Y + direction.Y);
            Point currentPoint = new Point(character.Position.X, character.Position.Y);

            // Validate if the target Tile actually exists (Not outside the map)
            if (targetPoint.X >= X || targetPoint.Y >= Y || targetPoint.X < 0 || targetPoint.Y < 0)
            {
                return true;
            }

            Tile targetTile = Map[targetPoint.X, targetPoint.Y];
            Tile currentTile = Map[currentPoint.X, currentPoint.Y];

            if (direction.Y < 0) // Up
            {
                if (targetTile.FourWalls.HasFlag(Walls.Down) || currentTile.FourWalls.HasFlag(Walls.Up))
                {
                    return true;
                }
            }
            else if (direction.Y > 0)   // Down
            {
                if (targetTile.FourWalls.HasFlag(Walls.Up) || currentTile.FourWalls.HasFlag(Walls.Down))
                {
                    return true;
                }
            }
            if (direction.X < 0) // Left
            {
                if (targetTile.FourWalls.HasFlag(Walls.Right) || currentTile.FourWalls.HasFlag(Walls.Left))
                {
                    return true;
                }
            }
            else if (direction.X > 0) // Right
            {
                if (targetTile.FourWalls.HasFlag(Walls.Left) || currentTile.FourWalls.HasFlag(Walls.Right))
                {
                    return true;
                }
            }
            return false;
        }
    }
}