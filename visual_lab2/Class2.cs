using System;

namespace VisualLab2
{
    public class RomanNumberException : Exception
    {
        public RomanNumberException() : base() { }
        public RomanNumberException(string mes) : base(mes) { }
    }
}
