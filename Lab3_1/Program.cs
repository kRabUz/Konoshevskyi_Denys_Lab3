using Laba3_1;
using System;
using System.Collections.Generic;
using System.IO;

namespace Laba_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var objectlist = new List<MyList>
            {
                new MyList(1, 21455),
                new MyList(2, 68681),
                new MyList(3, 78249),
                new MyList(4, 68439),
                new MyList(5, 78211),
                new MyList(6, 95875),
                new MyList(7, 91980),
                new MyList(8, 49160),
                new MyList(9, 31529),
                new MyList(10, 22423),
            };
            Console.WriteLine("Object list");
            foreach (var p in objectlist)
                Console.WriteLine($"object {p.Number} - {p.Id}");

            Console.WriteLine("\nEnter Id");
            int FindId = 0;
            bool finder = true;
            try
            {
                FindId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"\nObjects with your Id: ");
                foreach (var p in objectlist)
                {
                    if (p.Id == FindId)
                    {
                        Console.WriteLine($"object {p.Number}");
                        finder = false;
                    }
                }
                if (finder)
                {
                    Console.WriteLine($"Objects with your Id don't exist");
                }
            }
            catch
            {
                Console.WriteLine("Check entered data");
            }
        }
    }
}
