using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoenraadShapes
{
    public class Square : Rectangle
    {
        // een vierkant heeft geen aparte breedte
        // en hoogte/lengte nodig, enkel een zijde
        // dus moet ik maar één cijfer invullen bij de constructor
        // dit ene cijfer wordt dan wel gebruikt bij de vereiste
        // parameters van de base public class constructor
        public Square(int side,  string color) 
            : base(side, side, color)
        {

        }
    }
}
