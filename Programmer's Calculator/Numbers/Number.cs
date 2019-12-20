using System;
using System.Collections.Generic;
using System.Text;

namespace Numbers
{
    public abstract class Number
    {
        private string _bits;
        private bool _signed;

        public Number()
        {

        }

        public Number(string bits)
        {
            _bits = bits;
        }

        public Number(string bits, bool signed)
        {
            _bits = bits;
            _signed = signed;
        }

        public override string ToString()
        {
            return _signed ? $"-{_bits}" : _bits;
        }

        public abstract void AssignInputValue(string inputValue);
        public abstract void AssignInputValue(string inputValue, bool sign);
        public abstract string GetNumber(Number number);
        public abstract bool GetSign(Number number);
    }
}
