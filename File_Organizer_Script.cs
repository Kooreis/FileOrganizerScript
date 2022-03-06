```CSharp
using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string sourceDirectory = args[0];
        string destinationDirectory = args[1];

        try
        {
            var txtFiles = Directory.EnumerateFiles(sourceDirectory, "*.txt");

            foreach (string currentFile in txtFiles)
            {
                string fileName = currentFile.Substring(sourceDirectory.Length + 1);
                Directory.Move(currentFile, Path.Combine(destinationDirectory, fileName));
            }

            txtFiles = Directory.EnumerateFiles(sourceDirectory, "*.txt");

            if (txtFiles.Any())
            {
                Console.WriteLine("Some files couldn't be moved.");
            }
            else
            {
                Console.WriteLine("All files have been moved.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.ReadKey();
    }
}
```