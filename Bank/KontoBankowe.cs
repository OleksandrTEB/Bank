namespace Bank
{
    internal class KontoBankowe
    {

        private decimal _saldo;

        private string _nrKonta;

        private string _wlasciel;

        private string _pin;

        // gettery i settery
        public decimal Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        public string Wlasciciel
        {
            get { return _wlasciel; }
            set { _wlasciel = value; }
        }

        public KontoBankowe()
        {
            _wlasciel = "Nieznany";
            _saldo = 0;
            Console.WriteLine($"Utworzono puste konto");
        }

        public KontoBankowe(string nowyWlasciciel, decimal startoweSaldo, string pin)
        {
            _wlasciel = nowyWlasciciel;
            // walidacjasalda

            if(startoweSaldo < 0)
            {
                Console.WriteLine("Saldo nie moze byc ujemne");
            }
            else
            {
                _saldo = startoweSaldo;
            }

            // generowanie numeru konta

            Random r = new Random();

            _nrKonta = GeneratorLosowychLiczb(10);

            _pin = pin;

            // powinno jeszcze wypisać jaki nr ma konto
            Console.WriteLine($"Utworzono konto dla: {_wlasciel} z saldem: {startoweSaldo} PLN i numerem konta: {_nrKonta}");
        }

        private string GeneratorLosowychLiczb(int dlugosNumeru)
        {
            Random r = new Random();

            string nr = "";

            for(int i = 0; i < dlugosNumeru; i++)
            {
                int num = r.Next(0, 11);

                nr += num;
            }

            return nr;
        }

        public void Wplata(decimal kwota, string pin)
        {
            // walidacja kwoty

            if (pin == _pin)
            {
                if (kwota < 0)
                {
                    Console.WriteLine("Kwota nie moze byc ujemna");
                }
                else
                {
                    _saldo += kwota;
                }

                Console.WriteLine($"Wpłacono {kwota} PLN. Aktualny stan konta: {_saldo} PLN.");
            }
            else
            {
                Console.WriteLine("Podano nie przwidlowy pin");
            }
        }

        public void Wyplata(decimal kwota, string pin)
        {
            // walidacja kwoty

            if (pin == _pin)
            {
                if (_saldo < kwota)
                {
                    Console.WriteLine("Nie wystarcza srodkuw");
                }
                else
                {
                    _saldo -= kwota;
                }

                Console.WriteLine($"Wypłacono {kwota} PLN. Aktualny stan konta: {_saldo} PLN.");
            }
            else
            {
                Console.WriteLine("Podano nie przwidlowy pin");
            }
        }

        public void WyswietliInformacje()
        {
            Console.WriteLine($"Właściciel: {_wlasciel}");
            Console.WriteLine($"Stan konta: {_saldo} PLN");
        }

    }
}
