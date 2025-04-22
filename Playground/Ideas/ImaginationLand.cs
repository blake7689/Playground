using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Playground.Ideas
{
    public class ImaginationLand
    {
        public static void ImageSort()
        {
            string[] fileEntries = Directory.GetFiles("Z:\\Pictures\\phone 1-16-2017");
            foreach (string path in fileEntries)
            {
                DateTime first = File.GetCreationTime(path);
                DateTime last = File.GetLastWriteTime(path);
                FileInfo info = new FileInfo(path);
                if (first != last)
                {
                    info.CreationTime = last;
                }

                Console.WriteLine($"File : {Path.GetFileName(path)}");
                Console.WriteLine($"Creation Date : {info.CreationTime}");

                //todo///////////////////////////
                //sort by file type and date
                //create folder structure
                //remove duplicates
                /////////////////////////////////
            }
        }
    }
}
