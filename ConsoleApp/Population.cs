using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    class Population
    {
        private List<Generation> mesGenerations;

        public Population()
        {
            this.mesGenerations = new List<Generation>();
        }

        public List<Generation> GetGenerations
        {
            get
            {
                return this.mesGenerations;
            }
        }

        
        public void Play(int taillePopulation, int nombreIndividu, List<Ville> mesVilles, int nombreCross, int nombreMutation, int nbrElite)
        {
            int cntGeneration = 1;
            int pointArret = 0;
            Generation firstPopulation = new Generation(nombreIndividu, mesVilles, "Generation" + cntGeneration);
            firstPopulation.AlgoRun(nombreCross, nombreMutation, nbrElite, "Generation" + cntGeneration);
            this.mesGenerations.Add(firstPopulation);

            while (pointArret < taillePopulation - 1)
            {
                cntGeneration++;
                this.mesGenerations.Add(this.mesGenerations.Last().AlgoRun(nombreCross, nombreMutation, nbrElite, "G�n�ration" + cntGeneration));
                if (this.mesGenerations.Last().Get_generation[0].Score == mesGenerations[this.mesGenerations.Count - 1].Get_generation[0].Score)
                {
                    pointArret++;
                }
                else
                {
                    pointArret = 0;
                }
            }

            ResultAffichage();
        }

        public void ResultAffichage()
        {
            int i = 1;
            foreach (Generation po in this.mesGenerations)
            {
                Console.WriteLine("--------Generation " + i + "------ MOYEN: " + po.GetMoyenScoreGeneration + " M.SCORE: " + po.GetTopScoreGeneration);
               
                i++;
            }
            Console.WriteLine("Affiche de meilleur chemin de la population");
            Console.WriteLine(GetMeilleurCheminDeLaPopulation() + " " + GetMeilleurCheminDeLaPopulation().Score.ToString());
        }

        public Chemin GetMeilleurCheminDeLaPopulation()
        {
            Chemin top = null;
            foreach (Generation gs in this.mesGenerations)
            {
                foreach (Chemin c in gs.Get_generation)
                {
                    if (top is null)
                    {
                        top = c;
                    }
                    else
                    {
                        if (c.Score < top.Score) top = c;
                    }


                }
            }
            return top;
        }


    }
}
