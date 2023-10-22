namespace Ham
{
    class Program
    {
        static void Main(string[] args)
        {
            TinhTong(1, 2);
        }
        static void TinhTong(int a, int b)
        {
            Console.WriteLine("Tong hai so nguyen la: {0}", a + b);
            PrintSomeThings("Do Thi Van", 20);
            return;
        }

        static void PrintSomeThings(string ten, int tuoi)
        {
            Console.WriteLine("This is {0}, {1} years old", ten, tuoi);
        }

        static void IncreseValue(out int value)
        {
            value = 0;
            value++;
        }
    }
}
