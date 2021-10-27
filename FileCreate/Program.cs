using System;
using System.IO;

namespace FileCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples";
            string userfile = "wishlist";
            string fullFilePath = $@"{rootDirectory}\{userfile}.txt";

            bool directoryExists = Directory.Exists(rootDirectory);
            bool fileExists = File.Exists(fullFilePath);

            if(directoryExists && fileExists)
            {
                Console.WriteLine($"{userfile} already exists in {rootDirectory}");
            }
            else if (!directoryExists)
            {
                Console.WriteLine($"{rootDirectory} does not exist.");
                Directory.CreateDirectory(rootDirectory);
                Console.WriteLine($"{rootDirectory} has been created.");
                File.Create(fullFilePath);
                Console.WriteLine($"{userfile}.txt has been created in {rootDirectory}");
            }
            else
            {
                File.Create(fullFilePath);
                Console.WriteLine($"{userfile}.txt has been created in {rootDirectory}");
            }

            
        }
    }
}
