using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace ArcadeLog
{
    public class Score : IComparable<Score>
    {
        // Variável de Instância Privada: points (int)
        // CÓDIGO AQUI
        private int points;


        // Propriedade Auto-Implementada Só de Leitura: Name (string)
        // CÓDIGO AQUI
        public string Name { get; }


        // Propriedade: Points (int), sempre entre 0 e 9999
        public int Points
        {
            get => points;
            set
            {
                if (value < 0)
                {
                    points = 0;
                }
                else if (value > 9999)
                {
                    points = 9999;
                }
                else
                {
                    points = value;
                }
            }
        }


        // Propriedade Só de Leitura: Medal (string)
        // CÓDIGO AQUI
        public string Medal 
        {
            get
            {
                if (points >= 7000)
                {
                    return "Gold";
                }
                else if (points >= 4000)
                {
                    return "Silver";
                }
                else
                {
                    return "Bronze";
                }
            }
        }


        // Construtor: aceita nome e pontuação
        // CÓDIGO AQ(UI
        public Score(string name, int points)
        {
            Name = name;
            Points = points;
        }

        public int CompareTo(Score other)
        {
            // CÓDIGO AQUI
            // ordenação decrescente ou descendente por pontuação
            /*if (other == null) return 1;
            return other.Score - this.Score;
            List<int> lista = new List<int>(){Score};
            lista.Sort();
            foreach (int i in lst) Console.Write ()
            return 0; // substitua o return*/
        
            return other.CompareTo(this);
        }
        
        /*public int CompareTo(Player other)
        {
            return other.Score.CompareTo(this.Score);
        }*/

        public override string ToString()
        {
            // CÓDIGO AQUI
            return $"{Name} {Medal}: {points}";
        }
    }
}
