using System;
using System.Collections.Generic;
using System.Text;
using Numbers;
using System.Linq;

namespace Operations
{
    public class AddOperation : Operation
    {
        public AddOperation()
        {

        }
        public AddOperation(string bits) : base(bits)
        {

        }
        public AddOperation(string bits, bool signed) : base(bits, signed)
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
        /// This method add the two values given by user (this, other)
        /// </summary>
        /// <param name="other">Second value to Add</param>
        /// <returns>Add object</returns>
        public override Number Calculate(Number num1, Number num2)
        {

            char[] a = num1.GetNumber(num1).ToCharArray();
            char[] b = num2.GetNumber(num2).ToCharArray();
            bool flag = false;
            int len = a.Length > b.Length ? a.Length : b.Length; // maximum length

            if (num2 is null || this is null || a.Length == 0 || b.Length == 0)
            {
                num2.AssignInputValue("");
                return num2;
            }

            if ((num1.GetNumber(num1)== num2.GetNumber(num2)) && (num1.GetSign(num1) || num2.GetSign(num2)))
            {
                num2.AssignInputValue("0", false);
                return num2;
            }

            string result = "";
            int s = 0;

            int i = a.Length - 1, j = b.Length - 1;
            while (i >= 0 || j >= 0 || s == 1)
            {
                s += ((i >= 0) ? a[i] - '0' : 0);
                s += ((j >= 0) ? b[j] - '0' : 0);
                result = (char)(s % 2 + '0') + result;

                s /= 2;
                i--; j--;
            }
            //this is for when both are signed 
            if (num1.GetSign(num1) && num2.GetSign(num2))
            {
                num2.AssignInputValue(result, true);
                return num2;
            }

            //To know which number is greater
            if (b.Length > a.Length) flag = true;
            else if (b.Length == a.Length)
            {
                for (int x = 0; x < a.Length; x++)
                {
                    if (a[x] < b[x])
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

            //this is for when one is signed and the other isn't.
            if ((num1.GetSign(num1) && !num2.GetSign(num2)) || (!num1.GetSign(num1) && num2.GetSign(num2)))
            {
                Number c1 = new Binary(num1.GetNumber(num1));
                Number c2 = new Binary(num2.GetNumber(num2));
                Operation sp = new SubOperation();
                Number res = sp.Calculate(c1, c2);

                if (flag)
                {
                    if (num1.GetSign(num1) && !num2.GetSign(num2))
                        return new Binary(res.GetNumber(res), false);
                    else
                        return new Binary(res.GetNumber(res), true);
                }
                else
                {
                    if (!num1.GetSign(num1) && num2.GetSign(num2))
                        return res;
                    else
                        return new Binary(res.GetNumber(res), true);
                }
            }
            if (!num1.GetSign(num1) && num2.GetSign(num2))
            {
                Number c1 = new Binary(num1.GetNumber(num1));
                Number c2 = new Binary(num2.GetNumber(num2));
                Operation sp = new SubOperation();
                Number res = sp.Calculate(c1, c2);
                return res;
            }
            string p = new string(result);
            num2.AssignInputValue(p);
            return num2;
        }
    }
}
