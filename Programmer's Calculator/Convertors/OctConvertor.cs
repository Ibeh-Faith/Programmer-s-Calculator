using System;
using System.Collections.Generic;
using System.Text;
using Numbers;

namespace Convertors
{
    public class OctConvertor : Convertor
    {
        private readonly string _oct;
        public OctConvertor(string oct)

        {
            _oct = oct;
        }
        public override string ToString()

        {
            return _oct;
        }

        private static readonly Dictionary<char, string> oct2Binary = new Dictionary<char, string> {
            { '0', "0" },
            { '1', "001" },
            { '2', "010" },
            { '3', "011" },
            { '4', "100" },
            { '5', "101" },
            { '6', "110" },
            { '7', "111" }

        };

        public override Binary ToBinary()
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in _oct)
            {
                // This will crash for non-hex characters. You might want to handle that differently.
                result.Append(oct2Binary[char.ToLower(c)]);
            }
            return new Binary(result.ToString());
        }

        public override Octal ToOctal()
        {

            return new Octal(_oct);
        }

        public override Hexadecimal ToHexadecimal()
        {
            return new Hexadecimal(_oct);
        }
    }
}
