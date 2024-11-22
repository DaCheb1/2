using NUnit.Framework;
using Privet123;
using System;
using System.IO.Packaging;



public class PersonTests
{
    private Person person;

    [SetUp]
    public void SetUp()
    {
        person = new Person("Alice", 30, "USA");
    }

    [Test]
    public void TestGetBirthYear()
    {
        int currentYear = DateTime.Now.Year;
        int expectedBirthYear = currentYear - person.Age;
        Assert.AreEqual(expectedBirthYear, person.GetBirthYear());
    }

    [Test]
    public void TestToJson()
    {
        string expectedJson = "{\"Name\":\"Alice\",\"Age\":30,\"Country\":\"USA\"}";
        Assert.AreEqual(expectedJson, person.ToJson());
    }
}