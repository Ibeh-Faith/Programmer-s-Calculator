using System;

using Numbers;
namespace Operations
{
    public abstract class Operation : Object
    {
        private string _bits;
        private bool _signed;

        protected Operation()
        {

        }
        protected Operation(string bits)
        {
            _bits = bits;
        }

        protected Operation(string bits, bool signed )
        {
            _bits = bits;
            _signed = signed;
        }

        public override string ToString()
        {
            return _signed ? $"-{_bits}" : _bits;
        }

        public abstract Number Calculate(Number num1, Number num2);
    }
}
