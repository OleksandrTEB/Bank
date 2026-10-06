namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // Tworzenie objektu

            Console.Write("Wprowadz wlasciciela dla nowego konta: ");

            string wlasc = Console.ReadLine();

            Console.Write("Stwuz 4 cyfrowy pin do tego konta: ");

            string newPin = Console.ReadLine();

            KontoBankowe konto = new KontoBankowe(wlasc, 0, newPin);



            while (true)
            {
                Console.WriteLine("Wybierz operacje, 1 = Wplata, 2 = Wyplata. \n");

                int wybor = int.Parse(Console.ReadLine());

                switch (wybor)
                {
                    case 1:
                        {
                            Console.Write("Wprowadz kwote do wplacenia: ");

                            int kwota = int.Parse(Console.ReadLine());

                            Console.Write("Wprowadz PIN konta: ");

                            string pin = Console.ReadLine();

                            konto.Wplata(kwota, pin);

                            break;
                        }

                    case 2:
                        {
                            Console.Write("Wprowadz kwote do wyplaty: ");

                            int kwota = int.Parse(Console.ReadLine());

                            Console.Write("Wprowadz PIN konta: ");

                            string pin = Console.ReadLine();

                            konto.Wyplata(kwota, pin);

                            break;
                        }
                }
            }
        }
    }
}