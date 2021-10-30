using System;
using System.Collections.Generic;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyDictionary<int, string> siralama = new MyDictionary<int, string>();
            siralama.Add(1001, "Yasin");
            siralama.Add(1002, "Furkan");
            siralama.Add(1003, "Halil");
            Console.WriteLine(siralama.Length);
            siralama.Add(1004, "Barış");
            siralama.Add(1005, "Hasan");
            Console.WriteLine(siralama.Length);

        }

    }
}
