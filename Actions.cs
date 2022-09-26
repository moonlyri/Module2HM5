using System;
namespace Module2HM6
{
    public class Actions
    {
        private FileService _logger = Logger.GetInstance();
        public Result Method1()
        {
            var item = new LogItem(DateTime.Now, "Start method: Method1", LogType.Info);
            _logger.File(item);
            return new Result(true);
        }
        
        public Result Method2()
        {
            throw new BusinessException("Skipped logic in method: Method 2");
        }

        public Result Method3()
        {
            throw new Exception("I broke a logic");
        }

    }
}

