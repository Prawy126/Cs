using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Circle: Shape
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Koło");
        }
    }
}
