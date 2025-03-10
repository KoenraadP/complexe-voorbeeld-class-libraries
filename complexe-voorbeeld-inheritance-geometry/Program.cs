using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complexe_voorbeeld_inheritance_geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(6,8,"Green");
            //r.Color = "Red";
            //Console.WriteLine(r.Color);

            Polygon p = new Polygon(10, "Blue");
            Console.WriteLine(p.Color);

            Square s = new Square(7, "Purple");
            Console.WriteLine(s.Height);
            Console.WriteLine(s.CalculateArea());
        }
    }
}
