using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Shape
    {
        double x, y, width, height;
        public virtual void Draw()
        {
            Console.WriteLine("Rysuję figurę");
        }
        public Shape()
        {

        }
        public Shape(double x, double y, double width, double height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
    }
}
