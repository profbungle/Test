using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumerals
{
    public class RomanNumeralsConverter : IRomanNumeralsConverter
    {
        private List<RomanMapping> mappings;

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
                    RomanMapping subtractor = mappings.Skip(mappings.IndexOf(mapping) + 1).Take(2).Where(x => x.IsSubtractable && (mapping.Value - x.Value <= remaining)).FirstOrDefault();
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

    }
}
