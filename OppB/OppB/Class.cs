namespace OppB
{
    internal class Class
    {
        private string _className;
        private Subject[] _subjects;
        private Teacher _teacher; 
        private List<Student> _students = new List<Student>();

        //private int _studentCount;

        public Class(string className, Subject[] subjects, List<Student> students, Teacher teacher) 
        {
            _className = className;
            _subjects = subjects;
            _teacher = teacher;
            _students = students;

        }



        public string GetName()
        {
            return _className;
        }

        public Subject[] GetSubjects()
        {
            return _subjects;
        }

        public void AddStudents(Student student)
        {
            _students.Add(student);
        }

        public string[] GetSubjectNames()
        {
            var subjectNames = new List<string>();
            foreach (Subject subject in _subjects)
            {
                subjectNames.Add(subject.GetName());
            }
            return subjectNames.ToArray();
        }

        public string[] GetStudentNames()
        {
            var studentNames = new List<string>();
            foreach (var student in _students)
            {
                studentNames.Add(student.GetName());
            }
            return studentNames.ToArray();

        }
    }
}
