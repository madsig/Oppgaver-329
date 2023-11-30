namespace OppB
{

    internal class Room
    {
        private string _roomName;
        private List<string> _times = new List<string>() { "08:00", "09:00", "10:00", "11:00", "12:30", "13:30", "14:30" };
        private List<string> _bookedTimes = new List<string>();
        private string _subject;


        public Room(string roomName)
        {
            _roomName = roomName;
        }

        public bool BookNextAvailableTime(string subject)
        {
            foreach (string t in _times)
            {
                if (!_bookedTimes.Contains(t))
                {
                    _bookedTimes.Add(t);
                    _subject = subject;
                    return true;
                }
            }
            return false;

        }

        public string GetRoomName()
        {
            return _roomName;
        }

        public string GetBookedTimes()
        {
            string result = "";
            foreach (string t in _bookedTimes) { result += " "+t; }
            return result;
        }
        

        
    }

}