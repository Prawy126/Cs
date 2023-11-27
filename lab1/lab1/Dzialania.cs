namespace lab1
{
    internal class Dzialania
    {
        private double[] tab = new double[10];
        private double wynik = 0;
        public Dzialania(double[] tab)
        {
            this.tab = tab;
        }
        public void Dodaj()
        {
            for (int i = 0; i < 10; i++)
            {
                wynik += tab[i];
            }
            Console.WriteLine("Suma tablicy wynosi: " + wynik);
            wynik = 0;
        }
        public void Iloczyn()
        {
            wynik = 1;
            for (int i = 0; i < 10; i++)
            {
                wynik *= tab[i];
            }
            Console.WriteLine("Mnożenie tablicy wynosi: " + wynik);
            wynik = 0;
        }
        public void Srednia()
        {
            for (int i = 0; i < 10; i++)
            {
                wynik += tab[i];
            }
            wynik = wynik / 10;
            Console.WriteLine("Średnia tablicy wynosi: " + wynik);
            wynik = 0;
        }
        public void Max()
        {
            wynik = tab[0];
            for (int i = 1; i < 10; i++)
            {

                if (tab[i] > wynik)
                    wynik = tab[i];
            }
            Console.WriteLine("Max tablicy wynosi: " + wynik);
            wynik = 0;
        }
        public void Min()
        {
            wynik = tab[0];
            for (int i = 1; i < 10; i++)
            {

                if (tab[i] < wynik)
                    wynik = tab[i];
            }
            Console.WriteLine("Min tablicy wynosi: " + wynik);
            wynik = 0;
        }
    }
}
