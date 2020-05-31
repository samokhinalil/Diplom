﻿using EntityLibrary;
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
    public partial class TeamForm : Form
    {
        private Project project;

        public TeamForm(Project project)
        {
            InitializeComponent();
            dgvTeamEmployees.AutoGenerateColumns = false;
            dgvOtherEmployees.AutoGenerateColumns = false;

            this.project = project;
            UpdateAll();
        }

        private void UpdateAll()
        {
            var team = TeamDao.GetProjectTeam(project.ID);
            dgvTeamEmployees.DataSource = null;
            dgvTeamEmployees.DataSource = team;

            dgvOtherEmployees.DataSource = null;
            dgvOtherEmployees.DataSource = EmployeeDao.SelectList().Where(e=>team.All(t=>t.ID != e.ID)).ToList();
        }

        private void BtnAddEmployeeToProject_Click(object sender, EventArgs e)
        {
            if(dgvOtherEmployees.CurrentRow != null)
            {
                int employeeId = ((Employee)dgvOtherEmployees.CurrentRow
                    .DataBoundItem).ID;
                TeamDao.AddEmployeeToProject(project.ID, employeeId);
                UpdateAll();
                MessageBox.Show("Сотрудник добавлен в команду.", "Информационное сообщение",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Строка не выбрана!", "Предупреждение",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void BtnRemoveEmployeeFromProject_Click(object sender, EventArgs e)
        {
            if (dgvTeamEmployees.CurrentRow != null)
            {
                int employeeId = ((Employee)dgvTeamEmployees.CurrentRow
                    .DataBoundItem).ID;
                TeamDao.DeleteEmployeeFromProject(project.ID, employeeId);
                UpdateAll();
                MessageBox.Show("Сотрудник удален из команды.", "Информационное сообщение",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Строка не выбрана!", "Предупреждение",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
