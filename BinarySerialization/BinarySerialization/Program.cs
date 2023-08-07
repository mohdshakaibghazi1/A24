using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Employee;

namespace BinarySerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp emp = new Emp();
            Console.WriteLine("Employee Id\t\t"+emp.ID);
            Console.WriteLine("Employee Firt name\t"+emp.FName);
            Console.WriteLine("Employee Laqst name\t" + emp.LName);
            Console.WriteLine("Employee Salary\t\t" + emp.Salary);
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(@"C:\Users\moham\source\repos\Day21\Assignment24\employee.bin", FileMode.Create))
            {
                bf.Serialize(fs, emp);
            }
            Console.WriteLine("Created and Serialized ");
            Console.ReadKey();

        }
    }
}
