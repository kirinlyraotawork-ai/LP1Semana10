using System;
using System.Collections.Generic;
using System.Linq;

namespace MeuTeste
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();
            dict["first"] = 10;
            dict["second"] = 20;
            dict["third"] = 30;

            Console.WriteLine(string.Join("; ", dict.Select(entry => $"{entry.Key}: {entry.Value}")));
            // Output:
            // first: 10; second: 20; third: 30
        }
    }
}
