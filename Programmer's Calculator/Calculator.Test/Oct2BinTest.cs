using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Calculator.Test
{
    public class Oct2BinTest
    {
        [Test]
        public void oct2bin1()
        {
            Convertors.OctConvertor a = new Convertors.OctConvertor("7777");
            string expected = "111111111111";
            string actual = a.ToBinary().ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void oct2bin2()
        {
            Convertors.OctConvertor a = new Convertors.OctConvertor("651");
            string expected = "110101001";
            string actual = a.ToBinary().ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void oct2bin3()
        {
            Convertors.OctConvertor a = new Convertors.OctConvertor("1");
            string expected = "001";
            string actual = a.ToBinary().ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void oct2bin4()
        {
            Convertors.OctConvertor a = new Convertors.OctConvertor("57");
            string expected = "101111";
            string actual = a.ToBinary().ToString();
            Assert.AreEqual(expected, actual);
        }

        /********************************************************/
        [Test]
        public void oct2bin5()
        {
            Convertors.OctConvertor a = new Convertors.OctConvertor("157");
            string expected = "001101111";
            string actual = a.ToBinary().ToString();
            Assert.AreEqual(expected, actual);
        }

    }
}
