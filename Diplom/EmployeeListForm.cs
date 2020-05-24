using EntityLibrary;
using Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class EmployeeListForm : Form
    {
        private Access _access;

        private enum SortMode { Asceding, Desceding };
        private SortMode _sortMode = SortMode.Asceding;

        public EmployeeListForm()
        {
            InitializeComponent();

            UpdateDgvEmployees(0);
        }

        public EmployeeListForm(Access access)
        {
            InitializeComponent();

            _access = access;

            InitEmployeeProjectComboBox(_access.Employee.ID);

            UpdateDgvEmployees(((Project)cbProject.SelectedItem).ID);

            InitPositionSearchComboBox();

            if ("Разработчик".Equals(_access.Role.RoleName))
            {
                cbProject.Enabled = false;
                btnAddEmployee.Visible = false;
                btnEditEmployee.Visible = false;
            }
        }

        private void InitPositionSearchComboBox()
        {
            cbSearchEmployeePosition.DataSource = null;
            cbSearchEmployeePosition.DataSource = PositionDao.SelectList();
            cbSearchEmployeePosition.DisplayMember = "PositionName";
            cbSearchEmployeePosition.ValueMember = "ID";
            cbSearchEmployeePosition.SelectedValue = 0;
        }

        private void InitEmployeeProjectComboBox(int employeeId)
        {
            cbProject.DataSource = null;
            cbProject.DataSource = ProjectDao.GetEmployeeProjects(employeeId);
            cbProject.DisplayMember = "ProjectName";
            cbProject.ValueMember = "ID";
            if(cbProject.DataSource != null)
            {
                cbProject.SelectedIndex = 0;
            }
        }

        private void UpdateDgvEmployees(int projectId)
        {
            dgvEmployees.AutoGenerateColumns = false;
            dgvEmployees.DataSource = null;
            if(projectId != 0)
            {
                dgvEmployees.DataSource = TeamDao.GetProjectTeam(projectId);
            }
            else
            {
                dgvEmployees.DataSource = EmployeeDao.SelectList();
            }
        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.ShowDialog();
            if (employeeForm.DialogResult == DialogResult.OK)
            {
                EmployeeDao.Add(new Employee(employeeForm.FullName, employeeForm.Passport,
                    employeeForm.Phone, employeeForm.Email, employeeForm.Position));

                UpdateDgvEmployees(((Project)cbProject.SelectedItem).ID);

                if (employeeForm.Project != null)
                {
                    TeamDao.AddEmployeeToProject(employeeForm.Project.ID,
                                                 employeeForm.EmployeeID);
                }
            }
        }

        private void BtnEditEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow == null)
            {
                MessageBox.Show("Строка не выбрана!", "Предупреждение",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                Employee employee = EmployeeDao.GetByID(
                    Convert.ToInt32(dgvEmployees.CurrentRow.Cells[0].Value));
                EmployeeForm employeeForm = new EmployeeForm(employee);
                employeeForm.ShowDialog();

                if (employeeForm.DialogResult == DialogResult.OK)
                {
                    employee.FullName = employeeForm.FullName;
                    employee.Passport = employeeForm.Passport;
                    employee.Phone = employeeForm.Phone;
                    employee.Email = employeeForm.Email;
                    employee.Position = employeeForm.Position;

                    EmployeeDao.Edit(employee);

                    UpdateDgvEmployees(((Project)cbProject.SelectedItem).ID);
                }
            }
        }

        private void BtnSearchEmployee_Click(object sender, EventArgs e)
        {
            dgvEmployees.CurrentCell = null;
            if (!string.IsNullOrEmpty(tbSearchEmployeeByName.Text))
            {
                string fullName = tbSearchEmployeeByName.Text.ToLower();
                var nameParts = fullName.Split(' ');

                foreach (DataGridViewRow row in dgvEmployees.Rows)
                {
                    foreach (var namePart in nameParts)
                    {
                        if (!row.Cells[1].Value.ToString().ToLower().Contains(namePart))
                        {
                            row.Visible = false;
                        }
                    }
                }
            }

            if (!string.IsNullOrEmpty(cbSearchEmployeePosition.Text))
            {
                foreach (DataGridViewRow row in dgvEmployees.Rows)
                {
                    if (!row.Cells[5].Value.ToString().Contains(cbSearchEmployeePosition.Text))
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void BtnResetSearchingResults_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvEmployees.Rows)
            {
                row.Visible = true;
            }
        }

        private void CbProject_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateDgvEmployees(((Project)cbProject.SelectedItem).ID);
        }

        private void DgvEmployees_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    if (_sortMode == SortMode.Asceding)
                    {
                        List<Employee> list = (List<Employee>)dgvEmployees.DataSource;
                        dgvEmployees.DataSource = null;
                        dgvEmployees.DataSource = list
                            .OrderBy(o => o.ID).ToList();

                        _sortMode = SortMode.Desceding;
                    }
                    else
                    {
                        List<Employee> list = (List<Employee>)dgvEmployees.DataSource;
                        dgvEmployees.DataSource = null;
                        dgvEmployees.DataSource = list
                            .OrderByDescending(o => o.ID).ToList();

                        _sortMode = SortMode.Asceding;
                    }
                    break;
                case 1:
                    if (_sortMode == SortMode.Asceding)
                    {
                        List<Employee> list = (List<Employee>)dgvEmployees.DataSource;
                        dgvEmployees.DataSource = null;
                        dgvEmployees.DataSource = list
                            .OrderBy(o => o.FullName).ToList();

                        _sortMode = SortMode.Desceding;
                    }
                    else
                    {
                        List<Employee> list = (List<Employee>)dgvEmployees.DataSource;
                        dgvEmployees.DataSource = null;
                        dgvEmployees.DataSource = list
                            .OrderByDescending(o => o.FullName).ToList();

                        _sortMode = SortMode.Asceding;
                    }
                    break;
                case 5:
                    if (_sortMode == SortMode.Asceding)
                    {
                        List<Employee> list = (List<Employee>)dgvEmployees.DataSource;
                        dgvEmployees.DataSource = null;
                        dgvEmployees.DataSource = list
                            .OrderBy(o => o.Position.PositionName).ToList();

                        _sortMode = SortMode.Desceding;
                    }
                    else
                    {
                        List<Employee> list = (List<Employee>)dgvEmployees.DataSource;
                        dgvEmployees.DataSource = null;
                        dgvEmployees.DataSource = list
                            .OrderByDescending(o => o.Position.PositionName).ToList();

                        _sortMode = SortMode.Asceding;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
