using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTryCatch
{
    public class G
    {
        String filePath = "C:/test/test.txt";
        public void rn()
        {
            if(File.Exists(filePath))
            {
                Console.WriteLine(filePath + " exist");

                Console.WriteLine("Please enter a new name for this file: ");

                string newFilename = Console.ReadLine();

                if(newFilename != String.Empty)
                {
                    File.Move(filePath, newFilename);

                    if(File.Exists(newFilename))
                    {
                        Console.WriteLine("The file was renamed to " + newFilename);

                    }
                }
            }
            else
            {
                Console.WriteLine("Path " + filePath + " does not exist.");
            }
        }
    }
}
