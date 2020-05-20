namespace Tests
{
    using System.Collections.Generic;
    using NUnit.Framework;
    using Services;

    class TreeMaxTests
    {
        private static List<TestCaseData> _maxTreeTestCases = new List<TestCaseData>
        {
            // Empty tree
            new TestCaseData(null, int.MinValue),

            /*    3
             *   / \
             * -2  54
             */
            new TestCaseData(new Tree(
                                      new Tree(null, null, -2),
                                      new Tree(null, null, 54),
                                      3),
                             54),
            /*      36
             *      / \
             *     /   \
             *    35   34
             *   /  \    \
             *  33  32   31
             *          /  \
             *         30  200
             */
            new TestCaseData(new Tree(
                                      new Tree(
                                               new Tree(null,
                                                        null,
                                                        33),
                                               new Tree(null,
                                                        null,
                                                        32),
                                               35),
                                      new Tree(
                                               null,
                                               new Tree(new Tree(null,
                                                                 null,
                                                                 30),
                                                        new Tree(null,
                                                                 null,
                                                                 200),
                                                        31),
                                               34),
                                      7),
                             200),
        };

        [Test]
        [TestCaseSource(nameof(_maxTreeTestCases))]
        public void GetTreeMaxTests(Tree input, int? expectedResult)
        {
            var actualResult = Utilities.GetTreeMax(input);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
