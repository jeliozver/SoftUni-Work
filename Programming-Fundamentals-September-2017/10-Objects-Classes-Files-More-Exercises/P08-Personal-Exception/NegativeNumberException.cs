namespace P08_Personal_Exception
{
    using System;

    [Serializable]
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException()
        { }

        public NegativeNumberException(string message)
            : base(message)
        { }

        public NegativeNumberException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}