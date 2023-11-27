namespace lab1
{
    internal class Tablica
    {
        private int[] tab = new int[10];
        private int wybor;
        public Tablica(int[] tab)
        {
            this.tab = tab;

            do
            {
                Console.WriteLine("1)Wyświetlanie od najmniejszego indexu");
                Console.WriteLine("2)Wyświetlanie od największego indexu");
                Console.WriteLine("3)Wyświetlanie nieprzystych indexu");
                Console.WriteLine("4)Wyświetlanie parzystych indexu");
                Console.WriteLine("5)Wyjśćie z programu");
                wybor = int.Parse(Console.ReadLine());
                if (wybor == 1)
                    WyswietlOdNajmniejszego();
                else if (wybor == 2)
                    WyswielOdNajwiekszego();
                else if (wybor == 3)
                    Nieparzyste();
                else if(wybor == 4)
                    Parzyste();
                Console.ReadLine();
                Console.Clear();
            } while (wybor < 5);
        }
        public void WyswietlOdNajmniejszego()
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
        }
        public void WyswielOdNajwiekszego()
        {
            for (int i = tab.Length - 1; i >= 0; i--)
                Console.WriteLine(tab[i]);
        }
        public void Nieparzyste()
        {
            for (int i = 0; i < tab.Length; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(tab[i]);
                }
            }
        }
        public void Parzyste()
        {
            for (int i = 0; i < tab.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(tab[i]);
                }
            }
        }

    }
}
