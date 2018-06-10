using System;

namespace Lab4.Model
{
    public class Address
    {
        public string City { get; }
        public string Street { get; }
        public int House { get; }

        public Address() : this ("n/a", "n/a", 0)
        {
        }

        public Address (string city, string street, int house)
        {
            if (string.IsNullOrWhiteSpace(city))
            {
                throw new ArgumentException("invalid argument");
            }
            if (string.IsNullOrWhiteSpace(street))
            {
                throw new ArgumentException("invalid argument");
            }
            City = city;
            Street = street;
            House = house;
        }

        public override string ToString()
        {
            return $"{House}, {Street}, {City}";
        }
    }
}
