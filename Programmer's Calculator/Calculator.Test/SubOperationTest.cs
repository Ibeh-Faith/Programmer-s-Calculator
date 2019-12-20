using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Test
{
    class SubOperationTest
    {
        [Test]
        public void SubOperationTest1()
        {
            Numbers.Number a = new Numbers.Binary("110", true);
            Numbers.Number b = new Numbers.Binary("011", true);
            Operations.Operation res = new Operations.SubOperation();
            string expected = "-011";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SubOperationTest2()
        {
            Numbers.Number a = new Numbers.Binary("011");
            Numbers.Number b = new Numbers.Binary("110");
            Operations.Operation res = new Operations.SubOperation();
            string expected = "-011";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SubOperationTest3()
        {
            Numbers.Number a = new Numbers.Binary("011", true);
            Numbers.Number b = new Numbers.Binary("110", true);
            Operations.Operation res = new Operations.SubOperation();
            string expected = "011";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SubOperationTest4()
        {
            Numbers.Number a = new Numbers.Binary("1100", true);
            Numbers.Number b = new Numbers.Binary("10101010");
            Operations.Operation res = new Operations.SubOperation();
            string expected = "-10110110";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SubOperationTest5()
        {
            Numbers.Number a = new Numbers.Binary("110", true);
            Numbers.Number b = new Numbers.Binary("011", true);
            Operations.Operation res = new Operations.SubOperation();
            string expected = "-011";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SubOperationTest6()
        {
            Numbers.Number a = new Numbers.Binary("110", true);
            Numbers.Number b = new Numbers.Binary("110", true);
            Operations.Operation res = new Operations.SubOperation();
            string expected = "0";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SubOperationTest7()
        {
            Numbers.Number a = new Numbers.Binary("011", true);
            Numbers.Number b = new Numbers.Binary("110", true);
            Operations.Operation res = new Operations.SubOperation();
            string expected = "011";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SubOperationTest8()
        {
            Numbers.Number a = new Numbers.Binary("0");
            Numbers.Number b = new Numbers.Binary("0");
            Operations.Operation res = new Operations.SubOperation();
            string expected = "0";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SubOperationTest9()
        {
            Numbers.Number a = new Numbers.Binary("101", true);
            Numbers.Number b = new Numbers.Binary("011");
            Operations.Operation res = new Operations.SubOperation();
            string expected = "-1000";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SubOperationTest10()
        {
            Numbers.Number a = new Numbers.Binary("101");
            Numbers.Number b = new Numbers.Binary("11", true);
            Operations.Operation res = new Operations.SubOperation();
            string expected = "1000";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SubOperationTest11()
        {
            Numbers.Number a = new Numbers.Binary("011", true);
            Numbers.Number b = new Numbers.Binary("110");
            Operations.Operation res = new Operations.SubOperation();
            string expected = "-1001";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SubOperationTest12()
        {
            Numbers.Number a = new Numbers.Binary("011");
            Numbers.Number b = new Numbers.Binary("110", true);
            Operations.Operation res = new Operations.SubOperation();
            string expected = "1001";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}
