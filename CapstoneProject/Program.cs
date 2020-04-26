using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject
{
    // **************************************************
    //
    // Title: CapStoneProject 
    // Description: This is an application that makes trivia questions into a game programm.
    // Application Type: Console
    // Author: Pearl, Natham
    // Dated Created: 4/24/2020
    // Last Modified: 4/25/2020
    //
    // **************************************************



    class Program
    {


        static void Main(string[] args)
        {


            SetTheme();

            DisplayWelcomeScreen();
            DisplayMenuScreen();
            DisplayClosingScreen();
        }

        /// <summary>
        /// setup the console theme
        /// </summary>
        static void SetTheme()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// *****************************************************************
        /// *                     Main Menu                                 *
        /// *****************************************************************
        /// </summary>
        static void DisplayMenuScreen()
        {

            Console.CursorVisible = true;

            bool quitApplication = false;
            string menuChoice;
            do
            {
                DisplayScreenHeader("Main Screen");
                Console.WriteLine("\ta) Trivia Game ");
                Console.WriteLine("\tb) ");
                Console.WriteLine("\tc) ");
                Console.WriteLine("\td) ");
                Console.WriteLine("\te) ");
                Console.WriteLine("\tf) ");
                Console.WriteLine("\tq) Quit");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                switch (menuChoice)
                {
                    case "a":
                        DisplayGameMenuScreen();
                        break;

                    case "b":

                        break;


                    case "q":

                        quitApplication = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitApplication);
        }

        #region trivia Game

        /// <summary>
        /// *****************************************************************
        /// *                     Talent Show Menu                          *
        /// *****************************************************************
        /// </summary>
        /// 


        static void DisplayGameMenuScreen()
        {
            Console.CursorVisible = true;

            bool quitGameCatacoriesMenu = false;
            string menuChoice;
            double totalScore = 0;

            do
            {
                DisplayScreenHeader("\tTrivia Time");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Music");
                Console.WriteLine("\tb) Sports Legends");
                Console.WriteLine("\tc) Fun Facts");
                Console.WriteLine("\tq) Main Menu");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        DisplayMusic();
                        break;

                    case "b":
                        DisplaySportsLegends();
                        break;

                    case "c":
                        DisplayFunFacts();
                        break;

                    case "d":
                        DisplayTotalScore();
                        break;

                    case "q":
                        quitGameCatacoriesMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitGameCatacoriesMenu);
        }




        static void DisplayFunFacts()
        {

            Console.CursorVisible = true;

            bool quitFunFActsMenu = false;
            string menuChoice;

            do
            {
                DisplayScreenHeader("\tFun Facts");

                //
                // get user menu choice
                //
                Console.WriteLine("_________________");
                Console.WriteLine("\ta) 100        |");
                Console.WriteLine("________________|");
                Console.WriteLine("\tb) 200        |");
                Console.WriteLine("________________|");
                Console.WriteLine("\tc) 300        |");
                Console.WriteLine("________________|");
                Console.WriteLine("\td) 400        |");
                Console.WriteLine("________________|");
                Console.WriteLine("\te) 500        |");
                Console.WriteLine("________________| ");
                Console.WriteLine("\tq) Main Menu");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        DisplayFunFactsFor100();
                        break;

                    case "b":
                        DisplayFunFactsFor200();
                        break;

                    case "c":
                        DisplayFunFactsFor300();
                        break;

                    case "d":
                        DisplayFunFactsFor400();
                        break;

                    case "e":
                        DisplayFunFactsFor500();
                        break;

                    case "q":
                        quitFunFActsMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitFunFActsMenu);


        }

        static double DisplayFunFactsFor500()
        {
            string userResponse;
            List<int> Score = new List<int>();
            do
            {
                Console.WriteLine("How long does it take the average person to fall asleep:");
                Console.WriteLine("[ 12 minutes ]");
                Console.WriteLine("[ 20 minutes ]");
                Console.WriteLine("[ 7 minutes ] ");
                Console.WriteLine("[ 25 minutes ] ");
                userResponse = Console.ReadLine();
                if (userResponse.ToLower() == "7 minutes")
                {
                    Score.Add(500);
                    Console.WriteLine("That Is the correct answer:");

                }
                else
                {
                    Console.WriteLine("Incorrect");
                }

            } while (true);

            DisplayContinuePrompt();

        }

        static void DisplayFunFactsFor400()
        {
            string userResponse;
            List<int> Score = new List<int>();
            do
            {
                Console.WriteLine("Which state could produce enough wheat in 1 year for the entire worlf for two weeks.");
                userResponse = Console.ReadLine();
                if (userResponse.ToLower() == "Kansas")
                {
                    Console.WriteLine("That Is the correct answer:");
                    Score.Add(400);
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }

            } while (true);

            DisplayContinuePrompt();

        }

        static void DisplayFunFactsFor300()
        {
            string userResponse;
            List<int> Score = new List<int>();
            do
            {
                Console.WriteLine("What two state do not observe daylight savings time.");
                userResponse = Console.ReadLine();
                if (userResponse.ToLower() == "Arizona and Hawaii")
                {
                    Console.WriteLine("That Is the correct answer:");
                    Score.Add(300);
                }
                else
                {
                    Console.WriteLine("That is the worng answer:");
                }

            } while (true);

            DisplayContinuePrompt();

        }

        static void DisplayFunFactsFor200()
        {
            string userResponse;
            List<int> Score = new List<int>();
            do
            {
                Console.WriteLine("Which Country soled Alaska to the United States for 2 cents per acre:");
                userResponse = Console.ReadLine();
                if (userResponse.ToLower() == "Russia")
                {
                    Console.WriteLine("That Is the correct answer:");
                    Score.Add(200);
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }

            } while (true);

            DisplayContinuePrompt();

        }

        static double DisplayFunFactsFor100()
        {
            string userResponse;
            List<int> Score = new List<int>();
            do
            {
                Console.WriteLine("What is the official launguage of the United States:");
                userResponse = Console.ReadLine();
                if (userResponse.ToLower() == "No Offical Launguage")
                {
                    Console.WriteLine("That Is the correct answer:");
                    Score.Add(100);
                }
                else
                {
                    Console.WriteLine("That is incorrect the corect answer is no offical launguage.");
                }

            } while (true);

            DisplayContinuePrompt();

        }



        static void DisplaySportsLegends()
        {
            Console.CursorVisible = true;

            bool quitSportsLegendsMenu = false;
            string menuChoice;

            do
            {
                DisplayScreenHeader("\tSports Legends");

                //
                // get user menu choice
                //
                Console.WriteLine("_________________");
                Console.WriteLine("\ta) 100        |");
                Console.WriteLine("________________|");
                Console.WriteLine("\tb) 200        |");
                Console.WriteLine("________________|");
                Console.WriteLine("\tc) 300        |");
                Console.WriteLine("________________|");
                Console.WriteLine("\td) 400        |");
                Console.WriteLine("________________|");
                Console.WriteLine("\te) 500        |");
                Console.WriteLine("________________| ");
                Console.WriteLine("\tq) Main Menu");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        DisplaySportsLegendsFor100();
                        break;

                    case "b":
                        DisplaySportsLegendsFor200();
                        break;

                    case "c":
                        DisplaySportsLegendsFor300();
                        break;

                    case "d":
                        DisplaySportsLegendsFor400();
                        break;

                    case "e":
                        DisplaySportsLegendsFor500();
                        break;

                    case "q":
                        quitSportsLegendsMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitSportsLegendsMenu);


        }

        static void DisplaySportsLegendsFor500()
        {
            string userResponse;
            List<int> Score = new List<int>();
            do
            {
                Console.WriteLine("Which NBA player has the most championships Rings:");
                userResponse = Console.ReadLine();
                if (userResponse.ToLower() == "Bill Russell")
                {
                    Console.WriteLine("That Is the correct answer:");
                    Score.Add(500);
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }

            } while (true);

            DisplayContinuePrompt();


        }

        static void DisplaySportsLegendsFor400()
        {
            string userResponse;
            List<int> Score = new List<int>();
            do
            {
                Console.WriteLine("Who is the Logo for the NBA based on: ");
                userResponse = Console.ReadLine();
                if (userResponse.ToLower() == "Jerry West")
                {
                    Console.WriteLine("That Is the correct answer:");
                    Score.Add(400);
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }

            } while (true);

            DisplayContinuePrompt();


        }

        static void DisplaySportsLegendsFor300()
        {
            string userResponse;
            List<int> Score = new List<int>();
            do
            {
                Console.WriteLine("In what year was the first football game played:  ");
                userResponse = Console.ReadLine();
                if (userResponse.ToLower() == "1869")
                {
                    Console.WriteLine("That Is the correct answer:");
                    Score.Add(300);
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }

            } while (true);

            DisplayContinuePrompt();


        }

        static void DisplaySportsLegendsFor200()
        {
            string userResponse;
            List<int> Score = new List<int>();
            do
            {
                Console.WriteLine("What is the state sport of Alabama: ");
                userResponse = Console.ReadLine();
                if (userResponse.ToLower() == "Figure skating")
                {
                    Console.WriteLine("That Is the correct answer:");
                    Score.Add(200);
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }

            } while (true);

            DisplayContinuePrompt();


        }

        static void DisplaySportsLegendsFor100()
        {
            string userResponse;
            List<int> Score = new List<int>();
            do
            {
                Console.WriteLine("In the NBA which hall of famer was known as the [round bound on the rebound]:");
                userResponse = Console.ReadLine();
                if (userResponse.ToLower() == "Charles Barkley")
                {
                    Console.WriteLine("That Is the correct answer:");
                    Score.Add(100);
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }

            } while (true);

            DisplayContinuePrompt();


        }




        static void DisplayMusic()
        {
            Console.CursorVisible = true;

            bool quittMusicMenu = false;
            string menuChoice;

            do
            {
                DisplayScreenHeader("\tMusic");

                //
                // get user menu choice
                //
                Console.WriteLine("_________________");
                Console.WriteLine("\ta) 100        |");
                Console.WriteLine("________________|");
                Console.WriteLine("\tb) 200        |");
                Console.WriteLine("________________|");
                Console.WriteLine("\tc) 300        |");
                Console.WriteLine("________________|");
                Console.WriteLine("\td) 400        |");
                Console.WriteLine("________________|");
                Console.WriteLine("\te) 500        |");
                Console.WriteLine("________________| ");
                Console.WriteLine("\tq) Main Menu");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        DisplayMusicFor100();
                        break;

                    case "b":
                        DisplayMusicFor200();
                        break;

                    case "c":
                        DisplayMusicFor300();
                        break;

                    case "d":
                        DisplayMusicFor400();
                        break;

                    case "e":
                        DisplayMusicFor500();
                        break;

                    case "q":
                        quittMusicMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quittMusicMenu);


        }


        static void DisplayMusicFor100()
        {
            string userResponse;
            List<int> Score = new List<int>();
            do
            {
                Console.WriteLine("Do Musicians have shorter life spans that the general populations:");
                userResponse = Console.ReadLine();
                if (userResponse.ToLower() == "Yes")
                {
                    Console.WriteLine("That Is the correct answer:");
                    Score.Add(100);
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }

            } while (true);

            DisplayContinuePrompt();


        }

        static void DisplayMusicFor200()
        {
            string userResponse;
            List<int> Score = new List<int>();

            do
            {
                Console.WriteLine("Who hosted the largest ever free concet in 1993:");
                userResponse = Console.ReadLine();
                if (userResponse.ToLower() == "Rod Stewart")
                {
                    Console.WriteLine("That Is the correct answer:");
                    Score.Add(200);
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }

            } while (true);

            DisplayContinuePrompt();


        }

        static void DisplayMusicFor300()
        {
            string userResponse;
            List<int> Score = new List<int>();
            do
            {
                Console.WriteLine("What Navy uses Britney Spears songs to scare off pirates:");
                userResponse = Console.ReadLine();
                if (userResponse.ToLower() == "British")
                {
                    Console.WriteLine("That Is the correct answer:");
                    Score.Add(300);
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }

            } while (true);

            DisplayContinuePrompt();


        }

        static void DisplayMusicFor400()
        {
            string userResponse;
            List<int> Score = new List<int>();
            do
            {
                Console.WriteLine("Which country conducted a study that proves plants grow faster:");
                userResponse = Console.ReadLine();
                if (userResponse.ToLower() == "South Korea")
                {
                    Console.WriteLine("That Is the correct answer:");
                    Score.Add(400);
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }

            } while (true);

            DisplayContinuePrompt();


        }

        static void DisplayMusicFor500()
        {
            string userResponse;
            List<int> Score = new List<int>();
            do
            {
                Console.WriteLine("Which famous Band could read or write music:");
                userResponse = Console.ReadLine();
                if (userResponse.ToLower() == "The Beatles")
                {
                    Console.WriteLine("That Is the correct answer:");
                    Score.Add(500);
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }

            } while (true);

            DisplayContinuePrompt();


        }


        static void DisplayTotalScore()
        {
            List<int> Score = new List<int>();
            Console.WriteLine("_______________");
            Console.WriteLine(Score.Sum(x => Convert.ToInt32(x)));

            DisplayContinuePrompt();
        }


        #endregion

        #region USER INTERFACE

        /// <summary>
        /// *****************************************************************
        /// *                     Welcome Screen                            *
        /// *****************************************************************
        /// </summary>
        static void DisplayWelcomeScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tJeperdy");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// *****************************************************************
        /// *                     Closing Screen                            *
        /// *****************************************************************
        /// </summary>
        static void DisplayClosingScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tThank you for using Jeperdy show!");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display continue prompt
        /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("\tPress any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// display menu prompt
        /// </summary>
        static void DisplayMenuPrompt(string menuName)
        {
            Console.WriteLine();
            Console.WriteLine($"\tPress any key to return to the {menuName} Menu.");
            Console.ReadKey();
        }
        /// <summary>
        /// display screen header
        /// </summary>
        static void DisplayScreenHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerText);
            Console.WriteLine();
        }
        #endregion
    }
}
