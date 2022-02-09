using System;
using System.IO;

namespace quiz_60
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string path = @"C:\Path60\Textfile.txt";
            string empty = "";
            using (StreamReader show = new StreamReader(path))
            {
                Console.WriteLine($"{show.ReadToEnd()}\n");
                string[] array = File.ReadAllLines(path);
                foreach (var file in array)
                {
                    empty += file;
                }
            }
            char[] nadeyus = new char[] { '.' };
            string[] vs = empty.Split(nadeyus,StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < vs.Length; i++)
            {
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine(empty);
        }
    }
}
