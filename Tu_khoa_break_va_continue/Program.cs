namespace BreakVaContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tu khoa Break
            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                {
                    break;
                }
                Console.Write("Gia tri hang thu {0}:", i);
                for (int j = 0; j < 5; j++)
                {
                    if (j == 3)
                    {
                        break;
                    }
                    Console.Write(" {0}", j);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //Tu khoa continue
            for (int i = 0; i < 10; i++)
            {
                if (i == 6)
                {
                    continue;
                }
                Console.Write("Gia tri hang thu {0}: ", i);
                for (int j = 0; j < 5; j++)
                {
                    if (j == 2)
                    {
                        continue;
                    }
                    Console.Write("{0} ", j);
                }
                Console.WriteLine();
            }

            //In ra cac so chan
            for (int i = 0; i < 20; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                Console.Write("{0} ", i);
            }
        }
    }
}
