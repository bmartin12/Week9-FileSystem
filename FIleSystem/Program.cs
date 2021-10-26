using System.IO;
using System;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples";

            Console.WriteLine("enter directory name name");
            string userFolder = Console.ReadLine();

            string newDirectoryFullPath = @$"{rootDirectory}\{userFolder}";
            bool directoryExists = Directory.Exists(newDirectoryFullPath);

            if (directoryExists)
            {
                Console.WriteLine($"{userFolder} directory already exists.");
                Console.WriteLine("Would you like to create a folder? y/n");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());
                if (userInput == 'y')
                {
                    Console.WriteLine("Enter file name");
                    string userfile = Console.ReadLine() + ".txt";
                    string userfileFullPath = $@"{newDirectoryFullPath}\{userfile}";
                    File.Create(userfileFullPath);
                }
                else
                {
                    Console.WriteLine("piss off");
                }
            }else
            {
                Directory.CreateDirectory(newDirectoryFullPath);
                Console.WriteLine($"Directory {userFolder} has been created");
            }
        }
    }
}
