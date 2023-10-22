namespace VongLapFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int chieuDai = 20, chieuRong = 10;
            for (int i = 0; i < chieuRong; i++)
            {
                for (int j = 0; j < chieuDai; j++)
                {
                    if (i == 0 || i == (chieuRong - 1) || j == 0 || (j == chieuDai - 1))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("@ ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
