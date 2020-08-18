using System;
using System.IO;


namespace TextReaderExmample
{
    class Program
    {
        static void Main(string[] args)
        {
            using(TextReader tr = File.OpenText("e:\\f.txt"))
            {
                Console.WriteLine(tr.ReadLine());
            }

        }
    }
}
