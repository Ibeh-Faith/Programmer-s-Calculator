using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Calculator.Test
{
    public class Hex2BinTest
    {
        //[Test]
        //public void Hex2Bin1()
        //{
        //    Hex2Bin a = new Hex2Bin("e");
        //    string expected = "1110";
        //    string actual = a.ConvertHex2Binary("101010").ToString();
        //    Assert.AreEqual(expected, actual);
        //}
        [Test]
        public void Hex2Bin2()
        {
            Convertors.HexConvertor a = new Convertors.HexConvertor("101010");
            string expected = "000100000001000000010000";
            string actual = a.ToBinary().ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Hex2Bin3()
        {
            Convertors.HexConvertor a = new Convertors.HexConvertor("b");
            string expected = "1011";
            string actual = a.ToBinary().ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Hex2Bin4()
        {
            Convertors.HexConvertor a = new Convertors.HexConvertor("c");
            string expected = "1100";
            string actual = a.ToBinary().ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Hex2Bin5()
        {
            Convertors.HexConvertor a = new Convertors.HexConvertor("2a");
            string expected = "00101010";
            string actual = a.ToBinary().ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Hex2Bin6()
        {
            Convertors.HexConvertor a = new Convertors.HexConvertor("2a3d");
            string expected = "0010101000111101";
            string actual = a.ToBinary().ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Hex2Bin7()
        {
            Convertors.HexConvertor a = new Convertors.HexConvertor("11ad2");
            string expected = "00010001101011010010";
            string actual = a.ToBinary().ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Hex2Bin8()
        {
            Convertors.HexConvertor a = new Convertors.HexConvertor("ffff");
            string expected = "1111111111111111";
            string actual = a.ToBinary().ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        
        
        public void Hex2Bin9()
        {
            Convertors.HexConvertor a = new Convertors.HexConvertor("999ffff");
            string expected = "1001100110011111111111111111";
            string actual = a.ToBinary().ToString();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Hex2Bin10()
        {
            Convertors.HexConvertor a = new Convertors.HexConvertor("abc");
            string expected = "101010111100";
            string actual = a.ToBinary().ToString();
            Assert.AreEqual(expected, actual);
        }

        /**********************************************************/
        [Test]
        public void Hex2Bin11()
        {
            Convertors.HexConvertor a = new Convertors.HexConvertor("a");
            string expected = "1010";
            string actual = a.ToBinary().ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}
