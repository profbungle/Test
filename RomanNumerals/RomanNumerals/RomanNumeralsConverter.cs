using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumerals
{
    public class RomanNumeralsConverter
    {
        private static List<RomanMapping> mappings;

        static RomanNumeralsConverter()
        {
            mappings = new List<RomanMapping>();
            mappings.Add(new RomanMapping() { Value = 1000, Mapping = "M", IsRepeatable = true, IsSubtractable = false });
            mappings.Add(new RomanMapping() { Value = 500, Mapping = "D", IsRepeatable = false, IsSubtractable = false });
            mappings.Add(new RomanMapping() { Value = 100, Mapping = "C", IsRepeatable = true, IsSubtractable = true });
            mappings.Add(new RomanMapping() { Value = 50, Mapping = "L", IsRepeatable = false, IsSubtractable = false });
            mappings.Add(new RomanMapping() { Value = 10, Mapping = "X", IsRepeatable = true, IsSubtractable = true });
            mappings.Add(new RomanMapping() { Value = 5, Mapping = "V", IsRepeatable = false, IsSubtractable = false });
            mappings.Add(new RomanMapping() { Value = 1, Mapping = "I", IsRepeatable = true, IsSubtractable = true });
        }

        public static string ConvertToRoman(int numberToConvert)
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
