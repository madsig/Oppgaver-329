﻿namespace OppC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sodaArray = new Soda[]
            {
                new Soda("Cola", 20),
                new Soda("Cola Zero", 18),
                new Soda("Pepsi", 24),
                new Soda("Pepsi Max", 22),
                new Soda("Solo", 23),
                new Soda("Solo Super", 21),
            };

            var sodaMachine = new SodaMachine(sodaArray, 4, 5, 2, 8, 6, 6);

            while (true) //skrive om for å kunne enten legge til penger eller kjøpe brus
            {
                sodaMachine.ShowInventory();

                Console.Write("\nHvilken brus vill du kjøpe? (skriv index): ");
                var sodaInput = Console.ReadLine();
                if (!int.TryParse(sodaInput, out int sodaIndex))
                {
                    Console.WriteLine("Feil input");
                    return;
                }

                sodaMachine.BuySoda(sodaIndex);
            }
        }
    }
}