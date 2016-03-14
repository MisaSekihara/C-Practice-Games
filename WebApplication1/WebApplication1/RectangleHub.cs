using Microsoft.AspNet.SignalR;
using WebApplication1;
using WebApplication1.Characters;

namespace WebApplication1
{
    public class RectangleHub : Hub
    {
        public static GameSystem GameSystem;
        //public GameSystem GameSystem = new GameSystem();

        public void InitializeGame()
        {
            GameSystem = new GameSystem();
            GameSystem.Init();
        }

        public MainCharacter GetMainCharacter()
        {
            var temp = GameSystem.GetMainCharacter();
            return temp;
        }        
        
        public Item GetItem()
        {
            var temp = GameSystem.GetItem();
            return temp;
        }

        public void ChangeColour(string colour)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastColourChange(colour);
        }

        public void ChangePosition(int x, int y)
        {
            Clients.All.broadcastPositionChange(x, y);
        }

        public void PickUpItem(string name)
        {
            Clients.All.broadcastItemPickUp(name);
        }
    }
}