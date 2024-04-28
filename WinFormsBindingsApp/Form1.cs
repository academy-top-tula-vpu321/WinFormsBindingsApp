namespace WinFormsBindingsApp
{
    public partial class Form1 : Form
    {
        //public Employee employee;
        public Form1()
        {
            InitializeComponent();

            //employee = new Employee()
            //{
            //    Id = 21,
            //    LastName = "Thomson",
            //    FirstName = "Bobby",
            //    BirthDate = DateTime.Now.AddYears(-30)
            //};


            //this.DataContext = employee;

            //txtEmployeeLastName.DataBindings.Add(new("Text", this.DataContext, "LastName"));
            //txtEmployeeFirstName.DataBindings.Add(new("Text", this.DataContext, "FirstName"));
            //txtEmployeePhone.DataBindings.Add(new("Text", this.DataContext, "Phone"));
            //datePickerEmployeeBirthDate.DataBindings.Add(new("Value", this.DataContext, "BirthDate"));

            //this.DataBindings.Add(new("DataContext"));

            this.DataContext = new EmloyeesListViewModel();

            listBoxEmployees.DataBindings.Add(new Binding("DataSource", 
                                                            this.DataContext, 
                                                            "EmployeesList", 
                                                            false, 
                                                            DataSourceUpdateMode.OnPropertyChanged));
            listBoxEmployees.DisplayMember = "LastName";
            listBoxEmployees.ValueMember = "Id";

            listBoxEmployees.DataBindings.Add(new Binding("SelectedValue",
                                                            this.DataContext,
                                                            "SelectedId",
                                                            false,
                                                            DataSourceUpdateMode.OnPropertyChanged));
            lblEmployeeSelected.DataBindings.Add(new Binding("Text",
                                                              this.DataContext,
                                                              "SelectedEmployee.LastName",
                                                              false,
                                                              DataSourceUpdateMode.OnPropertyChanged));
        }

        //private void btnViewEmployee_Click(object sender, EventArgs e)
        //{
        //    string msg = employee.LastName + "\n";
        //    msg += employee.FirstName + "\n";
        //    msg += employee.BirthDate.ToLongDateString() + "\n";
        //    msg += employee.Phone + "\n";

        //    MessageBox.Show(msg);
        //}

        //private void btnChangeEmployee_Click(object sender, EventArgs e)
        //{
        //    Employee employee2 = new();
        //    employee2.LastName = "Simpson";
        //    employee2.FirstName = "Jimmy";
        //    employee2.Phone = "999 235-67-45";
        //    employee2.BirthDate = DateTime.Now.AddYears(-26);

        //    this.DataContext = employee2;
        //}
    }
}
