using Xunit;
using System;
using Moqpractice;
using Moq;
namespace XTestProject1;

public class UnitTest1
{
    [Fact]
    public void Test_Addition()
    {
        var op = new Mock<IOperations>();
        op.Setup(obj => obj.Add(30, 40)).Returns(70);
        Xunit.Assert.Equal(70, op.Object.Add(30, 40));
    }
    [Fact]
    public void Test_Division()
    {
        var op = new Mock<IOperations>();
        op.Setup(obj => obj.divide(30, 5)).Returns(6);
        Xunit.Assert.Equal(6, op.Object.divide(30, 5));
    }
    [Fact]
    public void Test_Multiplication()
    {
        var op = new Mock<IOperations>();
        op.Setup(obj => obj.multiply(30, 40)).Returns(1200);
        Xunit.Assert.Equal(1200, op.Object.multiply(30, 40));
    }
    [Fact]
    public void Test_Subtract()
    {
        var op = new Mock<IOperations>();
        op.Setup(obj => obj.subtract(40, 30)).Returns(10);
        Xunit.Assert.Equal(10, op.Object.subtract(40, 30));
    }
}