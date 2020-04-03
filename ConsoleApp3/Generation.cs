using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp
{
     public class Generation
    {
      
        private List<Ville> lesVilles;
        
        private List<Chemin> mapopulation;
       
        public List<Chemin> Get_population { get { return this.mapopulation; } }
        
        private List<Chemin> mageneration;
       
        private string nomgeneration;
       
        public String NameGeneration{get{return this.nomgeneration;}}
        
        private int PremierGeneration;
      
        public int FirstGeneration{get{return this.PremierGeneration; }set{this.PremierGeneration = value;}}
        
        public List<Chemin> Get_generation{get{return this.mageneration;}set{ this.mageneration = value; }}
        
        public Generation(int firstGeneration, List<Chemin> mesChemins, string nom_gen = null)
        {
            this.FirstGeneration = firstGeneration;
            this.mageneration = new List<Chemin>(mesChemins);
            this.mapopulation = new List<Chemin>();
            this.nomgeneration = nom_gen;
        }
        public Generation(int firstGeneration, List<Ville> lesVilles, string nom_gen = null)
        { 
            this.lesVilles = lesVilles; 
            this.FirstGeneration = firstGeneration;
            this.mageneration = new List<Chemin>();
            this.mapopulation = new List<Chemin>();
            this.nomgeneration = nom_gen;
            GeneratePremierGeneration();
        }
        public void GeneratePremierGeneration()
        {
            int combinaisons = FirstGeneration;
            while (combinaisons != 0)
            {
                Chemin chemin = new Chemin(lesVilles.OrderBy(a => Guid.NewGuid()).ToList());
                if (comparerChemin(chemin, mageneration) == 0)
                {
                    mageneration.Add(chemin);
                    combinaisons--;
                }

            }
        }
        public int comparerChemin(Chemin chemin, List<Chemin> maListe)
        {   var cnt = from c in maListe
                      where c.ToString() == chemin.ToString()
                      select c;
            return cnt.Count();
        }
        public void CrossOver(int nombreCross)
        {
            for (int index = 0; index < nombreCross; index++)
            {
                int taille = mageneration[0].MesVilles.Count;
                int partition1 = taille / 2;

                List<Ville> CrossVille = new List<Ville>();
                List<Chemin> CrossChemin = new List<Chemin>();
                List<Ville> portionDroite = new List<Ville>();

                Random r = new Random();
                int nombreChemin = 2;
                int randomIndex1 = r.Next(0, mageneration.Count);

                Chemin chemin1 = mageneration[randomIndex1];
                Chemin chemin2;
                CrossChemin.Add(chemin1);

                while (nombreChemin != 1)
                {
                    int randomIndex2 = r.Next(0, mageneration.Count);
                    if (randomIndex2 != randomIndex1)
                    {
                        chemin2 = mageneration[randomIndex2];
                        CrossChemin.Add(chemin2);
                        nombreChemin--;
                    }
                }

                for (int i = 0; i < partition1; i++)
                {
                    CrossVille.Add(CrossChemin[0].MesVilles[i]);
                    
                }

                for (int i = partition1; i < taille; i++)
                {
                    CrossVille.Add(CrossChemin[1].MesVilles[i]);
                    portionDroite.Add(CrossChemin[0].MesVilles[i]);
                }

                List<Ville> VillesDoublons = VerifierDouble(CrossVille);

                List<Ville> resultVilles = CheminSansDoublon(VillesDoublons, portionDroite, CrossVille);

                Chemin resultChemin = new Chemin(resultVilles);

                if (comparerChemin(resultChemin, mapopulation) == 0)
                {
                    mapopulation.Add(resultChemin);
                }

            }
        }

        public List<Ville> VerifierDouble(List<Ville> ListeATester)
            {
                List<Ville> maListe = new List<Ville>();
                foreach (Ville v in ListeATester)
                {
                    if (ComparerVille(v, ListeATester) == 2)
                    {
                        maListe.Add(v);
                    }
                }
                return maListe;
            }
        public List<Ville> CheminSansDoublon(List<Ville> listeDoublon, List<Ville> portionDroite, List<Ville> ListeComplete)
        {

            foreach (Ville v in listeDoublon)
            {
                int doublon = ListeComplete.LastIndexOf(v);
                foreach (Ville pd in portionDroite)
                {
                    if (ComparerVille(pd, ListeComplete) == 0)
                    {
                        ListeComplete[doublon] = pd;
                        break;
                    }
                }
            }

            return ListeComplete;
        }

        public int ComparerVille(Ville ville, List<Ville> maListe)
        {
            var cnt = from v in maListe
                      where v.ToString() == ville.ToString()
                      select v;
            return cnt.Count();
        }

        public void Elite(int nbrElite)
        {
            
            int nombreElite = nbrElite;
            var elite = from e in mageneration orderby e.Score select e;

            for (int i = 0; i < nombreElite; i++)
            {
                if (comparerChemin(elite.ElementAt(i), mapopulation) == 0)
                {
                    mapopulation.Add(elite.ElementAt(i));
                }
            }
        }

        public void Mutation(int nombreMutation)
        {
            int i = 0;
            while (i < nombreMutation)
            {
                Random r = new Random();
                int randomIndex = r.Next(0, mageneration.Count);
                Chemin chemin = mageneration[randomIndex];
                List<Ville> mesVilles = new List<Ville>(chemin.MesVilles);
                int nombreVille = mesVilles.Count;
                int indexVille1 = r.Next(0, nombreVille);
                int indexVille2 = r.Next(0, nombreVille);

                while (indexVille2 == indexVille1)
                {
                    indexVille2 = r.Next(nombreVille);
                }
                List<Ville> resultVilles = Swap(mesVilles, indexVille1, indexVille2);
                Chemin cheminFinal = new Chemin(resultVilles);
                if (comparerChemin(cheminFinal, mapopulation) == 0)
                {
                    mapopulation.Add(cheminFinal);
                    i++;
                }
            }
        }

        public List<Chemin> BestChemin()
        {
            List<Chemin> bestChemins = new List<Chemin>();
            var elite = from e in mapopulation orderby e.Score select e;
            for (int i = 0; i < FirstGeneration; i++)
            {
                bestChemins.Add(elite.ElementAt(i));
            }
            return bestChemins;
        }
        public Generation AlgoRun(int nombreCross, int nombreMutation, int nbrelite, string namegeneration)
        {
            CrossOver(nombreCross);
            Mutation(nombreMutation);
            Elite(nbrelite);
            Generation p = new Generation(FirstGeneration, BestChemin(), namegeneration);
            return p;
        }
        public List<Ville> Swap(List<Ville> list, int indexA, int indexB)
        {
            Ville tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
            return list;
        }
        public double GetTopScoreGeneration
        {
            get
            {
                IEnumerable<Chemin> listeScores = from v in this.mageneration orderby v.Score ascending select v;
                return Math.Round(listeScores.FirstOrDefault().Score, 2);

            }

        }
        public double GetMoyenScoreGeneration
        {
            get
            {
                double result = 0;
                foreach (Chemin c in this.mageneration)
                {
                    result += c.Score;
                }
                return Math.Round(result / this.mageneration.Count, 2);
            }
        }






    }


















    }

