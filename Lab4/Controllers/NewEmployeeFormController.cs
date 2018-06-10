using System;
using Lab4.Model;

namespace Lab4.Controllers
{
    class NewEmployeeFormController
    {
        private Employee _employee;
        private Department department { get; }

        public NewEmployeeFormController(Department selecteDepartment)
        {
            department = selecteDepartment;
        }

        public void AddNewEmployee(string fName, string lName, int year, int month, int day, string position)
        {
           _employee = new Employee(new FullName(fName, lName), new DateTime(year, month, day), position);
            department.AddEmployee(_employee);
        }
    }
}
