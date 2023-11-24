namespace OppB
{
    internal class Subject
    {
        public string SubjectName { get; private set; }
        public int Day { get; private set; }
        public int Period { get; private set; }
        public Subject(string nameInput, int dayInput, int periodInput)
        {
            SubjectName = nameInput;
            Day = dayInput;
            Period = periodInput;
        }

        public static string GetDateString()
        {
            var dateString = $"{(Enum.Weekday)Day} i {Period}. periode";
            return dateString;
        }
    }
}
