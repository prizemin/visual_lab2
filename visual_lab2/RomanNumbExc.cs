using System;

namespace VisualLab2
{
    public class RomanNumbExc : Exception
    {
        public RomanNumbExc() : base() { }
        public RomanNumbExc(string mes) : base(mes) { }
    }
}
