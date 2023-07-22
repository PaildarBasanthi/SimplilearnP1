using System;

using System.IO;


namespace ConminiProjectSimplilearn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\basan\OneDrive\Desktop\Student Data.txt";

            try
            {
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine(fileContent);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found. Please make sure the file exists at the specified path.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            Console.ReadLine();

        }
    }
}
