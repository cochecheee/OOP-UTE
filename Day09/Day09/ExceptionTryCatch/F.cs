using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTryCatch
{
    public class F
    {
        public static void PrintDirectory(string dirPath)
        {
            try
            {
                IEnumerable<string> enums = Directory.EnumerateDirectories(dirPath);

                List<string> dirs = new List<string>(enums);

                foreach (var dir in dirs)
                {
                    Console.WriteLine(dir);

                    PrintDirectory(dir);
                }
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("Can not access directory: " + dirPath);
                Console.WriteLine(e.Message);
            }
        }
    }
}
