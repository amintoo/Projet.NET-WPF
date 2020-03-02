using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Parametrage
    {
        
        public Parametrage(int _taille, int _nbchemin, int _xover, int _mutation, int _elite)
        {
            this.mutation = _mutation;
            this.nbrCheminInGeneration = _nbchemin;
            this.taille_population = _taille;
            this.crossover = _xover;
            this.elite = _elite;
            this.cntVille = 1;
            this.id = 1;
        }

        public Parametrage()
        {
            this.cntVille = 1;
            this.id = 1;
        }

        private int id;

       // [Column("Id"), PrimaryKey]
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (this.id != value)
                {
                    this.id = value;
                }
            }
        }



        private int mutation;

       // [Column("Mutation")]
        public int Mutation
        {
            get { return this.mutation; }
            set
            {
                if (this.mutation != value)
                {
                    this.mutation = value;
                }
            }
        }

        private int crossover;

       // [Column("Crossover")]
        public int Crossover
        {
            get { return this.crossover; }
            set
            {
                if (this.crossover != value)
                {
                    this.crossover = value;
                }
            }
        }

        private int elite;

      //  [Column("Elite")]
        public int Elite
        {
            get { return this.elite; }
            set
            {
                if (this.elite != value)
                {
                    this.elite = value;
                }
            }
        }

        private int taille_population;

        //[Column("Taille_population")]
        public int Taille_population
        {
            get { return this.taille_population; }
            set
            {
                if (this.taille_population != value)
                {
                    this.taille_population = value;
                }
            }
        }

        private int nbrCheminInGeneration;

       // [Column("NbrCheminInGeneration")]
        public int NbrCheminInGeneration
        {
            get { return this.nbrCheminInGeneration; }
            set
            {
                if (this.nbrCheminInGeneration != value)
                {
                    this.nbrCheminInGeneration = value;
                }
            }
        }

        private int cntVille;

       // [Column("ConteurVille")]
        public int ConteurVille
        {
            get { return this.cntVille; }
            set
            {
                if (this.cntVille != value)
                {
                    this.cntVille = value;
                }
            }
        }


    }
}
