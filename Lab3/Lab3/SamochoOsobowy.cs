namespace Lab3
{
    internal class SamochoOsobowy : Samochod
    {
        private float waga, pojemnosc;
        private int iloscOsob;
        public float Waga
        {
            get { return waga; }
            set { if (value > 2) waga = value; else waga = 2f; }
        }
        public float Pojemnosc 
        {
            get { return pojemnosc; }
            set { if (value > 0) pojemnosc = value; else pojemnosc = 50f; }
        }
        public int IloscOsob
        {
            get { return iloscOsob; }
            set { if (value < 0) iloscOsob = 1; else iloscOsob = value; }
        }

        public SamochoOsobowy(string marka, string model, string nadwozie, string kolor, int rokProdukcji, float przebieg, float waga, float pojemnosc, int iloscOsob) : base(marka, model, nadwozie, kolor, rokProdukcji, przebieg)
        {
            Waga = waga;
            Pojemnosc = pojemnosc;
            IloscOsob = iloscOsob;
        }

        public override void PokazInformacje()
        {
            base.PokazInformacje();
            Console.WriteLine("Waga: " + Waga);
            Console.WriteLine("Pojemność Silnika: " + Pojemnosc);
            Console.WriteLine("Ilość Miejsc: " + IloscOsob);

        }
    }
}
