using System;
using System.Collections.Generic;
using System.Text;
using Numbers;
using System.Linq;

namespace Convertors
{
    public class BinConvertor : Convertor
    {
        private readonly string _bin;
        public BinConvertor(string bin)
        {
            _bin = bin;
        }
        public override string ToString()
        {
            return _bin;
        }

        private static readonly Dictionary<string, char> Bin2Oct = new Dictionary<string, char> {
            { "0", '0' },
            { "001", '1'},
            { "010", '2'},
            { "011", '3'},
            { "100", '4'},
            { "101", '5'},
            { "110", '6'},
            { "111", '7'}
        };

        private static readonly Dictionary<string, char> Hex2Binary = new Dictionary<string, char> {
            { "0000", '0' },
            { "0001", '1' },
            { "0010", '2' },
            { "0011", '3' },
            { "0100", '4' },
            { "0101", '5' },
            { "0110", '6' },
            { "0111", '7' },
            { "1000", '8' },
            { "1001", '9' },
            { "1010", 'a' },
            { "1011", 'b' },
            { "1100", 'c' },
            { "1101", 'd' },
            { "1110", 'e' },
            { "1111", 'f' }
        };

        public override Binary ToBinary()
        {
            Convertor bc = new BinConvertor(_bin);
            if (bc.ToString() is null || bc.ToString() == "" || bc.ToString().Length == 0) throw new ArgumentNullException();
            return new Binary(_bin);
        }

        public override Octal ToOctal()
        {
            Convertor bc = new BinConvertor(_bin);
            if (bc.ToString() is null || bc.ToString() == "" || bc.ToString().Length == 0) throw new ArgumentNullException();
            string b = ConvertToBinArray(bc.ToString());
            string[] binArray = Split1(b, 3);
            string result = "";
            foreach (string s in binArray)
            {
                if (Bin2Oct.ContainsKey(s))
                {
                    result += Bin2Oct[s];
                }
            }
            return new Octal(result);
        }

        public override Hexadecimal ToHexadecimal()
        {
            Convertor bc = new BinConvertor(_bin);
            if (bc.ToString() is null || bc.ToString() == "" || bc.ToString().Length == 0) throw new ArgumentNullException();
            string b = ConvertToBinArray1(bc.ToString());
            string[] binArray = Split1(b, 4);
            string result = "";
            foreach (string s in binArray)
            {
                if (Hex2Binary.ContainsKey(s))
                {
                    result += Hex2Binary[s];
                }
            }
            return new Hexadecimal(result);
        }

        public string ConvertToBinArray(string bin)
        {
            if (bin.Length % 3 != 0)
            {
                int r = bin.Length % 3;
                if (r == 2) bin = "0" + bin;
                else if (r == 1) bin = "00" + bin;
            }
            return bin;
        }

        public string ConvertToBinArray1(string bin)
        {
            if (bin.Length % 4 != 0)
            {
                int r = bin.Length % 4;
                if (r == 3) bin = "0" + bin;
                else if (r == 2) bin = "00" + bin;
                else if (r == 1) bin = "000" + bin;
            }
            return bin;
        }

        public static string[] Split1(string value, int desiredLength)
        {
            int numberOfItems = value.Length / desiredLength;

            int remaining = (value.Length > numberOfItems * desiredLength) ? 1 : 0;

            IList<string> splitted = new List<string>(numberOfItems + remaining);

            for (int i = 0; i < numberOfItems; i++)
            {
                splitted.Add(value.Substring(i * desiredLength, desiredLength));
            }

            if (remaining != 0)
            {
                splitted.Add(value.Substring(numberOfItems * desiredLength));
            }

            return splitted.ToArray();
        }
    }
}
