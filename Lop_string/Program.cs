namespace LopString
{
    class Program
    {
        static void Main(string[] args)
        {
            string strA = "Dung ";
            string strB = "Van";
            string strC;

            string[] arrStrD;
            int doDai;
            doDai = strA.Length;

            //2 phuong thuc dung so sanh chuoi
            String.Compare(strA, strB);
            strA.CompareTo(strB);

            //Ghep 2 chuoi
            strC = String.Concat(strA, strB);
            Console.WriteLine(strC);

            //Vi tri xuat hien dau tien ky tu 'V' trong chuoi strC
            strC.IndexOf("V");

            //Chen them chuoi value tai vi tri mong muon
            strC = strA.Insert(5, "Sama");
            Console.WriteLine(strC);

            //Kiem tra chuoi co null hay khong
            String.IsNullOrEmpty(strC);

            //Vi tri xuat hien cuoi cung ki tu 'a' trong chuoi strC
            strC.LastIndexOf("a");

            //Xoa 3 ky tu tu vi tri 0(vi tri dau tien)
            strC = strC.Remove(0, 3);
            Console.WriteLine(strC);

            //Thay the ky tu trog chuoi
            strC = strC.Replace('a', 'g');
            Console.WriteLine(strC);

            //Cat chuoi ra thanh nhieu mang chuoi con
            strC = "Dao Tien Dung dz";
            arrStrD = strC.Split(' ', 'n');
            for (int i = 0; i < arrStrD.Length; i++)
            {
                Console.Write("{0}|", arrStrD[i]);
            }

            Console.WriteLine();
            // Substring
            strC = strC.Substring(0, 2);
            Console.WriteLine(strC);

            //Vi du chuan hoa nhap ten nguoi dung
            string fullName;
            string result = "";
            Console.Write("Moi ban nhap ho va ten cua minh len he thong: ");
            fullName = Console.ReadLine();

            fullName = fullName.Trim();

            while (fullName.IndexOf("  ") != -1)
            {
                fullName = fullName.Replace("  ", " ");
            }

            string[] subName = fullName.Split(' ');

            for (int i = 0; i < subName.Length; i++)
            {
                string fistChar = subName[i].Substring(0, 1);
                string otherChar = subName[i].Substring(1);
                subName[i] = fistChar.ToUpper() + otherChar.ToLower();
                result += subName[i] + " ";
            }
            Console.WriteLine("Ho va ten cua ban la: {0}", result);
        }
    }
}
