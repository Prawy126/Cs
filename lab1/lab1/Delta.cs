namespace lab1
{
    internal class Delta
    {
        private double a, b, c;
        
        public Delta(double a, double b, double c)
        {
            string sa;
            if (a == 0)
            {
                Console.WriteLine("Proszę podać równanie kwadratowe");
                sa = Console.ReadLine();
                a = double.Parse(sa);
            }

            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double LiczDelte()
        {
            return Math.Pow(b, 2) + (-4 * a * c);
        }
        public double[] LiczPierwiastki()
        {
            double delta = LiczDelte();
            double[] tab = new double[2];
            if (delta == 0)
            {
                tab[0] = b / -2 * a;
            }
            if (delta > 0)
            {
                tab[0] = b + Math.Sqrt(delta) / -2 * a;
                tab[1] = b - Math.Sqrt(delta) / -2 * a;
            }
            if (delta < 0)
            {
                Console.WriteLine("Ujemna delta nie ma takiej lizby która byłaby rozwiązaniem w zbiorze liczb rzeczywistych.");

            }
            return tab;
        }
    }
}
