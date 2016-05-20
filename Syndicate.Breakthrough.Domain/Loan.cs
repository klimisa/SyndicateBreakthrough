using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syndicate.Breakthrough.Domain
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
