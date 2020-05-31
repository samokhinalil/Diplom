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
    public partial class EmployeeMenuForm : Form
    {
        private Access _access;

        public EmployeeMenuForm(Access access)
        {
            InitializeComponent();

            _access = access;
            laAccess.Text = string.Join(" ", "Вы вошли как:", _access.Employee.FullName,
                "(", _access.Role.RoleName, ")");
        }

        private void CtlEditEmployee_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm(_access.Employee);
            employeeForm.ShowDialog();

            if (employeeForm.DialogResult == DialogResult.OK)
            {
                _access.Employee.FullName = employeeForm.FullName;
                _access.Employee.Passport = employeeForm.Passport;
                _access.Employee.Phone = employeeForm.Phone;
                _access.Employee.Email = employeeForm.Email;
                _access.Employee.Position = employeeForm.Position;

                EmployeeDao.Edit(_access.Employee);
            }
        }

        private void CtlExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CtlChangeUser_Click(object sender, EventArgs e)
        {
            EnterForm enterForm = new EnterForm();
            enterForm.ShowDialog();
            if (enterForm.DialogResult == DialogResult.OK)
            {
                this.Hide();
            }
        }

        private void EmployeeMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Закрыть приложение?", "Информационное сообщение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void EmployeeMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnOpenTasks_Click(object sender, EventArgs e)
        {
            TaskListForm taskListForm = new TaskListForm(_access, openTasksSelector);
            taskListForm.ShowDialog();
        }

        private void BtnDoneTasks_Click(object sender, EventArgs e)
        {
            TaskListForm taskListForm = new TaskListForm(_access, executedTasksSelector);
            taskListForm.ShowDialog();
        }

        private const int openTasksSelector = 1;
        private const int executedTasksSelector = 2;

        private void BtnMyTeam_Click(object sender, EventArgs e)
        {
            EmployeeListForm employeeListForm = new EmployeeListForm(_access);
            employeeListForm.ShowDialog();
        }

        private void BtnGetIssuesStates_Click(object sender, EventArgs e)
        {
            IssueHistoryForm issueHistoryForm = new IssueHistoryForm(_access);
            issueHistoryForm.ShowDialog();
        }
    }
}
