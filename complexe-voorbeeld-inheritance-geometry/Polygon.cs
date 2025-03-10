using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complexe_voorbeeld_inheritance_geometry
{
    // polygon = veelhoek
    // base class voor rechthoek en driehoek
    // Polygon krijgt hierdoor automatisch al
    // de property Color
    class Polygon : Shape
    {
        // alle veelhoeken krijgen de property Height
        // automatisch heeft Polygon ook al de Color property
        // gekregen via overerving van Shape
        public int Height { get; set; }

        // constructor voor Polygon
        // base() duidt hier op de constructor van
        // de base class, waarbij je in dezelfde 
        // volgorde als bij die constructor
        // de parameters correct moet invullen
        public Polygon(int height, string color) : base(color)
        {
            Height = height;
        }       
    }
}
