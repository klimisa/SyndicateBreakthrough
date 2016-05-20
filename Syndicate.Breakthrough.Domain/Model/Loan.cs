using System.Collections.Generic;

namespace Syndicate.Breakthrough.Domain.Model
{
    public class Loan
    {
        public Facility Facility { get; }
        public Money Amount { get; private set; }

        public List<LoanInvestment> LoanInvestments { get; }

        public Loan(Facility facility, Money amount)
        {
            Facility = facility;
            LoanInvestments = new List<LoanInvestment>();
            Amount = amount;
        }

        public void Increase(Money money)
        {
            Amount = Amount.Add(money);
        }

        public void Decrease(Money money)
        {
            Amount = Amount.Subtract(money);
        }
    }
}
