﻿using System;
using System.Windows.Forms;
using Lab4.Controllers;
using Lab4.Model;

namespace Lab4.View
{
    public partial class OrganizationForm : Form
    {
        private OrganizationFormController _controller;
        public event EventHandler UpdateForm;

        public OrganizationForm(OrganizationFormController controller)
        {
            InitializeComponent();
            _controller = controller;
            UpdateForm += OnUpdateForm;
        }

        private void OnUpdateForm(object sender, EventArgs e)
        {
            OrganizationInfoTextBox.Text = _controller.OrgInfo;
            ShowDepartments();
            ShowEmployees();
            EnableAddDepartmentButton();
        }

        private void ShowDepartments()
        {
            departmentListView.Items.Clear();
            foreach (var t in _controller.Departments)
            {
                ListViewItem depItem = new ListViewItem();
                depItem.SubItems.Add(t.Id);
                depItem.SubItems.Add(t.Type.ToString());
                depItem.SubItems.Add(t.Phone.ToString());
                departmentListView.Items.Add(depItem);
            }
        }

        private void ShowEmployees()
        {
            employeesListView.Items.Clear();
            foreach (var t in _controller.Employees)
            {
                ListViewItem empItem = new ListViewItem();
                empItem.SubItems.Add(t.Id);
                empItem.SubItems.Add(t.Name.ToString());
                empItem.SubItems.Add($"{t.DateOfBirth:d}");
                empItem.SubItems.Add(t.Position);
                empItem.SubItems.Add(t.CurrentSalary.ToString());
                employeesListView.Items.Add(empItem);
            }
        }

        private void EnableAddDepartmentButton()
        {
            if (_controller.Departments.Count < 6)
            {
                addDepartmentButton.Enabled = true;
            }
            else
            {
                addDepartmentButton.Enabled = false;
            }
        }

        private void initButton_Click(object sender, EventArgs e)
        {

            _controller.InitializeOrganization();
            UpdateForm?.Invoke(this, e);
        }

        private void departmentListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (departmentListView.SelectedItems.Count == 0)
                return;
            var item = departmentListView.SelectedItems[0];
            _controller.SelectDepartment(item.SubItems[1].Text);
            UpdateForm?.Invoke(this, e);
        }

        private void newDepartmentButton_Click(object sender, EventArgs e)
        {
            var newDepartmentController = new NewDepartmentFormController(_controller.Departments, _controller.CityCode);
            var newDepartmentForm = new NewDepartmentForm(newDepartmentController);
            if (newDepartmentForm.ShowDialog() == DialogResult.OK)
            {
                var newDepartment = newDepartmentController.Department;
                _controller.AddDepartment(newDepartment);
            }
            UpdateForm?.Invoke(this, e);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem t in departmentListView.CheckedItems)
                _controller.RemoveDepartment(t.SubItems[1].Text);
            UpdateForm?.Invoke(this, e);
        }

        private void newEmployeeButton_Click(object sender, EventArgs e)
        {
            if (_controller.SelectedDepartment == null) return;

            var newEmployeeController = new NewEmployeeFormController();
            var newEmployeeForm = new NewEmployeeForm(newEmployeeController);

            if (newEmployeeForm.ShowDialog() == DialogResult.OK)
            {
                var newEmployee = newEmployeeController.Employee;
                _controller.AddEmployee(newEmployee);
            }
            ShowEmployees();
        }

        private void removeEmpButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem t in employeesListView.CheckedItems)
                _controller.RemoveEmployee(t.SubItems[1].Text);
            UpdateForm?.Invoke(this, e);
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            reportTextBox.Text = _controller.Report;
        }

        private void departmentListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = departmentListView.Columns[e.ColumnIndex].Width;
        }

        private void employeesListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = employeesListView.Columns[e.ColumnIndex].Width;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
