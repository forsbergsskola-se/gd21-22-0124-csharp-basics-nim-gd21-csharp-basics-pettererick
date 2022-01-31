namespace Nim
{
    class Program
    {
        private static int currentMatches = 24;
        private static int playerDraw = 0;
        private static int aiDraw = 25;
        private static bool gameOver;
        static Random random = new Random();
        
        static void Main()
        {
            WelcomeMessage();
            while (!gameOver)
            {
                CurrentMatches();
                PlayerDraw();
                RemoveMatches(playerDraw);
                playerDraw = 0;
                PlayerWinState();
                PlayAgain();
                CurrentMatches();
                AiDraw();
                RemoveMatches(aiDraw);
                aiDraw = 25;
                AiWinState();
                PlayAgain();
            }
        }

        static void WelcomeMessage()
        {
            Console.WriteLine("\n>> Welcome to Nim! Don't be the last one picking a Match <<");
        }

        static void CurrentMatches()
        {
            Console.WriteLine("\nCurrent Matches: ");
            for (int i = 0; i < currentMatches; i++)
            {
                Console.Write("|");
            }
            Console.WriteLine($" ({currentMatches})\n");
        }

        static void PlayerDraw()
        {
            while (playerDraw <= 0 || playerDraw > 3)
            {
                Console.WriteLine("How many matches do you want to draw?");
                playerDraw = Convert.ToInt32(Console.ReadLine());
                if (playerDraw <= 0 || playerDraw > 3)
                {
                    Console.WriteLine("\ninvalid draw, pick a number between 1 and 3\n");
                }
            }
        }

        static void AiDraw()
        {
            switch (currentMatches)
            {
                case 4:
                    aiDraw = 3;
                    break;
                case 3:
                    aiDraw = 2;
                    break;
                case 2:
                    aiDraw = 1;
                    break;
                case 7:
                    aiDraw = 2;
                    break;
                case 6:
                    aiDraw = 1;
                    break;
                case 8:
                    aiDraw = 3;
                    break;
                case 5:
                    aiDraw = 1;
                    break;
                default:
                    while (aiDraw > currentMatches)
                     {
                       aiDraw = random.Next(1, 4);
                     }
                     break;
            }
            Console.WriteLine($"\nThe AI draws {aiDraw} matches\n");
        }

        static void RemoveMatches(int draw)
        {
            currentMatches -= draw;
        }

        static void PlayerWinState()
        {
            if (currentMatches == 1)
            {
                CurrentMatches();
                Console.WriteLine("\n___YOU WON___\n");
                gameOver = true;
            }
            else if (currentMatches == 0)
            {
                Console.WriteLine("\n___YOU LOST___\n");
                gameOver = true;
            }
        }

        static void AiWinState()
        {
            if (currentMatches == 1)
            {
                CurrentMatches();
                Console.WriteLine("\n___YOU LOST___\n");
                gameOver = true;
            }
            else if (currentMatches == 0)
            {
                Console.WriteLine("\n___YOU WON___\n");
                gameOver = true;
            }
        }

        static void PlayAgain()
        {
            bool validAnswer = false;
            string answer;
            if (gameOver)
            {
                while (!validAnswer)
                {
                    Console.WriteLine("\nDo you want to play again? (yes/no)");
                    answer = Console.ReadLine();
                    switch (answer)
                    {
                        case "yes":
                            WelcomeMessage();
                            gameOver = false;
                            validAnswer = true;
                            currentMatches = 24;
                            break;
                        case "no":
                            currentMatches = 0;
                            validAnswer = true;
                            break;
                        default:
                            Console.WriteLine("Invalid Command\n");
                            break;
                    }
                }
            }
        }
    }
}
