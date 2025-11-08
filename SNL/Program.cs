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


            int position = 0;
            int diceCount = 0;
            Random random = new Random();
            while (position <= 100)
            {
                int die = random.Next(1, 7);
                Console.WriteLine("\n Die rolled: " + die);

                position += die;

                if(position > 100)
                {
                    position -= die;
                    Console.WriteLine($"Position is greater than 100 so moving back to the position: {position}");
                    continue;
                }
                else if(position == 100)
                {
                    Console.WriteLine($"Congratulations you have successfully reached the position {position} and won the game!!");
                    break;
                }

                for (int i = 0; i < ladders.GetLength(0); i++)
                {
                    if (position == ladders[i, 0])
                    {
                        position = ladders[i, 1];
                        Console.WriteLine($"Player found a Ladder!!! moving up to the positon: {position}");
                    }
                }
                for (int i = 0; i < snakes.GetLength(0); i++)
                {
                    if (position == snakes[i,0])
                    {
                        position = snakes[i, 1];
                        Console.WriteLine($"Player got caught with a snake :( going back to the positon: {position}");
                    }
                    
                }
                diceCount++;
                Console.WriteLine($"Player moved to the positon: {position}");
                

            }
            Console.WriteLine($"the dice has been played {diceCount} time");
        }
    }
}
