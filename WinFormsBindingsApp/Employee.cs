using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBindingsApp
{
    public class Employee
    {
        public int Id { get; set; }
        public string LastName { get; set; } = null!;
        public string? FirstName {  get; set; }
        public DateTime BirthDate { get; set; }
        public string? Phone { get; set; }
    }
}
