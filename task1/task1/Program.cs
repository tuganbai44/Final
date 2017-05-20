using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileFind
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Asus\Desktop\Final\Filestask1");
            for (int i = 0; i < dir.GetFileSystemInfos().Length; i++)
            {

                if (dir.GetFileSystemInfos()[i].Name.Contains("file"))
                {
                    Console.WriteLine(dir.GetFileSystemInfos()[i].Name);
                    cnt++;
                }
            }
            Console.ReadKey();
        }
    }
}
