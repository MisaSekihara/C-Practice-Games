namespace MT_WinForm.Model
{
    public class Tile : Thing
    {
        public Walls FourWalls { get; set; }
        
        public Tile(int x, int y): base(x, y)
        {
            
        }
    }
}
