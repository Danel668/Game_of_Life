namespace GameOfLife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var field = new int[Io.height, Io.width];
            int generation = 1;
            int speed = 700;
            
            Io.Input(field);
            Io.Draw(field, generation, speed);

           while(Logic.NextGeneration(field, ref generation))
           {
                Console.Clear();
                Io.Draw(field, generation, speed);
                Console.WriteLine();
                Thread.Sleep(speed);
           }
        }
    }
}