using System;
using System.IO;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\Samples";
            

            Console.WriteLine("Enter Directory Name:");
            string userFolder = Console.ReadLine();
            string newDirectoryFullPath = $"{rootDirectory}\\{userFolder}";

            bool DirectoryExists = Directory.Exists(newDirectoryFullPath);
            if (DirectoryExists)
            {
                Console.WriteLine($"{userFolder} directory already exists.");
                Console.WriteLine("would you like to create a folder? Y/N");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("enter file Name:");
                    string userFile = Console.ReadLine() + ".txt";
                    string userFileFullPath = $@"{newDirectoryFullPath}\\{userFile}";
                    File.Create(userFileFullPath);
                }
                else
                {
                    Console.WriteLine("Take care!");
                }
            }
            else
            {
                Directory.CreateDirectory(newDirectoryFullPath);
                Console.WriteLine($"directory {userFolder} has been created.");

            }
        }
    }
}
