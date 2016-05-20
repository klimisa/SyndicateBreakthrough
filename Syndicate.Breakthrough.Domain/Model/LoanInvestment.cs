namespace Syndicate.Breakthrough.Domain.Model
{
    public class LoanInvestment
    {
        public Investment Investment { get; }

        public Money Amount { get; }

        public LoanInvestment(Investment investment, Money amount)
        {
            Investment = investment;
            Amount = amount;
        }
    }
}