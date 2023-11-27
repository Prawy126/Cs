namespace lab1
{
    internal class Kalkulator
    {
        private double a, b;
        bool dzialanie = true;
        public Kalkulator()
        {
            while (dzialanie)
            {
                Console.WriteLine("1.Dodawanie");
                Console.WriteLine("2.Odejmowanie");
                Console.WriteLine("3.Mnożenie");
                Console.WriteLine("4.Dzielenie");
                Console.WriteLine("5.Potęgowanie");
                Console.WriteLine("6.Pierwiastkowanie");
                Console.WriteLine("7.Sinus");
                Console.WriteLine("8.Cosinus");
                Console.WriteLine("9.Tangens");
                Console.WriteLine("10.Cotangens");
                Console.WriteLine("11 Wyjście");
                string wyborS = Console.ReadLine();
                int wybor = int.Parse(wyborS);
                string sb, sa;
                switch (wybor)
                {
                    case 1:
                        Console.WriteLine("Proszę podać liczby:");
                        sa = Console.ReadLine();
                        sb = Console.ReadLine();
                        a = double.Parse(sa);
                        b = double.Parse(sb);
                        Console.WriteLine(a + b);
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Proszę podać liczby:");
                        sa = Console.ReadLine();
                        sb = Console.ReadLine();
                        a = double.Parse(sa);
                        b = double.Parse(sb);
                        Console.WriteLine(a - b);
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Proszę podać liczby:");
                        sa = Console.ReadLine();
                        sb = Console.ReadLine();
                        a = double.Parse(sa);
                        b = double.Parse(sb);
                        Console.WriteLine(a * b);
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Proszę podać liczby:");
                        sa = Console.ReadLine();
                        sb = Console.ReadLine();
                        a = double.Parse(sa);
                        b = double.Parse(sb);
                        Console.WriteLine(a / b);
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Proszę podać liczby:");
                        sa = Console.ReadLine();
                        sb = Console.ReadLine();
                        a = double.Parse(sa);
                        b = double.Parse(sb);
                        Console.WriteLine(Math.Pow(a, b));
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Proszę podać liczbę:");
                        sa = Console.ReadLine();

                        a = double.Parse(sa);

                        Console.WriteLine(Math.Sqrt(a));
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine("Proszę podać liczbę:");
                        sa = Console.ReadLine();

                        a = double.Parse(sa);

                        Console.WriteLine(Math.Sin(a));
                        Console.ReadLine();
                        break;
                    case 8:
                        Console.WriteLine("Proszę podać liczbę:");
                        sa = Console.ReadLine();
                        
                        a = double.Parse(sa);
                        
                        Console.WriteLine(Math.Cos(a));
                        Console.ReadLine();
                        break;
                    case 9:
                        Console.WriteLine("Proszę podać liczbę:");
                        sa = Console.ReadLine();
                        
                        a = double.Parse(sa);
                       
                        Console.WriteLine(Math.Tan(a));
                        Console.ReadLine();
                        break;
                    case 10:
                        Console.WriteLine("Proszę podać liczbę:");
                        sa = Console.ReadLine();
                        
                        a = double.Parse(sa);
                        
                        Console.WriteLine(1/Math.Tan(a));
                        Console.ReadLine();
                        break;
                    case 11:
                        dzialanie = false;
                        break;
                }
                Console.Clear();
            }
        }
    }
}
