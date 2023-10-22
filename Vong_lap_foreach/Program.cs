//Su dung lop Stopwatch
using System.Diagnostics;

namespace VongLapForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch time = new Stopwatch();
            int sum = 0;
            int[] intArr = new int[] { 1, 2, 3, 5, 74, 364, 123, 3, 525, 643 };
            Console.WriteLine("Mang 1 chieu la: ");

            time.Start();
            //Duyet mang 1 chieu
            foreach (int item in intArr)
            {
                Console.Write("{0,6}", item);
                sum += item;
            }
            Console.WriteLine();
            Console.WriteLine("Tong so phan tu cua mang 1 chieu la: {0}", sum);

            //Duyet mang jagged
            int[][] arrA = new int[3][];

            //Khoi tao gia tri cho cac phan tu trong mang
            arrA[0] = new int[] { 1, 2, 3 };
            arrA[1] = new int[] { 3, 4, 5, 8, 9, 10 };
            arrA[2] = new int[] { 7, 8, 9, 20, 30 };

            foreach (int[] element in arrA)
            {
                foreach (int item in element)
                {
                    Console.Write("{0,5}", item);
                }
                Console.WriteLine();
            }
            time.Stop();
            Console.WriteLine("Thoi gian thuc hien doan code tren la: {0} second {1} milisecond", time.Elapsed.Seconds, time.Elapsed.Milliseconds);
        }
    }
}
