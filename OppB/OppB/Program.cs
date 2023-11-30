namespace OppB
{
    internal class Program
    {

        static void Main(string[] args)
        {
            SchoolManager manager = new SchoolManager();

            manager.InitSchedule();
            Console.WriteLine(manager.GetAllTeachers());
            Console.WriteLine(manager.GetAllSubjects());
            Console.WriteLine(manager.GetAllClasses());

            //var lærer1 = new Teacher("Marit");
            //var matte = new Subject("Math", room, lærer1);
            //var gym = new Subject("PE", room, lærer1);
            //var TiBfag = new[] { matte };
            //var klasse = new Class("10B", TiBfag);
            //var student = new Student("Eva Jolie", klasse);
            //var gymList = new[] { gym };
            //student.AddSubjects(gymList);

            //Console.WriteLine("Alle fag er : "+manager.GetAllSubjects()+"\nAlle lærerne er : "+manager.GetAllTeachers());

            //Console.WriteLine($"Lærer {lærer1.GetName()} har {matte.GetName()} med klasse {klasse.GetName()} som har 1 student, {student.GetName()} på rom {room.GetRoomName()}. Rommet er booket på følgende tider {room.GetBookedTimes()}");
            //Console.WriteLine(student.GetSubjects()[0].GetName());
        }
    }

    /*
     *  Klasse - fag, Elev
     *  Elev - navn, valgfag, klasse
     *  Fag - navn, rom, tid, lærer
     *  Lærer - navn, fag
     * /
    /*
     *Terje — 23/11/2023 11:25
       Bare tenk hel konkret. Velg deg et scenario. Per, Pål, Espen er studenter. 
       Per tar A og B, Pål, B og C, Espen tar A og C. Lærerne er Anders, Bente og Cecilie.
       Opprett studenter, lærere og påmeldinger.
       Hardkod scenarioet. Hvordan registrere karakter?
       Hvordan lage deltakerlist for et kurs?
       Hvis du trenger mer, legg inn timeplan
       Vis timeplan til en student
       Vis timeplan til en lærer
       Vis timeplan til et kurs.
     */
}


/*
 * var math = new Subject("Math", 0, 2);
   var pe = new Subject("Math", 0, 4);
   var science = new Subject("Math", 3, 0);
   
   var subjectsArray = new Subject[] { math, pe, science };
   var grade8 = new Class("Grade 8", subjectsArray);
 */