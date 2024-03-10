using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Terrain
{
    public class TerrainDetail
    {
        public int Id { get; set; }
        public string Titre { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Prix { get; set; }
    }
}
