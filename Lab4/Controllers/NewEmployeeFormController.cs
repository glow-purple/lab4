using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using Lab4.Model;

namespace Lab4.Controllers
{
    public class NewEmployeeFormController : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private int? _year;
        private int? _month;
        private int? _day;
        private string _position;

        public Employee Employee => CanSave
            ? new Employee(new FullName(FirstName, LastName),
                new DateTime(Year.Value, Month.Value, Day.Value), Position)
            : null;

        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }

        public int? Year
        {
            get => _year;
            set
            {
                _year = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }

        public int? Month
        {
            get => _month;
            set
            {
                _month = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }

        public int? Day
        {
            get => _day;
            set
            {
                _day = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }

        public string Position
        {
            get => _position;
            set
            {
                _position = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }

        public bool CanSave =>
        !string.IsNullOrWhiteSpace(FirstName)
        && !string.IsNullOrWhiteSpace(LastName)
        && Year.HasValue
        && Month.HasValue
        && Day.HasValue
        && !string.IsNullOrWhiteSpace(Position);

        public event PropertyChangedEventHandler PropertyChanged;

        //  [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}