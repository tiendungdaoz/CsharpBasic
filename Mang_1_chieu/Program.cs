namespace Mang1Chieu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khai bao mang 1 chieu
            int[] arr1;
            //Cap phat vung nho cho mang voi so phan tu toi da la 3
            arr1 = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("arr[{0}]: {1}", i, arr1[i]);
            }

            //Khai bao, cap phat vung nho va khoi tao gia tri cho mang arr2
            string[] arr2 = new string[] { "Dung", "Van" };
            Console.WriteLine(arr2[0]);
            Console.WriteLine(arr2[1]);

            //Co the khoi tao truc tiep ma khong can dung tu khoa new int[]
            int[] intArr = { 1, 2, 3 };

            string[] stringArr = new string[5];
            for (int i = 0; i < stringArr.Length; i++)
            {
                stringArr[i] = Console.ReadLine();
            }

            for (int i = 0; i < stringArr.Length; i++)
            {
                Console.WriteLine(stringArr[i]);
            }
        }
    }
}
