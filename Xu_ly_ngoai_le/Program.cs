namespace XuLyNgoaiLe
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arrInt = new int[3];
                arrInt[10] = 9;                 //Dong phat sinh loi
                Console.WriteLine(arrInt[10]);  //Dong lenh khong duoc thuc thi vi loi tren
            }
            catch (Exception ex1)
            {
                //Khoi lenh thuc thi khi co loi
                Console.WriteLine("Da xay ra loi");

                Console.WriteLine(ex1.Message);
                Console.WriteLine(ex1.StackTrace);
                Console.WriteLine(ex1.Source);

            }

            Console.WriteLine();

            //Xy ly ngoai le do chinh minh tao ra

            try
            {
                double z = Thuong2So(100, 0);
            }
            catch (Exception ex1)
            {
                Console.WriteLine(ex1.Message);

            }
        }
        static double Thuong2So(double a, double b)
        {
            if (b == 0)
            {
                //Khoi tao ngoai le, tham so la noi dung thong bao loi
                Exception ex = new Exception("So chia khong duoc bang 0");

                //Phat sinh ngoai le
                throw ex;
            }
            return a / b;
        }
    }
}
