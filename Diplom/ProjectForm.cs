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
    public partial class ProjectForm : Form
    {
        public int ID { get; set; }
        public string ProjectName { get; set; }
        public DateTime StartDate { get; set; }

        public ProjectForm()
        {
            InitializeComponent();
        }

        public ProjectForm(Project project)
        {
            InitializeComponent();

            Text = "Редактировать проект";

            tbProjectName.Text = project.ProjectName;
            ctlProjectStartTime.Text = project.StartDate.ToString();

            ID = project.ID;
            ProjectName = project.ProjectName;
            StartDate = project.StartDate;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                ProjectName = tbProjectName.Text;
                StartDate = DateTime.Parse(ctlProjectStartTime.Text);
                DialogResult = DialogResult.OK;
            }
        }

        private void TbProjectName_Validated(object sender, EventArgs e)
        {
            ProjectName = tbProjectName.Text.Trim();
        }

        private void TbProjectName_Validating(object sender, CancelEventArgs e)
        {
            FieldValidator fieldValidator = new FieldValidator();
            fieldValidator.CheckForEmptyField(tbProjectName, e);
        }
    }
}
