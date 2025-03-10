using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complexe_voorbeeld_inheritance_geometry
{
    class Triangle : Polygon
    {
        public int Base { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }

        // constructor voor Triangle
        public Triangle(int height, string color) : base(height, color)
        {

        }
    }
}
