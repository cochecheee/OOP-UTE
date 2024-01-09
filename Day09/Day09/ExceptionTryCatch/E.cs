using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTryCatch
{
    public class E
    {
        string filePath = "C:/test/test.txt";
        public void ktFile()
        {
            if(File.Exists(filePath))
            {
                File.Delete(filePath);

                if(!File.Exists(filePath))
                {
                    Console.WriteLine("File deleted...");
                }
            }
            else
            {
                Console.WriteLine("File test.txt does not yet exist!");
            }
        }
    }
}
