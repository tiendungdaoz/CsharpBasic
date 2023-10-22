namespace TuKhoaGoTo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vi du 1
            int a = 2;
            switch (a)
            {
                case 1:
                    {
                        Console.WriteLine("Case 1");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Case 2");
                        goto case 1;
                    }
                default:
                    {
                        Console.WriteLine("TH Mac dinh");
                        goto case 2;
                    }
            }

           // Vi du 2

            int b = 1;

            if (b == 2)
            {
                goto isb2;
            }
            Console.WriteLine("b == 1");
        isb2:
            Console.WriteLine("b == 2");

            //Vi du 3
            string strValue = "Do Thi Van";
            int count = 0;

        beginLoop:
            Console.WriteLine(strValue);
            count++;
            if (count <= 9)
            {
                goto beginLoop;
            }
        }
    }
}
