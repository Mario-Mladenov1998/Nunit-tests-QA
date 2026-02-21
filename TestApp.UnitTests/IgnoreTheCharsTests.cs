using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class IgnoreTheCharsTests
{
    [Test]
    public void Test_IgnoreChars_EmptyStringSentence_ReturnsEmptyString()
    {
        //Arrange
        string sentence = "";
        List<char> ignoredChars = new List<char> { 'a', 'e' };
        


        //Act
        string result = IgnoreTheChars.IgnoreChars(sentence, ignoredChars);

        //Assert
        Assert.AreEqual(sentence, result);

    }

    [Test]
    public void Test_IgnoreChars_EmptyList_ReturnsSameSentence()
    {
        //Arrange
        string sentence = "Mario is 27 years old";
        List<char> ignoredChars = new List<char>();


        //Act
        string result = IgnoreTheChars.IgnoreChars(sentence, ignoredChars);

        //Assert
        Assert.AreEqual(sentence, result);
    }

    [Test]
    public void Test_IgnoreChars_OneCharSentenceAndSameCharsForIgnoring_ReturnsEmptyString()
    {
        //Arrange
        string sentence = "d";
        List<char> ignoredChars = new List<char> { 'd' };
        string expected = string.Empty;


        //Act
        string result = IgnoreTheChars.IgnoreChars(sentence, ignoredChars);

        //Assert
        Assert.AreEqual(expected, result);
    } 

    [Test]
    public void Test_IgnoreChars_WholeSentenceAndFewCharsToIgnore_ReturnsCorrectString()
    {
        //Arrange
        string sentence = "Desi is 27 years old.";
        List<char> ignoredChars = new List<char> { 'a', 'e', '.'};
        string expected = "Dsi is 27 yrs old";


        //Act
        string result = IgnoreTheChars.IgnoreChars(sentence, ignoredChars);

        //Assert
        Assert.AreEqual(expected, result);
    }
}
