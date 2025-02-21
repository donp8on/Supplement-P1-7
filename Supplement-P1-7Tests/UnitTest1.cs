namespace Supplement_P1_7Tests
{
    public class UnitTest1
    {
        private readonly Supplement_P1_7.Supplement_P1_7 operations = new();

        [Fact]
        public void ShouldReturnEvenNumbers_WithSkip()
        {
            int skipCount = 10;
            var result = operations.ReturnEvenNumbers(skipCount);

            Assert.All(result, num => Assert.True(num % 2 == 0));

            Assert.Equal(skipCount * 2, result.First());
        }

        [Fact]
        public void ShouldShuffleAndReturnOddNumbers()
        {
            var result1 = operations.ShuffleAndReturnOddNumbers();
            var result2 = operations.ShuffleAndReturnOddNumbers();

            Assert.All(result1, num => Assert.True(num % 2 != 0));

            Assert.Equal(500_000, result1.Length);

            Assert.NotEqual(result1, result2);
        }

        [Fact]
        public void ShouldReturnAvgMinMax()
        {
            var (avg, min, max) = operations.ReturnAvgMinMax(); 

            Assert.Equal(499999.5, avg, 1);
            Assert.Equal(0, min);
            Assert.Equal(999999, max);
        }
    }
}