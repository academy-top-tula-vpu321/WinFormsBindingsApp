using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBindingsApp
{
    internal class EmloyeesListViewModel
    {
        public int SelectedId { get; set; }

        public EmployeeViewModel SelectedEmployee 
        { 
            get => EmployeesList.FirstOrDefault(e => e.Id == SelectedId)!;
        }

        public List<EmployeeViewModel> EmployeesList { get;}

        public EmloyeesListViewModel()
        {
            EmployeesList = new List<EmployeeViewModel>()
            {
                new()
                {
                    Id = 1,
                    LastName = "Whatson",
                    FirstName = "Billy",
                    BirthDate = new DateTime(1999, 5, 10),
                    Phone = "(999) 111-22-33"
                },
                new()
                {
                    Id = 2,
                    LastName = "Simpson",
                    FirstName = "Tommy",
                    BirthDate = new DateTime(2002, 2, 18),
                    Phone = "(900) 555-00-99"
                },
                new()
                {
                    Id = 3,
                    LastName = "House",
                    FirstName = "Gregory",
                    BirthDate = new DateTime(1984, 7, 8),
                    Phone = "(555) 456-65-56"
                },
            };

            SelectedId = 2;
        }
    }
}
