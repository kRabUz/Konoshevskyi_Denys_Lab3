using Lab3_2;
using System;
using System.Collections.Generic;
using System.IO;

namespace Lab_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary[] MyDictionary =
            {
                new Dictionary("key1", "value1"),
                new Dictionary("key2","value2"),
                new Dictionary("key3","value3"),
                new Dictionary("key4", "value1"),
                new Dictionary("key5", "value6"),
                new Dictionary("key6","value5"),
                new Dictionary("key7","value7"),
                new Dictionary("key1", "value4"),
                new Dictionary("key5", "value4"),
                new Dictionary("key3","value7")
            };
            var values = from dictionary in MyDictionary
                         group dictionary by dictionary.Value into d
                         select new
                         {
                             key = d.Key,
                             value = from p in d select p
                         };
            Console.WriteLine("Same values in pairs Key-Value:");
            foreach (var v in values)
            {
                int count = 0;
                foreach (var k in v.value)
                {
                    ++count;
                }
                if (count > 1)
                {
                    Console.WriteLine($"{v.key}:");
                    foreach (var k in v.value)
                    {
                        Console.WriteLine($"{k.Key} - {v.key}");
                    }
                    Console.WriteLine();
                }
            }

            var keys = from dictionary in MyDictionary
                       group dictionary by dictionary.Key into d
                       select new
                       { key = d.Key, value = from p in d select p };

            Console.WriteLine("Same keys in pairs Key-Value:");
            foreach (var k in keys)
            {
                int count = 0;
                foreach (var v in k.value)
                {
                    ++count;
                }
                if (count > 1)
                {
                    Console.WriteLine($"{k.key}:");
                    foreach (var v in k.value)
                    {
                        Console.WriteLine($"{k.key} - {v.Value}");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
