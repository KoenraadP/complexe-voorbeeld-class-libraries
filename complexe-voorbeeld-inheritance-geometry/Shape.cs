using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complexe_voorbeeld_inheritance_geometry
{
    // base class shape (vorm)
    class Shape
    {
        // iedere shape/vorm heeft een kleur
        public string Color { get; set; }

        // constructor voor Shape
        public Shape(string color)
        {
            Color = color;
        }

    }
}
