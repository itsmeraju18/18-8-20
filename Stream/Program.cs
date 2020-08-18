using System;
using System.IO;

    public class FileStreamExample
    {
       public static void Main(string[] args)
        {
        FileStream f = new FileStream("e:\\b.txt", FileMode.OpenOrCreate); // creating the file stream
        f.WriteByte(65); // writing byte into stream
        f.Close(); // closing stream
        }
    }
 
