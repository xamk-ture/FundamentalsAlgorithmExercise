using FundamentalsAlgorithmExercise;

namespace TestProject
{
    public class AlgorithmsTests
    {
        [Fact]
        public void PrintTree_ValidHeight_DoesNotThrowException()
        {
            int height = 5;
            var ex = Record.Exception(() => Algorithms.PrintTree(height));
            Assert.Null(ex);
        }

        [Theory]
        [InlineData("I", 1)]
        [InlineData("IV", 4)]
        [InlineData("IX", 9)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        public void RomanToInt_ValidRomanNumerals_ReturnsCorrectInteger(string romanNumeral, int expected)
        {
            int result = Algorithms.RomanToInt(romanNumeral);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, "I")]
        [InlineData(4, "IV")]
        [InlineData(9, "IX")]
        [InlineData(58, "LVIII")]
        [InlineData(1994, "MCMXCIV")]
        public void IntToRoman_ValidIntegers_ReturnsCorrectRomanNumeral(int number, string expected)
        {
            string result = Algorithms.IntToRoman(number);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GenerateFibonacci_ValidCount_ReturnsCorrectSequence()
        {
            List<int> expected = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            List<int> result = Algorithms.GenerateFibonacci(10);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("Saippuakivikauppias", true)]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("A man a plan a canal Panama", true)]
        public void IsPalindrome_TestStrings_ReturnsCorrectResult(string input, bool expected)
        {
            bool result = Algorithms.IsPalindrome(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("1, 2, 3, 4, 5", new int[] { 1, 2, 3, 4, 5 })]
        [InlineData("10 20 30 40", new int[] { 10, 20, 30, 40 })]
        [InlineData("-1,-2,-3", new int[] { -1, -2, -3 })]
        public void ParseNumbers_ValidInput_ReturnsCorrectList(string input, int[] expected)
        {
            List<int> result = Algorithms.ParseNumbers(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 1)]
        [InlineData(new int[] { 10, 20, 5, 40 }, 5)]
        [InlineData(new int[] { -1, -2, -3 }, -3)]
        public void FindMinimum_ValidList_ReturnsMinimum(int[] numbersArray, int expected)
        {
            List<int> numbers = new List<int>(numbersArray);
            int result = Algorithms.FindMinimum(numbers);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 5)]
        [InlineData(new int[] { 10, 20, 5, 40 }, 40)]
        [InlineData(new int[] { -1, -2, -3 }, -1)]
        public void FindMaximum_ValidList_ReturnsMaximum(int[] numbersArray, int expected)
        {
            List<int> numbers = new List<int>(numbersArray);
            int result = Algorithms.FindMaximum(numbers);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 15)]
        [InlineData(new int[] { 10, 20, 30 }, 60)]
        [InlineData(new int[] { -1, -2, -3 }, -6)]
        public void CalculateSum_ValidList_ReturnsSum(int[] numbersArray, int expected)
        {
            List<int> numbers = new List<int>(numbersArray);
            int result = Algorithms.CalculateSum(numbers);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 5, 3, 8, 4, 2 }, new int[] { 2, 3, 4, 5, 8 })]
        [InlineData(new int[] { 10, -1, 0, 5 }, new int[] { -1, 0, 5, 10 })]
        [InlineData(new int[] { 1 }, new int[] { 1 })]
        [InlineData(new int[] { }, new int[] { })]
        public void SortNumbers_ValidList_ReturnsSortedNumbers(int[] inputArray, int[] expectedArray)
        {
            List<int> inputList = new List<int>(inputArray);
            List<int> expectedList = new List<int>(expectedArray);
            List<int> result = Algorithms.SortNumbers(inputList);
            Assert.Equal(expectedList, result);
        }
    }
}