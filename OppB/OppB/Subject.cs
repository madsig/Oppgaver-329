namespace OppB
{
    internal class Subject
    {
        private string _name;
        private Room room; //tid, sted
        private Teacher _teacher;
        private List<Student> _student;

        public Subject(string name)
        {
            _name = name;
            //_room = room;
            //_teacher = teacher;
        }

        public string GetName()
        {
            return _name;
        }

        



    }
}
