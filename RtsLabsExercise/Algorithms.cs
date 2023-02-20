namespace RtsLabsExercise
{
    public static class Algorithms
    {
        public static AboveBelowResult AboveBelow(IList<int> integerList, int comparisonValue)
        {
            return new AboveBelowResult(
                above: integerList.Count(i => i > comparisonValue),
                below: integerList.Count(i => i < comparisonValue));
        }

        public static string? StringRotation(string originalString, uint rotationAmount)
        {
            if (string.IsNullOrEmpty(originalString))
            {
                return null;
            }

            var originalCharArray = originalString.ToCharArray();
            var rotatedCharArray = RotateArray(originalCharArray, rotationAmount);

            return new string(rotatedCharArray);
        }

        private static T[] RotateArray<T>(T[] originalArray, uint rotationAmount)
        {
            // If rotation amount is greater than array length, use the remainder as the rotation amount.
            rotationAmount = Math.Min(rotationAmount, rotationAmount % (uint)originalArray.Length);

            var resultArray = new T[originalArray.Length];

            for (var i = 0; i < originalArray.Length; i++)
            {
                var newPosition = i + rotationAmount;
                if (newPosition > (originalArray.Length - 1))
                {
                    newPosition -= originalArray.Length;
                }

                resultArray[newPosition] = originalArray[i];
            }

            return resultArray;
        }
    }
}