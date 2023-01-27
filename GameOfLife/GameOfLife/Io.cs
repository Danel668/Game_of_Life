namespace GameOfLife
{
    internal static class Io
    {
        public static int height = 25;
        public static int width = 80;

        public static void Input(int[,] field)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    field[i, j] = Convert.ToInt32(Console.Read()) - 48;
                }
                Console.Read();
                Console.Read();
            }
        }

        public static void Draw(int[,] field, int generation, int speed)
        {
            Console.WriteLine($"Number of generation: {generation}");
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (field[i, j] == 1)
                        Console.Write("#");
                    else
                        Console.Write(".");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Speed: {speed}");
        }
    }
}
