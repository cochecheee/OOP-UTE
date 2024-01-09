using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTryCatch
{
    public class H
    {
        FileInfo fileInfo = new FileInfo("C:/test/test.txt");
        public void renamInfo()
        {
            if(!fileInfo.Exists)
            {
                Console.WriteLine(fileInfo.FullName + "does not exist");
                Console.Read();
                return;
            }
            Console.WriteLine(fileInfo.FullName + " exist");
            Console.WriteLine("Please enter a new name for this file: ");

            string newFilename = Console.ReadLine();
            if(newFilename == String.Empty)
            {
                Console.WriteLine("You not enter new file name. Cancel rename");
                Console.Read();
                return;
            }

            FileInfo newFileInfo = new FileInfo(newFilename);
            if(newFileInfo.Exists)
            {
                Console.WriteLine("Can not rename file to " + newFileInfo.FullName + ". File already exist.");
                Console.Read();
                return;


            }
            newFileInfo.Directory.Create();
            fileInfo.MoveTo(newFileInfo.FullName);

            newFileInfo.Refresh();
            if(newFileInfo.Exists)
            {
                Console.WriteLine("The file was renamed to " + newFileInfo.FullName);
            }
        }
    }
}
