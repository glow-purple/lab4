using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Lab4.Model;
using Lab4.View;

namespace Lab4.Controllers
{
    public class OrganizationFormController
    {
        private Organization _organization;
        public int CityCode => _organization.Phone.CityCode;
        public List<Department> Departments =>_organization?.Departments?? new List<Department>();
        public Department SelectedDepartment { get; set; }
        public List<Employee> Employees => SelectedDepartment?.Employees??new List<Employee>();
        public string OrgInfo => IsSet ? $"{ _organization } { _organization.Address}, { _organization.Phone}" : " ";
        public string Report => IsSet ? $"Organization has {_organization.CountEmployees()} employee(s) in {_organization.Departments.Count}" +
                                $" departments with average salary {Departments.Sum(d => d.GetAverageSalary())/Departments.Count:c}" : " ";
        
        private bool IsSet => _organization!=null;

        public OrganizationFormController()
        {
           _organization = new Organization("default");
        }

        public void InitializeOrganization()
        {
            Organization test = new Organization("Test");
            OrgInit.InitializeOrganization(test);
            _organization = test;
        }

        public void AddEmployee(Employee newEmployee)
        {
            SelectedDepartment.AddEmployee(newEmployee);
        }

        public void AddDepartment(Department newDepartment)
        {
            _organization.AddDepartment(newDepartment);
        }

        public void SelectDepartment(string id)
        {
            SelectedDepartment = Departments.Find(d => d.Id == id);
        }

        public void RemoveDepartment(string id)
        {
            _organization.RemoveDepartment(id);
        }

        public void RemoveEmployee(string id)
        {
            SelectedDepartment.RemoveEmployee(id);
        }
    }
}
