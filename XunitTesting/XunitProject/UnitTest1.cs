using System;
using Xunit;
using Calculator;


namespace XunitProject
{
    public class UnitTest1
    {
        
        [Fact]
        public void Test_Addition()
        {
            int a=10,b=20;
            Operations op = new Operations();
            int res=op.addition(a,b);
            Assert.Equal(30,res);
        }

        [Fact]
        public void Test_subraction()
        {
            int a = 10, b = 20;
            Operations op = new Operations();
            int res = op.subraction(b,a);
            Assert.Equal(10, res);
        }
        [Fact]
        public void Test_multiplication()
        {
            int a = 10, b = 20;
            Operations op = new Operations();
            int res = op.multiplication(a,b);
            Assert.Equal(200, res);
        }

        [Fact]
        public void Test_division()
        {
            int a = 10, b = 20;
            Operations op = new Operations();
            int res = op.division(b,a);
            Assert.Equal(2, res);
        }
    }
}