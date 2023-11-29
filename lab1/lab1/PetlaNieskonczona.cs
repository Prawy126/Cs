using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class PetlaNieskonczona
    {
        public PetlaNieskonczona()
        {
            while(true)
            {
                Console.WriteLine("Podaj liczbę:");
                int liczba = int.Parse(Console.ReadLine());
                if (liczba < 0 )
                    break;
                
            }
        }
    }
}
