using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GithubActionsLab;

[TestClass]
public class CalculatorTests
{
    // ==========================================
    // Addition Tests
    // ==========================================
    [TestMethod]
    public void Add_Valid_Thutika()
    {
        Assert.AreEqual(3.0, Program.Add("1", "2"));
        Assert.AreEqual(5.0, Program.Add("3", "2"));
        Assert.AreEqual(12.0, Program.Add("5", "7"));
    }

    [TestMethod]
    public void Add_Invalid_Thutika()
    {
        Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
    }

    [TestMethod]
    public void Add_Null_Thutika()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
    }

    // ==========================================
    // Subtraction Tests
    // ==========================================
    [TestMethod]
    public void Subtract_Valid_Thutika()
    {
        Assert.AreEqual(1.0, Program.Subtract("3", "2"));
        Assert.AreEqual(-2.0, Program.Subtract("5", "7"));
    }

    // ==========================================
    // Multiplication Tests
    // ==========================================
    [TestMethod]
    public void Multiply_Valid_Thutika()
    {
        Assert.AreEqual(6.0, Program.Multiply("2", "3"));
        Assert.AreEqual(0.0, Program.Multiply("0", "5"));
    }

    // ==========================================
    // Division Tests
    // ==========================================
    [TestMethod]
    public void Divide_Valid_Thutika()
    {
        Assert.AreEqual(2.0, Program.Divide("6", "3"));
        Assert.AreEqual(2.5, Program.Divide("5", "2"));
    }

    // ==========================================
    // Power Tests
    // ==========================================
    [TestMethod]
    public void Power_Valid_Thutika()
    {
        Assert.AreEqual(8.0, Program.Power("2", "3"));
        Assert.AreEqual(1.0, Program.Power("5", "0"));
        Assert.AreEqual(9.0, Program.Power("3", "2"));
    }

    [TestMethod]
    public void Power_Invalid_Thutika()
    {
        Assert.ThrowsException<FormatException>(() => Program.Power("2", "b"));
        Assert.ThrowsException<FormatException>(() => Program.Power("b", "2"));
    }

    [TestMethod]
    public void Power_Null_Thutika()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power("2", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "2"));
    }
}