using System;
using System.Collections.Generic;
using System.Linq;

namespace IntCollections
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Insere os valores {1, 10, -30, 10, -5} em cada uma das coleção, pela ordem indicada
            List<int> lista = new() {1,10,-30,10,-5};
            Stack<int> stack = new();
            stack.Push(1);
            stack.Push(10);
            stack.Push(-30);
            stack.Push(10);
            stack.Push(-5);
           

            int[] array = {1,10,-30,10,-5};
            Queue<int> queue = new();
            HashSet<int> hashset = new();
            foreach (int i in array)
            {
                queue.Enqueue(i);
                hashset.Add(i);
                
            }
            Console.WriteLine($"List: {string.Join(", ", lista )}");
            Console.WriteLine($"Stack: {string.Join(", ", stack )}");
            Console.WriteLine($"Queue: {string.Join(", ", queue )}");
            Console.WriteLine($"HashSet: {string.Join(", ", hashset )}");
            
            
        }
    }
}
