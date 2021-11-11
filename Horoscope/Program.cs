using System;
using System.IO;

namespace Horoscope
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your zodiac sign:");
            string userZodiacSign = Console.ReadLine();

            string output = GetLineFromFileData(userZodiacSign);

           
              static string[] ReadDataFromFile()
            {
                string directoryPath = @"C:\Users\opilane\samples";
                string fileName = "horoscope.txt";
                string fullPath = $@"{directoryPath}\{fileName}";

                string[] dataFromFile = File.ReadAllLines(fullPath);
                return dataFromFile;
            }

             static string GetLineFromFileData(string userInput)
            {
                string[] dataFromFile = ReadDataFromFile();
                string result = "";

                foreach (string line in dataFromFile)
                {
                    result = line;
                    break;
                }
                return result;
            }
        }
    }
}
