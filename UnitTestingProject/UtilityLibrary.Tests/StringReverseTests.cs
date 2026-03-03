using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    [TestCase("", "")]
    [TestCase("A", "A")]
    [TestCase("Hello", "olleH")]
    [TestCase("12345", "54321")]
    [TestCase("ab cd", "dc ba")]
    public void Reverse_ValidInput_ReturnsReversedString(string input, string expected)
    {
        //Act
        string result = StringReverse.Reverse(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
    [Test]
    public void Reverse_Palindrome_ReturnsSameString()
    {
        //Arrange
        string input = "level";

        //Act
        string result = StringReverse.Reverse(input);

        //Assert
        Assert.That(result, Is.EqualTo(input));
    }
}