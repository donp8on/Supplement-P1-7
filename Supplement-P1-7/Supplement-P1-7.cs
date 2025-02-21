using System.Linq;

namespace Supplement_P1_7
{
    public class Supplement_P1_7
    {
        /// <summary>
        /// An array of even numbers from 0 to 1,000,000 that are initialized to index.
        /// </summary>
        /// <param name="skip">This is the optional skip parameter.</param>
        /// <returns>Returns an array of even numbers with the option to skip numbers in between.</returns>
        public int[] ReturnEvenNumbers(int skip = 0)
        {
            int[] array1 = Enumerable.Range(0, 1_000_000).ToArray();
            return array1.Where(n => n % 2 == 0).Skip(skip).ToArray();
        }


        public int[] ShuffleAndReturnOddNumbers(int skip = 0)
        {
            int[] array2 = Enumerable.Range(0, 1_000_000).ToArray();
            var shuffle = array2.OrderBy(_ => Guid.NewGuid()).ToArray();
            return shuffle.Where(n => n % 2 != 0).Skip(skip).ToArray();
        }


        public (double average, int min, int max) ReturnAvgMinMax()
        {
            throw new NotImplementedException();
        }
    }
}
