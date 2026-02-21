using System;
using System.Linq;

namespace TestApp
{
    public class Duplicates
    {
        public int[] GetDuplicates(int[] numbers)
        {
            if (numbers == null)
                throw new ArgumentNullException(nameof(numbers));

            return numbers
                .GroupBy(x => x)
                .Where(g => g.Count() > 1)
                .Select(g => g.Key)
                .OrderBy(x => x)
                .ToArray();
        }
    }
}