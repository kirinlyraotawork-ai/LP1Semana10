using System;
using System.Collections.Generic;
using System.IO;

namespace FilePower
{
    public class Program
    {
        private static void Main(string[] args)
        {
             string fileName = args[0];
             Queue<string> queue = new();

        while (true)
            {
                string input = Console.ReadLine();

                if (input == "")
                    break;

                queue.Enqueue(input);

            }
        File.WriteAllLines( fileName, queue);
        }
        
    
    }

}
