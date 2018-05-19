using System;

namespace Task2
{
    class ExceedingTheAllowedValue : Exception
    {
        public ExceedingTheAllowedValue()
        { }

        public ExceedingTheAllowedValue(string message)
            : base(message)
        { }
    }
}
