using System.Collections.Generic;
using System.Drawing;
using WebApplication1.Characters;

namespace WebApplication1
{
    public class GameSystem
    {
        private MainCharacter mainCharacter;
        private Item itemOne;
        private List<Tree> backgroundItems = new List<Tree>();

        public void Init()
        {
            mainCharacter = new MainCharacter(new Point(10,20), 40, 32, "pink", "Vera");
            itemOne = new Item(new Point(10, 20), 16, 16, "red", "Apple");

            // CreateBoundaryTrees(Tree);
        }

        public void CreateBoundaryTrees(Tree TreeType)
        {
//            var width = 
//            var xMax = this.canvas.width - usualSize;
//            var yMax = this.canvas.height - usualSize;
//
//            for (var i = 0; i <= xMax; i += usualSize)
//            {
//                for (var j = 0; j <= yMax; j += usualSize)
//                {
//                    if (i == 0 || j == 0 || i == xMax || j == yMax)
//                    {
//                        var tree = new ITree(i, j);
//                        this.stuffOnTheFloor.push(tree);
//                        console.log("tree added");
//                    }
//                }
//            }
        }

        public MainCharacter GetMainCharacter()
        {
            return mainCharacter;
        }

        public Item GetItem()
        {
            return itemOne;      
        }

        public void MovePlayer(string direction)
        {
            var currentPosition = mainCharacter.GetPosition();
            var newPosition = new Point();

            if (direction == "up")
            {
                newPosition = new Point(currentPosition.X, currentPosition.Y + 10);

            }            
            if (direction == "down")
            {
                
            }            
            if (direction == "left")
            {
                
            }            
            if (direction == "right")
            {
                
            }
        }

        public bool CanPlayerMove(Point position)
        {

            return false;
        }

        // migrate Move method here

        // add Move validation here

        // migrate Add Tree method here
            // add bridge method to pass Character position parameter to Client

        // add bridge method to pass Character position parameter to Client

        // modify position data from pixel to grid, and convert to point
    }
}