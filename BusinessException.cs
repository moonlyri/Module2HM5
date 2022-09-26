namespace Module2HM6
{
    internal class BusinessException : Exception
    {
        private BusinessException _exception;
        private string exception;

        public BusinessException(string ex)
        {
            this.exception = ex;
        }
    }
}

