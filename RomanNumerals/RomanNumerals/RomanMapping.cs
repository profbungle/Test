using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class RomanMapping
    {
        public int Value { get; set; }

        public string Mapping { get; set; }

        public bool IsRepeatable { get; set; }

        public bool IsSubtractable { get; set; }
    }
}
