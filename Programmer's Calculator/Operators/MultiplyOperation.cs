using System;
using System.Collections.Generic;
using System.Text;
using Numbers;

namespace Operations
{
    public class MultiplyOperation : Operation
    {
        public MultiplyOperation()
        {

        }
        public MultiplyOperation(string bits) : base(bits)
        {

        }
        public MultiplyOperation(string bits, bool signed) : base(bits, signed)
        {

        }

        /// <summary>
        /// This method overrides ToString() function
        /// </summary>
        /// <param name="other">Second value to multiply</param>
        /// <returns>multiplication value with/without signed</returns>
        public override string ToString()
        {
            return base.ToString();
        }

        /// <summary>
        /// This method multiplys two values given by user (this, other)
        /// </summary>
        /// <param name="other">Second value to multiply</param>
        /// <returns>Multiply object</returns>
        public override Number Calculate(Number num1, Number num2)
        {
            char[] a = num1.GetNumber(num1).ToCharArray();
            char[] b = num2.GetNumber(num2).ToCharArray();
            int[] c = new int[a.Length + b.Length];
            int[] d = new int[a.Length + b.Length];

            //Null object or empty array checking
            if (num2 is null || this is null || a.Length == 0 || b.Length == 0)
            {
                num2.AssignInputValue("");
                return num2;
            }

            for (int i = 0; i < b.Length; i++)
            {
                int bIndex = b.Length - 1 - i;
                char bitA, bitB;
                bitB = bIndex >= 0 ? b[bIndex] : '0';
                if (bitB != '0' && i == 0)
                {
                    for (int j = 0; j < c.Length - i; j++)
                    {
                        int aIndex = a.Length - 1 - j;
                        bitA = aIndex >= 0 ? a[aIndex] : '0';
                        c[c.Length - j - 1 - i] = bitA == '0' ? 0 : 1;
                    }
                }
                if (bitB == '0' && i != 0 && (a.Length > 1 || b.Length > 1))
                {
                    for (int j = 0; j < d.Length; j++) d[j] = 0;
                }
                if (bitB != '0' && i != 0 && (a.Length > 1 || b.Length > 1))
                {
                    for (int j = 0; j < i; j++)
                    {
                        d[d.Length - 1 - j] = 0;
                    }
                    for (int j = 0; j < d.Length - i; j++)
                    {
                        int aIndex = a.Length - 1 - j;
                        bitA = aIndex >= 0 ? a[aIndex] : '0';
                        d[d.Length - j - 1 - i] = bitA == '0' ? 0 : 1;
                    }
                }
                string s1 = string.Join("", c);
                string s2 = string.Join("", d);
                Number m1 = new Binary(s1);
                Number m2 = new Binary(s2);
                Operation ab = new AddOperation();
                var m3 = ab.Calculate(m1, m2).ToString();
                for (int k = 0; k < m3.Length; k++)
                {
                    c[k] = m3[k] - '0';
                }
            }
            bool first = true;
            var sb = new StringBuilder();
            int countZeros = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (first)
                {
                    if (c[i] != 0)
                    {
                        first = false;
                        sb.Append((char)(c[i] + '0'));
                        continue;
                    }
                    else countZeros++;
                }
                else sb.Append((char)(c[i] + '0'));
                if (countZeros == c.Length) sb.Append((char)(c[i] + '0'));
            }
            //Console.WriteLine("Multiply: " + sb.ToString());

            if (((!num1.GetSign(num1) && !num2.GetSign(num2)) || (num1.GetSign(num1) && num2.GetSign(num2))) || (countZeros == c.Length)) return new Binary(sb.ToString());
            else return new Binary(sb.ToString(), true);
        }
    }
}
