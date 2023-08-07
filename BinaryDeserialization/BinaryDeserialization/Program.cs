using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Employee;

namespace BinaryDeserialization
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            string filePath = @"C:\Users\moham\source\repos\Day21\Assignment24\employee.bin"; // Remove the extra spaces from the file path

            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                Emp emp = (Emp)formatter.Deserialize(fs);
                Console.WriteLine("Player ID: " + emp.ID);
                Console.WriteLine("Player Name: " + emp.LName);
                Console.WriteLine("Player Type: " + emp.FName);
                Console.WriteLine("Player Team: " + emp.Salary);
            }

            Console.ReadKey();
        }
    }
}
