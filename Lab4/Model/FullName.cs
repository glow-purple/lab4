using System;

namespace Lab4.Model
{
    public class FullName
    {
        public string FirstName { get; }
        public string LastName { get; }

        public FullName(string fn, string ln)
        {
            FirstName = fn ?? throw new ArgumentException("invalid name");
            LastName = ln ?? throw new ArgumentException("invalid name");
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
