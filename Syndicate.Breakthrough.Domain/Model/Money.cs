using System;
using System.Runtime.InteropServices;

namespace Syndicate.Breakthrough.Domain
{
    public class Money
    {
        public decimal Amount { get; }

        public Money(decimal amount)
        {
            Amount = amount;
        }

        public Money Add(Money money)
        {
            var newAmount = Amount + money.Amount;
            return new Money(newAmount);
        }

        public Money Subtract(Money money)
        {
            var newAmount = Amount - money.Amount;
            return new Money(newAmount);
        }

        public override string ToString()
        {
            return $"{Amount.ToString("G")} {"EUR"}";
        }
    }
}