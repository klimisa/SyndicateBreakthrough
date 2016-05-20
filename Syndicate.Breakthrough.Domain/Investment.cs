using System;

namespace Syndicate.Breakthrough.Domain
{
    public class Investment
    {
        public decimal Percent { get; }
        public Guid Id { get; }
        public Company Investor { get; }

        public Investment(Guid id, Company investor, decimal percent)
        {
            if (id == null)
                throw new ArgumentNullException("Id cannot be null!");

            if (investor == null)
                throw new ArgumentNullException("Please give an investor!");

            if (percent < 0)
                throw new ArgumentOutOfRangeException("Percentage cannot be negative!");

            Id = id;
            Investor = investor;
            Percent = percent;
        }
    }
}