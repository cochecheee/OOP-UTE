using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTryCatch
{
    public class A
    {
        DirectoryInfo dirInfo = new DirectoryInfo(@"D:\HK1_2018\00P\00PC#\Teaching");

        // Ghi ra các thông tin
        public void showDI()
        {
            // Thông tin ngày tạo file
            Console.WriteLine("Creation time: " + dirInfo.CreationTime);

            // Thông tin thời điểm file được sửa đổi lần cuối
            Console.WriteLine("Last Write Time" + dirInfo.LastWriteTime);

            // Tên thư mục
            Console.WriteLine("Directory Name: " + dirInfo.FullName);

            // Một mảng các thư mục con
            DirectoryInfo[] childDirs = dirInfo.GetDirectories();

            // Mảng các file nằm trong thư mục
            FileInfo[] childFiles = dirInfo.GetFiles();

            foreach (DirectoryInfo childDir in childDirs)
            {
                Console.WriteLine(" - Directory: " + childDir.FullName);
            }

            foreach (FileInfo childFile in childFiles)
            {
                Console.WriteLine(" - File: " + childFile.FullName);
            }
        }
    }
}
