using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class SomeClass
    {
        public void CanThroException()
        {
            if(new Random().Next(5) == 0)
            {
                throw new Exception();
            }
        }
    }
}
