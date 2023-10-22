namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string Can, Chi;
            int namSinh;
            bool kiemTra;
            Console.Write("Moi ban nhap nam sinh cua minh: ");
            kiemTra = int.TryParse(Console.ReadLine(), out namSinh);

            while (kiemTra == false)
            {
                Console.Write("Moi ban nhap lai nam sinh cho dung: ");
                kiemTra = int.TryParse(Console.ReadLine(), out namSinh);
            }


            switch (namSinh % 10)
            {
                case 0:
                    {
                        Can = "Canh";
                        break;
                    }
                case 1:
                    {
                        Can = "Tan";
                        break;
                    }
                case 2:
                    {
                        Can = "Nham";
                        break;
                    }
                case 3:
                    {
                        Can = "Quy";
                        break;
                    }
                case 4:
                    {
                        Can = "Giap";
                        break;
                    }
                case 5:
                    {
                        Can = "At";
                        break;
                    }
                case 6:
                    {
                        Can = "Binh";
                        break;
                    }
                case 7:
                    {
                        Can = "Dinh";
                        break;
                    }
                case 8:
                    {
                        Can = "Mau";
                        break;
                    }
                default:
                    Can = "Ky";
                    break;
            }

            switch (namSinh % 12)
            {
                case 0:
                    {
                        Chi = "Than";
                        break;
                    }
                case 1:
                    {
                        Chi = "Dau";
                        break;
                    }
                case 2:
                    {
                        Chi = "Tuat";
                        break;
                    }
                case 3:
                    {
                        Chi = "Hoi";
                        break;
                    }
                case 4:
                    {
                        Chi = "Ty";
                        break;
                    }
                case 5:
                    {
                        Chi = "Suu";
                        break;
                    }
                case 6:
                    {
                        Chi = "Dan";
                        break;
                    }
                case 7:
                    {
                        Chi = "Mao";
                        break;
                    }
                case 8:
                    {
                        Chi = "Thin";
                        break;
                    }
                case 9:
                    {
                        Chi = "Ty";
                        break;
                    }
                case 10:
                    {
                        Chi = "Ngo";
                        break;
                    }
                default:
                    Chi = "Mui";
                    break;
            }

            Console.WriteLine("Nam sinh cua ban {0} la nam: {1} {2}", namSinh, Can, Chi);
        }
    }
}
