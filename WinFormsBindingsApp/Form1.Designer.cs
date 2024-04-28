namespace WinFormsBindingsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxEmployee = new GroupBox();
            btnChangeEmployee = new Button();
            btnViewEmployee = new Button();
            lblEmployeeBirthDate = new Label();
            datePickerEmployeeBirthDate = new DateTimePicker();
            txtEmployeePhone = new TextBox();
            lblEmployeePhone = new Label();
            txtEmployeeFirstName = new TextBox();
            lblEmployeeFirstName = new Label();
            txtEmployeeLastName = new TextBox();
            lblEmployeeLastName = new Label();
            groupBoxEmoyeesList = new GroupBox();
            listBoxEmployees = new ListBox();
            lblEmployeeSelected = new Label();
            groupBoxEmployee.SuspendLayout();
            groupBoxEmoyeesList.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxEmployee
            // 
            groupBoxEmployee.Controls.Add(btnChangeEmployee);
            groupBoxEmployee.Controls.Add(btnViewEmployee);
            groupBoxEmployee.Controls.Add(lblEmployeeBirthDate);
            groupBoxEmployee.Controls.Add(datePickerEmployeeBirthDate);
            groupBoxEmployee.Controls.Add(txtEmployeePhone);
            groupBoxEmployee.Controls.Add(lblEmployeePhone);
            groupBoxEmployee.Controls.Add(txtEmployeeFirstName);
            groupBoxEmployee.Controls.Add(lblEmployeeFirstName);
            groupBoxEmployee.Controls.Add(txtEmployeeLastName);
            groupBoxEmployee.Controls.Add(lblEmployeeLastName);
            groupBoxEmployee.Font = new Font("Segoe UI", 16F);
            groupBoxEmployee.Location = new Point(452, 29);
            groupBoxEmployee.Name = "groupBoxEmployee";
            groupBoxEmployee.Size = new Size(702, 415);
            groupBoxEmployee.TabIndex = 0;
            groupBoxEmployee.TabStop = false;
            groupBoxEmployee.Text = "Employee:";
            // 
            // btnChangeEmployee
            // 
            btnChangeEmployee.Location = new Point(455, 205);
            btnChangeEmployee.Name = "btnChangeEmployee";
            btnChangeEmployee.Size = new Size(225, 76);
            btnChangeEmployee.TabIndex = 5;
            btnChangeEmployee.Text = "Change Employee";
            btnChangeEmployee.UseVisualStyleBackColor = true;
            // 
            // btnViewEmployee
            // 
            btnViewEmployee.Location = new Point(455, 305);
            btnViewEmployee.Name = "btnViewEmployee";
            btnViewEmployee.Size = new Size(225, 83);
            btnViewEmployee.TabIndex = 4;
            btnViewEmployee.Text = "View Employee";
            btnViewEmployee.UseVisualStyleBackColor = true;
            // 
            // lblEmployeeBirthDate
            // 
            lblEmployeeBirthDate.AutoSize = true;
            lblEmployeeBirthDate.Location = new Point(465, 56);
            lblEmployeeBirthDate.Name = "lblEmployeeBirthDate";
            lblEmployeeBirthDate.Size = new Size(109, 30);
            lblEmployeeBirthDate.TabIndex = 3;
            lblEmployeeBirthDate.Text = "Birth Date";
            // 
            // datePickerEmployeeBirthDate
            // 
            datePickerEmployeeBirthDate.Location = new Point(455, 89);
            datePickerEmployeeBirthDate.Name = "datePickerEmployeeBirthDate";
            datePickerEmployeeBirthDate.Size = new Size(225, 36);
            datePickerEmployeeBirthDate.TabIndex = 2;
            // 
            // txtEmployeePhone
            // 
            txtEmployeePhone.Location = new Point(19, 305);
            txtEmployeePhone.Name = "txtEmployeePhone";
            txtEmployeePhone.Size = new Size(385, 36);
            txtEmployeePhone.TabIndex = 1;
            // 
            // lblEmployeePhone
            // 
            lblEmployeePhone.AutoSize = true;
            lblEmployeePhone.Location = new Point(19, 272);
            lblEmployeePhone.Name = "lblEmployeePhone";
            lblEmployeePhone.Size = new Size(74, 30);
            lblEmployeePhone.TabIndex = 0;
            lblEmployeePhone.Text = "Phone";
            // 
            // txtEmployeeFirstName
            // 
            txtEmployeeFirstName.Location = new Point(19, 193);
            txtEmployeeFirstName.Name = "txtEmployeeFirstName";
            txtEmployeeFirstName.Size = new Size(385, 36);
            txtEmployeeFirstName.TabIndex = 1;
            // 
            // lblEmployeeFirstName
            // 
            lblEmployeeFirstName.AutoSize = true;
            lblEmployeeFirstName.Location = new Point(19, 160);
            lblEmployeeFirstName.Name = "lblEmployeeFirstName";
            lblEmployeeFirstName.Size = new Size(117, 30);
            lblEmployeeFirstName.TabIndex = 0;
            lblEmployeeFirstName.Text = "First Name";
            // 
            // txtEmployeeLastName
            // 
            txtEmployeeLastName.Location = new Point(19, 91);
            txtEmployeeLastName.Name = "txtEmployeeLastName";
            txtEmployeeLastName.Size = new Size(385, 36);
            txtEmployeeLastName.TabIndex = 1;
            // 
            // lblEmployeeLastName
            // 
            lblEmployeeLastName.AutoSize = true;
            lblEmployeeLastName.Location = new Point(19, 58);
            lblEmployeeLastName.Name = "lblEmployeeLastName";
            lblEmployeeLastName.Size = new Size(114, 30);
            lblEmployeeLastName.TabIndex = 0;
            lblEmployeeLastName.Text = "Last Name";
            // 
            // groupBoxEmoyeesList
            // 
            groupBoxEmoyeesList.Controls.Add(lblEmployeeSelected);
            groupBoxEmoyeesList.Controls.Add(listBoxEmployees);
            groupBoxEmoyeesList.Font = new Font("Segoe UI", 16F);
            groupBoxEmoyeesList.Location = new Point(12, 29);
            groupBoxEmoyeesList.Name = "groupBoxEmoyeesList";
            groupBoxEmoyeesList.Size = new Size(414, 502);
            groupBoxEmoyeesList.TabIndex = 1;
            groupBoxEmoyeesList.TabStop = false;
            groupBoxEmoyeesList.Text = "Employees List";
            // 
            // listBoxEmployees
            // 
            listBoxEmployees.FormattingEnabled = true;
            listBoxEmployees.ItemHeight = 30;
            listBoxEmployees.Location = new Point(3, 32);
            listBoxEmployees.Name = "listBoxEmployees";
            listBoxEmployees.Size = new Size(408, 364);
            listBoxEmployees.TabIndex = 0;
            // 
            // lblEmployeeSelected
            // 
            lblEmployeeSelected.AutoSize = true;
            lblEmployeeSelected.Location = new Point(6, 438);
            lblEmployeeSelected.Name = "lblEmployeeSelected";
            lblEmployeeSelected.Size = new Size(0, 30);
            lblEmployeeSelected.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 577);
            Controls.Add(groupBoxEmoyeesList);
            Controls.Add(groupBoxEmployee);
            Name = "Form1";
            Text = "Form1";
            groupBoxEmployee.ResumeLayout(false);
            groupBoxEmployee.PerformLayout();
            groupBoxEmoyeesList.ResumeLayout(false);
            groupBoxEmoyeesList.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxEmployee;
        private DateTimePicker datePickerEmployeeBirthDate;
        private TextBox txtEmployeePhone;
        private Label lblEmployeePhone;
        private TextBox txtEmployeeFirstName;
        private Label lblEmployeeFirstName;
        private TextBox txtEmployeeLastName;
        private Label lblEmployeeLastName;
        private Label lblEmployeeBirthDate;
        private Button btnViewEmployee;
        private Button btnChangeEmployee;
        private GroupBox groupBoxEmoyeesList;
        private ListBox listBoxEmployees;
        private Label lblEmployeeSelected;
    }
}
