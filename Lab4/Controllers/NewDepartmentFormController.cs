using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Lab4.Model;
using Lab4.View;

namespace Lab4.Controllers
{
    public class NewDepartmentFormController
    {
        private int? _number;

        public DepartmentType? DepType { get; set; }

        public int? CityCode { get; set; }

        public int? Number
        {
            get => _number;
            set
            {
                _number = value;
                OnPropertyChanged(nameof(CanSave));
            }
            
        }
        public List<DepartmentType> Departments { get; }

        public Department Department => CanSave
            ? new Department(DepType.Value, new PhoneNumber(CityCode.Value, Number.Value))
            : null;

        public bool CanSave => DepType.HasValue && CityCode.HasValue && Number.HasValue;

        public event PropertyChangedEventHandler PropertyChanged;

        public NewDepartmentFormController(List<Department> departments, int cityCode)
        {
            Departments = new List<DepartmentType>();
            foreach (var t in Enum.GetValues(typeof(DepartmentType)).Cast<DepartmentType>().ToList())
            {
                if (departments.All(d => d.Type != t))
                {
                    Departments.Add(t);
                }
            }
            CityCode = cityCode;
        }
       // [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}