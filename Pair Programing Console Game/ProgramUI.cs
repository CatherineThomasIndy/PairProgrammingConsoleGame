using System;
using Pair_Programming_Console_Game_Repo;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair_Programing_Console_Game
{
    public class ProgramUI
    {
        BasicSelections _basicRepo = new BasicSelections();
        StoryElements _storyRepo = new StoryElements();
        WrongSelections _wrongRepo = new WrongSelections();
        
        private bool _isRunning = true;
        bool hasMap = false;

        public void Start()
        {
            Console.WriteLine("The Pirate Game! ARGGGGGGGGG!");
            Console.ReadKey();
            Menu();
        }

        private void Menu()
        {
            while (_isRunning)
            {
                string userInput = GetMenuSelection();
                OpenMenuItem(userInput);
            }


        }
        private string GetMenuSelection()
        {
            Console.Clear();
            Console.WriteLine("What'll ye do, captain?\n" +
                            "Select Menu Item:\n" +
                            "1. Start A New Game\n" +
                            "2. Continue\n" +
                            "3. Extras / Cheats \n" +
                            "4. Credits \n" +
                            "5. Exit");

            string userInput = Console.ReadLine();
            return userInput;
        }

        private void OpenMenuItem(string userInput)
        {
            Console.Clear();

            switch (userInput)
            {
                case "1":
                    //Start the Game
                    DisplayStartPoint();
                    break;
                case "2":
                    //Continue From a Point, Multiple Swtich cases per save point in the content for this  
                    DisplaySavePoint();
                    break;
                case "3":
                    //Extras / Cheats / Display Map
                    DisplayMap();
                    break;
                case "4":
                    //Give Credits to Catie, Jared, and Rob (Probably just Catie and Rob)
                    DisplayCredit();
                    break;
                case "5":
                    //Console close.
                    QuitGame();
                    break;
                default:
                    Console.WriteLine("You couldn't read the map ya scallywag! Return to the selection menu and pick again!");
                    Console.ReadKey();
                    GetMenuSelection();
                    return;
            }

        }

        private void DisplayStartPoint()
        {
            Console.WriteLine("You wake as the captain of the Ship Ruby of the Sea, after a long night on the waves.\n" +
                "Your crew has been busy working through the night, as the ocean rocked the Ruby back and forth.");
            Console.ReadKey();
            Console.WriteLine("\nImmediately you feel that something is wrong. You can smell it in the salty air. In the movements of the Ruby.\n" +
                "In the squawking of your parrot, Charles.");
            Console.ReadKey();
            Console.WriteLine("\nStumbling out of bed, you graps for the nearest beverage, and call for your first mate; Sir Hooks Alot.");
            Console.ReadKey();
            Console.WriteLine("\nSir Hooks Alot, in his usual persnickety tone responds loudly 'Captain you rang?'");
            Console.ReadKey();
            Console.WriteLine("\n'Aye, where are we?' You respond in a tone representing your vast expirience at sea.");
            Console.ReadKey();
            Console.WriteLine("\n'Cap, whatever do you mean?' Sir Hooks Alot barks back.");
            Console.ReadKey();
            Console.WriteLine("\nYou say, 'Something is wrong. The sea and ship, they don't seem right!'");
            Console.ReadKey();
            Console.WriteLine("\n'*Squawk* Aint right, aint right.' Charles chirped.");
            Console.ReadKey();
            Console.WriteLine("\nYou collect yourself and command, 'Bring me the map, Sir Hooks Alot, and meet me at the helm!'");
            Console.ReadKey();
            Console.WriteLine("\n'*Squawk* Bring the captain the map, before you walk the plank!' Charles retorts.");
            Console.ReadKey();
            Console.Clear();
            ChapterOne();
        }

        private void ChapterOne()
        {
            Console.Clear();
            Console.WriteLine("Looking at the map and the stars, you realize that you are completely lost.\n" +
                "The only thing to do now is to pick a direction and sail.");
            _basicRepo.GetAllDirections();
            string input = Console.ReadLine();

            switch (input)
            {
                case "1": //n
                    _basicRepo.TravelNorth();
                    Console.ReadKey();
                    _storyRepo.RockyOutcrop();
                    Console.ReadKey();
                    DoYouContinue();
                    string userInput = Console.ReadLine();
                    if (userInput == "1")
                    {
                        _wrongRepo.RockyOutcropContinue();
                        Console.ReadKey();
                        _basicRepo.DangerousSituation();
                        string continueInput = Console.ReadLine();
                        if (continueInput == "1")
                        {
                            ChapterOne();
                        }
                        else QuitGame();
                    }
                    else if (userInput == "2")
                    {
                        _basicRepo.YouReturn();
                        Console.ReadKey();
                        ChapterOne();
                    }
                    else _basicRepo.InvalidSelection();
                    Console.ReadKey();
                    ChapterOne();
                    break;
                case "2": //s
                    _basicRepo.TravelSouth();
                    Console.ReadKey();
                    _storyRepo.GiantWhirlpool();
                    Console.ReadKey();
                    DoYouContinue();
                    string userInput2 = Console.ReadLine();
                    if (userInput2 == "1")
                    {
                        _wrongRepo.WhirlpoolContinue();
                        Console.ReadKey();
                        _basicRepo.DangerousSituation();
                        string continueInput = Console.ReadLine();
                        if (continueInput == "1")
                        {
                            ChapterOne();
                        }
                        else QuitGame();
                    }
                    else if (userInput2 == "2")
                    {
                        _basicRepo.YouReturn();
                        Console.ReadKey();
                        ChapterOne();
                    }
                    else _basicRepo.InvalidSelection();
                    Console.ReadKey();
                    ChapterOne();
                    break;
                case "3": //e
                    _basicRepo.TravelEast();
                    Console.ReadKey();
                    _storyRepo.MysteriousIsland();
                    string userInput3 = Console.ReadLine();
                    if (userInput3 == "2")
                    {
                        _basicRepo.YouReturn();
                        ChapterOne();
                    }
                    else if (userInput3 == "1")
                    {
                        ChapterTwo();
                    }
                    else _basicRepo.InvalidSelection();
                    Console.ReadKey();
                    ChapterOne();
                    break;
                case "4": //w
                    _basicRepo.TravelWest();
                    Console.ReadKey();
                    _storyRepo.Kraken();
                    Console.ReadKey();
                    DoYouContinue();
                    string userInput4 = Console.ReadLine();
                    if (userInput4 == "1")
                    {
                        _wrongRepo.KrakenContinue();
                        Console.ReadKey();
                        _basicRepo.DangerousSituation();
                        string continueInput = Console.ReadLine();
                        if (continueInput == "1")
                        {
                            ChapterOne();
                        }
                        else QuitGame();
                    }
                    else if (userInput4 == "2")
                    {
                        _basicRepo.YouReturn();
                        Console.ReadKey();
                        ChapterOne();
                    }
                    else _basicRepo.InvalidSelection();
                    Console.ReadKey();
                    ChapterOne();
                    break;
                case "5":
                    _basicRepo.OtherOptions();
                    break;
                default:
                    _basicRepo.InvalidDirection();
                    return;
            }
        }

        private void ChapterTwo()
        {
            Console.Clear();
            Console.WriteLine("Ignoring Charles' squawking, you arrive at the mysterious island and drop the anchor. \n" +
                "You and your crew find yourselves on the beach wondering where to go next.\n" +
                "To the north, you can see the entrance of a cave. To the south, you catch a glimpse of dilapidated ruins.\n" +
                "To the east is extremely dense jungle. To the west is your ship.");
            _basicRepo.GetAllDirections();
            string input = Console.ReadLine();

            switch (input)
            {
                case "1": //n
                    _basicRepo.TravelNorth();
                    Console.ReadKey();
                    _storyRepo.IslandCave();
                    Console.ReadKey();
                    DoYouContinue();
                    string userInput = Console.ReadLine();
                    if (userInput == "1")
                    {
                        _storyRepo.Skeleton();
                        _storyRepo.SkeletonExamine();
                        string examineInput = Console.ReadLine();
                        switch (examineInput)
                        {
                            case "1":
                                _storyRepo.Journal();
                                Console.ReadKey();
                                return;
                            case "2":
                                _storyRepo.Map();
                                Console.ReadKey();
                                hasMap = true;
                                return;
                            case "3":
                                _storyRepo.MapAndJournal();
                                Console.ReadKey();
                                hasMap = true;
                                return;
                            case "4":
                                Console.WriteLine("You decide to return to the beach.");
                                Console.ReadKey();
                                ChapterTwo();
                                break;
                            default:
                                _basicRepo.InvalidSelection();
                                ChapterTwo();
                                break;
                        }
                    }
                    else if (userInput == "2")
                    {
                        _basicRepo.YouReturn();
                        Console.ReadKey();
                        ChapterTwo();
                    }
                    else _basicRepo.InvalidSelection();
                    Console.ReadKey();
                    ChapterTwo();
                    break;
                case "2": //s
                    _basicRepo.TravelSouth();
                    Console.ReadKey();
                    _storyRepo.Ruins();
                    Console.ReadKey();
                    Console.WriteLine("You could investigate the ruins further if you wish, or return to the beach.\n" +
                        "1. Investigate\n" +
                        "2. Return to the beach\n");
                    string userInput2 = Console.ReadLine();
                    if (userInput2 == "1")
                    {
                        ChapterThree();
                    }
                    else if (userInput2 == "2")
                    {
                        Console.WriteLine("You decide to return to the beach.");
                        Console.ReadKey();
                        ChapterTwo();
                    }
                    else _basicRepo.InvalidSelection();
                    Console.ReadKey();
                    ChapterTwo();
                    break;
                case "3": //e
                    _basicRepo.TravelEast();
                    Console.ReadKey();
                    _storyRepo.DenseJungle();
                    string userInput3 = Console.ReadLine();
                    if (userInput3 == "1")
                    {
                        _wrongRepo.JungleContinue();
                        Console.ReadKey();
                        _basicRepo.DangerousSituation();
                        string continueInput = Console.ReadLine();
                        if (continueInput == "1")
                        {
                            ChapterTwo();
                        }
                        else QuitGame();
                    }
                    else if (userInput3 == "2")
                    {
                        _basicRepo.YouReturn();
                        ChapterTwo();
                    }
                    else _basicRepo.InvalidSelection();
                    Console.ReadKey();
                    ChapterTwo();
                    break;
                case "4": //w
                    _basicRepo.TravelWest();
                    Console.ReadKey();
                    if (hasMap == true)
                    {
                        _storyRepo.HomeWithoutJournal();
                    }
                    else
                    {
                        _storyRepo.IslandShipReturn();
                    }
                    break;
                case "5":
                    _basicRepo.OtherOptions();
                    break;
                default:
                    _basicRepo.InvalidDirection();
                    return;
            }
        }

        private void ChapterThree()
        {
            Console.Clear();
            Console.WriteLine("If all the walls were still standing, you would be in a room with three statues: one to the North, one to the East, and one to the South.\n" +
                "You can examine the statues further, or exit westward to go back to the beach.\n");
            _basicRepo.GetAllDirections();
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    _storyRepo.MermaidStatue();
                    if (hasMap == true)
                    {
                        _storyRepo.MermaidDoor();
                        Console.ReadKey();
                        DoYouContinue();
                        string continueInput = Console.ReadLine();
                        if (continueInput == "1")
                        {
                            ChapterFour();
                        }
                        else
                        {
                            _basicRepo.YouReturn();
                            ChapterThree();
                        }
                    }
                    else ChapterThree();
                    break;
                case "2":
                    _storyRepo.Skull();
                    Console.ReadKey();
                    DoYouContinue();
                    string continueInput2 = Console.ReadLine();
                    if(continueInput2 == "1")
                    {
                        _wrongRepo.SkullContinue();
                        Console.ReadKey();
                        _basicRepo.DangerousSituation();
                        string continueInput = Console.ReadLine();
                        if (continueInput == "1")
                        {
                            ChapterThree();
                        }
                        else QuitGame();
                    }
                    else if(continueInput2 == "2")
                    {
                        _basicRepo.YouReturn();
                        ChapterThree();
                    }
                    else
                    {
                        _basicRepo.InvalidSelection();
                        ChapterThree();
                    }
                    break;
                case "3":
                    _storyRepo.SnakeTreasure();
                    DoYouContinue();
                    string continueInput3 = Console.ReadLine();
                    if(continueInput3 == "1")
                    {
                        _wrongRepo.SnakeTreasureContinue();
                        Console.ReadKey();
                        _basicRepo.DangerousSituation();
                        string continueInput = Console.ReadLine();
                        if (continueInput == "1")
                        {
                            ChapterThree();
                        }
                        else QuitGame();
                    }
                    break;
                case "4":
                    _basicRepo.YouReturn();
                    ChapterTwo();
                    break;
                case "5":
                    _basicRepo.OtherOptions();
                    break;
                default:
                    _basicRepo.InvalidDirection();
                    return;
            }

        }

        private void ChapterFour()
        {
            Console.Clear();
            _storyRepo.UndergroundTemple();
            Console.WriteLine("1. Draw the dagger\n" +
                "2. Draw the sword\n" +
                "3. Drawe the pistol\n");
            string input = Console.ReadLine();
            if (input == "1")
            {
                _wrongRepo.DuelDaggerChoice();
                Console.ReadKey();
                _basicRepo.DangerousSituation();
                string continueInput = Console.ReadLine();
                if (continueInput == "1")
                {
                    ChapterFour();
                }
                else QuitGame();
            }
            else if (input == "2")
            {
                _wrongRepo.DuelSwordChoice();
                Console.ReadKey();
                _basicRepo.DangerousSituation();
                string continueInput = Console.ReadLine();
                if (continueInput == "1")
                {
                    ChapterFour();
                }
                else QuitGame();
            }
            else if (input == "3")
            {
                _storyRepo.Escape();
                Console.ReadKey();
                Console.WriteLine("THE END");
                Console.ReadKey();
                Menu();
            }
            else
            {
                _basicRepo.InvalidSelection();
                ChapterFour();
            }
        }
        
        private void DoYouContinue()
        {
            Console.WriteLine("1. Yes\n" +
                "2. No\n");
        }


        //Display Save Point
        private void DisplaySavePoint()
        {
            Console.WriteLine("Select the area from which you'd like to return:\n" +
                "1. The beach\n" +
                "2. The ruins\n" +
                "3. The temple");
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "1":
                    //return //save point island repo;
                break;
                case "2":
                    //return //save point at ruins;
                break;
                case "3":
                    //return //save point Sir Hooks Alot Betryal / Fight;
                break;
                default:
                    _basicRepo.InvalidSelection();
                    DisplaySavePoint();
                    break;
            }
        }

        //Display Map

        private void DisplayMap()
        {
            Console.WriteLine("Here are the right directions to find your treasure!\n" +
                "1. Travel East\n" +
                "2. Travel North\n" +
                "3. Read the journal\n" +
                "4. Take the map\n" +
                "5. Return to the beach\n" +
                "6. Travel South\n" +
                "7. Select the North statue\n" +
                "8. Draw your pistol\n" +
                "\n" +
                "Press any key to return to the menu selection.");
            Console.ReadKey();
            Menu();
        }

        //Display credits
        private void DisplayCredit()
        {
            Console.WriteLine("By Catie and Rob!");
            Console.ReadKey();
        }

        private void GetOtherOptions(string userInput)
        {
            _basicRepo.OtherOptions();

            switch (userInput)
            {
                case "1":
                    { if (hasMap == false)
                        {
                            _basicRepo.Inventory();
                        }
                        else _basicRepo.InventoryWithMap();
                    }
                    break;
                case "2": GetMenuSelection();
                    break;
                default:
                    _basicRepo.InvalidSelection();
                    break;
            }
        }

        private void QuitGame()
        {
            Console.WriteLine("Arrrrgh, see you next time, matey!");
            Console.ReadKey();
            _isRunning = false;
        }
    }
}

