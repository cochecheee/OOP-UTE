using System;

namespace RefAndOut02
{
    public class Change
    {
        public static void ChangeNames(out string FstEmp, out string SecndEmp)
        //static void ChangeNames(string FstEmp, string SecndEmp)
        
        {
            FstEmp = "Trang Le";
            SecndEmp = "Cuong Bui";

            Console.WriteLine($"Outside Main\n----\n{FstEmp}\n{SecndEmp}\n\n");
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            string FstEmp, SecndEmp;
            FstEmp = "Tuan Tran";
            SecndEmp = "Nghia Pham";

            Console.WriteLine($"Inside Main\n----\n{FstEmp}\n{SecndEmp}\n\n");
            Change.ChangeNames(out FstEmp, out SecndEmp);
            //ChangeNames(FstEmp, SecndEmp);

            Console.WriteLine($"Inside Main Again\n----\n{FstEmp}\n{SecndEmp}\n\n");

        }
    }
}