using NUnit.Framework;

namespace TestApp.UnitTests;

public class GradesTests
{
    [TestCase(2.00, "Fail")]
    [TestCase(2.99, "Fail")]
    [TestCase(3.00, "Average")]
    [TestCase(3.49, "Average")]
    [TestCase(3.50, "Good")]
    [TestCase(4.49, "Good")]
    [TestCase(4.50, "Very Good")]
    [TestCase(5.49, "Very Good")]
    [TestCase(5.50, "Excellent")]
    [TestCase(6.00, "Excellent")]
    public void Test_GradeAsWords_ReturnsCorrectString(double grade, string expected)
    {
        

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
       Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(1.99)]
    [TestCase(-1)]
    [TestCase(6.01)]
    [TestCase(10)]
    public void Test_GradeAsWords_ReturnsCorrectString_EdgeCases(double grade)
    {
        

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.That(actual, Is.EqualTo("Invalid!"));
    }
}
