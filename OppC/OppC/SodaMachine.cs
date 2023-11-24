namespace OppC
{
    internal class SodaMachine
    {
        public Soda[] SodaInventory { get; private set; }
        public int[] SodaStock { get; private set; }

        public SodaMachine(Soda[] sodas, int[] stock)
        {
            SodaInventory = sodas;
            SodaStock = stock;
        }

        public void ShowInventory()
        {
            Console.WriteLine("   | Navn:      | Pris: | Antall:");
            Console.WriteLine("---+------------+-------+--------");
            for (int i = 0; i < SodaInventory.Length; i++)
            {
                var space = new string(' ', 11 - SodaInventory[i].Name.Length);
                Console.WriteLine($" {i} | {SodaInventory[i].Name}{space}| {SodaInventory[i].Price} kr | {SodaStock[i]}");
                Console.WriteLine("---+------------+-------+---");
            }
        }

        public void BuySoda(int sodaIndex)
        {
            if (SodaStock[sodaIndex] < 1)
            {
                Console.WriteLine($"Det er tomt for {SodaInventory[sodaIndex].Name}\n");
                return;
            }
            SodaStock[sodaIndex]--;
            Console.WriteLine($"Du kjøpte en {SodaInventory[sodaIndex].Name} for {SodaInventory[sodaIndex].Price} kr. Det er {SodaStock[sodaIndex]} igjen.\n");
        }
    }
}
