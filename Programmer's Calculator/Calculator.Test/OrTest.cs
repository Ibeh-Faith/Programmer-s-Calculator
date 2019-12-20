using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Calculator.Test
{
    class OrTest
    {
        [Test]
        public void OrOperationTest1()
        {
            Numbers.Number a = new Numbers.Binary("01110");
            Numbers.Number b = new Numbers.Binary("11100");
            Operations.Operation res = new Operations.OrOperation();
            string expected = "11110";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void OrOperationTest2()
        {
            Numbers.Number a = new Numbers.Binary("01011010");
            Numbers.Number b = new Numbers.Binary("110001111");
            Operations.Operation res = new Operations.OrOperation();
            string expected = "111011111";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void OrOperationTest3()
        {
            Numbers.Number a = new Numbers.Binary("110001011");
            Numbers.Number b = new Numbers.Binary("111");
            Operations.Operation res = new Operations.OrOperation();
            string expected = "110001111";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void OrOperationTest4()
        {
            Numbers.Number a = new Numbers.Binary("01011011010111");
            Numbers.Number b = new Numbers.Binary("1100");
            Operations.Operation res = new Operations.OrOperation();
            string expected = "01011011011111";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void OrOperationTest5()
        {
            Numbers.Number a = new Numbers.Binary("1010111100");
            Numbers.Number b = new Numbers.Binary("1110011");
            Operations.Operation res = new Operations.OrOperation();
            string expected = "1011111111";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void OrOperationTest6()
        {
            Numbers.Number a = new Numbers.Binary("1010");
            Numbers.Number b = new Numbers.Binary("11100");
            Operations.Operation res = new Operations.OrOperation();
            string expected = "11110";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void OrOperationTest7()
        {
            Numbers.Number a = new Numbers.Binary("10111011");
            Numbers.Number b = new Numbers.Binary("1110011101");
            Operations.Operation res = new Operations.OrOperation();
            string expected = "1110111111";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void OrOperationTest8()
        {
            Numbers.Number a = new Numbers.Binary("101011100011");
            Numbers.Number b = new Numbers.Binary("111001");
            Operations.Operation res = new Operations.OrOperation();
            string expected = "101011111011";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void OrOperationTest9()
        {
            Numbers.Number a = new Numbers.Binary("1010110011110");
            Numbers.Number b = new Numbers.Binary("1110010");
            Operations.Operation res = new Operations.OrOperation();
            string expected = "1010111111110";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void OrOperationTest10()
        {
            Numbers.Number a = new Numbers.Binary("10101010110");
            Numbers.Number b = new Numbers.Binary("111001");
            Operations.Operation res = new Operations.OrOperation();
            string expected = "10101111111";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
       
       
       
        
        
    }
}
