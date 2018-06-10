namespace Lab4.View
{
    partial class organizationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.departmentListView = new System.Windows.Forms.ListView();
            this.checkboxColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Department = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employeesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateOfBirthColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.positionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.salaryColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrganizationInfoTextBox = new System.Windows.Forms.TextBox();
            this.reportTextBox = new System.Windows.Forms.TextBox();
            this.initButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.newEmployeeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.removeDepButton = new System.Windows.Forms.Button();
            this.addDepartmentButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.removeEmpButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // departmentListView
            // 
            this.departmentListView.BackColor = System.Drawing.SystemColors.Window;
            this.departmentListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.departmentListView.CheckBoxes = true;
            this.departmentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.checkboxColumn,
            this.Id,
            this.Department,
            this.PhoneNumber});
            this.departmentListView.ForeColor = System.Drawing.SystemColors.WindowText;
            this.departmentListView.FullRowSelect = true;
            this.departmentListView.GridLines = true;
            this.departmentListView.HideSelection = false;
            this.departmentListView.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.departmentListView.Location = new System.Drawing.Point(108, 162);
            this.departmentListView.MultiSelect = false;
            this.departmentListView.Name = "departmentListView";
            this.departmentListView.Scrollable = false;
            this.departmentListView.Size = new System.Drawing.Size(728, 747);
            this.departmentListView.TabIndex = 0;
            this.departmentListView.UseCompatibleStateImageBehavior = false;
            this.departmentListView.View = System.Windows.Forms.View.Details;
            this.departmentListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.departmentListView_ColumnWidthChanging);
            this.departmentListView.SelectedIndexChanged += new System.EventHandler(this.departmentListView_SelectedIndexChanged);
            // 
            // checkboxColumn
            // 
            this.checkboxColumn.Text = "";
            this.checkboxColumn.Width = 25;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 35;
            // 
            // Department
            // 
            this.Department.Text = "Department";
            this.Department.Width = 130;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Text = "PhoneNumber";
            this.PhoneNumber.Width = 150;
            // 
            // employeesListView
            // 
            this.employeesListView.AutoArrange = false;
            this.employeesListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeesListView.CheckBoxes = true;
            this.employeesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.idColumn,
            this.nameColumn,
            this.dateOfBirthColumn,
            this.positionColumn,
            this.salaryColumn});
            this.employeesListView.GridLines = true;
            this.employeesListView.Location = new System.Drawing.Point(918, 162);
            this.employeesListView.MultiSelect = false;
            this.employeesListView.Name = "employeesListView";
            this.employeesListView.Scrollable = false;
            this.employeesListView.Size = new System.Drawing.Size(1085, 747);
            this.employeesListView.TabIndex = 2;
            this.employeesListView.UseCompatibleStateImageBehavior = false;
            this.employeesListView.View = System.Windows.Forms.View.Details;
            this.employeesListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.employeesListView_ColumnWidthChanging);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 20;
            // 
            // idColumn
            // 
            this.idColumn.Text = "Id";
            this.idColumn.Width = 35;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 130;
            // 
            // dateOfBirthColumn
            // 
            this.dateOfBirthColumn.Text = "Date of Birth";
            this.dateOfBirthColumn.Width = 78;
            // 
            // positionColumn
            // 
            this.positionColumn.Text = "Position";
            this.positionColumn.Width = 70;
            // 
            // salaryColumn
            // 
            this.salaryColumn.Text = "CurrentSalary";
            this.salaryColumn.Width = 90;
            // 
            // OrganizationInfoTextBox
            // 
            this.OrganizationInfoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.OrganizationInfoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrganizationInfoTextBox.Location = new System.Drawing.Point(32, 27);
            this.OrganizationInfoTextBox.Multiline = true;
            this.OrganizationInfoTextBox.Name = "OrganizationInfoTextBox";
            this.OrganizationInfoTextBox.ReadOnly = true;
            this.OrganizationInfoTextBox.Size = new System.Drawing.Size(1640, 68);
            this.OrganizationInfoTextBox.TabIndex = 3;
            this.OrganizationInfoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // reportTextBox
            // 
            this.reportTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.reportTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportTextBox.Location = new System.Drawing.Point(32, 13);
            this.reportTextBox.Multiline = true;
            this.reportTextBox.Name = "reportTextBox";
            this.reportTextBox.ReadOnly = true;
            this.reportTextBox.Size = new System.Drawing.Size(1052, 86);
            this.reportTextBox.TabIndex = 4;
            this.reportTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // initButton
            // 
            this.initButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.initButton.Location = new System.Drawing.Point(1748, 27);
            this.initButton.Name = "initButton";
            this.initButton.Size = new System.Drawing.Size(215, 68);
            this.initButton.TabIndex = 5;
            this.initButton.Text = "Init";
            this.initButton.UseVisualStyleBackColor = true;
            this.initButton.Click += new System.EventHandler(this.initButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.reportButton.Location = new System.Drawing.Point(1253, 22);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(349, 68);
            this.reportButton.TabIndex = 6;
            this.reportButton.Text = "Get Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // newEmployeeButton
            // 
            this.newEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.newEmployeeButton.Location = new System.Drawing.Point(394, 0);
            this.newEmployeeButton.Name = "newEmployeeButton";
            this.newEmployeeButton.Size = new System.Drawing.Size(349, 68);
            this.newEmployeeButton.TabIndex = 8;
            this.newEmployeeButton.Text = "Add New";
            this.newEmployeeButton.UseVisualStyleBackColor = true;
            this.newEmployeeButton.Click += new System.EventHandler(this.newEmployeeButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.removeDepButton);
            this.panel1.Controls.Add(this.addDepartmentButton);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(108, 937);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 140);
            this.panel1.TabIndex = 10;
            // 
            // removeDepButton
            // 
            this.removeDepButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeDepButton.Location = new System.Drawing.Point(398, 74);
            this.removeDepButton.Name = "removeDepButton";
            this.removeDepButton.Size = new System.Drawing.Size(330, 68);
            this.removeDepButton.TabIndex = 10;
            this.removeDepButton.Text = "Delete Seleted";
            this.removeDepButton.UseVisualStyleBackColor = true;
            this.removeDepButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addDepartmentButton
            // 
            this.addDepartmentButton.Enabled = false;
            this.addDepartmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDepartmentButton.Location = new System.Drawing.Point(398, 0);
            this.addDepartmentButton.Name = "addDepartmentButton";
            this.addDepartmentButton.Size = new System.Drawing.Size(330, 68);
            this.addDepartmentButton.TabIndex = 9;
            this.addDepartmentButton.Text = "Add New";
            this.addDepartmentButton.UseVisualStyleBackColor = true;
            this.addDepartmentButton.Click += new System.EventHandler(this.newDepartmentButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.OrganizationInfoTextBox);
            this.panel2.Controls.Add(this.initButton);
            this.panel2.Location = new System.Drawing.Point(40, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1963, 113);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cancelButton);
            this.panel3.Controls.Add(this.reportTextBox);
            this.panel3.Controls.Add(this.reportButton);
            this.panel3.Location = new System.Drawing.Point(40, 1098);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1963, 102);
            this.panel3.TabIndex = 14;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cancelButton.Location = new System.Drawing.Point(1611, 22);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(349, 68);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Exit";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.removeEmpButton);
            this.panel4.Controls.Add(this.newEmployeeButton);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(1260, 937);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(743, 140);
            this.panel4.TabIndex = 15;
            // 
            // removeEmpButton
            // 
            this.removeEmpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.removeEmpButton.Location = new System.Drawing.Point(394, 74);
            this.removeEmpButton.Name = "removeEmpButton";
            this.removeEmpButton.Size = new System.Drawing.Size(349, 68);
            this.removeEmpButton.TabIndex = 10;
            this.removeEmpButton.Text = "Delete Selected";
            this.removeEmpButton.UseVisualStyleBackColor = true;
            this.removeEmpButton.Click += new System.EventHandler(this.removeEmpButton_Click);
            // 
            // organizationForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.cancelButton;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(2068, 1212);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.employeesListView);
            this.Controls.Add(this.departmentListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2100, 1300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(2100, 1300);
            this.Name = "organizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organization";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView departmentListView;
        private System.Windows.Forms.ListView employeesListView;
        private System.Windows.Forms.TextBox OrganizationInfoTextBox;
        private System.Windows.Forms.TextBox reportTextBox;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Department;
        private System.Windows.Forms.ColumnHeader PhoneNumber;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader dateOfBirthColumn;
        private System.Windows.Forms.ColumnHeader positionColumn;
        private System.Windows.Forms.ColumnHeader salaryColumn;
        private System.Windows.Forms.Button initButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button newEmployeeButton;
        private System.Windows.Forms.ColumnHeader checkboxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button removeDepButton;
        private System.Windows.Forms.Button addDepartmentButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button removeEmpButton;
        private System.Windows.Forms.Button cancelButton;
    }
}