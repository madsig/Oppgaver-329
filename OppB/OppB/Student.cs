namespace OppB
{
    internal class Student
    {
        private string _name;
        private Class _class;
        private readonly List<Subject> _subjects = new List<Subject>();

        private int _subjectCount;


        public Student(string name)
        {
            _name = name;
            //_subjects = _class.GetSubjects().ToList<Subject>();
        }

        public void AddSubjects(Subject sub)
        {

            if (!_subjects.Contains(sub))
            {
                _subjects.Add(sub);
            }

            //foreach (var sub in subjects)
            //{
            //    if (_subjectCount > 3) return;
            //    _subjects[_subjectCount++] = sub;
            //}
        }

        public void SetClass(Class c)
        {
            _class = c;
            foreach(Subject subject in c.GetSubjects()) {
                _subjects.Add(subject);
            }
        }
        



        public string GetName()
        {
            return _name;
        }

        public Class GetClass()
        {
            return _class;
        }

        public List<Subject> GetSubjects()
        {
            return _subjects;
        }

    }
}
