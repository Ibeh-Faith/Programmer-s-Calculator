using System;
using System.Collections.Generic;
using System.Text;
using Numbers;

namespace Operations
{
    public class OrOperation: Operation
    {
        public OrOperation()
        {

        }
        public OrOperation(string bits) : base(bits)
        {

        }
        public OrOperation(string bits, bool signed) : base(bits, signed)
        {

        }

        /// <summary>
        /// This method overrides ToString() function
        /// </summary>
        /// <param name="num2">Second value </param>
        /// <returns>value after performing OR operation</returns>
        public override string ToString()
        {
            return base.ToString();
        }

        /// <summary>
        /// This method performs and operation to the values given by user (num1, num2)
        /// </summary>
        /// <param name="num2">Second value to OR operation</param>
        /// <returns>the value after performing OR operation</returns>

        public override Number Calculate(Number num1, Number num2)
        {

            char[] q = num1.GetNumber(num1).ToCharArray();
            char[] r = num2.GetNumber(num2).ToCharArray();

            // checks for the maximum length
            int len = q.Length > r.Length ? q.Length : r.Length; 
            char[] s = new char[len];
            int j = 0;

            //Null object or empty array checking
            if (num2 is null || this is null || q.Length == 0 || r.Length == 0)
            {
                throw new ArgumentNullException();

            }

            for (int i = len; i > 0; i--)
            {
                int qIndex = q.Length - i;
                int rIndex = r.Length - i;
                char bitQ;
                char bitR;
                //appends 0 if the length of first number is smaller than the 
                //second number or vice versa
                bitQ = qIndex >= 0 ? q[qIndex] : '0';
                bitR = rIndex >= 0 ? r[rIndex] : '0';

                if (bitQ == '0' && bitR == '0')
                {
                    s[j] = '0';
                    
                    j++;
                   
                }
                else
                {
                    s[j] = '1'; 
                    j++;
                   
                }

            }


            string e = new string(s);
            return new Binary(e);


        }
    }
}
    

