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
        public TeamForm()
        {
            InitializeComponent();
        }

        private void BtnAddEmployeeToProject_Click(object sender, EventArgs e)
        {
            Form employeeForm = new EmployeeForm();
            employeeForm.Show();
        }
    }
}
