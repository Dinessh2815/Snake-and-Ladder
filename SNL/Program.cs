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


          
            

        }
    }
}
