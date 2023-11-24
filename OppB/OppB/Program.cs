namespace OppB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var math = new Subject("Math", 0, 2);
            var pe = new Subject("Math", 0, 4);
            var science = new Subject("Math", 3, 0);

            var subjectsArray = new Subject[] { math, pe, science };
            var grade8 = new Class("Grade 8", subjectsArray);

        }
    }
}