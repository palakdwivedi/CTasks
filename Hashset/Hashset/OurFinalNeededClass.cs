using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashset
{
    class OurFinalNeededClass : Abstract_Class, IFieldsToPlan
    {
        public override void abstract_method()
        {
            Console.WriteLine("we have defined logic for just a defined function in abstract class");
        }

        public void DefineMe()
        {
            Console.WriteLine("we can have multiple inheritances in case of interface");
        }

        public void NoBodyNeeded()
        {
            Console.WriteLine("Interfaces don't entertain logic in a function");
        }
    }
}
