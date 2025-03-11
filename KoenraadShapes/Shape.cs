using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoenraadShapes
{
    // base public class shape (vorm)
    public class Shape
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
