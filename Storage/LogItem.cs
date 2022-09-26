using System;
namespace Module2HM6
{
    public class LogItem
    {
        private string _message;
        private LogType _type;
        private DateTime _time;

        public LogItem Next { get; set; }

        public DateTime time
        {
            get { return _time; }
        }
      
        public string Message
        {
            get { return _message; }
        }

        public LogType Type
        {
            get { return _type; }
        }

        public LogItem(DateTime time, string message, LogType type)
        {
            _time = time;
            _message = message;
            _type = type;
        }
    }
}

