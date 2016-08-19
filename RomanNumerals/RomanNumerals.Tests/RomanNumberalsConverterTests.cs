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
        public void LXIVTest()
        {
            Assert.Equal("LXIV", RomanNumeralsConverter.ConvertToRoman(64));
            
        }

        [Fact]
        public void CCXXVITest()
        {
            Assert.Equal("CCXXVI", RomanNumeralsConverter.ConvertToRoman(226));
        }

        [Fact]
        public void CMTest()
        {
            Assert.Equal("CM", RomanNumeralsConverter.ConvertToRoman(900));
            
        }

        [Fact]
        public void CMXCVIIITest()
        {
            Assert.Equal("CMXCVIII", RomanNumeralsConverter.ConvertToRoman(998));
        }

        [Fact]
        public void MDCCXIITest()
        {
            Assert.Equal("MDCCXII", RomanNumeralsConverter.ConvertToRoman(1712));
        }

        [Fact]
        public void LTest()
        {
            Assert.Equal("L", RomanNumeralsConverter.ConvertToRoman(50));
        }

        [Fact]
        public void CTest()
        {
            Assert.Equal("C", RomanNumeralsConverter.ConvertToRoman(100));
        }

        [Fact]
        public void DTest()
        {
            Assert.Equal("D", RomanNumeralsConverter.ConvertToRoman(500));
        }

        [Fact]
        public void MTest()
        {
            Assert.Equal("M", RomanNumeralsConverter.ConvertToRoman(1000));
        }

        [Fact]
        public void XXXITest()
        {
            Assert.Equal("XXXI", RomanNumeralsConverter.ConvertToRoman(31));
        }

        [Fact]
        public void CXLVIIITest()
        {
            Assert.Equal("CXLVIII", RomanNumeralsConverter.ConvertToRoman(148));
        }

        [Fact]
        public void CCXCIVTest()
        {
            Assert.Equal("CCXCIV", RomanNumeralsConverter.ConvertToRoman(294));
        }

        [Fact]
        public void CCCXIITest()
        {
            Assert.Equal("CCCXII", RomanNumeralsConverter.ConvertToRoman(312));
        }

        [Fact]
        public void CDXXITest()
        {
            Assert.Equal("CDXXI", RomanNumeralsConverter.ConvertToRoman(421));
        }

        [Fact]
        public void DXXVIIITest()
        {
            Assert.Equal("DXXVIII", RomanNumeralsConverter.ConvertToRoman(528));
        }

        [Fact]
        public void DCCLXXXIITest()
        {
            Assert.Equal("DCCLXXXII", RomanNumeralsConverter.ConvertToRoman(782));
        }
      
        [Fact]
        public void CMXLITest()
        {
            Assert.Equal("CMXLI", RomanNumeralsConverter.ConvertToRoman(941));
        }

        [Fact]
        public void MXLIIITest()
        {
            Assert.Equal("MXLIII", RomanNumeralsConverter.ConvertToRoman(1043));
        }

        [Fact]
        public void MCDLXXXVTest()
        {
            Assert.Equal("MCDLXXXV", RomanNumeralsConverter.ConvertToRoman(1485));
        }

        [Fact]
        public void MMDCCXXIIITest()
        {
            Assert.Equal("MMDCCXXIII", RomanNumeralsConverter.ConvertToRoman(2723));
        }

        [Fact]
        public void MMMCLXXXVTest()
        {
            Assert.Equal("MMMCLXXXV", RomanNumeralsConverter.ConvertToRoman(3185));
        }

        [Fact]
        public void MMMCCCXIIITest()
        {
            Assert.Equal("MMMCCCXIII", RomanNumeralsConverter.ConvertToRoman(3313));
        }

        [Fact]
        public void MMMDCCCXLIVTest()
        {
            Assert.Equal("MMMDCCCXLIV", RomanNumeralsConverter.ConvertToRoman(3844));
        }

        [Fact]
        public void MMMDCCCLXXXVIIITest()
        {
            Assert.Equal("MMMDCCCLXXXVIII", RomanNumeralsConverter.ConvertToRoman(3888));
        }

        [Fact]
        public void MMMCMXCIXTest()
        {
            Assert.Equal("MMMCMXCIX", RomanNumeralsConverter.ConvertToRoman(3999));
        } 
    }
}
