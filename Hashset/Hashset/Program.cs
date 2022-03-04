using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashset
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Algorithm1 obj1 = new Algorithm1();
            Console.WriteLine("we are dealing with hashsets");
            obj1.PrintValues();
            Console.WriteLine("we are dealing with dictionary");
            Our_Dictionary.Add_Elements_Dictionary();
            Our_Dictionary.Print_Dict_Elements();
            OurFinalNeededClass obj2 = new OurFinalNeededClass();
            Console.WriteLine("We are implementing abstract classes and interface now");
            obj2.abstract_method();
            obj2.DefineMe();
            obj2.NoBodyNeeded();
            ClassDetails.PrintingTasks();
            Console.ReadLine();
        }
    }
}
