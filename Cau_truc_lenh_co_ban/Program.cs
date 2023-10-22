using System.ComponentModel;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace CsharpCoban
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
        enum Color
        {
            RED,
            GREEN,
            BLUE
        }

        static void Main(string[] args)
        {
            #region BienVaKieuDuLieu
            //string strSoNguyen, ketQua;
            //int soNguyen;

            //strSoNguyen = Console.ReadLine();
            //soNguyen = Int32.Parse(strSoNguyen);
            //ketQua = (soNguyen % 2 == 0) ? "so chan" : "so le";
            //Console.WriteLine("{0} la {1}", soNguyen, ketQua);

            //string stringValue = "100";
            //int intValue = int.Parse(stringValue);
            //Console.WriteLine(intValue+10);
            #endregion

            #region EpKieuTrongC#
            //int result;
            //bool kiemTra;
            //string data1 = "10", data2 = "Kteam";

            //kiemTra = int.TryParse(data2, out result);
            //Console.WriteLine( (kiemTra == true) ? "Thanh Cong " : "ThatBai");
            //Console.WriteLine(result);

            //string data3 = "100.91";
            //double data4 = Convert.ToDouble(data3);
            //Console.WriteLine(data4);
            #endregion

            #region BieuThucDieuKienIfElse
            //string strA = "Dao Tien Dung";

            //if (strA == "Do Tien Dung")
            //{
            //    Console.WriteLine("Dao Tien Dung dz");
            //}
            //else
            //{
            //    Console.WriteLine("kakakakaka");
            //}

            //Console.WriteLine("Giai phuong trinh Ax+B = 0");

            //string strA, strB;
            //int A, B;
            //Console.WriteLine("Moi ban nhap 2 so A va B:");
            //Console.Write("A = ");
            //strA = Console.ReadLine();
            //Console.Write("B = ");
            //strB = Console.ReadLine();

            //if (int.TryParse(strA, out A) == false || int.TryParse(strB, out B) == false)
            //{
            //    Console.WriteLine("Du lieu ban nhap bi sai");
            //}else
            //{
            //    Console.WriteLine("Phuong trinh can tim nghiem: {0}x+{1} = 0", A, B);
            //    if (A == 0)
            //    {
            //        if (B == 0)
            //        {
            //            Console.WriteLine("Phuong trinh co vo so nghiem");
            //        }else
            //        {
            //            Console.WriteLine("Phuong trinh vo nghiem");
            //        }

            //    }else
            //    {
            //        Console.WriteLine("Phuong trinh co nghiem la: {0}", (double)-B / A);
            //    }
            //}

            #endregion

            #region SwitchCase
            //string Can, Chi;
            //int namSinh;
            //bool kiemTra;
            //Console.Write("Moi ban nhap nam sinh cua minh: ");
            //kiemTra = int.TryParse(Console.ReadLine(), out namSinh);

            //while(kiemTra == false)
            //{
            //    Console.Write("Moi ban nhap lai nam sinh cho dung: ");
            //    kiemTra = int.TryParse(Console.ReadLine(), out namSinh);
            //}


            //switch (namSinh%10)
            //{   
            //    case 0:
            //        {
            //            Can = "Canh";
            //            break;
            //        }
            //    case 1:
            //        {
            //            Can = "Tan";
            //            break;
            //        }
            //    case 2:
            //        {
            //            Can = "Nham";
            //            break;
            //        }
            //    case 3:
            //        {
            //            Can = "Quy";
            //            break;
            //        }
            //    case 4:
            //        {
            //            Can = "Giap";
            //            break;
            //        }
            //    case 5:
            //        {
            //            Can = "At";
            //            break;
            //        }
            //    case 6:
            //        {
            //            Can = "Binh";
            //            break;
            //        }
            //    case 7:
            //        {
            //            Can = "Dinh";
            //            break;
            //        }
            //    case 8:
            //        {
            //            Can = "Mau";
            //            break;
            //        }
            //    default:
            //        Can = "Ky";
            //        break;
            //}

            //switch (namSinh % 12)
            //{
            //    case 0:
            //        {
            //            Chi = "Than";
            //            break;
            //        }
            //    case 1:
            //        {
            //            Chi = "Dau";
            //            break;
            //        }
            //    case 2:
            //        {
            //            Chi = "Tuat";
            //            break;
            //        }
            //    case 3:
            //        {
            //            Chi = "Hoi";
            //            break;
            //        }
            //    case 4:
            //        {
            //            Chi = "Ty";
            //            break;
            //        }
            //    case 5:
            //        {
            //            Chi = "Suu";
            //            break;
            //        }
            //    case 6:
            //        {
            //            Chi = "Dan";
            //            break;
            //        }
            //    case 7:
            //        {
            //            Chi = "Mao";
            //            break;
            //        }
            //    case 8:
            //        {
            //            Chi = "Thin";
            //            break;
            //        }
            //    case 9:
            //        {
            //            Chi = "Ty";
            //            break;
            //        }
            //    case 10:
            //        {
            //            Chi = "Ngo";
            //            break;
            //        }
            //    default:
            //        Chi = "Mui";
            //        break;
            //}

            //Console.WriteLine("Nam sinh cua ban {0} la nam: {1} {2}", namSinh, Can, Chi);
            #endregion

            #region KieuDuLieuObjectVaTuKhoaVar

            ////Kieu du lieu Object
            //object obj = "Dao Tien Dung";
            //object obj1 = "Dao Tien Dung ";
            //Console.WriteLine(obj.Equals(obj1));

            ////Boxing va Unboxing
            //int value = 109;
            //object objectValue = value;  //Boxing

            //int newValue = (int)objectValue;    //Unboxing

            ////Tu khoa var
            //var number1 = 1;


            #endregion

            #region TuKhoaDynamic
            //dynamic stringValue = "Dao Tien Dung dz";
            //stringValue++;
            #endregion

            #region TuKhoaGoto
            //Vi du 1
            //int a = 2;
            //switch (a)
            //{
            //    case 1:
            //        {
            //            Console.WriteLine("Case 1");
            //            break;
            //        }
            //    case 2:
            //        {
            //            Console.WriteLine("Case 2");
            //            goto case 1;
            //        }
            //    default:
            //        {
            //            Console.WriteLine("TH Mac dinh");
            //            goto case 2;
            //        }
            //}

            //Vi du 2

            //    int a = 1;

            //    if (a == 2)
            //    {
            //        goto isa2;
            //    }
            //    Console.WriteLine("a == 1");
            //isa2:
            //    Console.WriteLine("a == 2");

            //Vi du 3
            //    string strValue = "Do Thi Van";
            //    int count = 0;

            //beginLoop:
            //    Console.WriteLine(strValue);
            //    count++;
            //    if (count <= 9)
            //    {
            //        goto beginLoop;
            //    }

            #endregion

            #region VongLapFor
            //int chieuDai = 20, chieuRong = 10;
            //for (int i = 0; i < chieuRong; i++)
            //{
            //    for (int j = 0; j < chieuDai; j++)
            //    {
            //        if (i == 0 || i == (chieuRong - 1) || j == 0 || (j == chieuDai - 1))
            //        {
            //            Console.ForegroundColor= ConsoleColor.Green;
            //            Console.Write("* ");
            //        } 
            //        else
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.Write("@ ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region VongLapWhile, do-while
            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i <10);

            #endregion

            #region TuKhoaBreakVaContinue
            ////Tu khoa Break
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 3)
            //    {
            //        break;
            //    }
            //    Console.Write("Gia tri hang thu {0}:", i);
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (j ==3)
            //        {
            //            break;
            //        }
            //        Console.Write(" {0}",j);
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            ////Tu khoa continue
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 6)
            //    {
            //        continue;
            //    }
            //    Console.Write("Gia tri hang thu {0}: ", i);
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (j == 2)
            //        {
            //            continue;
            //        }
            //        Console.Write("{0} ",j);
            //    }
            //    Console.WriteLine();
            //}

            ////In ra cac so chan
            //for (int i = 0; i < 20; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        continue;
            //    }
            //    Console.Write("{0} ", i);
            //}
            #endregion

            #region Ham
            //TinhTong(1, 2);

            #endregion

            #region BienToanCucVaCucBo
            //bool isTrue = true;
            //if (isTrue)
            //{
            //    int value = 5;
            //    Console.WriteLine(value);
            //}
            //else 
            //{
            //    int value = 5;
            //    Console.WriteLine(value - 9);
            //}
            #endregion

            #region TuKhoaRefVaOut
            //int value = 5;
            //Console.WriteLine("Gia tri cua value truoc khi tang: {0}", value);
            //IncreseValue(out value);
            //Console.WriteLine("Gia tri cua value sau khi tang: {0}", value);
            #endregion

            #region Mang1Chieu
            ////Khai bao mang 1 chieu
            //int[] arr1;
            ////Cap phat vung nho cho mang voi so phan tu toi da la 3
            //arr1 = new int[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("arr[{0}]: {1}", i, arr1[i]);
            //}

            ////Khai bao, cap phat vung nho va khoi tao gia tri cho mang arr2
            //string[] arr2 = new string[] { "Dung", "Van" };
            //Console.WriteLine(arr2[0]);
            //Console.WriteLine(arr2[1]);

            ////Co the khoi tao truc tiep ma khong can dung tu khoa new int[]
            //int[] intArr = { 1, 2, 3 };

            //string[] stringArr = new string[5];
            //for (int i = 0; i < stringArr.Length; i++)
            //{
            //    stringArr[i] = Console.ReadLine();
            //}

            //for (int i = 0; i < stringArr.Length; i++)
            //{
            //    Console.WriteLine(stringArr[i]);
            //}

            #endregion

            #region Mang2Chieu
            ////Khai bao mang 2 chieu
            //int[,] arrA;
            ////Cap phat vung nho cho mang 2 chieu
            //arrA = new int[2, 3];
            ////Khoi tao gia tri cho mang 2 chieu
            //int[,] arrB = new int[,] {
            //                            { 1,2,3 }, 
            //                            { 7,8,9 }
            //                           };
            //for (int i = 0; i < arrB.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arrB.GetLength(1); j++)
            //    {
            //        Console.Write("{0,5}", arrB[i,j]);
            //    }
            //    Console.WriteLine();
            //}

            ////Vi du
            //int soHang, soCot, tong=0;
            //bool kiemTra;
            //bool kt1, kt2;
            //do
            //{
            //    Console.Write("Moi ban nhap so hang: ");
            //    kt1 = int.TryParse(Console.ReadLine(), out soHang);
            //    Console.Write("Moi ban nhap so cot: ");
            //    kt2 = int.TryParse(Console.ReadLine(), out soCot);
            //    kiemTra = kt1&& kt2;
            //    if (kiemTra == false)
            //    {
            //        Console.WriteLine("Moi ban nhap lai so hang hoac cot!");
            //    }
            //}while(kiemTra == false);

            //int[,] arrC = new int[soHang,soCot];

            //for (int i = 0; i < arrC.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arrC.GetLength(1); j++)
            //    {
            //        Console.Write("arrC[{0},{1}] = ", i, j);
            //        arrC[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("Mang 2 chieu ban vua nhap la: ");
            //for (int i = 0; i < arrC.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arrC.GetLength(1); j++)
            //    {
            //        Console.Write("{0,5}", arrC[i, j]);
            //        tong += arrC[i, j];
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Tong cac phan tu trong mang la: {0}", tong);

            //tong = 0;
            //for (int i = 0; i < arrC.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arrC.GetLength(1); j++)
            //    {
            //        if (i == j)
            //        {
            //            tong += arrC[i, j];
            //        }
            //    }
            //}
            //Console.WriteLine("Tong cac phan tu nam tren duong cheo cua mang la: {0}", tong);
            #endregion

            #region MangNhieuChieu
            ////Khai bao va cap phat vung nho mang jagged
            //int[][] arrA = new int[3][];

            ////Khoi tao gia tri cho cac phan tu trong mang
            //arrA[0] = new int[] {1, 2, 3};
            //arrA[1] = new int[] {3, 4, 5, 8, 9, 10};
            //arrA[2] = new int[] {7, 8, 9, 20, 30};

            ////Duyet mang jagged
            //for (int i = 0; i < arrA.Length; i++)
            //{
            //    for (int j = 0; j < arrA[i].Length; j++)
            //    {
            //        Console.Write("{0,5}", arrA[i][j]);
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            ////Lop Array
            //int[] arrB = new int[10] { 21, 4314, 213, 131, 123, 12312, 231, 12, 14, 51 };

            //Array.Sort(arrB);
            //Console.WriteLine("Mang sap xep theo tu tu tang dan: ");
            //for (int i = 0; i < arrB.Length; i++)
            //{
            //    Console.Write("{0,10}", arrB[i]);
            //}

            //Console.WriteLine();

            //Array.Reverse(arrB);
            //Console.WriteLine("Mang sap xep theo thu tu giam dan:");
            //for (int i = 0; i < arrB.Length; i++)
            //{
            //    Console.Write("{0,10}", arrB[i]);
            ////}

            #endregion

            #region VongLapForeach
            //Stopwatch time = new Stopwatch();
            //int sum = 0;
            //int[] intArr = new int[] { 1, 2, 3, 5, 74, 364, 123, 3, 525, 643};
            //Console.WriteLine("Mang 1 chieu la: ");

            //time.Start();
            ////Duyet mang 1 chieu
            //foreach (int item in intArr)
            //{
            //    Console.Write("{0,6}", item);
            //    sum += item;
            //}
            //Console.WriteLine();
            //Console.WriteLine("Tong so phan tu cua mang 1 chieu la: {0}", sum);

            ////Duyet mang jagged
            //int[][] arrA = new int[3][];

            ////Khoi tao gia tri cho cac phan tu trong mang
            //arrA[0] = new int[] { 1, 2, 3 };
            //arrA[1] = new int[] { 3, 4, 5, 8, 9, 10 };
            //arrA[2] = new int[] { 7, 8, 9, 20, 30 };

            //foreach (int[] element in arrA)
            //{
            //    foreach (int item in element)
            //    {
            //        Console.Write("{0,5}", item);
            //    }
            //    Console.WriteLine();
            //}
            //time.Stop();
            //Console.WriteLine("Thoi gian thuc hien doan code tren la: {0} second {1} milisecond", time.Elapsed.Seconds, time.Elapsed.Milliseconds);
            #endregion

            #region LopStringTrongC#
            //string strA = "Dung ";
            //string strB = "Van";
            //string strC;

            //string[] arrStrD;
            //int doDai;
            //doDai = strA.Length;

            ////2 phuong thuc dung so sanh chuoi
            //String.Compare(strA, strB);
            //strA.CompareTo(strB);

            ////Ghep 2 chuoi
            //strC = String.Concat(strA, strB);
            //Console.WriteLine(strC);

            ////Vi tri xuat hien dau tien ky tu 'V' trong chuoi strC
            //strC.IndexOf("V");

            ////Chen them chuoi value tai vi tri mong muon
            //strC = strA.Insert(5, "Sama");
            //Console.WriteLine(strC);

            ////Kiem tra chuoi co null hay khong
            //String.IsNullOrEmpty(strC);

            ////Vi tri xuat hien cuoi cung ki tu 'a' trong chuoi strC
            //strC.LastIndexOf("a");

            ////Xoa 3 ky tu tu vi tri 0(vi tri dau tien)
            //strC = strC.Remove(0,3);
            //Console.WriteLine(strC);

            ////Thay the ky tu trog chuoi
            //strC = strC.Replace('a', 'g');
            //Console.WriteLine(strC);

            ////Cat chuoi ra thanh nhieu mang chuoi con
            //strC = "Dao Tien Dung dz";
            //arrStrD = strC.Split(' ','n');
            //for (int i = 0; i < arrStrD.Length; i++)
            //{
            //    Console.Write("{0}|", arrStrD[i]);
            //}

            //Console.WriteLine();
            //// Substring
            //strC = strC.Substring(0, 2);
            //Console.WriteLine(strC);

            ////Vi du chuan hoa nhap ten nguoi dung
            //string fullName;
            //string result = "";
            //Console.Write("Moi ban nhap ho va ten cua minh len he thong: ");
            //fullName = Console.ReadLine();

            //fullName = fullName.Trim();

            //while (fullName.IndexOf("  ") != -1)
            //{
            //    fullName = fullName.Replace("  ", " ");
            //}

            //string[] subName = fullName.Split(' ');

            //for (int i = 0; i < subName.Length; i++)
            //{
            //    string fistChar = subName[i].Substring(0, 1);
            //    string otherChar = subName[i].Substring(1);
            //    subName[i] = fistChar.ToUpper() + otherChar.ToLower();
            //    result += subName[i] + " "; 
            //}
            //Console.WriteLine("Ho va ten cua ban la: {0}", result);
            #endregion

            #region Struct
            //SinhVien[] sinhVien = new SinhVien[3];
            //Console.WriteLine("Moi ban nhap thong tin cac sinh vien:");
            //for (int i = 0; i < sinhVien.Length; i++)
            //{
            //    Console.WriteLine("Sinh vien {0}", i);
            //    nhapThongTinSinhVien(out sinhVien[i]);
            //}
            //Console.WriteLine();
            //for (int i = 0; i < sinhVien.Length; i++)
            //{
            //    xuatThongTin(sinhVien[i]);
            //}

            #endregion

            #region Enum
            //Console.WriteLine(Color.RED);

            //int choosen = 0;
            //if (choosen == Convert.ToInt32(Color.RED))   //Phai ep kieu 
            //{
            //    Console.WriteLine("Ban vua chon mau do.");
            //}

            #endregion

            #region XuLyNgoaiLe

            //try
            //{
            //    int[] arrInt = new int[3];
            //    arrInt[10] = 9;                 //Dong phat sinh loi
            //    Console.WriteLine(arrInt[10]);  //Dong lenh khong duoc thuc thi vi loi tren
            //}
            //catch (Exception ex1)
            //{
            //    //Khoi lenh thuc thi khi co loi
            //    Console.WriteLine("Da xay ra loi");

            //    Console.WriteLine(ex1.Message);
            //    Console.WriteLine(ex1.StackTrace);
            //    Console.WriteLine(ex1.Source);

            //}

            //Console.WriteLine();

            ////Xy ly ngoai le do chinh minh tao ra

            //try
            //{
            //    double z = Thuong2So(100, 0);
            //}
            //catch (Exception ex1)
            //{
            //    Console.WriteLine(ex1.Message);

            //}
            #endregion

            #region BieuThucChinhQuy

            //Match va MatchCollection
            Regex reg = new Regex(@"\d");
            Match result = reg.Match("-howkteam.com 10092016-");

            Console.WriteLine(result.ToString());
            Console.WriteLine();

            do
            {
                Console.WriteLine(result.ToString());
                result = result.NextMatch();
            } while (result != Match.Empty);
            Console.WriteLine();

            foreach (Match item in reg.Matches("-howkteam.com 10092016-"))
            {
                Console.WriteLine(item.ToString());
            }

            //Group va GroupCollection
            Regex reg1 = new Regex(@"(?<hours>\d+):(?<minutes>\d+):(?<seconds>\d+)");

            foreach (Match item in reg1.Matches("15/10/2023 8:30:45 142.2415.12.12") )
            {
                Console.WriteLine("Match: {0}", item.ToString());
                Console.WriteLine("Hours: {0}", item.Groups["hours"]);
                Console.WriteLine("Minutes: {0}", item.Groups["minutes"]);
                Console.WriteLine("Seconds: {0}", item.Groups["seconds"]);

            }

            #endregion
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

        static void TinhTong(int a, int b)
        {
            Console.WriteLine("Tong hai so nguyen la: {0}", a + b);
            PrintSomeThings("Do Thi Van", 20);
            return;
        }

        static void PrintSomeThings(string ten, int tuoi)
        {
            Console.WriteLine("This is {0}, {1} years old", ten, tuoi);
        }

        static void IncreseValue(out int value)
        {
            value = 0;
            value++;
        }
    }
}