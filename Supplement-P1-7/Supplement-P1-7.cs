﻿using System.Linq;

namespace Supplement_P1_7
{
    public class Supplement_P1_7
    {
        public int[] ReturnEvenNumbers(int skip = 0)
        {
            int[] array1 = Enumerable.Range(0, 1_000_000).ToArray();
            return array1.Where(n => n % 2 == 0).Skip(skip).ToArray();
        }


        public int[] ShuffleAndReturnOddNumbers(int skip = 0)
        {
            throw new NotImplementedException();
        }


        public (double average, int min, int max) ReturnAvgMinMax()
        {
            throw new NotImplementedException();
        }
    }
}
