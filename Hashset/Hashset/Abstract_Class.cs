using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashset
{
    abstract class Abstract_Class
    {
        public abstract void abstract_method();

        public virtual void our_virtual()
        {
            Console.WriteLine("this is the virtual function present in the abstract class");
        }
    }
}
