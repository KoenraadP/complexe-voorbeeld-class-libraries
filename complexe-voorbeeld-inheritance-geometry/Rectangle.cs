using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complexe_voorbeeld_inheritance_geometry
{
    // Rectangle is een subklasse van Polygon
    // Polygon is een subklasse van Shape
    // hierdoor krijgt Rectangle automatisch
    // alle properties en methodes uit zowel Polygon als Shape
    class Rectangle : Polygon
    {
        // de Width eigenschap zat nog niet in de base class
        public int Width { get; set; }

        // constructor voor Rectangle
        public Rectangle(int height, int width,  string color) 
            : base(height, color)
        {
            Width = width;
        }

        // methode om de oppervlakte van een rechthoek te berekenen
        public int CalculateArea()
        {
            return Height * Width;
        }

        // methode om de omtrek van een rechthoek te berekenen
        public int CalculatePerimeter()
        {
            return 2 * (Height + Width);
        }

    }
}
