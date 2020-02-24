using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_UI
{
    [Table("Ville")]
    public class Ville
    {
        
        [PrimaryKey, AutoIncrement] 
        private string id { get; set ; }
        [Column("X")]
        public int X { get; set; }
        [Column("Y")]
        public int Y { get; set; }

        public string villename { get; set; }
        public string Id { get => id; set => id = value; }

        public Ville(string id, string villename, int x, int y)
        {
            this.Id = id;
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
