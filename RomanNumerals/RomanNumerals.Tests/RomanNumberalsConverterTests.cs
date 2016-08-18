using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RomanNumerals.Tests
{
    public class RomanNumberalsConverterTests
    {
        [Fact]
        public void OneTest()
        {
             Assert.Equal("I", RomanNumeralsConverter.ConvertToRoman(1));
        }

        [Fact]
        public void TwoTest()
        {
            Assert.Equal("II", RomanNumeralsConverter.ConvertToRoman(2));
        }

        [Fact]
        public void FourTest()
        {
            Assert.Equal("IV", RomanNumeralsConverter.ConvertToRoman(4));
        }

        [Fact]
        public void FiveTest()
        {
            Assert.Equal("V", RomanNumeralsConverter.ConvertToRoman(5));
        }

        [Fact]
        public void SixTest()
        {
            Assert.Equal("VI", RomanNumeralsConverter.ConvertToRoman(6));
        }

        [Fact]
        public void EightTest()
        {
            Assert.Equal("VIII", RomanNumeralsConverter.ConvertToRoman(8));
        }

        [Fact]
        public void NineTest()
        {
            Assert.Equal("IX", RomanNumeralsConverter.ConvertToRoman(9));
        }

        [Fact]
        public void TenTest()
        {
            Assert.Equal("X", RomanNumeralsConverter.ConvertToRoman(10));
        }

        [Fact]
        public void ProvidedExamplesTest()
        {
            Assert.Equal("LXIV", RomanNumeralsConverter.ConvertToRoman(64));
            Assert.Equal("CCXXVI", RomanNumeralsConverter.ConvertToRoman(226));
            Assert.Equal("CM", RomanNumeralsConverter.ConvertToRoman(900));
            Assert.Equal("CMXCVIII", RomanNumeralsConverter.ConvertToRoman(998));
            Assert.Equal("MDCCXII", RomanNumeralsConverter.ConvertToRoman(1712));
        }

    }
}
