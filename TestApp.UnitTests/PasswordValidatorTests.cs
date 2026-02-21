using System.Linq;
using NUnit.Framework;
using TestApp;

namespace TestApp.UnitTests;

[TestFixture]
public class PasswordValidatorTests
{
    private PasswordValidator validator;


    [SetUp]
    public void Setup()
    {
        validator = new TestApp.PasswordValidator();
    }

    [TestCase("Password1")]
    [TestCase("Aaaaaaaaa1")]
    public void IsValid_WhenPasswordMeetsRules_ReturnsTrue(string password)
    {
        bool result = validator.IsValid(password);
        Assert.That(result, Is.True);
    }
    [TestCase(null)]
    [TestCase("")]
    [TestCase(" ")]
    [TestCase("short1A")]  // < 8
    [TestCase("password1")] // no uppercase
    [TestCase("password")]  // no digit

    public void IsValid_WhenPasswordIsInvalid_ReturnsFalse(string password)
    {
        bool result = validator.IsValid(password);
        Assert.That(result, Is.False);
    }

}



