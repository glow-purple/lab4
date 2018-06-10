using System;
using System.Collections.Generic;
using System.Linq;
using Lab4.Model;
using Lab4.View;

namespace Lab4.Controllers
{
    class NewDepartmentFormController
    {
        private List<Department> _departments;
        private int _cityCode;
        public List<DepartmentType> DepartmentTypes= new List<DepartmentType>();

        public NewDepartmentFormController(List<Department> departments, int cityCode)
        {
            _departments= departments;
            _cityCode = cityCode;
            foreach (var t in Enum.GetValues(typeof(DepartmentType)).Cast<DepartmentType>().ToList())
            {
                if (!_departments.Any(d => d.Type == t))
                {
                    DepartmentTypes.Add(t);
                }
            }
        }

        public void Add(DepartmentType type, int phoneNumber)
        {
           _departments.Add(new Department(type, new PhoneNumber(_cityCode, phoneNumber)));
        }
    }
}
