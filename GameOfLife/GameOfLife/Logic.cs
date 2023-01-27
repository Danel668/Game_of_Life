namespace GameOfLife
{
    internal static class Logic
    {
        public static int CountOfNeighbors(int[,] field, int corX, int corY)
        {
            int neighbors = 0;

            neighbors += field[(corX - 1 + Io.height) % Io.height, (corY - 1 + Io.width) % Io.width];
            neighbors += field[(corX - 1 + Io.height) % Io.height, corY];
            neighbors += field[(corX - 1 + Io.height) % Io.height, (corY + 1 + Io.width) % Io.width];
            neighbors += field[corX, (corY - 1 + Io.width) % Io.width];
            neighbors += field[corX, (corY + 1 + Io.width) % Io.width];
            neighbors += field[(corX + 1 + Io.height) % Io.height, (corY - 1 + Io.width) % Io.width];
            neighbors += field[(corX + 1 + Io.height) % Io.height, corY];
            neighbors += field[(corX + 1 + Io.height) % Io.height, (corY + 1 + Io.width) % Io.width];

            return neighbors;
        }

        public static bool NextGeneration(int[,] field, ref int generation)
        {
            var nextGen = new int[Io.height, Io.width];
            bool flag = false;

            for (int i = 0; i < Io.height; i++)
            {
                for (int j = 0; j < Io.width; j++)
                {
                    int neighbors = CountOfNeighbors(field, i, j);

                    if (field[i, j] == 0 && neighbors == 3)
                        nextGen[i, j] = 1;

                    if (field[i,j] == 1)
                    {
                        if ((neighbors == 3) || (neighbors == 2))
                            nextGen[i, j] = 1;
                        if ((neighbors < 2) || (neighbors > 3))
                            nextGen[i, j] = 0;
                    }
                }
            }

            for (int i = 0; i < Io.height; i++)
            {
                for (int j = 0; j < Io.width; j++)
                {
                    if (field[i, j] != nextGen[i, j])
                    {
                        field[i, j] = nextGen[i, j];
                        flag = true;
                    }
                }
            }
            generation++;

            return flag;
        } 
    }
}
