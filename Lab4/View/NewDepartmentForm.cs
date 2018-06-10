using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Lab4.Controllers;
using Lab4.Model;

namespace Lab4.View
{
    public partial class NewDepartmentForm : Form
    {
        private NewDepartmentFormController _controller;

        public NewDepartmentForm(NewDepartmentFormController controller)
        {
            InitializeComponent();
            _controller = controller;

            GetDepartments();
            cityCodeTextBox.Text = _controller.CityCode.ToString();

            _controller.PropertyChanged += _controller_PropertyChanged;
        }

        private void _controller_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(_controller.CanSave))
                addButton.Enabled = _controller.CanSave;
        }

        public void GetDepartments()
        {
            foreach (var t in _controller.Departments)
                depTypeComboBox.Items.Add(t);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Fill in all fields");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void phoneNumberTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(phoneNumberTextBox.Text, out int phoneNumber))
            {
                e.Cancel = true;
                errorProvider1.SetError(phoneNumberTextBox, "Invalid phone number");
            }
        }

        private void phoneNumberTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(phoneNumberTextBox, "");
            _controller.Number = int.Parse(phoneNumberTextBox.Text);
        }

        private void depTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _controller.DepType = depTypeComboBox.SelectedItem as DepartmentType?;
        }
    }
}
