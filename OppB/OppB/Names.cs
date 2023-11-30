namespace OppB
{
    internal class Names
    {
        Random random = new Random();
      

        private List<string> _listOfAllNames = new List<string>{
            "Anna Andersen", "Bjørn Berg", "Caroline Christensen", "David Dahl", "Eva Eriksen",
            "Fredrik Fredriksen", "Gunnar Gundersen", "Hilde Hansen", "Ivar Iversen", "Julia Johansen",
            "Karl Kristensen", "Linda Larsen", "Magnus Madsen", "Nina Nygaard", "Ole Olsen",
            "Pia Pedersen", "Quentin Qvist", "Rita Rasmussen", "Stian Solberg", "Tina Torgersen",
            "Ulrik Ulriksen", "Vilde Vang", "William Wold", "Xander Xanderesen", "C-72x Ytterbø",
            "Zara Zachariassen", "Åse Åsnes", "Øystein Østensen", "Åsa Åsberg", "Älva Älvgren", "Xf0-/C#"
        };

        private List<string> _listOfAllSubjects = new List<string>
        {
            "Androidteknologi", "Rettsvitenskap for kunstige intelligenser", "Fremtidens bioetikk",
            "Kunstig empati og samhandling", "Urban design i dystopiske miljøer",
            "Off-world kolonialisering", "Syntetisk språklingvistikk", "Skyggehistorie og konspirasjonsteorier",
            "Neonbelysningsteknikker", "Postapokalyptisk psykologi",
            "Cybernetisk medisin", "Teknologisk avhengighet og avvenning", "Virtuelle verdener og drømmeanalyse",
            "Avansert replikantfysiologi", "Kunstig intelligens og følelser", "Dystopisk litteratur",
            "Eksistensiell robotfilosofi", "Teknologidrevet kunst og estetikk", "Transhumanistisk etikk",
            "Risikovurdering av kunstige livsformer"
        };
        
        public string GetName() 
        {
            var index = random.Next(_listOfAllNames.Count());
            var name = _listOfAllNames[index];
            _listOfAllNames.RemoveAt(index);
            return name; 
        }

        public string GetRandomSubjectName()
        {
            
            var index = random.Next(_listOfAllSubjects.Count());
            var subjectName = _listOfAllSubjects[index];
            _listOfAllSubjects.RemoveAt(index);
            return subjectName;

        }
    }




}