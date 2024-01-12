using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Losowanie
    {
        Random random = new Random();
        public Losowanie() 
        {
            int i = random.Next()%3;
            if(i == 0)
            {
                throw new ArithmeticException("Dzielenie przez zero");
            }else if(i == 1)
            {
                throw new StackOverflowException("Zbyt duża ilość elementów");
            }
            else
            {
                throw new Exception("Nie wiemy co nie zadziałało pracujemy nad tym");
            }

        }
    }
}
