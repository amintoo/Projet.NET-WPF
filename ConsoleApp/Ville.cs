using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp
{
   // [Table("Ville")]
    class Ville
    {   private string nomville;
        private int  X;
        private int Y;
        //constructeur
        public Ville(string nom, int x, int y)
        {
            this.nomville = nom;
            this.X = x;
            this.Y = y;
        }
        // [Column("nomVille"), PrimaryKey]
        //get et set 
        public string NomVille { get { return nomville;} set { nomville = value;} }
        //[Column("XVille")]
        public int XVille{get{return X;}set{X = value;}}
        //[Column("YVille")]
        public int YVille { get { return Y; } set { Y = value; } }
        // method String to String 
        public override String ToString()
        {   StringBuilder sb = new StringBuilder();
            sb.Append(NomVille + "(" + XVille + ";" + YVille + ")");
            return sb.ToString();
        }
    }
}
