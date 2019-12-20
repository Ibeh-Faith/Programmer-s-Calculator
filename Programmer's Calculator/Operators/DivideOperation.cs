using System;
using System.Collections.Generic;
using System.Text;
using Numbers;

namespace Operations
{
    public class DivideOperation : Operation
    {
        public DivideOperation()
        {

        }
        public DivideOperation(string bits) : base(bits)
        {

        }
        public DivideOperation(string bits, bool signed) : base(bits, signed)
        {

        }

        /// <summary>
        /// This method overrides ToString() function
        /// </summary>
        /// <param name="other">Second value to divide</param>
        /// <returns>dividsion value with/without signed</returns>
        public override string ToString()
        {
            return base.ToString();
        }

        /// <summary>
        /// This method divides the two values given by user (this, other)
        /// </summary>
        /// <param name="other">Second value to divide</param>
        /// <returns>Divide object</returns>
        public override Number Calculate(Number num1, Number num2)
        {
                char[] a = num1.GetNumber(num1).ToCharArray();
                char[] b = num2.GetNumber(num2).ToCharArray();
                bool flag1 = true, flag2 = true;
                int t = 0, countZeros = 0;

                //Null object or empty array checking
                if (num2 is null || this is null || a.Length == 0 || b.Length == 0)
                {
                    throw new ArgumentNullException();
                    /*num2.AssignInputValue("");
                    return num2;*/
                }

                //Can't divide by zero 
                for (int z = 0; z < b.Length; z++)
                {
                    if (b[z] == '0') countZeros++;
                }
                if (countZeros == b.Length)
                {
                    throw new DivideByZeroException();
                }

                //Example for 2/7, return 0
                if (a.Length < b.Length)
                {
                    Console.Write("0");
                    return new Binary("0");
                }
                else
                {
                    if (a.Length == b.Length)
                    {
                        for (int i = 0; i < a.Length; i++)
                        {
                            if (a[i] < b[i])
                            {
                                flag1 = false;
                                break;
                            }
                        }
                    }
                    //E.g, 5/7, return 0
                    if (!flag1)
                    {
                        Console.Write("0");
                        return new Binary("0");
                    }
                    char[] c = new char[a.Length];

                    string q1_first = "0", q = "";

                    //if a.length > b.length e.g., a= 1010101 b = 100, then create new array and add zeros in the beginning.
                    if (a.Length > b.Length)
                    {
                        for (int i = 0; i < a.Length - b.Length; i++)
                        {
                            c[i] = '0';
                        }
                        for (int i = a.Length - b.Length; i < a.Length; i++)
                        {
                            c[i] = b[t];
                            t++;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < b.Length; i++)
                        {
                            c[i] = b[i];
                        }
                    }

                    string s1 = new string(a);
                    string s2 = new string(c);

                    while (flag2)
                    {
                        Number n1 = new Binary(s1);
                        Number n2 = new Binary(s2);
                        Operation op = new SubOperation();
                        Number rem = op.Calculate(n1, n2);
                        s1 = rem.GetNumber(rem);
                        Number q1 = new Binary(q1_first);
                        Number q2 = new Binary("1");
                        Operation op1 = new AddOperation();
                        Number quot = op1.Calculate(q1, q2);
                        q1_first = quot.GetNumber(quot);

                        char[] p1 = rem.GetNumber(rem).ToCharArray();
                        char[] p2 = s2.ToCharArray();

                        //check if num1 is greater than num2
                        for (int i = 0; i < a.Length; i++)
                        {
                            if (p1[i] > p2[i])
                            {
                                flag2 = true;
                                break;
                            }
                            else if (p1[i] < p2[i])
                            {
                                flag2 = false;
                                break;
                            }
                        }
                        q = quot.GetNumber(quot);
                    }
                    Console.Write(q);

                    if (((!num1.GetSign(num1) && !num2.GetSign(num2)) || (num1.GetSign(num1) && num2.GetSign(num2))) || (q == "0"))
                        return new Binary(q);
                    else
                        return new Binary(q, true);
                }
           
        }
    }
}
