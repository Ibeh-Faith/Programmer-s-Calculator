using System;
using System.Collections.Generic;
using System.Text;

namespace Numbers
{
    public class Hexadecimal : Number
    {
        private string _bits;
        private bool _signed;

        public Hexadecimal()
        {

        }
        public Hexadecimal(string bits) : base(bits)
        {
            _bits = bits;
        }

        public Hexadecimal(string bits, bool signed) : base(bits, signed)
        {
            _bits = bits;
            _signed = signed;
        }

        public string Bits
        {
            get
            {
                return this._bits;
            }
            set
            {
                this._bits = value;
            }
        }

        public bool Signed
        {
            get
            {
                return this._signed;
            }
            set
            {
                this._signed = value;
            }
        }

        /// <summary>
        /// This method overrides ToString() function
        /// </summary>
        /// <returns>Hexadecimal value</returns>
        public override string ToString()
        {
            return _signed ? $"-{_bits}" : _bits;
        }

        /// <summary>
        /// This method assigns the input value to this class variable _bits
        /// </summary>
        /// <param name="inputValue">Input value entered by the user</param>
        /// <returns></returns>
        public override void AssignInputValue(string inputValue)
        {
            _bits = inputValue;
            if (inputValue.Contains('-')) _signed = true;
        }

        public override void AssignInputValue(string inputValue, bool sign)
        {
            _bits = inputValue;
            _signed = sign;
        }

        public override string GetNumber(Number number)
        {
            return Bits;
        }
        public override bool GetSign(Number number)
        {
            return Signed;
        }
    }
}
