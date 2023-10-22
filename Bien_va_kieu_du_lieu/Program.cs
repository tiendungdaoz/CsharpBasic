namespace BienVaKieuDuLieu
{
    class Program
    {
        static void Main(string[] args)
        {
            string strSoNguyen, ketQua;
            int soNguyen;

            strSoNguyen = Console.ReadLine();
            soNguyen = Int32.Parse(strSoNguyen);
            ketQua = (soNguyen % 2 == 0) ? "so chan" : "so le";
            Console.WriteLine("{0} la {1}", soNguyen, ketQua);

            string stringValue = "100";
            int intValue = int.Parse(stringValue);
            Console.WriteLine(intValue+10);
        }
    }
}
