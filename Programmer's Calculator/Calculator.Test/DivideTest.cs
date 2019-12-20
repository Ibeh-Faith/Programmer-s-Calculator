using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Calculator.Test
{
    public class DivideTest
    {
        [Test]
        public void TestDivide1()
        {
            Numbers.Number a = new Numbers.Binary("1000");
            Numbers.Number b = new Numbers.Binary("10");
            Operations.Operation res = new Operations.DivideOperation();
            string expected = "100";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestDivide2()
        {
            Numbers.Number a = new Numbers.Binary("10101010");
            Numbers.Number b = new Numbers.Binary("11001100");
            Operations.Operation res = new Operations.DivideOperation();
            string expected = "0";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestDivide3()
        {
            Numbers.Number a = new Numbers.Binary("11001100");
            Numbers.Number b = new Numbers.Binary("11001100");
            Operations.Operation res = new Operations.DivideOperation();
            string expected = "1";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestDivide4()
        {
            Numbers.Number a = new Numbers.Binary("11001100");
            Numbers.Number b = new Numbers.Binary("1100");
            Operations.Operation res = new Operations.DivideOperation();
            string expected = "10001";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestDivide5()
        {
            Numbers.Number a = new Numbers.Binary("0");
            Numbers.Number b = new Numbers.Binary("1");
            Operations.Operation res = new Operations.DivideOperation();
            string expected = "0";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestDivide6()
        {
            Numbers.Number a = new Numbers.Binary("1");
            Numbers.Number b = new Numbers.Binary("0");
            Operations.Operation res = new Operations.DivideOperation();
            Numbers.Number ans = null;
            Assert.Catch<DivideByZeroException>(() => ans = res.Calculate(a, b));
        }

        [Test]
        public void TestDivide7()
        {
            Numbers.Number a = new Numbers.Binary("1000", true);
            Numbers.Number b = new Numbers.Binary("10");
            Operations.Operation res = new Operations.DivideOperation();
            string expected = "-100";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestDivide8()
        {
            Numbers.Number a = new Numbers.Binary("10101010", true);
            Numbers.Number b = new Numbers.Binary("11001100");
            Operations.Operation res = new Operations.DivideOperation();
            string expected = "0";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestDivide9()
        {
            Numbers.Number a = new Numbers.Binary("11001100", true);
            Numbers.Number b = new Numbers.Binary("11001100");
            Operations.Operation res = new Operations.DivideOperation();
            string expected = "-1";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestDivide10()
        {
            Numbers.Number a = new Numbers.Binary("11001100", true);
            Numbers.Number b = new Numbers.Binary("1100");
            Operations.Operation res = new Operations.DivideOperation();
            string expected = "-10001";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestDivide11()
        {
            Numbers.Number a = new Numbers.Binary("0", true);
            Numbers.Number b = new Numbers.Binary("1");
            Operations.Operation res = new Operations.DivideOperation();
            string expected = "0";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestDivide12()
        {
            Numbers.Number a = new Numbers.Binary("1", true);
            Numbers.Number b = new Numbers.Binary("0");
            Operations.Operation res = new Operations.DivideOperation();
            Numbers.Number ans = null;
            Assert.Catch<DivideByZeroException>(() => ans = res.Calculate(a, b));
        }

        [Test]
        public void TestDivide13()
        {
            Numbers.Number a = new Numbers.Binary("10", true);
            Numbers.Number b = new Numbers.Binary("10", true);
            Operations.Operation res = new Operations.DivideOperation();
            string expected = "1";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestDivide14()
        {
            Numbers.Number a = new Numbers.Binary("10");
            Numbers.Number b = new Numbers.Binary("10", true);
            Operations.Operation res = new Operations.DivideOperation();
            string expected = "-1";
            Numbers.Number ans = res.Calculate(a, b);
            string actual = ans.ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestDivide15()
        {
            Numbers.Number a = new Numbers.Binary("");
            Numbers.Number b = new Numbers.Binary("");
            Operations.Operation res = new Operations.DivideOperation();
            Numbers.Number ans = null;
            Assert.Catch<ArgumentNullException>(() => ans = res.Calculate(a, b));
        }

        [Test]
        public void TestDivide16()
        {
            Numbers.Number a = new Numbers.Binary(null);
            Numbers.Number b = new Numbers.Binary(null);
            Operations.Operation res = new Operations.DivideOperation();
            Numbers.Number ans = null;
            Assert.Catch<NullReferenceException>(() => ans = res.Calculate(a, b));
        }

        [Test]
        public void TestDivide17()
        {
            Numbers.Number a = new Numbers.Binary(null);
            Numbers.Number b = new Numbers.Binary("10", true);
            Operations.Operation res = new Operations.DivideOperation();
            Numbers.Number ans = null;
            Assert.Catch<NullReferenceException>(() => ans = res.Calculate(a, b));
        }

        [Test]
        public void TestDivide18()
        {
            Numbers.Number a = new Numbers.Binary("10", true);
            Numbers.Number b = new Numbers.Binary("");
            Operations.Operation res = new Operations.DivideOperation();
            Numbers.Number ans = null;
            Assert.Catch<ArgumentNullException>(() => ans = res.Calculate(a, b));
        }

        [Test]
        public void TestDivide19()
        {
            Numbers.Number a = new Numbers.Binary("10");
            Numbers.Number b = new Numbers.Binary("");
            Operations.Operation res = new Operations.DivideOperation();
            Numbers.Number ans = null;
            Assert.Catch<ArgumentNullException>(() => ans = res.Calculate(a, b));
        }

        [Test]
        public void TestDivide20()
        {
            Numbers.Number a = new Numbers.Binary("");
            Numbers.Number b = new Numbers.Binary(new string(""));
            Operations.Operation res = new Operations.DivideOperation();
            Numbers.Number ans = null;
            Assert.Catch<ArgumentNullException>(() => ans = res.Calculate(a, b));
        }
    }
}
