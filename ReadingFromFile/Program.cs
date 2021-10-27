using System;
using System.IO;

namespace ReadingFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples";
            string userfile = "wishlist";
            string fullFilePath = $@"{rootDirectory}\{userfile}.txt";

            string[] dataFromFile = File.ReadAllLines(fullFilePath);

            foreach(string line in dataFromFile)
            {
                Console.WriteLine(line);
            }

            dataFromFile[0] = "pink unicorn";

            foreach (string line in dataFromFile)
            {
                Console.WriteLine(line);
            }
            File.WriteAllLines(fullFilePath, dataFromFile);
        }
    }
}
