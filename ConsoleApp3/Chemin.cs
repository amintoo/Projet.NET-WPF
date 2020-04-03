using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    public class Chemin
    {
        private List<Ville> lesVilles;

        public Chemin(List<Ville> lesVilles)
        {
            this.lesVilles = lesVilles;
        }

        public List<Ville> MesVilles
        {
            get
            {
                return lesVilles;
            }
            set
            {
                lesVilles = value;
            }
        }

        public Chemin()
        {
        }

        public double Score
        {
            get
            {
                int taille = lesVilles.Count;
                double score = 0F;
                for (int i = 0; i < taille - 1; i++)
                {
                    Ville v1 = lesVilles[i];
                    Ville v2 = lesVilles[i + 1];
                    double x = Math.Abs(v1.X - v2.X);
                    double y = Math.Abs(v1.Y - v2.Y);
                    

                    double distance = Math.Sqrt(Math.Pow(v1.X - v2.X, 2) + Math.Pow(v1.Y - v2.Y, 2));
                    score += distance;
                }

                return Math.Round(score, 2);
            }

        }

        
        public IEnumerable<Ville> VilleCommencePar(char c)
        {
            IEnumerable<Ville> listeVilleLINQ = from v in this.lesVilles
                                                where v.Nomville.ToLower()[0] == c.ToString().ToLower()[0]
                                                select v;
            foreach (Ville v in listeVilleLINQ)
            {
                Console.WriteLine(v.Nomville);
            }
            return listeVilleLINQ;
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Ville v in lesVilles)
            {
                sb.Append(v.Nomville);
                sb.Append("-");
            }
            sb = sb.Remove(sb.Length - 1, 1);  
            return sb.ToString();
        }

    }
}
