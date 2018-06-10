using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Lab4.Controllers;
using Lab4.Model;

namespace Lab4.View
{
    public partial class NewDepartmentForm : Form
    {
        private NewDepartmentFormController _controller;

        public NewDepartmentForm(List<Department> departments, int cityCode)
        {
            InitializeComponent();
            _controller = new NewDepartmentFormController(departments, cityCode);
            GetDepartments();
            cityCodeTextBox.Text = cityCode.ToString();
        }

        public void GetDepartments()
        {
            foreach (var t in _controller.DepartmentTypes)
                depTypeComboBox.Items.Add(t);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.Add((DepartmentType)depTypeComboBox.SelectedItem, Int32.Parse(phoneNumberTextBox.Text));
                Close();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Fill in all fields");
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void phoneNumberTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Int32.TryParse(phoneNumberTextBox.Text, out int phoneNumber))
            {
                e.Cancel = true;
                errorProvider1.SetError(phoneNumberTextBox, "Invalid phone number");
            }
        }

        private void phoneNumberTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(phoneNumberTextBox, "");
        }

    }
}
