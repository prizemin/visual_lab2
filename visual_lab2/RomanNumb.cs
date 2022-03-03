using System;

namespace VisualLab2
{
    public class RomanNumb : ICloneable, IComparable
    {
        private readonly ushort numb;

        public RomanNumb(ushort n)
        {
            if (n <= 0)
            {
                throw new RomanNumbExc();
            }
            numb = n;
        }
        public static RomanNumb Add(RomanNumb? n1, RomanNumb? n2)
        {
            return new RomanNumb((ushort)(n1.numb + n2.numb));
        }
        public static RomanNumb Sub(RomanNumb? n1, RomanNumb? n2)
        {
            if (n1.numb <= n2.numb) throw new RomanNumbExc();
            return new RomanNumb((ushort)(n1.numb - n2.numb));
        }
        public static RomanNumb Mul(RomanNumb? n1, RomanNumb? n2)
        {
            return new RomanNumb((ushort)(n1.numb * n2.numb));
        }
        public static RomanNumb Div(RomanNumb? n1, RomanNumb? n2)
        {
            return new RomanNumb((ushort)(n1.numb / n2.numb));
        }
        public override string ToString()
        {
            return toRoman(numb);
        }
        private static string toRoman(int number)
        {
            if (number < 1) return string.Empty;
            if (number >= 1000) return "M" + toRoman(number - 1000);
            if (number >= 900) return "CM" + toRoman(number - 900);
            if (number >= 500) return "D" + toRoman(number - 500);
            if (number >= 400) return "CD" + toRoman(number - 400);
            if (number >= 100) return "C" + toRoman(number - 100);
            if (number >= 90) return "XC" + toRoman(number - 90);
            if (number >= 50) return "L" + toRoman(number - 50);
            if (number >= 40) return "XL" + toRoman(number - 40);
            if (number >= 10) return "X" + toRoman(number - 10);
            if (number >= 9) return "IX" + toRoman(number - 9);
            if (number >= 5) return "V" + toRoman(number - 5);
            if (number >= 4) return "IV" + toRoman(number - 4);
            if (number >= 1) return "I" + toRoman(number - 1);
            throw new RomanNumbExc();
        }

        public object Clone()
        {
            return new RomanNumb(numb);
        }

        public int CompareTo(object obj)
        {
            if (obj is RomanNumb num) return numb.CompareTo(num.numb);
            else throw new RomanNumbExc("Некорректное значение аргумента");
        }

    }
}