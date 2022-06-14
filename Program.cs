using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace Практическая_16._1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader r = new StreamReader("t.txt");
            string a = r.ReadToEnd().ToLower();
            Console.WriteLine("Введите слово");
            string b = Console.ReadLine().ToLower();
            string[] c = a.Split();
            int colvo = 0;
            List<int> list = new List<int>();
            if (c.Contains<string>(b))
                for (int i = 0; i<c.Length; i++)              
                    if(c[i] == b)                   
                        list.Add(1);
            Console.WriteLine($"Были найдены {list.Sum()} вхождения (ий) поискового запроса {b}");
            r.Close();
        }
    }
}
