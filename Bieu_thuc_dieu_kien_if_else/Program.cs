namespace BieuThucDieuKienIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            string strc = "Dao Tien Dung";

            if (strc == "Do Tien Dung")
            {
                Console.WriteLine("Dao Tien Dung dz");
            }
            else
            {
                Console.WriteLine("kakakakaka");
            }

            Console.WriteLine("Giai phuong trinh Ax+B = 0");

            string strA, strB;
            int A, B;
            Console.WriteLine("Moi ban nhap 2 so A va B:");
            Console.Write("A = ");
            strA = Console.ReadLine();
            Console.Write("B = ");
            strB = Console.ReadLine();

            if (int.TryParse(strA, out A) == false || int.TryParse(strB, out B) == false)
            {
                Console.WriteLine("Du lieu ban nhap bi sai");
            }
            else
            {
                Console.WriteLine("Phuong trinh can tim nghiem: {0}x+{1} = 0", A, B);
                if (A == 0)
                {
                    if (B == 0)
                    {
                        Console.WriteLine("Phuong trinh co vo so nghiem");
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh vo nghiem");
                    }

                }
                else
                {
                    Console.WriteLine("Phuong trinh co nghiem la: {0}", (double)-B / A);
                }
            }
        }
    }
}
