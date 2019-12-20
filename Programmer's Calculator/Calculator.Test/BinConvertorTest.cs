using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Calculator.Test
{
    public class BinConvertorTest
    {
        //Binary to Octal test cases
        [Test]
        public void bin2oct1()
        {
            Convertors.Convertor a = new Convertors.BinConvertor("110110011");
            string expected = "663";
            string actual = a.ToOctal().ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void bin2oct2()
        {
            Convertors.Convertor a = new Convertors.BinConvertor("0110011");
            string expected = "63";
            string actual = a.ToOctal().ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void bin2oct3()
        {
            Convertors.Convertor a = new Convertors.BinConvertor("01110011");
            string expected = "163";
            string actual = a.ToOctal().ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void bin2oct4()
        {
            Convertors.Convertor a = new Convertors.BinConvertor("001110011");
            string expected = "163";
            string actual = a.ToOctal().ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void bin2oct5()
        {
            Convertors.Convertor a = new Convertors.BinConvertor("0001110011");
            string expected = "163";
            string actual = a.ToOctal().ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void bin2oct6()
        {
            Convertors.Convertor a = new Convertors.BinConvertor("");
            Numbers.Number number = null;
            Assert.Catch<ArgumentNullException>(() => number = a.ToOctal());
        }

        [Test]
        public void bin2oct7()
        {
            Convertors.Convertor a = new Convertors.BinConvertor(null);
            Numbers.Number number = null;
            Assert.Catch<ArgumentNullException>(() => number = a.ToOctal());
        }

        [Test]
        public void bin2oct8()
        {
            Convertors.Convertor a = new Convertors.BinConvertor(new string(""));
            Numbers.Number number = null;
            Assert.Catch<ArgumentNullException>(() => number = a.ToOctal());
        }

        //Binary to Hexadecimal test cases
        [Test]
        public void bin2hex1()
        {
            Convertors.Convertor a = new Convertors.BinConvertor("001100110011");
            string expected = "333";
            string actual = a.ToHexadecimal().ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void bin2hex2()
        {
            Convertors.Convertor a = new Convertors.BinConvertor("1100110011");
            string expected = "333";
            string actual = a.ToHexadecimal().ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void bin2hex3()
        {
            Convertors.Convertor a = new Convertors.BinConvertor("100110011");
            string expected = "133";
            string actual = a.ToHexadecimal().ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void bin2hex4()
        {
            Convertors.Convertor a = new Convertors.BinConvertor("11100110011");
            string expected = "733";
            string actual = a.ToHexadecimal().ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void bin2hex5()
        {
            Convertors.Convertor a = new Convertors.BinConvertor("10000110011");
            string expected = "433";
            string actual = a.ToHexadecimal().ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void bin2hex6()
        {
            Convertors.Convertor a = new Convertors.BinConvertor("");
            Numbers.Number number = null;
            Assert.Catch<ArgumentNullException>(() => number = a.ToHexadecimal());
        }

        [Test]
        public void bin2hex7()
        {
            Convertors.Convertor a = new Convertors.BinConvertor(null);
            Numbers.Number number = null;
            Assert.Catch<ArgumentNullException>(() => number = a.ToHexadecimal());
        }

        [Test]
        public void bin2hex8()
        {
            Convertors.Convertor a = new Convertors.BinConvertor(new string(""));
            Numbers.Number number = null;
            Assert.Catch<ArgumentNullException>(() => number = a.ToHexadecimal());
        }

        //Binary to Binary test cases
        [Test]
        public void bin2bin1()
        {
            Convertors.Convertor a = new Convertors.BinConvertor("11100110011");
            string expected = "11100110011";
            string actual = a.ToBinary().ToString();
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void bin2bin2()
        {
            Convertors.Convertor a = new Convertors.BinConvertor("100110011");
            string expected = "100110011";
            string actual = a.ToBinary().ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void bin2bin3()
        {
            Convertors.Convertor a = new Convertors.BinConvertor("001100110011");
            string expected = "001100110011";
            string actual = a.ToBinary().ToString();
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void bin2bin4()
        {
            Convertors.Convertor a = new Convertors.BinConvertor("01110011");
            string expected = "01110011";
            string actual = a.ToBinary().ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void bin2bin5()
        {
            Convertors.Convertor a = new Convertors.BinConvertor("0110011");
            string expected = "0110011";
            string actual = a.ToBinary().ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void bin2bin6()
        {
            Convertors.Convertor a = new Convertors.BinConvertor("");
            Numbers.Number number = null;
            Assert.Catch<ArgumentNullException>(() => number = a.ToBinary());
        }

        [Test]
        public void bin2bin7()
        {
            Convertors.Convertor a = new Convertors.BinConvertor(null);
            Numbers.Number number = null;
            Assert.Catch<ArgumentNullException>(() => number = a.ToBinary());
        }

        [Test]
        public void bin2bin8()
        {
            Convertors.Convertor a = new Convertors.BinConvertor(new string(""));
            Numbers.Number number = null;
            Assert.Catch<ArgumentNullException>(() => number = a.ToBinary());
        }
    }
}
