using System;

namespace SNL
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] board = new int[101];

            for (int i = 1; i <= 100; i++)
            {
                board[i] = i;
            }

            int[,] ladders = new int[,] 
            {
                { 4, 14 },
                { 9, 31 },
                { 20, 38 },
                { 28, 84 },
                { 40, 59 },
                { 51, 67 },
                { 63, 81 },
                { 71, 91 }
            };

            int[,] snakes = new int[,]
            {
                { 17, 7 },
                { 54, 34 },
                { 62, 19 },
                { 64, 60 },
                { 87, 24 },
                { 93, 73 },
                { 95, 75 },
                { 99, 78 }
            };


            int[] playerPosition = new int[] {0, 0};
            int diceCount = 0;
            int currentPlayer = 0;
            Random random = new Random();
            while (playerPosition[0] != 100 && playerPosition[1] != 100 )
            {
                bool gotLadder = false;
                Console.WriteLine("\n===========================");
                Console.WriteLine($"\nits player {currentPlayer + 1}'s turn");
                int die = random.Next(1, 7);
                Console.WriteLine("\nDie rolled: " + die);

                playerPosition[currentPlayer] += die;

                if (playerPosition[currentPlayer] > 100)
                {
                    playerPosition[currentPlayer] -= die;
                    Console.WriteLine($"Position is greater than 100 so moving back to the position: {playerPosition[currentPlayer]}");
                    continue;
                }
                else if(playerPosition[currentPlayer] == 100)
                {
                    Console.WriteLine($"Congratulations player {currentPlayer} have successfully reached the position {playerPosition[currentPlayer]} first and won the game!!");
                    break;
                }

                for (int i = 0; i < ladders.GetLength(0); i++)
                {
                    if (playerPosition[currentPlayer] == ladders[i, 0])
                    {
                        playerPosition[currentPlayer] = ladders[i, 1];
                        Console.WriteLine($"Player found a Ladder!!! moving up to the positon: {playerPosition[currentPlayer]}");
                        gotLadder = true;
                    }
                }
                for (int i = 0; i < snakes.GetLength(0); i++)
                {
                    if (playerPosition[currentPlayer] == snakes[i,0])
                    {
                        playerPosition[currentPlayer] = snakes[i, 1];
                        Console.WriteLine($"Player got caught with a snake :( going back to the positon: {playerPosition[currentPlayer]}");
                    }
                    
                }
                diceCount++;
                Console.WriteLine($"Player moved to the positon: {playerPosition[currentPlayer]}");
                if (!gotLadder)
                {
                    currentPlayer = (currentPlayer == 0) ? 1 : 0;
                }
                else
                {
                    continue;
                }
            }   
            Console.WriteLine($"the dice has been played {diceCount} time");
        }
    }
}
