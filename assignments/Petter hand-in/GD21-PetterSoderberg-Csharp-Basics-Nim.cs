using System;

namespace Nim
{
    class Program
    {
        static void Main(string[] args)
        {
            new Game().Run();
        }

        public class Game
        {
            const int START_NUMBER_OF_MATCHES = 24;
            const int MIN_DRAW_MATCHES = 1;
            const int MAX_DRAW_MATCHES = 3;

            int numberOfMatchesLeft = START_NUMBER_OF_MATCHES;
            Random randomGenerator = new Random();

            public void Run()
            {
                Console.WriteLine("Welcome to the game of Nim. In this game you can draw 1 to 3 matches. If you draw the last match, you lose.");
                Console.WriteLine();
                bool isMyTurn = true;
                while (true)
                {
                    int input = 0;
                    if (isMyTurn) {

                        do
                        { 
                            Console.WriteLine("How many matches do you want to draw?");
                            PrintNumberofMatches();
                            Console.Write("Enter number: ");
                            input = Int32.Parse(Console.ReadLine());

                        } while (input < MIN_DRAW_MATCHES || input > MAX_DRAW_MATCHES || input > numberOfMatchesLeft);
                    } else
                    {
                        int tempMaxDraw = MAX_DRAW_MATCHES;
                        if (numberOfMatchesLeft < MAX_DRAW_MATCHES)
                        {
                            tempMaxDraw = numberOfMatchesLeft;
                        }
                        if (numberOfMatchesLeft > 5 && numberOfMatchesLeft < 9)
                        {
                            input = numberOfMatchesLeft - 5;
                        }
                        else if (numberOfMatchesLeft < 5 && numberOfMatchesLeft > 1)
                        {
                            input = numberOfMatchesLeft - 1;
                        }
                        else 
                        {
                            input = randomGenerator.Next(MIN_DRAW_MATCHES, tempMaxDraw + 1);
                        }
                        Console.WriteLine();
                        Console.WriteLine("The AI draws " + input + " match(es).");
                        Console.WriteLine();
                    }

                    numberOfMatchesLeft = numberOfMatchesLeft - input;
                    if (numberOfMatchesLeft == 0)
                    {
                        Console.Write("Game over.");
                        if (isMyTurn)
                        {
                            Console.WriteLine(" The AI wins.");
                        }
                        else
                        {
                            Console.WriteLine(" You win.");
                        }
                        break;
                    }
                    isMyTurn = !isMyTurn;
                }
            }
            private void PrintNumberofMatches()
            {
                for (int i = 0; i < numberOfMatchesLeft; i++)
                {
                    Console.Write("|"); 
                }
                Console.WriteLine(" (" + numberOfMatchesLeft + ")");
                Console.WriteLine();
            }
        }
    }
}
