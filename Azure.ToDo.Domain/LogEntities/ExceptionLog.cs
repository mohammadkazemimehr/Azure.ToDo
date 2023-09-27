﻿namespace Azure.ToDo.Domain.LogEntities
{
    public class ExceptionLog
    {
        public ExceptionLog(string exception, string stackTrace)
        {
            Id = Guid.NewGuid();
            Exception = exception;
            StackTrace = stackTrace;
            Date = DateTime.Now;
        }

        public Guid Id { get; private set; }

        public string Exception { get; private set; }

        public string StackTrace { get; private set; }

        public DateTime Date { get; private set; }
    }
}
