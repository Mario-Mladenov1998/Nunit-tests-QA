using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void Test_CalculateFactorial_InputZero_ReturnsOne()
    {
        //Act
        int result = Factorial.CalculateFactorial(0);

        //Assert
        Assert.That(result, Is.EqualTo(1));

    }

    [Test]
    public void Test_CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        //Act 
        int result = Factorial.CalculateFactorial(5);

        //Assert
        Assert.That(result, Is.EqualTo(120));
    }
    

        [Test]
        public void Test_CalculateFactorial_NegativeInput_ThrowsException()
        {
            Assert.That(() => Factorial.CalculateFactorial(-1),
                        Throws.TypeOf<ArgumentOutOfRangeException>());
        }

    }

