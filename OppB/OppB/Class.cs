using System.ComponentModel;

namespace OppB
{
    internal class Class
    {
        public string ClassName { get; private set; }
        public Subject[] Subjects { get; private set; }
        public Class(string nameInput, Subject[] subjectsInput)
        {
            ClassName = nameInput;
            Subjects = subjectsInput;
        }

        public void PrintSubjects()
        {
            foreach (var subject in Subjects)
            {
                Console.Write(subject.SubjectName);
                Console.WriteLine($"  {Subject.GetDateString()}");
            }
        }
    }
}
