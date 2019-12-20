using System;
using System.Collections.Generic;
using System.Text;
using Numbers;

namespace Convertors
{
    interface IConvertor
    {
        Binary ToBinary();
        Octal ToOctal();
        Hexadecimal ToHexadecimal();
    }
}
