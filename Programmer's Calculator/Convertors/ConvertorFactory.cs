using System;
using System.Collections.Generic;
using System.Text;
using Numbers;

namespace Convertors
{
    public class ConvertorFactory
    {
        /// <summary>
        /// This method converts the number to the respective numbertype selected by the user
        /// </summary>
        /// <param name="sourceType">Source of the number type</param>
        /// <param name="number">Number entered by the user</param>
        /// <param name="targetType">Target of the number type</param>
        /// <returns>Number Object - Converted number</returns>
        public Number Convert(NumberType sourceType, Number number, NumberType targetType)
        {
            BinConvertor b = new BinConvertor(number.ToString());
            HexConvertor h = new HexConvertor(number.ToString());
            OctConvertor o = new OctConvertor(number.ToString());

            if (sourceType == Numbers.NumberType.Binary && targetType == Numbers.NumberType.Binary) return b.ToBinary();
            if (sourceType == Numbers.NumberType.Binary && targetType == Numbers.NumberType.Hexadecimal) return b.ToHexadecimal();
            if (sourceType == Numbers.NumberType.Binary && targetType == Numbers.NumberType.Octal) return b.ToOctal();

            if (sourceType == Numbers.NumberType.Hexadecimal && targetType == Numbers.NumberType.Binary) return h.ToBinary();
            if (sourceType == Numbers.NumberType.Hexadecimal && targetType == Numbers.NumberType.Hexadecimal) return h.ToHexadecimal();

            if (sourceType == Numbers.NumberType.Octal && targetType == Numbers.NumberType.Binary) return o.ToBinary();
            if (sourceType == Numbers.NumberType.Octal && targetType == Numbers.NumberType.Octal) return o.ToOctal();

            else return null;
        }
    }
}
