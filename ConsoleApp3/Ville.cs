using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp
{
   
    public class Ville
    {   
        private string nomville;
        public string Nomville
        {
            get { return nomville; }
            set { nomville = value; }
        }
        private int  x;
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        private int y;
        public int Y
        {
            get { return y; }
            set { y = value; }
        }


        //constructeur
        public Ville(string nomville, int x, int y)
        {
            this.nomville = nomville;
            this.X = x;
            this.Y = y;
        }

        public Ville() 
        { }

        

        // method String to String 
        public override String ToString()
        {   StringBuilder sb = new StringBuilder();
            sb.Append(Nomville + "(" + X + ";" + Y + ")");
            return sb.ToString();
        }
    }
}
