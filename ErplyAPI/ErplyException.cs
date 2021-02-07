using System;
using System.Collections.Generic;
using System.Text;

namespace ErplyAPI
{
    public class ErplyException : Exception
    {
        public Status Status { get; }
        public ErplyException(Status status)
        { Status = status; }

        public ErplyException(Status status, string message) : base(message)
        { Status = status; }

        public ErplyException(Status status, string message, Exception inner) : base(message, inner)
        { Status = status; }

        public ErplyException(string message) : base(message)
        { }
        public ErplyException(string message, Exception inner) : base(message, inner)
        { }
    }
}
