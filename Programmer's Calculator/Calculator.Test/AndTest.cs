using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Calculator.Test
{
    public class AndTest
    {
        [Test]
        public void AndOperationTest1()
        {
            Numbers.Number a = new Numbers.Binary("011011");
            Numbers.Number b = new Numbers.Binary("11100");
            Operations.Operation res = new Operations.AndOperation();
            string expected = "011000";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }

        
       
        
        [Test]
        public void AndOperationTest3()
        {
            Numbers.Number a = new Numbers.Binary("01");
            Numbers.Number b = new Numbers.Binary("11100");
            Operations.Operation res = new Operations.AndOperation();
            string expected = "00000";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AndOperationTest4()
        {
            Numbers.Number a = new Numbers.Binary("01");
            Numbers.Number b = new Numbers.Binary("11100");
            Operations.Operation res = new Operations.AndOperation();
            string expected = "00000";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AndOperationTest5()
        {
            Numbers.Number a = new Numbers.Binary("01");
            Numbers.Number b = new Numbers.Binary("11100");
            Operations.Operation res = new Operations.AndOperation();
            string expected = "00000";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AndOperationTest6()
        {
            Numbers.Number a = new Numbers.Binary("01");
            Numbers.Number b = new Numbers.Binary("11100");
            Operations.Operation res = new Operations.AndOperation();
            string expected = "00000";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AndOperationTest7()
        {
            Numbers.Number a = new Numbers.Binary("01");
            Numbers.Number b = new Numbers.Binary("11100");
            Operations.Operation res = new Operations.AndOperation();
            string expected = "00000";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }


    }
}
