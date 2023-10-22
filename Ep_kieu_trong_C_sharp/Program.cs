namespace EpKieuDuLieu
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            bool kiemTra;
            string data1 = "10", data2 = "Kteam";

            kiemTra = int.TryParse(data2, out result);
            Console.WriteLine((kiemTra == true) ? "Thanh Cong " : "ThatBai");
            Console.WriteLine(result);

            string data3 = "100.91";
            double data4 = Convert.ToDouble(data3);
            Console.WriteLine(data4);
        }
    }
}
