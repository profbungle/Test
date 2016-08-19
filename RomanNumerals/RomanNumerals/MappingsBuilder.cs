using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class MappingsBuilder : IMappingsBuilder
    {
        public List<RomanMapping> Build()
        {
            List<RomanMapping> mappings = new List<RomanMapping>();
            mappings.Add(new RomanMapping() { Value = 1000, Mapping = "M", IsRepeatable = true, IsSubtractable = false });
            mappings.Add(new RomanMapping() { Value = 500, Mapping = "D", IsRepeatable = false, IsSubtractable = false });
            mappings.Add(new RomanMapping() { Value = 100, Mapping = "C", IsRepeatable = true, IsSubtractable = true });
            mappings.Add(new RomanMapping() { Value = 50, Mapping = "L", IsRepeatable = false, IsSubtractable = false });
            mappings.Add(new RomanMapping() { Value = 10, Mapping = "X", IsRepeatable = true, IsSubtractable = true });
            mappings.Add(new RomanMapping() { Value = 5, Mapping = "V", IsRepeatable = false, IsSubtractable = false });
            mappings.Add(new RomanMapping() { Value = 1, Mapping = "I", IsRepeatable = true, IsSubtractable = true });

            return mappings;
        }
    }
}
