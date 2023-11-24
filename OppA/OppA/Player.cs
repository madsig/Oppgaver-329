using System.Threading.Tasks.Sources;

namespace OppA
{
    internal class Player
    {
        private readonly Random _random = new();
        private string _name;
        private int _score;
        public Player(string nameInput, int scoreInput)
        {
            _name = nameInput;
            _score = scoreInput;
        }

        public void Play(Player opponent)
        {
            Console.Write($"{_name} VS {opponent._name} => ");
            var winner = _random.Next(2);
            if (winner == 0)
            {
                _score++;
                opponent._score--;
            }
            else if (winner == 1)
            {
                opponent._score++;
                _score--;
            }

            Console.WriteLine($"{(winner == 0 ? _name: opponent._name)} vant!");
        }

        public void ShowNameAndPoints()
        {
            var spaces = new string(' ', 8 - _name.Length);
            Console.WriteLine($"Navn: {_name}{spaces}Poeng: {_score}");
        }
    }
}
