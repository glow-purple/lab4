using System;

namespace Lab4.Model
{
    public class Employee : Person, IEquatable<Employee>
    {
        public Organization Organization { get; private set; }
        public string Id { get; private set; }
        public Department Department { get; private set; }
        public string Position { get; }
        public Salary CurrentSalary { get; }

        public Employee(FullName name, DateTime birthDate, string position) : base(name, birthDate)
        {
            if (string.IsNullOrWhiteSpace(position))
            throw new ArgumentException("invalid position");
            Position = position;
            CurrentSalary = new Salary();
            Id = "0";
        }

        public void AddTo(Department dep)
        {
            Department = dep ?? throw new ArgumentNullException();
            Organization = dep.Organization;
        }

        public void SetId(int id)
        {
            Id = Department.Id + id;
        }
        
        public void Clear()
        {
            Id = null;
            Department = null;
            Organization = null;
        }

        public override string ToString()
        {
            return $"id: {Id} {Name} ({DateOfBirth:d}) title: {Position} in {Department} (salary: {CurrentSalary})";
        }

        public bool Equals(Employee other)
        {
            return (other != null) && Id.Equals(other.Id);
        }
    }
}
