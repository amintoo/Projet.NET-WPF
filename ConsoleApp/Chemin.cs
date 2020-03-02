using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    class Chemin
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
                    double x = Math.Abs(v1.XVille - v2.XVille);
                    double y = Math.Abs(v1.YVille - v2.YVille);
                    

                    double distance = Math.Sqrt(Math.Pow(v1.XVille - v2.XVille, 2) + Math.Pow(v1.YVille - v2.YVille, 2));
                    score += distance;
                }

                return Math.Round(score, 2);
            }

        }

        
        public IEnumerable<Ville> VilleCommencePar(char c)
        {
            IEnumerable<Ville> listeVilleLINQ = from v in this.lesVilles
                                                where v.NomVille.ToLower()[0] == c.ToString().ToLower()[0]
                                                select v;
            foreach (Ville v in listeVilleLINQ)
            {
                Console.WriteLine(v.NomVille);
            }
            return listeVilleLINQ;
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Ville v in lesVilles)
            {
                sb.Append(v.NomVille);
                sb.Append("-");
            }
            sb = sb.Remove(sb.Length - 1, 1);  
            return sb.ToString();
        }

    }
}
