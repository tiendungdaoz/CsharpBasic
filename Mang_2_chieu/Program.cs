namespace Mang2Chieu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khai bao mang 2 chieu
            int[,] arrA;
            //Cap phat vung nho cho mang 2 chieu
            arrA = new int[2, 3];
            //Khoi tao gia tri cho mang 2 chieu
            int[,] arrB = new int[,] {
                                        { 1,2,3 },
                                        { 7,8,9 }
                                       };
            for (int i = 0; i < arrB.GetLength(0); i++)
            {
                for (int j = 0; j < arrB.GetLength(1); j++)
                {
                    Console.Write("{0,5}", arrB[i, j]);
                }
                Console.WriteLine();
            }

            //Vi du
            int soHang, soCot, tong = 0;
            bool kiemTra;
            bool kt1, kt2;
            do
            {
                Console.Write("Moi ban nhap so hang: ");
                kt1 = int.TryParse(Console.ReadLine(), out soHang);
                Console.Write("Moi ban nhap so cot: ");
                kt2 = int.TryParse(Console.ReadLine(), out soCot);
                kiemTra = kt1 && kt2;
                if (kiemTra == false)
                {
                    Console.WriteLine("Moi ban nhap lai so hang hoac cot!");
                }
            } while (kiemTra == false);

            int[,] arrC = new int[soHang, soCot];

            for (int i = 0; i < arrC.GetLength(0); i++)
            {
                for (int j = 0; j < arrC.GetLength(1); j++)
                {
                    Console.Write("arrC[{0},{1}] = ", i, j);
                    arrC[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Mang 2 chieu ban vua nhap la: ");
            for (int i = 0; i < arrC.GetLength(0); i++)
            {
                for (int j = 0; j < arrC.GetLength(1); j++)
                {
                    Console.Write("{0,5}", arrC[i, j]);
                    tong += arrC[i, j];
                }
                Console.WriteLine();
            }

            Console.WriteLine("Tong cac phan tu trong mang la: {0}", tong);

            tong = 0;
            for (int i = 0; i < arrC.GetLength(0); i++)
            {
                for (int j = 0; j < arrC.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        tong += arrC[i, j];
                    }
                }
            }
            Console.WriteLine("Tong cac phan tu nam tren duong cheo cua mang la: {0}", tong);
        }
    }
}
