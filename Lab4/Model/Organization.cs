using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4.Model
{
    public class Organization
    {
        public string Name { get; }
        public List<Department> Departments { get; }
        public Address Address { get; set; }
        public PhoneNumber Phone { get; set; }
        
        public Organization(string name) : this(name, new Address(), new PhoneNumber())
        {
            Name = name;
        }

        public Organization(string name, Address address, PhoneNumber phone, params Department[] departments)
        {
            Name = string.IsNullOrWhiteSpace(name) ? throw new ArgumentException("invalid name") : name;
            Departments = new List<Department>();
            Address = address;
            Phone = phone;
            foreach (var d in departments)
            {
                if (!(HasDepartment(d)))
                {
                    Departments.Add(d);
                }
            }
        }

        public void AddDepartment(Department dep)
        {
            if (dep == null)
                throw new ArgumentNullException();
            if (!HasDepartment(dep))
            {
                Departments.Add(dep);
                dep.AddTo(this);
            }
        }

        public void AddDepartments(params Department[] deps)
        {
            foreach (var t in deps)
            {
                if (t == null)
                    throw new ArgumentNullException();
                AddDepartment(t);
            }
        }
        public void RemoveDepartment(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException();
           Department dep = GetDepartment(id);
            if (dep == null)
                throw new ArgumentNullException();
            Departments.Remove(dep);
            dep.Clear();
        }
        
        public void MoveEmployee(string fromDepId, string empId, string toDepId)
        {
            if (string.IsNullOrWhiteSpace(fromDepId))
                throw new ArgumentException();
            if (string.IsNullOrWhiteSpace(toDepId))
                throw new ArgumentException();
            if (string.IsNullOrWhiteSpace(empId))
                throw new ArgumentException();
            var fromDep = GetDepartment(fromDepId);
            var toDep = GetDepartment(toDepId);
            if (!(fromDep == null || toDep == null))
            {
                var e = fromDep.GetEmployee(empId);
                if (e != null)
                {
                    fromDep.RemoveEmployee(empId);
                    toDep.AddEmployee(e);
                }
            }
        }

        public int CountEmployees() => Departments.Sum(d => d.CountEmployees());

        public Department GetDepartment(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException();
            return Departments.Find(e => e.Id == id);
        }

        private bool HasDepartment(Department dep)
        {
            if (dep == null)
                throw new ArgumentNullException();
            return Departments.Contains(dep);
        }

        public override string ToString() => $"\"{Name}\"";
    }
}
