class Program
{
    static void Main(string[] agrs)
    {
        String FstEmp, SecndEmp;
        FstEmp = "Tuan Tran";
        SecndEmp = "Nghia Pham";
        System.Console.WriteLine($"Inside Main\n----\n{FstEmp}\n{SecndEmp}\n\n");
        //ChangeNames(FstEmp, SecndEmp);
        ChangeNames(ref FstEmp, ref SecndEmp);
        System.Console.WriteLine($"Inside Main Again\n----\n{FstEmp}\n{SecndEmp}\n\n");
        System.Console.ReadKey();
    }
    static void ChangeNames(string FstEmp,string SecndEmp)
    {
        FstEmp = "Trang Le";
        SecndEmp = "Cuong Bui";
        System.Console.WriteLine($"Outside Main\n----\n{FstEmp}\n{SecndEmp}\n\n");
    }

    static void ChangeNames(ref string FstEmp, ref string SecndEmp)
    {
        FstEmp = "Trang Le";
        SecndEmp = "Cuong Bui";
        System.Console.WriteLine($"Outside Main\n----\n{FstEmp}\n{SecndEmp}\n\n");
    }

}