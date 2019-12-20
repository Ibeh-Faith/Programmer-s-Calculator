using System;
using System.Collections.Generic;
using System.Text;
using Numbers;

namespace Convertors
{
    public class HexConvertor : Convertor
    {
        private readonly string _hex;
        public HexConvertor(string hex)

        {
            _hex = hex;
        }
        public override string ToString()

        {
            return _hex;
        }
        private static readonly Dictionary<char, string> hex2Binary = new Dictionary<char, string> {
            { '0', "0000" },
            { '1', "0001" },
            { '2', "0010" },
            { '3', "0011" },
            { '4', "0100" },
            { '5', "0101" },
            { '6', "0110" },
            { '7', "0111" },
            { '8', "1000" },
            { '9', "1001" },
            { 'a', "1010" },
            { 'b', "1011" },
            { 'c', "1100" },
            { 'd', "1101" },
            { 'e', "1110" },
            { 'f', "1111" }
        };

        public override Binary ToBinary()
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in _hex)
            {
                result.Append(hex2Binary[char.ToLower(c)]);
            }
            return new Binary(result.ToString());
        }

        public override Octal ToOctal()
        {
            return new Octal(_hex);
        }

        public override Hexadecimal ToHexadecimal()
        {
            return new Hexadecimal(_hex);
        }
    }
}