using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestFileSize
{
    class Program
    {
        static void Main(string[] args)
        {
            
            FileInfo f = new FileInfo(@"C:\Test\testOver500kFile.txt");

            long fileLength = f.Length;

            Console.WriteLine(fileLength.ToString());
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
