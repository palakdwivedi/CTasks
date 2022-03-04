using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashset
{
    public class ClassDetails
    {
        private static object object_palak = new object();
        public int Serial_Number { get; set; }
        public static List<Task> our_task = new List<Task>();
        public static void PrintingTasks()
        {
            for (int i = 1; i <= 10; i++)
            {
                // create task
                Task task = new Task(o => PrintingTask((ClassDetails)o), new ClassDetails() { Serial_Number = i });

                // adding in list
                our_task.Add(task);
            }
            our_task.ForEach(item => item.Start());
            Task.WaitAll(our_task.ToArray());

            Console.ReadLine();

        }

        // start
        private static void PrintingTask(ClassDetails o)
        {
            lock (object_palak)
            {
                if (o == null)
                {
                    return;
                }
                if (int.TryParse(Convert.ToString(o.Serial_Number), out int i))
                {
                    Task.Delay(TimeSpan.FromSeconds(1)).Wait();
                    Console.WriteLine($"{DateTime.Now} :: Task no :: {i}");
                }
            }
        }

        public static void PrintingTask(int o)
        {
            lock (object_palak)
            {
                if (int.TryParse(Convert.ToString(o), out int i))
                {
                    Task.Delay(TimeSpan.FromSeconds(1)).Wait();
                    Console.WriteLine($"{DateTime.Now} :: Task no :: {i}");
                }
            }
        }
    }
}
