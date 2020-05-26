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
    public partial class TeamForm : Form
    {
        private Project project;

        public TeamForm(Project project)
        {
            InitializeComponent();

            this.project = project;
            UpdateAll();
        }

        private void UpdateAll()
        {
            var team = TeamDao.GetProjectTeam(project.ID);
            dgvTeamEmployees.DataSource = null;
            dgvTeamEmployees.DataSource = team;

            dgvOtherEmployees.DataSource = null;
            dgvOtherEmployees.DataSource = EmployeeDao.SelectList().Except(team).ToList();
        }

        private void BtnAddEmployeeToProject_Click(object sender, EventArgs e)
        {
            if(dgvOtherEmployees.SelectedRows.Count != 0)
            {
                int employeeId = ((Employee)dgvOtherEmployees.SelectedRows[0]
                    .DataBoundItem).ID;
                TeamDao.AddEmployeeToProject(project.ID, employeeId);
                UpdateAll();
            }
        }

        private void BtnRemoveEmployeeFromProject_Click(object sender, EventArgs e)
        {
            if (dgvTeamEmployees.SelectedRows.Count != 0)
            {
                int employeeId = ((Employee)dgvTeamEmployees.SelectedRows[0]
                    .DataBoundItem).ID;
                TeamDao.DeleteEmployeeFromProject(project.ID, employeeId);
                UpdateAll();
            }
        }
    }
}
