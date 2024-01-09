using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTryCatch
{
    public class B
    {
        String dirPath = "C:/test/CSharp";
        public void di()
        {
            bool exist = Directory.Exists(dirPath);

            if (!exist)
            {
                Console.WriteLine(dirPath + " does not exist.");
                Console.WriteLine("Create ditrctory: " + dirPath);

                //Tạo thư mục
                Directory.CreateDirectory(dirPath);
            }

            Console.WriteLine("Directory Information " + dirPath);
            Console.WriteLine("Creation time: " + Directory.GetCreationTime(dirPath));
            Console.WriteLine("Last Write Time: " + Directory.GetLastWriteTime(dirPath));

            DirectoryInfo parentInfo = Directory.GetParent(dirPath);
            Console.WriteLine("Parent directory: " + parentInfo.FullName);
        }
    }
}
