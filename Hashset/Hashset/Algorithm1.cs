using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashset
{
    class Algorithm1 : IHashset
    {
        public static readonly HashSet<int> our_hash = new HashSet<int>() {12,45,66,77,23,44,78,55,90};
        public void PrintValues()
        {
            Console.WriteLine("our_hash consists of the following values");
            foreach (var i in our_hash)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
