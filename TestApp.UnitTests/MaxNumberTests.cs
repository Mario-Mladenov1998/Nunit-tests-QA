using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        //Arrange
        List<int> numbers = new List<int> { 5 };
        int expected = 5;

        //Act
        int result = MaxNumber.FindMax(numbers);

        //Assert
        Assert.That(expected, Is.EqualTo(result));
        //Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        //Arrange
        List<int> numbers = new List<int> { 2, 4, 1, 7, 10, 23, 43, 6 };
        int expected = 43;

        //Act
        int result = MaxNumber.FindMax(numbers); //43

        //Assert
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        //Arrange
        List<int> numbers = new List<int> { -1, -6, -7, -3, -9 };
        int expected = -1;

        //Act
        int result = MaxNumber.FindMax(numbers);

        //Assert
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        //Arrange
        List<int> numbers = new List<int> { -1, 3, 4, -6, -9, 10 };
        int expected = 10;

        //Act
        int result = MaxNumber.FindMax(numbers); //10

        //Assert
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        //Arrange
        List<int> numbers = new List<int> { 10, -1, 3, 4, -6, -9, 10 };
        int expected = 10;

        //Act
        int result = MaxNumber.FindMax(numbers);

        //Assert
        Assert.That(expected, Is.EqualTo(result));
    }
}
