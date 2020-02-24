using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_UI
{
    class Data
    {
        // declaration de la classe data
        private string _dbPath = "../MyDatabase.db3";
        private static Data d;
        public static Data getData()
        {
            if (d == null) d = new Data();
            return d;
        }

        // constructeur 
        private Data() { }

        // une méthode pour inserer les villes 
        public void Insert(Ville v)
        {
            // connection à la base SQLlite
            SQLiteConnection connection = new SQLiteConnection(_dbPath);

            //Création d'une table 
            connection.CreateTable<Ville>();
            connection.Insert(v);
        }

    }
}
