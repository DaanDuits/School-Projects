using System;
using System.IO;

namespace FileDirOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\daand\OneDrive\Bureaublad\Ma\bewijzenmap\periode1.4\GD");
            foreach (var dir2 in dir.GetDirectories())
            {
                Console.WriteLine(dir2.Name);
                foreach(var dir3 in dir2.GetDirectories())
                {
                    Console.WriteLine(dir3.Name);
                }
                foreach (var file in dir2.GetFiles())
                {
                    Console.WriteLine(file.Name);
                }
            }
            foreach (var file in dir.GetFiles())
            {
                Console.WriteLine(file.Name);
            }
        }
    }
}
