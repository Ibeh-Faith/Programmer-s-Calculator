using System;
using System.Collections.Generic;
using System.Text;
using Numbers;
using System.Linq;

namespace Operations
{
    public class SubOperation : Operation
    {
        public SubOperation()
        {

        }
        public SubOperation(string bits) : base(bits)
        {

        }
        public SubOperation(string bits, bool signed) : base(bits, signed)
        {

        }

        /// <summary>
        /// This method overrides ToString() function
        /// </summary>
        /// <param name="other">Second value to add</param>
        /// <returns>add value with/without signed</returns>
        public override string ToString()
        {
            return base.ToString();
        }

        /// <summary>
        /// This method subtract the two values given by user (this, other)
        /// </summary>
        /// <param name="other">Second value to Add</param>
        /// <returns>Add object</returns>
        public override Number Calculate(Number num1, Number num2)
        {
            char[] a = num1.GetNumber(num1).ToCharArray();
            char[] b = num2.GetNumber(num2).ToCharArray();

            //Null object or empty array checking
            if (num2 is null || this is null || a.Length == 0 || b.Length == 0)
            {
                num2.AssignInputValue("");
                return num2;
            }

            if ((num1.GetNumber(num1) == num2.GetNumber(num2)) && (num1.GetSign(num1) && num2.GetSign(num2)))
            {
                num2.AssignInputValue("0", false);
                return num2;
            }

            bool flag = false;
            int len = a.Length > b.Length ? a.Length : b.Length;

            if (b.Length > a.Length) flag = true;
            else if (b.Length == a.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] < b[i])
                    {
                        flag = true;
                        break;
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                }
            }
            else flag = false;

            a = num1.GetNumber(num1).PadLeft(b.Length, '0').ToCharArray();
            b = num2.GetNumber(num2).PadLeft(a.Length, '0').ToCharArray();

            if (flag)
            {
                for (int i = 0; i < len; i++)
                {
                    char temp = a[i];
                    a[i] = b[i];
                    b[i] = temp;
                }
            }

            for (int i = 0; i < len; i++)
            {
                if (b[i] == '0') b[i] = '1';
                else b[i] = '0';
            }

            Number add1 = new Binary(new String(b));
            Number add2 = new Binary("1");
            Operation addSum1 = new AddOperation();
            Number sum1 = addSum1.Calculate(add1, add2);

            Number add3 = new Binary(sum1.GetNumber(sum1));
            Number add4 = new Binary(new String(a));
            Operation addSum2 = new AddOperation();
            Number sum2 = addSum2.Calculate(add3, add4);
            char[] c = sum2.GetNumber(sum2).ToCharArray();
            if (c.Length > len)
            {
                for (int i = 0; i < len; i++)
                {
                    c[i] = c[i + 1];
                }
                c = c.Take(c.Length - 1).ToArray();
            }
            String p = new String(c);

            //this is for when both are signed
            if (num1.GetSign(num1) && num2.GetSign(num2) && !flag)
            {
                num2.AssignInputValue(p, true);
                return num2;
            }

            //this is for when this is signed and the other isn't
            if (num1.GetSign(num1) && !num2.GetSign(num2))
            {
                Number c1 = new Binary(num1.GetNumber(num1));
                Number c2 = new Binary(num2.GetNumber(num2));
                Operation a1 = new AddOperation();
                Number res = a1.Calculate(c1, c2);
                res.AssignInputValue(res.GetNumber(res), true);
                return res;
            }

            //this is for when this is not signed and the other is signed
            if (!num1.GetSign(num1) && num2.GetSign(num2))
            {
                Number c1 = new Binary(num1.GetNumber(num1));
                Number c2 = new Binary(num2.GetNumber(num2));
                Operation a1 = new AddOperation();
                Number res = a1.Calculate(c1, c2);
                return res;
            }
            if (flag && num1.GetSign(num1) && num2.GetSign(num2)) return new Binary(p);
            else if (flag) return new Binary(p, true);
            else return new Binary(p);
        }
    }
}
