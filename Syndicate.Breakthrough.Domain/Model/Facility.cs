using System;
using System.Collections.Generic;

namespace Syndicate.Breakthrough.Domain.Model
{
    public class Facility
    {
        public Guid Id { get; }

        public Money Limit { get; }

        public List<Investment> Investments { get; }

        public Loan Loan { get; set; }

        public Facility(Guid id, Money limit)
        {
            if (id == null)
                throw new ArgumentNullException("Id cannot be null!");

            if (limit == null)
                throw new ArgumentNullException("Please specify the facility limit.");

            Id = id;
            Limit = limit;
            Investments = new List<Investment>();
        }
    }
}