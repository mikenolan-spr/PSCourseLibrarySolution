using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PSCourseLibrary.Tests;

[TestClass]
public class CalculatorTests
{
    [TestMethod]
    public void TestAdd()
    {
        var calculator = new PSCourseLibrary.Calculator();
        var value = calculator.add(1, 2);
        Assert.AreEqual(3, value);
    }
}