using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> numbers = new List<int> { 5 };

        // Act
        List<int> result = GaussTrick.SumPairs(numbers);

        // Assert
        CollectionAssert.AreEqual(numbers, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
        List<int> expected = new List<int> { 7, 7, 7 };

        // Act
        List<int> result = GaussTrick.SumPairs(numbers);


        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
        List<int> expected = new List<int> { 8, 8, 8, 4 };

        // Act
        List<int> result = GaussTrick.SumPairs(numbers);


        // Assert
        CollectionAssert.AreEqual(expected, result);

    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> expected = new List<int> { 11, 11, 11, 11, 11 };

        // Act
        List<int> result = GaussTrick.SumPairs(numbers);


        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        List<int> expected = new List<int> { 12, 12, 12, 12, 12, 6 };

        // Act
        List<int> result = GaussTrick.SumPairs(numbers);


        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
