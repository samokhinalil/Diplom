using EntityLibrary;
using Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class ProjectListForm : Form
    {
        public ProjectListForm(Access access)
        {
            InitializeComponent();
            GetProjectList();
        }

        private void GetProjectList()
        {
            dgvProjects.DataSource = null;
            dgvProjects.DataSource = ProjectDao.SelectList();
        }

        private void BtnAddProject_Click(object sender, EventArgs e)
        {
            ProjectForm projectForm = new ProjectForm();
            projectForm.ShowDialog();
            if(projectForm.DialogResult == DialogResult.OK)
            {
                ProjectDao.Add(new Project(projectForm.ProjectName,
                    projectForm.StartDate));
                GetProjectList();
            }
        }

        private void BtnEditProject_Click(object sender, EventArgs e)
        {
            Project editingProject =
                (Project)dgvProjects.SelectedRows[0].DataBoundItem;
            
            ProjectForm projectForm = new ProjectForm(editingProject);
            projectForm.ShowDialog();
            if (projectForm.DialogResult == DialogResult.OK)
            {
                editingProject.ProjectName = projectForm.ProjectName;
                editingProject.StartDate = projectForm.StartDate;
                ProjectDao.Edit(editingProject);
                GetProjectList();
            }
        }

        private void BtnEditTeam_Click(object sender, EventArgs e)
        {
            TeamForm teamForm = new TeamForm();
            teamForm.Show();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void BtnSearchProject_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSearchProject.Text))
            {
                string firmName = tbSearchProject.Text.ToLower();
                var nameParts = Regex.Split(firmName, @"\\W+", RegexOptions.IgnorePatternWhitespace);

                foreach (DataGridViewRow row in dgvProjects.Rows)
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

            if (ctlDateFrom.Text != ctlDateTo.Text)
            {
                DateTime dateFrom = DateTime.Parse(ctlDateFrom.Text);
                DateTime dateTo = DateTime.Parse(ctlDateTo.Text);

                foreach (DataGridViewRow row in dgvProjects.Rows)
                {
                    var currentStartDate = DateTime.Parse(row.Cells[2].Value.ToString());
                    if (!(currentStartDate <= dateTo && currentStartDate >= dateFrom))
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void BtnResetSearchingResults_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvProjects.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
