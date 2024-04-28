using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBindingsApp
{
    public class EmployeeViewModel : INotifyPropertyChanged
    {
        public Employee Employee { get; set; } = new Employee();

        public int Id { get; set; }
        public string LastName
        {
            get => Employee.LastName;
            set
            {
                if(Employee.LastName != value)
                {
                    Employee.LastName = value;
                    OnPropertyChanged();
                }
            }
        }
        public string FirstName 
        { 
            get => Employee.FirstName;
            set
            {
                if(Employee.FirstName != value)
                {
                    Employee.FirstName = value;
                    OnPropertyChanged();
                }
                
            }
        }
        public DateTime BirthDate
        {
            get => Employee.BirthDate;
            set
            {
                if(Employee.BirthDate != value)
                {
                    Employee.BirthDate = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Phone 
        { 
            get => Employee.Phone;
            set
            {
                if(Employee.Phone != value)
                {
                    Employee.Phone = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
