namespace Struct
{
    class Program
    {
        struct SinhVien
        {
            public string hoVaTen;
            public int maSV;
            public float diemToan;
            public float diemLy;
            public float diemHoa;
        }
        static void Main(string[] args)
        {
            SinhVien[] sinhVien = new SinhVien[3];
            Console.WriteLine("Moi ban nhap thong tin cac sinh vien:");
            for (int i = 0; i < sinhVien.Length; i++)
            {
                Console.WriteLine("Sinh vien {0}", i);
                nhapThongTinSinhVien(out sinhVien[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < sinhVien.Length; i++)
            {
                xuatThongTin(sinhVien[i]);
            }
        }
        static void nhapThongTinSinhVien(out SinhVien SV)
        {
            Console.Write("Ho va ten: ");
            SV.hoVaTen = Console.ReadLine();
            Console.Write("Ma SV: ");
            SV.maSV = int.Parse(Console.ReadLine());
            Console.Write("Diem Toan: ");
            SV.diemToan = float.Parse(Console.ReadLine());
            Console.Write("Diem Ly: ");
            SV.diemLy = float.Parse(Console.ReadLine());
            Console.Write("Diem Hoa: ");
            SV.diemHoa = float.Parse(Console.ReadLine());
        }

        static void xuatThongTin(SinhVien SV)
        {
            Console.WriteLine(SV.hoVaTen);
            Console.WriteLine(SV.maSV);
            Console.WriteLine(SV.diemToan);
            Console.WriteLine(SV.diemLy);
            Console.WriteLine(SV.diemLy);
            Console.WriteLine("Diem trung binh: {0}", diemTrungBinh(SV));
        }

        static float diemTrungBinh(SinhVien SV)
        {
            float diemTB = (SV.diemToan + SV.diemLy + SV.diemHoa) / 3;
            return diemTB;
        }
    }
}
