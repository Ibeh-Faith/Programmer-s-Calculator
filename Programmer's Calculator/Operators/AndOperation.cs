using System;
using System.Collections.Generic;
using System.Text;
using Numbers;

namespace Operations
{
   public class AndOperation :Operation
    {
        public AndOperation()
        {

        }
        public AndOperation(string bits) : base(bits)
        {

        }
        public AndOperation(string bits, bool signed) : base(bits, signed)
        {

        }
        /// <summary>
        /// This method overrides ToString() function
        /// </summary>
        /// <param name="num2">Second value </param>
        /// <returns>value after performing AND operation</returns>
        public override string ToString()
        {
            return base.ToString();
        }



        /// <summary>
        /// This method performs and operation to the values given by user (num1, num2)
        /// </summary>
        /// <param name="num2">Second value to AND operation</param>
        /// <returns>the value after performing AND operation</returns>

        public override Number Calculate (Number num1, Number num2)
        {

            char[] x = num1.GetNumber(num1).ToCharArray();
            char[] y = num2.GetNumber(num1).ToCharArray();
           
            // checks for the maximum length
            int len = x.Length > y.Length ? x.Length : y.Length; 
            char[] z = new char[len];
            int j = 0;

            //Null object or empty array checking
            if (num2 is null || this is null || x.Length == 0 || y.Length == 0)
            {
                throw new ArgumentNullException();
                
            }

            for (int i = len; i > 0; i--)
            {
                int xIndex = x.Length - i;
                int yIndex = y.Length - i;
                char bitX;
                char bitY;


                //appends 0 if the length of first number is smaller than the 
                //second number or vice versa
                bitX = xIndex >= 0 ? x[xIndex] : '0';
                bitY = yIndex >= 0 ? y[yIndex] : '0';
                if (bitX == '1' && bitY == '1')
                {
                    z[j] = '1';
                    j++;
                }
                else
                {
                    z[j] = '0';
                    j++;
                }
            }

            string e = new string(z);
            return new Binary(e);
        }
    }
}


