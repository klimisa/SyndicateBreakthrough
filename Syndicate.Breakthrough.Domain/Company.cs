using System;

namespace Syndicate.Breakthrough.Domain
{
    public class Company
    {
        public Guid Id { get; }
        public string Name { get; }

        public Company(Guid id, string name)
        {
            if (id == null)
                throw new ArgumentNullException("Id cannot be null!");

            if (String.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Please give a name to the company!");

            Id = id;
            Name = name;
        }
    }
}