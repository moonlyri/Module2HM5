using System;
namespace Module2HM6
{
    public class FileService
    {
        private LogItem _head;
        private LogItem _current;

        public LogItem Storage
        {
            get { return _head; }
        }

        private static FileService _instance;

        public FileService() { }

        public static FileService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new FileService();
            }

            return _instance;
        }
        public void File(LogItem item)
        {
            if (_head == null)
            {
                _head = item;
                _current = _head;
            }
            else
            {
                _current.Next = item;
                _current = _current.Next;
            }
        }
    }
}