using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4.Model
{
    public class Department : IEquatable<Department>
    {
        public DepartmentType Type { get; }
        public Organization Organization { get; private set; }
        public List<Employee> Employees { get; }
        public string Id { get; private set; }
        public PhoneNumber Phone { get; set; }

        public Department(DepartmentType type) : this(type, new PhoneNumber())
        {
        }

        public Department(string name)
        {
            Type = (DepartmentType)Enum.Parse(typeof(DepartmentType), name, true);
            Phone = new PhoneNumber();
            Employees = new List<Employee>();
            Id = Type.ToString().Substring(0, 1);
        }

        public Department(DepartmentType type, PhoneNumber phone)
        {
            Type = type;
            Phone = phone;
            Employees = new List<Employee>();
            Id = Type.ToString().Substring(0, 1);
        }

        public void AddEmployee(Employee emp)
        {
            if (emp == null)
                throw new ArgumentNullException();
            emp.AddTo(this);
            emp.SetId(Employees.Count + 1);
            Employees.Add(emp);
        }

        public void AddEmployees(params Employee[] emps)
        {
            foreach (var e in emps)
            {
                if (e == null)
                    throw new ArgumentNullException();
                AddEmployee(e);
            }
        }

        public void RemoveEmployee(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException();
            var e = GetEmployee(id);
            if (e == null) 
                throw new ArgumentNullException();
                Employees.Remove(e);
                e.Clear();
        }

        public void AddTo(Organization org)
        {
            Organization = org ?? throw new ArgumentNullException();
        }

        public void Clear()
        {
            Organization = null;
            Id = null;
            foreach (var e in Employees)
                e.Clear();
            Employees.Clear();
        }

        public Employee GetEmployee(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException();
            return Employees.Find(e => e.Id == id);
        }

        private bool HasEmployee(Employee emp)
        {
            if (emp == null)
                throw new ArgumentNullException();
            return Employees.Contains(emp);
        }

        public int CountEmployees ()
        {
            return Employees.Count;
        }

        public double GetAverageSalary()
        {
             int empCount = CountEmployees();
             return (empCount == 0)? 0 : Employees.Sum(e => e.CurrentSalary.Sum) / empCount;
        }

        public bool Equals(Department other)
        {
            if (other != null && Type.Equals(other.Type)) return true;
            return false;
        }

        public override string ToString()
        {
            return $"{Type} (id: {Id})";
        }
    }

}
