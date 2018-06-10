using System.Collections.Generic;
using System.Linq;
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
        public string OrgInfo => $"{ _organization } { _organization.Address}, { _organization.Phone}";
        public string Report => $"Organization has {_organization.CountEmployees()} employee(s) in {_organization.Departments.Count}" +
                                $" departments with average salary {Departments.Sum(d => d.GetAverageSalary())/Departments.Count:c}";


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
