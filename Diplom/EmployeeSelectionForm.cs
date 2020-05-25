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
    public partial class EmployeeSelectionForm : Form
    {
        public int EmployeeID { get; set; }

        public EmployeeSelectionForm(int projectId)
        {
            InitializeComponent();

            dgvEmployees.DataSource = null;

            var employees = TeamDao.GetProjectTeam(projectId);
            CoefficientCalculatorDao coefficientCalculator = new CoefficientCalculatorDao(employees);
            dgvEmployees.DataSource = coefficientCalculator.GetEmployeesWithCoefficient();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if(dgvEmployees.CurrentRow != null)
            {
                EmployeeID = ((AppropriateEmployee)dgvEmployees.CurrentRow.DataBoundItem).ID;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
