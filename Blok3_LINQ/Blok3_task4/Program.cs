using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace Blok3_task4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Adams");
            arrayList.Add("Arthur");
            arrayList.Add("Buchanan");
            IEnumerable<string> names = arrayList.Cast<string>().Where(n => n.Length < 7);
            foreach (string name in names)
                Console.WriteLine(name);
        }
    }
}
