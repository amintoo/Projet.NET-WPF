using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_UI
{
    class Generation
    {

        private List<Ville> mesVilles;
        private int PremierGeneration;
        private List<Chemin> maGeneration;
        // constructeur 
        public Generation(int firstGeneration, List<Ville> mesVilles)
        {
            this.mesVilles = mesVilles;
            this.PremierGeneration = firstGeneration;
            this.maGeneration = new List<Chemin>();
        }
        public List<Chemin> getPremierGen()
        {
            int com = PremierGeneration;
            List<Chemin> chemins = new List<Chemin>();
            while (com != 0)
            {
                Chemin chemin = new Chemin(mesVilles.OrderBy(a => Guid.NewGuid()).ToList());

                var cnt = from c in chemins
                          where c.ToString() == chemin.ToString()
                          select c;
                if (cnt.Count() == 0)
                {
                    chemins.Add(chemin);
                    maGeneration.Add(chemin);
                    com--;
                }

            }
            return chemins;
        }
        public static List<Chemin> GenerateRandomChemins(List<Ville> villes, int cheminsNumber)
        {
            List<Chemin> result = new List<Chemin>();
            while (result.Count < cheminsNumber)
            {
                Chemin newChemin = new Chemin(villes.OrderBy(a => Guid.NewGuid()).ToList());
                if (!result.Contains(newChemin))
                {
                    result.Add(newChemin);
                }
            }
            return result;
        }



    }
}
