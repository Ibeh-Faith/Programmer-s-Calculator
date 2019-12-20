using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Calculator.Test
{
    public class MultiplyTest
    {
        [Test]
        public void TestMultiply1()
        {
            Numbers.Number a = new Numbers.Binary("101010");
            Numbers.Number b = new Numbers.Binary("10");
            Operations.Operation res = new Operations.MultiplyOperation();
            string expected = "1010100";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMultiply2()
        {
            Numbers.Number a = new Numbers.Binary("101010");
            Numbers.Number b = new Numbers.Binary("11001100");
            Operations.Operation res = new Operations.MultiplyOperation();
            string expected = "10000101111000";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMultiply3()
        {
            Numbers.Number a = new Numbers.Binary("1111");
            Numbers.Number b = new Numbers.Binary("1111");
            Operations.Operation res = new Operations.MultiplyOperation();
            string expected = "11100001";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMultiply4()
        {
            Numbers.Number a = new Numbers.Binary("0000");
            Numbers.Number b = new Numbers.Binary("1111");
            Operations.Operation res = new Operations.MultiplyOperation();
            string expected = "0";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMultiply5()
        {
            Numbers.Number a = new Numbers.Binary("0");
            Numbers.Number b = new Numbers.Binary("1");
            Operations.Operation res = new Operations.MultiplyOperation();
            string expected = "0";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMultiply6()
        {
            Numbers.Number a = new Numbers.Binary("1");
            Numbers.Number b = new Numbers.Binary("0");
            Operations.Operation res = new Operations.MultiplyOperation();
            string expected = "0";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMultiply7()
        {
            Numbers.Number a = new Numbers.Binary("101010", true);
            Numbers.Number b = new Numbers.Binary("10");
            Operations.Operation res = new Operations.MultiplyOperation();
            string expected = "-1010100";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMultiply8()
        {
            Numbers.Number a = new Numbers.Binary("101010", true);
            Numbers.Number b = new Numbers.Binary("11001100");
            Operations.Operation res = new Operations.MultiplyOperation();
            string expected = "-10000101111000";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMultiply9()
        {
            Numbers.Number a = new Numbers.Binary("1111", true);
            Numbers.Number b = new Numbers.Binary("1111");
            Operations.Operation res = new Operations.MultiplyOperation();
            string expected = "-11100001";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMultiply10()
        {
            Numbers.Number a = new Numbers.Binary("0000", true);
            Numbers.Number b = new Numbers.Binary("1111");
            Operations.Operation res = new Operations.MultiplyOperation();
            string expected = "0";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMultiply11()
        {
            Numbers.Number a = new Numbers.Binary("0", true);
            Numbers.Number b = new Numbers.Binary("1");
            Operations.Operation res = new Operations.MultiplyOperation();
            string expected = "0";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMultiply12()
        {
            Numbers.Number a = new Numbers.Binary("1", true);
            Numbers.Number b = new Numbers.Binary("0");
            Operations.Operation res = new Operations.MultiplyOperation();
            string expected = "0";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMultiply13()
        {
            Numbers.Number a = new Numbers.Binary("1");
            Numbers.Number b = new Numbers.Binary("1");
            Operations.Operation res = new Operations.MultiplyOperation();
            string expected = "1";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMultiply14()
        {
            Numbers.Number a = new Numbers.Binary("1", true);
            Numbers.Number b = new Numbers.Binary("1");
            Operations.Operation res = new Operations.MultiplyOperation();
            string expected = "-1";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMultiply15()
        {
            Numbers.Number a = new Numbers.Binary("1000", true);
            Numbers.Number b = new Numbers.Binary("10000", true);
            Operations.Operation res = new Operations.MultiplyOperation();
            string expected = "10000000";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMultiply16()
        {
            Numbers.Number a = new Numbers.Binary("1000");
            Numbers.Number b = new Numbers.Binary("10000", true);
            Operations.Operation res = new Operations.MultiplyOperation();
            string expected = "-10000000";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}
