using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulator");
            Console.WriteLine();

            double a = 0, b = 0;
            Console.Write("Podaj pierwszą liczbę: ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.Write("Niepoprawna wartość wpisz jeszcze raz: ");
            }
            Console.Write("Podaj drugą liczbę: ");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.Write("Niepoprawna wartość wpisz jeszcze raz: ");
            }

            Console.WriteLine();
            Console.WriteLine("Wybierz operację:");
            Console.WriteLine("1 - Dodawanie");
            Console.WriteLine("2 - Odejmowanie");
            Console.WriteLine("3 - Mnożenie");
            Console.WriteLine("4 - Dzielenie");
            Console.Write("Twój wybór: ");

            string wybor = Console.ReadLine();

            Operation op = null;

            switch (wybor)
            {
                case "1":
                    op = new Add();
                    break;
                case "2":
                    op = new Subtract();
                    break;
                case "3":
                    op = new Multiply();
                    break;
                case "4":
                    op = new Divide();
                    break;
                default:
                    Console.WriteLine("Nieznana opcja kończę program.");
                    return;
            }

            Calculator kalkulator = new Calculator();
            kalkulator.SetOperation(op);

            try
            {
                double wynik = kalkulator.Calculate(a, b);
                Console.WriteLine();
                Console.WriteLine("Wynik: " + wynik);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Bład: " + e.Message);
            }
           

            Console.WriteLine();
            Console.WriteLine("Naciśnij Enter żeby zakończyć");
            Console.ReadLine();
        }
    }
}
