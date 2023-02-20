namespace RtsLabsExercise.Tests
{
    public class StringRotationTests
    {
        [Theory]
        [MemberData(nameof(GetTestData))]
        public void StringRotationTheory(string originalString, uint rotationAmount, string expectedResult)
        {
            var actualResult = Algorithms.StringRotation(originalString, rotationAmount);

            Assert.Equal(expectedResult, actualResult);
        }

        public static IEnumerable<object[]> GetTestData()
        {
            return new List<object[]>
            {
                // Example usages test scenario
                new object[]
                {
                    "MyString",
                    2,
                    "ngMyStri"
                },

                // String with space
                new object[]
                {
                    "Sam Nutkins",
                    6,
                    "utkinsSam N"
                },

                // Full rotation
                new object[]
                {
                    "Sam Nutkins",
                    11,
                    "Sam Nutkins"
                },

                // Rotation greater than string length
                new object[]
                {
                    "RTS Labs",
                    11,
                    "absRTS L"
                },

                // Rotation greater than two times string length
                new object[]
                {
                    "RTS Labs",
                    19,
                    "absRTS L"
                },

                // Rotation is 0
                new object[]
                {
                    "RTS Labs",
                    0,
                    "RTS Labs"
                },

                // String is null
                new object[]
                {
                    null,
                    2,
                    null
                }
            };
        }
    }
}