using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTryCatch
{
    public class C
    {
        public void showDriver()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives) { 
                Console.WriteLine(" ============================ ");

                Console.WriteLine("Drive {0}", drive.Name);

                if(drive.IsReady)
                {
                    Console.WriteLine(" Volume label: {0}",drive.VolumeLabel);
                    Console.WriteLine(" File system: {0}", drive.DriveFormat);
                    Console.WriteLine(" Available space to current user:{0,15} bytes", drive.AvailableFreeSpace);
                    Console.WriteLine(" Total available space:               {0,15} bytes",drive.TotalFreeSpace);
                    Console.WriteLine(" Total size of drive:                 {0,15} bytes", drive.TotalSize);
                }
            }

        }
    }
}
