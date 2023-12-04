namespace OppB
{
    internal class SchoolManager
    {
        /*
            Å kunne liste opp alle elever med index - navn
            Å liste opp alle fag med index - navn
            Så melde elev på fag.

            Printe timeplan.
        */

        private Names names = new Names();

        private List<Teacher> _teachers;
       // private List<Subject> _subjects;
        //private List<Student> _students;
        private Class[] _classes;
        private Room[] _rooms;



        public SchoolManager()
        {
            _teachers = InitTeachers(3);
            //_subjects = InitSubjects(3);
            _rooms = InitRooms(2);
            _classes = InitClasses(3);
        }

        List<Teacher> InitTeachers(int count)
        {
            var teachers = new List<Teacher>();
            for (int i = 0; i < count; i++)
            {
                teachers.Add(new Teacher(names.GetName()));
            }
            return teachers;

        }

        List<Subject> InitSubjects(int count)
        {
            var subjects = new List<Subject>();
            for (int i = 0; i < count; i++)
            {
                subjects.Add(new Subject(names.GetRandomSubjectName()));
            }
            return subjects;
        }

        Room[] InitRooms(int count)
        {
            var rooms = new List<Room>();
            for(int i = 0; i < count;i++){
                rooms.Add(new Room((101 + i).ToString()));
            }

            return rooms.ToArray();
        }

        List<Student> InitStudents(int count)
        {
            var students = new List<Student>();
            for(int i = 0;i < count; i++)
            {
                students.Add(new Student(names.GetName()));
            }
            return students;
        }

        Class[] InitClasses(int count)
        {
            
            var classes = new List<Class>();    
            for(int i = 0; i < count ; i++)
            {
                var className = (10 + (char)65 + i).ToString();
                classes.Add(new Class(className, InitSubjects(4).ToArray(),InitStudents(6), _teachers[i]));
            }
            return classes.ToArray();
        }

        public void InitSchedule()
        {
            foreach (Class c in _classes)
            {
                
                foreach (Subject s in c.GetSubjects())
                {
                
                    foreach (Room r in _rooms)
                    {
                        r.BookNextAvailableTime(s.GetName());
                        return;
                    }

                }   
            }
        }

        public string GetAllSubjects()
        {
            var result = "";
            foreach(var c in _classes)
            {
                result += c.GetSubjects();
            }

            return result;

        }

        public string GetAllTeachers()
        {
            var result = "";
            foreach(var teacher in _teachers)
            {
                result+= teacher.GetName();
            }
            return result;
        }

        public string GetAllClasses()
        {
            string result = "";
            foreach (var c in _classes)
            {
                result += "Klasse "+c.GetName() + " har følgende fag:\n" +
                    string.Join(", ", c.GetSubjectNames()) + "\n" +
                    "Elever:\n"+ string.Join(", ",c.GetStudentNames())+"\n\n";
            }
            return result;

        }
      
    }









}