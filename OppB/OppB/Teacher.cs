namespace OppB
{
    internal class Teacher
    {
        private string _name;
        private Subject[] subjects = new Subject[5];

        public Teacher(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }
    }
}
