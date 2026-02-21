using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListManipulationTests
{
    [Test]
    public void Test_RemoveNegativesAndReverse_EmptyListInput_ReturnEmptyList()
    {
        //Arrange 
        List<int> numbers = new List<int>(); //празен спписък

        //Act
        List<int> result = ListManipulation.RemoveNegativesAndReverse(numbers);

        //Assert
        CollectionAssert.IsEmpty(result);
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_OnlyNegativeNumbers_ReturnEmptyList()
    {
        //Arrange
        List<int> numbers = new List<int> { -4, -3, -2, -1 };

        //Act
        List<int> result = ListManipulation.RemoveNegativesAndReverse(numbers);

        //Assert
        CollectionAssert.IsEmpty(result);
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_OnlyOnePositiveNumber_ReturnSameCollection()
    {
        //Arrange 
        List<int> numbers = new List<int> { 5 };

        //Act
        List<int> result = ListManipulation.RemoveNegativesAndReverse(numbers);

        //Assert
        CollectionAssert.AreEqual(numbers, result);
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_OnlyPositiveNumbers_ReturnRevursedList()
    {
        //Arrange
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        List<int> expected = new List<int> { 5, 4, 3, 2, 1 };

        //Act
        List<int> result = ListManipulation.RemoveNegativesAndReverse(numbers);

        //Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_PostiveAndNegativeElements_ReturnPositiveNumbersInReversedOrder()
    {
        //Arrange
        List<int> numbers = new List<int> { -1, 2, -3, -4, 5, 6, 7, 9 };
        List<int> expected = new List<int> { 9, 7, 6, 5, 2 };

        //Act
        List<int> result = ListManipulation.RemoveNegativesAndReverse(numbers);

        //Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
