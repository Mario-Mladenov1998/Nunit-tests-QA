using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class TriangleTests
{
    [Test]
    public void PrintTriangle_Size0_ReturnsEmptyString()
    {
        //Act
        string result = Triangle.PrintTriangle(0);

        //Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void PrintTriangle_NegativeSize_ThrowsArgumenOutOfRangeException()
    {
        //Act & Assert
        Assert.That(() => Triangle.PrintTriangle(-1), Throws.TypeOf<ArgumentOutOfRangeException>());
    }

    }

   
