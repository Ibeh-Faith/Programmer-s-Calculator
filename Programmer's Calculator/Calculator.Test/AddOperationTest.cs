using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;


namespace Calculator.Test
{
    class AddOperationTest
    {
        [Test]
        public void AddOperationTest1()
        {
            Numbers.Number a = new Numbers.Binary("10101010", true);
            Numbers.Number b = new Numbers.Binary("11110000", true);
            Operations.Operation res = new Operations.AddOperation();
            string expected = "-110011010";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddOperationTest2()
        {
            Numbers.Number a = new Numbers.Binary("101");
            Numbers.Number b = new Numbers.Binary("011");
            Operations.Operation res = new Operations.AddOperation();
            string expected = "1000";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AddOperationTest3()
        {
            Numbers.Number a = new Numbers.Binary("110", true);
            Numbers.Number b = new Numbers.Binary("011", true);
            Operations.Operation res = new Operations.AddOperation();
            string expected = "-1001";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AddOperationTest4()
        {
            Numbers.Number a = new Numbers.Binary("110");
            Numbers.Number b = new Numbers.Binary("011", true);
            Operations.Operation res = new Operations.AddOperation();
            string expected = "011";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AddOperationTest5()
        {
            Numbers.Number a = new Numbers.Binary("0");
            Numbers.Number b = new Numbers.Binary("0");
            Operations.Operation res = new Operations.AddOperation();
            string expected = "0";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AddOperationTest6()
        {
            Numbers.Number a = new Numbers.Binary("110", true);
            Numbers.Number b = new Numbers.Binary("110");
            Operations.Operation res = new Operations.AddOperation();
            string expected = "0";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AddOperationTest7()
        {
            Numbers.Number a = new Numbers.Binary("110", true);
            Numbers.Number b = new Numbers.Binary("011");
            Operations.Operation res = new Operations.AddOperation();
            string expected = "-011";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AddOperationTest8()
        {
            Numbers.Number a = new Numbers.Binary("011", true);
            Numbers.Number b = new Numbers.Binary("110");
            Operations.Operation res = new Operations.AddOperation();
            string expected = "011";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AddOperationTest9()
        {
            Numbers.Number a = new Numbers.Binary("110");
            Numbers.Number b = new Numbers.Binary("011", true);
            Operations.Operation res = new Operations.AddOperation();
            string expected = "011";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AddOperationTest10()
        {
            Numbers.Number a = new Numbers.Binary("011");
            Numbers.Number b = new Numbers.Binary("110", true);
            Operations.Operation res = new Operations.AddOperation();
            string expected = "-011";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}
