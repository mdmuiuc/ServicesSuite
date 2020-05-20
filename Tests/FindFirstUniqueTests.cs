namespace Tests
{
    using NUnit.Framework;
    using Services;
    using System.Collections.Generic;

    [TestFixture]
    public class FindFirstUniqueTests
    {
        private static List<TestCaseData> FindFirstUniqueTestCases = new List<TestCaseData>
        {
            new TestCaseData(null, null),
            new TestCaseData("abcabc", null),
            new TestCaseData("abcacz", "b"),
            new TestCaseData("ABCac", "A"),
            new TestCaseData("The quick brown fox jumps over the lazy dog", "q")
        };

        [Test]
        [TestCaseSource(nameof(FindFirstUniqueTestCases))]
        public void FindFirstUniqueStringTests(string input, string expectedResult)
        {
            var actualResult = Utilities.FindFirstUnique(input);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
