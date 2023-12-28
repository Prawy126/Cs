using System;

namespace Lab3
{
    internal class Samochod
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Nadwozie { get; set; }
        public string Kolor { get; set; }
        private int rokProdukcji;
        private float przebieg;

        public int RokProdukcji
        {
            get { return rokProdukcji; }
            set { rokProdukcji = (value > 1960 && value <= DateTime.Now.Year) ? value : 0; }
        }

        public float Przebieg
        {
            get { return przebieg; }
            set { przebieg = Math.Abs(value); }
        }

        public Samochod(string marka, string model, string nadwozie, string kolor, int rokProdukcji, float przebieg)
        {
            Marka = marka;
            Model = model;
            Nadwozie = nadwozie;
            Kolor = kolor;
            RokProdukcji = rokProdukcji;
            Przebieg = przebieg;
        }

        public Samochod(string marka, string model)
        {
            Marka = marka;
            Model = model;
            Nadwozie = "Nieznane";
            Kolor = "Nieznane";
            RokProdukcji = 0;
            Przebieg = 0;
        }

        public virtual void PokazInformacje()
        {
            Console.WriteLine($"Marka: {Marka}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Nadwozie: {(string.IsNullOrEmpty(Nadwozie) ? "brak informacji" : Nadwozie)}");
            Console.WriteLine($"Kolor: {(string.IsNullOrEmpty(Kolor) ? "brak informacji" : Kolor)}");
            Console.WriteLine($"Rok Produkcji: {(RokProdukcji == 0 ? "brak informacji" : RokProdukcji)}");
            Console.WriteLine($"Przebieg: {(Przebieg == 0 ? "brak informacji" : Przebieg)}");
        }
    }
}
