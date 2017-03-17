using System;
using Xunit;

namespace Devrocks.Travis.Demo.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var a = true;
            Assert.True(a);
        }

        [Fact]
        public void Test2()
        {
            var a = true;
            Assert.True(a);
        }

        [Fact]
        public void Test3()
        {
            var a = true;
            Assert.True(a);
        }

        [Fact]
        public void Test4()
        {
            var a = false;
            Assert.False(a);
        }
    }
}
