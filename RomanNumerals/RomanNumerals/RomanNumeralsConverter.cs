﻿using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumerals
{
    public class RomanNumeralsConverter : IRomanNumeralsConverter
    {
        private List<RomanMapping> mappings;
        private const int SubtractionRangeCount = 2;

        public RomanNumeralsConverter(IMappingsBuilder mappingsBuilder)
        {
            mappings = mappingsBuilder.Build();
        }

        public string ConvertToRoman(int numberToConvert)
        {
            int remaining = numberToConvert;
            StringBuilder roman = new StringBuilder();

            foreach (RomanMapping mapping in mappings)
            {
                if (!mapping.IsRepeatable && (remaining / mapping.Value == 1))
                {
                    remaining -= mapping.Value;
                    roman.Append(mapping.Mapping);
                }

                if (remaining >= mapping.Value && mapping.IsRepeatable && (remaining / mapping.Value <= 3))
                {
                    int repeatCount = remaining / mapping.Value;
                    for (int i = 1; i <= repeatCount; i++)
                    {
                        roman.Append(mapping.Mapping);
                    }
                    remaining = remaining - (mapping.Value * repeatCount);
                }

                if (remaining > 0)
                {
                    RomanMapping subtractor = SelectValidSubtractorMapping(mapping, remaining);
                    if (subtractor != null)
                    {
                        remaining = remaining - (mapping.Value - subtractor.Value);
                        roman.Append(subtractor.Mapping);
                        roman.Append(mapping.Mapping);
                    }
                }
               
            }

            return roman.ToString();
        }

        /// <summary>
        /// Selects a valid Subtractor mapping for the current mapping as per - The '1' symbols ('I', 'X', and 'C') can only be subtracted from the 2 next highest values
        /// </summary>
        private RomanMapping SelectValidSubtractorMapping(RomanMapping mapping, int remaining)
        {
            
            return mappings.Skip(mappings.IndexOf(mapping) + 1).
                                                Take(SubtractionRangeCount).Where(x => x.IsSubtractable && (mapping.Value - x.Value <= remaining)).
                                                FirstOrDefault();
        }
    }
}
