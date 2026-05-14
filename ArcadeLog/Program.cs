using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;

namespace ArcadeLog
{
    public class Program
    {
        // Argumento:
        // args[0]: Caminho para o ficheiro (formato "nome pontuação" por linha)
        private static void Main(string[] args)
        {
            // Lê o Ficheiro e Cria os Scores
            using StreamReader sr = new (args[0]);
            /*while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                    break;
                sw.WriteLine(input);
            }*/



            List<Score> scores = new List<Score>();
            // CÓDIGO AQUI

            // Ordena os Scores
            scores.Sort();
//alallaaala
//&&&&&&&
            // CÓDIGO AQUI

            // Agrupa por Medalha e Imprime (Gold → Silver → Bronze)
            foreach (string medal in new[] { "Gold", "Silver", "Bronze" })
            {
                foreach (Score score in scores)
                {
                    if (score.Medal == medal)
                    {
                        Console.WriteLine($"{score.Name} [{score.Medal}]: {score.Points}");
                    }
                }
            }

          // else if (Score.points >= 4000)
          //     7 {
          //7/          return "Silver";
           //     }
            //    else
             //   {
            //        return "Bronze";
           //     }

         //   if (Score s in scores == )
          //  {
                
          //  }
          //  foreach (Score score in scores)
           // {
           //     Console.WriteLine($"{score.Name} [{score.Medal.value}]: {score.Points}");
           // }
            
             /*Program prog = new Program();
            // Start the program instance
            prog.Start();*/


            // Escreve a lista no ficheiro ranking.txt
            // CÓDIGO AQUI
            //using StreamWriter sw = new (args[0]);
            /*while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                    break;
                sw.WriteLine(input);
            }*/
            /*string fileName = args[0];
             Queue<string> queue = new();

        while (true)
            {
                string input = Console.ReadLine();

                if (input == "")
                    break;

                queue.Enqueue(input);

            }
        File.WriteAllLines( fileName, queue);
        }*/
            File.WriteAllLines("ranking.txt", scores.ConvertAll(s => $"{s.Name} [{s.Medal}]: {s.Points}"));
            Console.WriteLine("Ranking guardado em 'ranking.txt'.");

            // Ordena por Nome e Escreve em alpha.txt
            // CÓDIGO AQUI

            // Este programa mostra o seguinte no ecrã (exemplo: scores.txt com "Kronos 7400", "Luna 3800", "Rex 520", "Phantom 6100"):
            //
            // Kronos [Gold]: 7400
            // Phantom [Silver]: 6100
            // Luna [Bronze]: 3800
            // Rex [Bronze]: 520
            // Ranking guardado em 'ranking.txt'.
        }
    }
}
