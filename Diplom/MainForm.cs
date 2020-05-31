using EntityLibrary;
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
    public partial class MainForm : Form
    {
        private Access _access = new Access(
            new Employee(4,"aaa","aaa","aaa","aaa", new Position(1, "aaa")),
            "login",
            "password",
            new Role());
        public MainForm(Access access)
        {
            InitializeComponent();

            _access = access;

            laAccess.Text = string.Join(" ", "Вы вошли как:",
                _access.Employee.FullName,
                "(", _access.Role.RoleName, ")");
        }

        private void BtnTasks_Click(object sender, EventArgs e)
        {
            TaskListForm taskListForm = new TaskListForm(_access);
            taskListForm.ShowDialog();
        }

        private void BtnEmployees_Click(object sender, EventArgs e)
        {
            EmployeeListForm employeeListForm = new EmployeeListForm(_access);
            employeeListForm.ShowDialog();
        }

        private void BtnProjects_Click(object sender, EventArgs e)
        {
            ProjectListForm projectListForm = new ProjectListForm(_access);
            projectListForm.ShowDialog();
        }

        private void BtnTaskIssuing_Click(object sender, EventArgs e)
        {
            TaskIssuingForm taskIssuingForm = new TaskIssuingForm(_access);
            taskIssuingForm.ShowDialog();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CtlChangeUser_Click(object sender, EventArgs e)
        {
            EnterForm enterForm = new EnterForm();
            enterForm.ShowDialog();
            if(enterForm.DialogResult == DialogResult.OK)
            {
                this.Hide();
            }
        }

        private void CtlTaskSettings_Click(object sender, EventArgs e)
        {
            TaskSettingsForm taskSettingsForm = new TaskSettingsForm();
            taskSettingsForm.ShowDialog();
        }

        private void CtlShowPositions_Click(object sender, EventArgs e)
        {
            PositionListForm positionsListForm = new PositionListForm();
            positionsListForm.ShowDialog();
        }

        private void CtlGrantAccessRights_Click(object sender, EventArgs e)
        {
            AccessForm accessForm = new AccessForm();
            accessForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Закрыть приложение?", "Информационное сообщение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CtlCheckConnection_Click(object sender, EventArgs e)
        {

        }

        private void CtlExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.ShowDialog();
        }
    }
}
