using System;
using System.IO;
class Program
{
    static void Main()
    {
        // Create and write to a file
        //File.WriteAllText(@"C:\MyFiles\example.txt", "Hello, World!");
        //File.WriteAllText("sample.txt", "Hello, File Handling!");
        // Read the file
        //string content = File.ReadAllText("sample.txt");
        // Console.WriteLine("File Content: " + content);
        Directory.CreateDirectory("MyFolder");
    }
}
