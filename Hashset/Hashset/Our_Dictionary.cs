using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashset
{
    class Our_Dictionary
    {
        public static readonly Dictionary<int, string> ourDict =
                      new Dictionary<int, string>();

        public static void Add_Elements_Dictionary()
        {
            ourDict.Add(11, "you can rest");
            ourDict.Add(12, "you can have coffee");
            ourDict.Add(13, "you can chill as well");
        }
          
        public static void Print_Dict_Elements()
        {
            foreach (KeyValuePair<int, string> variable_to_assume in ourDict)
            {
                Console.WriteLine("{0} -> {1}",
                          variable_to_assume.Key, variable_to_assume.Value);
            }

        }
    
    }
}
