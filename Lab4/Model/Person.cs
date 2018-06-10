using System;

namespace Lab4.Model
{
    public abstract class Person
    {
        public FullName Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        protected Person()
        {
            Name = new FullName("default", "default");
            DateOfBirth = default(DateTime);
        }
        protected Person(FullName name, DateTime birthDate)
        {
            Name = name;
            DateOfBirth = birthDate;
        }

    }
}
