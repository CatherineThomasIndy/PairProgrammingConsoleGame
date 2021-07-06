using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair_Programming_Console_Game_Repo
{
    public class BasicSelections
    {
        public void InvalidDirection()
        {
            Console.Clear();
            Console.WriteLine("Argh, that's not a direction!");
            Console.ReadKey();
        }

        public void InvalidSelection()
        {
            Console.Clear();
            Console.WriteLine("'Invalid selection!' *Squawk* 'Pick again!'");
            Console.ReadKey();
        }

        public void GetAllDirections()
        {
            Console.WriteLine("Select the direction you wish to travel, or look at the other options:\n" +
                "1. North\n" +
                "2. South\n" +
                "3. East\n" +
                "4. West\n" +
                "5. Other Options\n");
        }

        public void OtherOptions()
        {
            Console.WriteLine("What would you like to do?\n" +
                "1. Check inventory\n" +
                "2. Go back to main menu\n");
        }

        public void YouReturn()
        {
            Console.WriteLine("You sense danger and decide to turn back.\n");
        }

        public void Inventory()
        {
            Console.WriteLine("You currently have a compass, a knife, a cutlass, and a pistol.\n");
        }

        public void InventoryWithMap()
        {
            Console.WriteLine("You currently have a compass, a knife, a cutlass, and a pistol, as well as the map you grabbed in the cave.\n");
        }


        public void TravelWest()
        {
            Console.WriteLine("You decide to go westward.\n");
        }

        public void TravelNorth()
        {
            Console.WriteLine("You decide to go northward.\n");
        }

        public void TravelEast()
        {
            Console.WriteLine( "You decide to go eastward.\n");
        }

        public void TravelSouth()
        {
            Console.WriteLine("You decide to go southward.\n");
        }

        public void DangerousSituation()
        {
            Console.WriteLine("Your crew could not survive. Start Over?\n" +
                "1. Yes\n" +
                "2. No, quit the game\n");
        }
    }
}
