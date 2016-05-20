using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Ploeh.AutoFixture.NUnit2;

namespace Syndicate.Breakthrough.Domain.Tests
{
    public class MoneyTest
    {
        [TestCase(1,2)]
        public void MoneyAdditionTest(decimal d1, decimal d2)
        {
            var m1 = new Money(d1);
            var m2 = new Money(d2);
            var addition = m1.Amount + m2.Amount;

            Assert.AreEqual(addition, m1.Add(m2).Amount);
        }
    }
}
