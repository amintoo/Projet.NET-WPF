using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_UI
{
    public class Ville
    {
        public string id;
     

        public int X { get; set; }
        public int Y { get; set; }

        public string villename { get; set; }

        public Ville(string id, string villename, int x, int y)
        {
            this.id = id;
            this.villename = villename;
            this.X = x;
            this.Y = y;
        }

        public Ville(string villename, int x, int y)
        {
            this.villename = villename;
            this.X = x;
            this.Y = y;
        }

        public Ville(int x, int y, string villename)
        {
            this.X = x;
            this.Y = y;
            this.villename = villename;
        }

        public Ville()
        {

        }

    }
}
