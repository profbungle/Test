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
        IRomanNumeralsConverter romanNumeralsConverter;

        public RomanNumberalsConverterTests()
        {
            romanNumeralsConverter = new RomanNumeralsConverter(new MappingsBuilder());
        }

        [Fact]
        public void OneTest()
        {
             Assert.Equal("I", romanNumeralsConverter.ConvertToRoman(1));
        }

        [Fact]
        public void TwoTest()
        {
            Assert.Equal("II", romanNumeralsConverter.ConvertToRoman(2));
        }

        [Fact]
        public void FourTest()
        {
            Assert.Equal("IV", romanNumeralsConverter.ConvertToRoman(4));
        }

        [Fact]
        public void FiveTest()
        {
            Assert.Equal("V", romanNumeralsConverter.ConvertToRoman(5));
        }

        [Fact]
        public void SixTest()
        {
            Assert.Equal("VI", romanNumeralsConverter.ConvertToRoman(6));
        }

        [Fact]
        public void EightTest()
        {
            Assert.Equal("VIII", romanNumeralsConverter.ConvertToRoman(8));
        }

        [Fact]
        public void NineTest()
        {
            Assert.Equal("IX", romanNumeralsConverter.ConvertToRoman(9));
        }

        [Fact]
        public void TenTest()
        {
            Assert.Equal("X", romanNumeralsConverter.ConvertToRoman(10));
        }

        [Fact]
        public void LXIVTest()
        {
            Assert.Equal("LXIV", romanNumeralsConverter.ConvertToRoman(64));
            
        }

        [Fact]
        public void CCXXVITest()
        {
            Assert.Equal("CCXXVI", romanNumeralsConverter.ConvertToRoman(226));
        }

        [Fact]
        public void CMTest()
        {
            Assert.Equal("CM", romanNumeralsConverter.ConvertToRoman(900));
            
        }

        [Fact]
        public void CMXCVIIITest()
        {
            Assert.Equal("CMXCVIII", romanNumeralsConverter.ConvertToRoman(998));
        }

        [Fact]
        public void MDCCXIITest()
        {
            Assert.Equal("MDCCXII", romanNumeralsConverter.ConvertToRoman(1712));
        }

        [Fact]
        public void LTest()
        {
            Assert.Equal("L", romanNumeralsConverter.ConvertToRoman(50));
        }

        [Fact]
        public void CTest()
        {
            Assert.Equal("C", romanNumeralsConverter.ConvertToRoman(100));
        }

        [Fact]
        public void DTest()
        {
            Assert.Equal("D", romanNumeralsConverter.ConvertToRoman(500));
        }

        [Fact]
        public void MTest()
        {
            Assert.Equal("M", romanNumeralsConverter.ConvertToRoman(1000));
        }

        [Fact]
        public void XXXITest()
        {
            Assert.Equal("XXXI", romanNumeralsConverter.ConvertToRoman(31));
        }

        [Fact]
        public void CXLVIIITest()
        {
            Assert.Equal("CXLVIII", romanNumeralsConverter.ConvertToRoman(148));
        }

        [Fact]
        public void CCXCIVTest()
        {
            Assert.Equal("CCXCIV", romanNumeralsConverter.ConvertToRoman(294));
        }

        [Fact]
        public void CCCXIITest()
        {
            Assert.Equal("CCCXII", romanNumeralsConverter.ConvertToRoman(312));
        }

        [Fact]
        public void CDXXITest()
        {
            Assert.Equal("CDXXI", romanNumeralsConverter.ConvertToRoman(421));
        }

        [Fact]
        public void DXXVIIITest()
        {
            Assert.Equal("DXXVIII", romanNumeralsConverter.ConvertToRoman(528));
        }

        [Fact]
        public void DCCLXXXIITest()
        {
            Assert.Equal("DCCLXXXII", romanNumeralsConverter.ConvertToRoman(782));
        }
      
        [Fact]
        public void CMXLITest()
        {
            Assert.Equal("CMXLI", romanNumeralsConverter.ConvertToRoman(941));
        }

        [Fact]
        public void MXLIIITest()
        {
            Assert.Equal("MXLIII", romanNumeralsConverter.ConvertToRoman(1043));
        }

        [Fact]
        public void MCDLXXXVTest()
        {
            Assert.Equal("MCDLXXXV", romanNumeralsConverter.ConvertToRoman(1485));
        }

        [Fact]
        public void MMDCCXXIIITest()
        {
            Assert.Equal("MMDCCXXIII", romanNumeralsConverter.ConvertToRoman(2723));
        }

        [Fact]
        public void MMMCLXXXVTest()
        {
            Assert.Equal("MMMCLXXXV", romanNumeralsConverter.ConvertToRoman(3185));
        }

        [Fact]
        public void MMMCCCXIIITest()
        {
            Assert.Equal("MMMCCCXIII", romanNumeralsConverter.ConvertToRoman(3313));
        }

        [Fact]
        public void MMMDCCCXLIVTest()
        {
            Assert.Equal("MMMDCCCXLIV", romanNumeralsConverter.ConvertToRoman(3844));
        }

        [Fact]
        public void MMMDCCCLXXXVIIITest()
        {
            Assert.Equal("MMMDCCCLXXXVIII", romanNumeralsConverter.ConvertToRoman(3888));
        }

        [Fact]
        public void MMMCMXCIXTest()
        {
            Assert.Equal("MMMCMXCIX", romanNumeralsConverter.ConvertToRoman(3999));
        } 
    }
}
