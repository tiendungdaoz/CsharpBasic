namespace Enum
{
    class Program
    {
        enum Color
        {
            RED,
            GREEN,
            BLUE
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Color.RED);

            int choosen = 0;
            if (choosen == Convert.ToInt32(Color.RED))   //Phai ep kieu 
            {
                Console.WriteLine("Ban vua chon mau do.");
            }
        }
    }
}
