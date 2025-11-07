namespace SNL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] board = new int[101];
            
            for(int i = 1; i <= 100; i++)
            {
                board[i] = i;
            }


            Dictionary<int, int> ladders = new Dictionary<int, int>
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

            Dictionary<int, int> snakes = new Dictionary<int, int>
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


            foreach (var ladder in ladders)
            {
                board[ladder.Key] = ladder.Value;
            }
            foreach (var snake in snakes)
            {
                board[snake.Key] = snake.Value;
            }
            int position = 0;
            
            Random random = new Random();
            int die = random.Next(1, 7);
            Console.WriteLine("Die rolled: " + die);
            

        }
    }
}
