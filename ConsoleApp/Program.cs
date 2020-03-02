using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Ville A = new Ville("Marseille", 15, 20);
            Ville B = new Ville("toulon", 10, 10);
            Ville C = new Ville("Nice", 20, 60);
            Ville D = new Ville("lyon", 40, 40);
            Ville E = new Ville("Nantes", 35, 70);
            Ville F = new Ville("Bordeaux", 42, 46);
            Ville G = new Ville("Rennes", 43, 48);

            // instancier la liste 
            List<Ville> Villes = new List<Ville>();
            //ajouter les villes dans la liste 
            Villes.Add(A);
            Villes.Add(B);
            Villes.Add(C);
            Villes.Add(D);
            Villes.Add(E);
            Villes.Add(F);
            Villes.Add(G);
            //Chemin C1 = new Chemin(Villes);

            Parametrage param = new Parametrage(30, 10, 30, 30, 2);
            Generation g = new Generation(10, Villes);
            Population p = new Population();
            Thread thread = new Thread(new ThreadStart(() => p.Play(param.Taille_population, param.NbrCheminInGeneration,Villes, param.Crossover, param.Mutation, param.Elite)));
            thread.Start();


            Console.ReadKey();
            //foreach (Chemin c in maGenartion)
            // {
            //Console.WriteLine(c.ToString());
            //  Console.WriteLine(c.Score);
            //}
            //Console.WriteLine(c1.Score);
            //Console.WriteLine("Hello World!");
        }
    }
}
