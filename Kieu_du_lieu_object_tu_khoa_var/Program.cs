namespace KieuDuLieuObjectVaTuKhoaVar
{ 
    class Program
    {
        static void Main(string[] args)
        {
            //Kieu du lieu Object
            object obj = "Dao Tien Dung";
            object obj1 = "Dao Tien Dung ";
            Console.WriteLine(obj.Equals(obj1));

            //Boxing va Unboxing
            int value = 109;
            object objectValue = value;  //Boxing

            int newValue = (int)objectValue;    //Unboxing

            //Tu khoa var
            var number1 = 1;
        }
    }
}
