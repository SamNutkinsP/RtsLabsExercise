namespace RtsLabsExercise.Tests
{
    public class AboveBelowTests
    {
        [Theory]
        [MemberData(nameof(GetTestData))]
        public void AboveBelowTheory(IList<int> integerList, int comparisonValue, AboveBelowResult expectedResult)
        {
            var actualResult = Algorithms.AboveBelow(integerList, comparisonValue);

            Assert.Equal(expectedResult, actualResult);
        }

        public static IEnumerable<object[]> GetTestData()
        {
            return new List<object[]>
            {
                // Example usages test scenario
                new object[]
                {
                    new[] {1, 5, 2, 1, 10},
                    6,
                    new AboveBelowResult(above: 1, below: 4)
                },

                // All above
                new object[]
                {
                    new[] {1, 5, 2, 1, 10},
                    0,
                    new AboveBelowResult(above: 5, below: 0)
                },

                // All below
                new object[]
                {
                    new[] {1, 5, 2, 1, 10},
                    50,
                    new AboveBelowResult(above: 0, below: 5)
                },

                // Negative numbers
                new object[]
                {
                    new[] {-10, -1, 2, 4, 10},
                    0,
                    new AboveBelowResult(above: 3, below:2)
                },

                // Exclude equal value
                new object[]
                {
                    new[] {1, 5, 2, 1, 10},
                    5,
                    new AboveBelowResult(above: 1, below: 3)
                },

                // Invalid entry
                new object[]
                {
                    Array.Empty<int>(),
                    5,
                    new AboveBelowResult(above: 0, below: 0)
                },
            };
        }
    }
}