using System;
using System.Collections.Generic;

namespace Lab4.Model
{
    public static class OrgInit
    {
        public static List<string> FirstNames = new List<string> { "Florence", "George", "Ann", "Erin", "Mark" };
        public static List<string> LastNames = new List<string> { "Cat", " Racoon", "Squirrel", "Weasel", "Hamster" };
        public static List<string> Positions = new List<string> { "manager", "employee", "secretary", "accountant" };
        public static List<string> Streets = new List<string> { "First St.", "Second St.", "Third St." };
        private static readonly Random Rand = new Random();

        public static Employee GetRandEmployee()
        {
            FullName name = new FullName(FirstNames[Rand.Next(FirstNames.Count)], LastNames[Rand.Next(LastNames.Count)]);
            Employee randEmp = new Employee(name, GetRandDateTime(), GetRandTitle());
            return randEmp;
        }

        public static DateTime GetRandDateTime()
        {
            DateTime randDate = new DateTime(Rand.Next(1930, 2000), Rand.Next(1, 13), Rand.Next(1, 29));
            return randDate;
        }

        public static Address GetRandAddress()
        {
            Address randAddress = new Address("Chicago", Streets[Rand.Next(Streets.Count)], Rand.Next(100));
            return randAddress;
        }

        public static string GetRandTitle()
        {
            return Positions[Rand.Next(Positions.Count)];
        }

        public static PhoneNumber GetRandPhone()
        {
            PhoneNumber randPhone = new PhoneNumber(9, Rand.Next(10000, 99999));
            return randPhone;
        }

        public static void InitializeOrganization(Organization test)
        {
            test.Address = GetRandAddress();
            test.Phone = GetRandPhone();
            test.AddDepartments(new Department(DepartmentType.Marketing, GetRandPhone()),
                        new Department(DepartmentType.Production, GetRandPhone()),
                        new Department(DepartmentType.Research, GetRandPhone()));
            foreach (var d in test.Departments)
            {
                d.AddEmployees(GetRandEmployee(), GetRandEmployee());
            }
            test.Departments[0].AddEmployee(GetRandEmployee());
        }
    }
}
