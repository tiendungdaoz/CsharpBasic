namespace MangNhieuChieu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khai bao va cap phat vung nho mang jagged
            int[][] arrA = new int[3][];

            //Khoi tao gia tri cho cac phan tu trong mang
            arrA[0] = new int[] { 1, 2, 3 };
            arrA[1] = new int[] { 3, 4, 5, 8, 9, 10 };
            arrA[2] = new int[] { 7, 8, 9, 20, 30 };

            //Duyet mang jagged
            for (int i = 0; i < arrA.Length; i++)
            {
                for (int j = 0; j < arrA[i].Length; j++)
                {
                    Console.Write("{0,5}", arrA[i][j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //Lop Array
            int[] arrB = new int[10] { 21, 4314, 213, 131, 123, 12312, 231, 12, 14, 51 };

            Array.Sort(arrB);
            Console.WriteLine("Mang sap xep theo tu tu tang dan: ");
            for (int i = 0; i < arrB.Length; i++)
            {
                Console.Write("{0,10}", arrB[i]);
            }

            Console.WriteLine();

            Array.Reverse(arrB);
            Console.WriteLine("Mang sap xep theo thu tu giam dan:");
            for (int i = 0; i < arrB.Length; i++)
            {
                Console.Write("{0,10}", arrB[i]);
                //}
            }
        }
}
