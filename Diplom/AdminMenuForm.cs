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
    public partial class AdminMenuForm : Form
    {
        public AdminMenuForm()
        {
            InitializeComponent();
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

        private void CtlGrantAccessRights_Click(object sender, EventArgs e)
        {
            AccessForm accessForm = new AccessForm();
            accessForm.ShowDialog();
        }

        private void CtlCheckConnection_Click(object sender, EventArgs e)
        {
            DBConnectionForm dBConnectionForm = new DBConnectionForm();
            dBConnectionForm.ShowDialog();
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

        private void AdminMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Закрыть приложение?", "Информационное сообщение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void AdminMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnEmployees_Click(object sender, EventArgs e)
        {
            EmployeeListForm employeeListForm = new EmployeeListForm();
            employeeListForm.ShowDialog();
        }

        private void CtlExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnBackups_Click(object sender, EventArgs e)
        {
            BackUpForm backUpForm = new BackUpForm();
            backUpForm.ShowDialog();
        }
    }
}
