using NUnit.Framework;
using System;
using System.Collections.Generic;
using TestApp;

namespace TestApp.UnitTests
{
    [TestFixture]
    public class DuplicatesTests
    {
        private Duplicates duplicates;

        [SetUp]
        public void Setup()
        {
            duplicates = new Duplicates();
        }

        // TestCaseSource method MUST be static
        private static IEnumerable<TestCaseData> GetDuplicatesTestCases()
        {
            yield return new TestCaseData(new int[] { 1, 2, 2, 3, 3, 3 }, new int[] { 2, 3 }).SetName("MixedInput_ReturnsUniqueDuplicates");

            yield return new TestCaseData(new int[] { 1, 1, 1, 1 }, new int[] { 1 }).SetName("SingleNumberRepeats_ReturnsSingleDuplicate");

            yield return new TestCaseData(new int[] { 1, 2, 3, 4 } Array.Empty<int>()).SetName("NoDuplicates_ReturnsEmpty");

            yield return new TestCaseData(new int[] { -1, -1, 0, 1, 1 }, new int { -1, 1 }).SetName("NegativeNumbers_WorkCorrectly");
        }

        [TestCaseSource(nameof(GetDuplicatesTestCases))]
        public void GetDuplicates_ReturnsExpected(int[] input, int[] expected)
        {
            int[] result = duplicates.GetDuplicates(input);

            Assert.Mutiple(() =>
            {
                Assert.That(result, Is.EqualTo(expected));
                Assert.That(result, Is.Ordered);

            });
        }

        [Test]
        public void GetDuplicates_WhenInputIsNull_ThrowsArgumentNullException()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => duplicates.GetDuplicates(null));

            Assert.That(ex.ParamName, Is.EqualTo("numbers"));
        }
    }
}



             