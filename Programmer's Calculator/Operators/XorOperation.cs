using System;
using System.Collections.Generic;
using System.Text;
using Numbers;


namespace Operations
{
  public  class XorOperation:Operation
    {
        public XorOperation()
        {

        }
        public XorOperation(string bits) : base(bits)
        {

        }
        public XorOperation(string bits, bool signed) : base(bits, signed)
        {

        }

        /// <summary>
        /// This method overrides ToString() function
        /// </summary>
        /// <param name="num2">Second value </param>
        /// <returns>value after performing XOR operation</returns>
        public override string ToString()
        {
            return base.ToString();
        }

        /// <summary>
        /// This method performs and operation to the values given by user (num1, num2)
        /// </summary>
        /// <param name="num2">Second value to XOR operation</param>
        /// <returns>the value after performing XOR operation</returns>
        public override Number Calculate(Number num1, Number num2)
        {

            char[] a = num1.GetNumber(num1).ToCharArray();
            char[] b = num2.GetNumber(num2).ToCharArray();

            // checks for the maximum length
            int len = a.Length > b.Length ? a.Length : b.Length; 
            char[] c = new char[len];
            int k = 0;
            //Null object or empty array checking
            if (num2 is null || this is null || a.Length == 0 || b.Length == 0)
            {
                throw new ArgumentNullException();

            }

            for (int i = len; i > 0; i--)
            {
                int aIndex = a.Length - i;
                int bIndex = b.Length - i;
                char bitA;
                char bitB;

                //appends 0 if the length of first number is smaller than the 
                //second number or vice versa
                bitA = aIndex >= 0 ? a[aIndex] : '0';
                bitB = bIndex >= 0 ? b[bIndex] : '0';
                if (bitA != bitB)
                {
                    c[k] = '1';
                    k++;

                }
                else
                {

                    c[k] = '0';
                    k++;
                }
            }
            string e = new string(c);
            return new Binary(e);
        }
    }
}
