using System;
using Xunit;
using CharClass;

namespace CharClassTest
{
    public class FighterTest
    {
        [Fact]
        public void Test1()
        {
            var f = new Fighter(30, 30, 30);
            Assert.True(f.DamageBonus() == 60);
        }
    }
}
