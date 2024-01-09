using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTryCatch
{
    public class I
    {
        String dirPath = "C:/test/CSharp";
        public void reD()
        {
            if (!Directory.Exists(dirPath))
            {
                Console.WriteLine(dirPath + " does not exist.");
                Console.Read();
                return;
            }

            Console.WriteLine(dirPath + " exist");
            Console.WriteLine("Please enter a new name for this directory:");

            string newDirname = Console.ReadLine();
            if(newDirname == String.Empty)
            {
                Console.WriteLine("You not enter new directory name. Cancel rename.");
                Console.Read();
                return;
            }

            if(Directory.Exists(newDirname))
            {
                Console.WriteLine("Cannot rename directory. New directory already exist");
                Console.Read();
                return;
            }

            DirectoryInfo parentInfo = Directory.GetParent(newDirname);
            Directory.CreateDirectory(parentInfo.FullName);
            Directory.Move(dirPath, newDirname);

            if(Directory.Exists(newDirname))
            {
                Console.WriteLine("The directory was renamed to " + newDirname);
            }
        }
    }
}
