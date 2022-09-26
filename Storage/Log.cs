using System;
namespace Module2HM6
{
    public class Log
    {
        private string _message;
        private LogType _type;
        public string Message
        {
            get { return _message; }
        }
        public LogType Type
        {
            get { return _type; }
        }
        public Log(string message, LogType type)
        {
            _message = message;
            _type = type;
        }
    }
}

