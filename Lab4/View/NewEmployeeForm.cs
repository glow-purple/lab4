using System;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Lab4.Controllers;
using Lab4.Model;

namespace Lab4
{
    public partial class NewEmployeeForm : Form
    {
        private NewEmployeeFormController _controller;

        public NewEmployeeForm(Department selectedDepartment)
        {
            InitializeComponent();
            _controller = new NewEmployeeFormController(selectedDepartment);

            YearComboBox.Items.AddRange(Enumerable.Range(1950, 50).Cast<object>().ToArray());
            MonthComboBox.Items.AddRange(Enumerable.Range(1, 12).Cast<object>().ToArray());
            DayComboBox.Items.AddRange(Enumerable.Range(1, 30).Cast<object>().ToArray());
        }
        
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.AddNewEmployee(firstNameTextBox.Text, lastNameTextBox.Text,
                    (int) YearComboBox.SelectedItem,
                    (int) MonthComboBox.SelectedItem,
                    (int) DayComboBox.SelectedItem, positionTextBox.Text);
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

        private void firstNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateString(firstNameTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(firstNameTextBox, "Invalid name");
            }
        }

        private void lastNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateString(lastNameTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(lastNameTextBox, "Invalid name");
            }
        }

        private void positionTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateString(positionTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(positionTextBox, "Invalid position");
            }
        }

        private void firstNameTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(firstNameTextBox, "");
        }

        private void lastNameTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(lastNameTextBox, "");
        }

        private void positionTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(positionTextBox, "");
        }

        static bool ValidateString(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z]+$");
        }
    }
}