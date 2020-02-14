using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_UI
{
    public class Chemin
    {

        private List<Ville> Villes; //delacration de la liste

        public StringBuilder Path = new StringBuilder();


        // getteur & setteur
        public List<Ville> listeVille
        {
            get { return this.Villes; }
            set { this.Villes = value; }
        }

        // constructeur de chemin
        public Chemin(List<Ville> liste)
        {
            this.Villes = liste;
        }

        public Chemin()
        {

        }

        // conprend rien
        public double Score
        {
            get
            {
                return CalculScore();
            }

        }

        public double CalculScore()
        {
            double result = 0;
            // cas ou on a qu'une seule ville
            if (this.listeVille.Count == 1)
            {
                return 0;
            }

            for (int i = 0; i < this.listeVille.Count - 1; i++)
            {
                result += Distance(this.listeVille[i], this.listeVille[i + 1]);
            }

            return result;
        }

        static public double Sqr(double a)
        {
            return a * a;
        }
        static public double Distance(Ville v1, Ville v2)
        {
            double x = v1.X - v2.X;
            double y = v1.Y - v2.Y;
            double distance = Math.Sqrt(Sqr(x) + Sqr(y));
            return distance;

        }

        public List<Chemin> GetFirstGeneration(int nb, List<Ville> listville)
        {


            // déclaration liste vide
            List<Chemin> chemins = new List<Chemin>();
            int n = 0;
            do
            {
                // chemin result
                Chemin result = new Chemin();

                //duplication de ma liste en parametre
                List<Ville> duplicata = new List<Ville>(listville);

                for (int i = 0; i < listville.Count - 1; i++)
                {  
                    // instancier un random 
                    Random ran = new Random();
                    // randommer la liste d'une manière aléatoire 
                    int rang = ran.Next(duplicata.Count);

                    for (int j= 0; j< duplicata.Count; j++)
                    {

                    result.Path.Append(duplicata[rang].id);
                    // supprimer l'element que on a randommé 
                    duplicata.RemoveAt(rang);}
                }
                result.Path.Append(duplicata[0].id);

                chemins.Add(result);

                Console.WriteLine(result.Path);
                n++;
            } while (n < 10);
            return chemins;
        }
    }
}
