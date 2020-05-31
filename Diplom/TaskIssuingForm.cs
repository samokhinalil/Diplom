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
    public partial class TaskIssuingForm : Form
    {
        private Access _access;

        public TaskIssuingForm(Access access)
        {
            InitializeComponent();
            _access = access;

            InitProjectComboBox(_access.Employee.ID);

            int projectId = ((Project)cbProject.SelectedItem).ID;
            UpdateComboBoxTasks(projectId, 1);
            UpdateComboBoxEmployees(projectId);
        }

        public TaskIssuingForm(Access access, IssueListView issue)
        {
            InitializeComponent();
            _access = access;

            InitProjectComboBox(_access.Employee.ID);

            int projectId = ((Project)cbProject.SelectedItem).ID;
            UpdateComboBoxTasks(projectId, issue.ID);

            UpdateComboBoxEmployees(projectId);

            cbProject.Enabled = false;
            cbTask.Enabled = false;
            tbComplexity.Enabled = false;
            tbPriority.Enabled = false;
            
        }

        private void InitProjectComboBox(int employeeId)
        {
            cbProject.DataSource = null;
            cbProject.DataSource = ProjectDao.GetEmployeeProjects(employeeId);
            cbProject.DisplayMember = "ProjectName";
            cbProject.ValueMember = "ID";
            if (cbProject.DataSource != null)
            {
                cbProject.SelectedValue = 1;
            }
        }

        private void UpdateComboBoxTasks(int projectId, int selectedTaskId)
        {
            cbTask.DataSource = null;
            cbTask.DataSource = IssueDao.GetProjectOpenIssues(projectId);
            cbTask.DisplayMember = "IssueName";
            cbTask.ValueMember = "ID";

            if (cbTask.Items.Count != 0)
            {
                cbTask.SelectedValue = selectedTaskId;

                UpdatePriorityAndComplexityText();
            }

            cbEmployee.Enabled = cbTask.SelectedIndex != 0;
            ctlEndDate.Enabled = cbTask.SelectedIndex != 0;
            btnCalculateDate.Enabled = cbTask.SelectedIndex != 0;
            btnSelectEmployee.Enabled = cbTask.SelectedIndex != 0;
        }

        private void UpdatePriorityAndComplexityText()
        {
            if (cbTask.SelectedIndex != -1)
            {
                tbPriority.Text = ((IssueListView)cbTask.SelectedItem).PriorityName;
                tbComplexity.Text = ((IssueListView)cbTask.SelectedItem).ComplexityName;
            }
            else
            {
                tbPriority.Clear();
                tbComplexity.Clear();
            }
        }

        private void UpdateComboBoxEmployees(int projectId)
        {
            cbEmployee.DataSource = null;
            if (projectId != 0)
            {
                cbEmployee.DataSource = TeamDao.GetProjectTeam(projectId);
                cbEmployee.DisplayMember = "FullName";
                cbEmployee.ValueMember = "ID";
            }
        }

        private void BtnSelectEmployee_Click(object sender, EventArgs e)
        {
            int projectId = ((Project)cbProject.SelectedItem).ID;
            EmployeeSelectionForm employeeSelectionForm =
                new EmployeeSelectionForm(projectId);
            employeeSelectionForm.ShowDialog();

            if(employeeSelectionForm.DialogResult == DialogResult.OK)
            {
                cbEmployee.SelectedValue = employeeSelectionForm.EmployeeID;
            }
        }

        private void CbTask_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbTask.SelectedItem != null)
            {
                UpdatePriorityAndComplexityText();
            }
        }

        private void CbProject_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbProject.SelectedItem != null)
            {
                int projectId = ((Project)cbProject.SelectedItem).ID;
                UpdateComboBoxTasks(projectId, 1);
                UpdateComboBoxEmployees(projectId);
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if(cbTask.SelectedItem != null && cbEmployee.SelectedItem != null)
            {
                IssueDao.AppointIssueToEmployee(((IssueListView)cbTask.SelectedItem).ID,
                ((Employee)cbEmployee.SelectedItem).ID, _access.Employee.ID,
                ctlEndDate.Value);

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Поля не заполнены!", "Предупреждение",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void BtnCalculateDate_Click(object sender, EventArgs e)
        {
            IssueDateCalculatorDao issueDateCalculator =
                new IssueDateCalculatorDao((IssueListView)cbTask.SelectedItem,
                _access.Employee.ID);
            ctlEndDate.Value = issueDateCalculator.CalculateIssueEndDate();
            lblCalculateMessage.Visible = true;
        }
    }
}
