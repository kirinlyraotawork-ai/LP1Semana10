using System;
using System.IO;

namespace FilePower2
{
    public class Program
    {
        private static void Main(string[] args)
        {
            using StreamWriter sw = new (args[0]);
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                    break;
                sw.WriteLine(input);
            }
            
        }
    }
}
