using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Employee;

namespace ConAppXMLDserilaization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DeSerialized Example");
            XmlSerializer serializer = new XmlSerializer(typeof(Emp));
            using (TextReader reader = new StreamReader(@"C:\Users\moham\source\repos\Day21\Assignment24\Employee.xml"))
            {
                Emp deserializedPerson = (Emp)serializer.Deserialize(reader);
                Console.WriteLine($"ID:{deserializedPerson.ID}\nFirst NAME:{deserializedPerson.FName}\nLast Name:{deserializedPerson.LName}\nSalary:{deserializedPerson.Salary}");
               
            }
            Console.ReadKey();
        }
    }
}
