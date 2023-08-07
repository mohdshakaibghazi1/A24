using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee;
using System.Xml.Serialization;
using System.IO;

namespace XmlSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp emp = new Emp();
            //Serialize The Object To Xml
            XmlSerializer serializer = new XmlSerializer(typeof(Emp));
            using (TextWriter writer = new StreamWriter(@"C:\Users\moham\source\repos\Day21\Assignment24\Employee.xml"))
            {
                serializer.Serialize(writer, emp);

            }
            Console.WriteLine("Serialization Done");
            Console.ReadKey();
        }
    }
}
