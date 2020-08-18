using System;
using System.IO;

namespace FileStreamExample
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("e:\\b.txt", FileMode.OpenOrCreate);
            for (int i = 65; i<90; i++)
            {
                f.WriteByte((byte)i);
            }
            f.Close();
        }
    }
}
