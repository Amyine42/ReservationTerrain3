using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Terrain
{
    public class TerrainListe
    {
        public int Id { get; set; }
        public String Nom { get; set; }
        public string Description { get; set; } = String.Empty;
        public Decimal Prix { get; set; }
    }
}
