using System;
using System.Collections.Generic;
using System.Text;
using Numbers;

namespace Convertors
{
    public abstract class Convertor : IConvertor
    {
        public abstract Binary ToBinary();
        public abstract Octal ToOctal();
        public abstract Hexadecimal ToHexadecimal();

    }
}
