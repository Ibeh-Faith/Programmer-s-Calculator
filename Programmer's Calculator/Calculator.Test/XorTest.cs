using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Calculator.Test
{
    class XorTest
    {
        [Test]
        public void XorOperationTest1()
        {
            Numbers.Number a = new Numbers.Binary("011100");
            Numbers.Number b = new Numbers.Binary("11100");
            Operations.Operation res = new Operations.XorOperation();
            string expected = "000000";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void XorOperationTest2()
        {
            Numbers.Number a = new Numbers.Binary("01001");
            Numbers.Number b = new Numbers.Binary("11100");
            Operations.Operation res = new Operations.XorOperation();
            string expected = "10101";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void XorOperationTest3()
        {
            Numbers.Number a = new Numbers.Binary("110011101100");
            Numbers.Number b = new Numbers.Binary("11100110");
            Operations.Operation res = new Operations.XorOperation();
            string expected = "110000001010";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void XorOperationTest4()
        {
            Numbers.Number a = new Numbers.Binary("11001011");
            Numbers.Number b = new Numbers.Binary("1101111");
            Operations.Operation res = new Operations.XorOperation();
            string expected = "10100100";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void XorOperationTest5()
        {
            Numbers.Number a = new Numbers.Binary("11001011001111");
            Numbers.Number b = new Numbers.Binary("1101111011");
            Operations.Operation res = new Operations.XorOperation();
            string expected = "11000110110100";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void XorOperationTest6()
        {
            Numbers.Number a = new Numbers.Binary("01011011");
            Numbers.Number b = new Numbers.Binary("111001");
            Operations.Operation res = new Operations.XorOperation();
            string expected = "01100010";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void XorOperationTest7()
        {
            Numbers.Number a = new Numbers.Binary("1");
            Numbers.Number b = new Numbers.Binary("1");
            Operations.Operation res = new Operations.XorOperation();
            string expected = "0";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void XorOperationTest8()
        {
            Numbers.Number a = new Numbers.Binary("0");
            Numbers.Number b = new Numbers.Binary("1");
            Operations.Operation res = new Operations.XorOperation();
            string expected = "1";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void XorOperationTest9()
        {
            Numbers.Number a = new Numbers.Binary("1");
            Numbers.Number b = new Numbers.Binary("0");
            Operations.Operation res = new Operations.XorOperation();
            string expected = "1";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AndOperationTest10()
        {
            Numbers.Number a = new Numbers.Binary("01011011001");
            Numbers.Number b = new Numbers.Binary("1110001110000");
            Operations.Operation res = new Operations.XorOperation();
            string expected = "1111010101001";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }


    }
}
