using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTryCatch
{
    public class D
    {
        FileInfo testFile = new FileInfo("C:/test/test.txt");
        public void infoFile()
        {
            if(testFile.Exists)
            {
                Console.WriteLine(testFile.FullName + " exist");
                Console.WriteLine("Creation Time: " + testFile.CreationTime);
                Console.WriteLine("Last Write Time: " + testFile.LastWriteTime);
                Console.WriteLine("Directory Name: " + testFile.DirectoryName);
            }
            else
            {
                Console.WriteLine(testFile.FullName + "does not exist.");
            }
        }
    }
}
