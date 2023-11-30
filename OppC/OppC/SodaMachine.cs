namespace OppC
{
    internal class SodaMachine
    {
        private readonly Soda[] _sodaInventory;
        private readonly int[] _sodaStock;
        private int[] _coinsExchange = { 12, 5, 7, 3 }; //1kr, 5kr, 10kr, 20kr
        private readonly int[] _coinsInput = { 0, 0, 0, 0}; //1kr, 5kr, 10kr, 20kr

        private static readonly string[] CoinName = { "en", "fem", "ti", "tjue" };

        public SodaMachine(Soda[] sodas, int[] stock)
        {
            _sodaInventory = sodas;
            _sodaStock = stock;
        }

        public void ShowInventory()
        {
            Console.WriteLine("   | Navn:      | Pris: | Antall:");
            Console.WriteLine("---+------------+-------+--------");
            for (int i = 0; i < _sodaInventory.Length; i++)
            {
                var space = new string(' ', 11 - _sodaInventory[i].Name.Length);
                Console.WriteLine($" {i} | {_sodaInventory[i].Name}{space}| {_sodaInventory[i].Price} kr | {_sodaStock[i]}");
                Console.WriteLine("---+------------+-------+---");
            }
        }

        public void ShowCoinsInput()
        {
            if (_coinsInput.All(n => n == 0))
            {
                Console.WriteLine("Du har ikke lagt inn noen mynter");
                return;
            }

            Console.Write("Du har lagt inn: ");
            for (int i = 0; i < _coinsInput.Length; i++)
            {
                var coinOrCoins = _coinsInput[i] == 1 ? "kroning" : "kroninger";
                var end = i == 3 ? "\n" : i == 2 ? " & " : ", ";
                Console.Write($"{_coinsInput[i]} {CoinName[i]}-{coinOrCoins}{end}");
            }
        }

        public void AddCoins(int coin)
        {
            if (coin is < 0 or > 3)
            {
                Console.WriteLine("Feil input"); 
                return;
            }
            _coinsInput[coin]++;
        }

        public void BuySoda(int sodaIndex)
        {
            if (_sodaStock[sodaIndex] < 1)
            {
                Console.WriteLine($"Det er tomt for {_sodaInventory[sodaIndex].Name}\n");
                return;
            }
            _sodaStock[sodaIndex]--;
            Console.WriteLine($"Du kjøpte en {_sodaInventory[sodaIndex].Name} for {_sodaInventory[sodaIndex].Price} kr. Det er {_sodaStock[sodaIndex]} igjen.\n");
        }
    }
}
