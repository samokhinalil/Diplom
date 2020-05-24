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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void CtlReport1_Click(object sender, EventArgs e)
        {
            SolvedTasksComplexityCountReportForm reportForm =
                new SolvedTasksComplexityCountReportForm();
            reportForm.ShowDialog();
        }

        private void CtlReport2_Click(object sender, EventArgs e)
        {
            StateEmployeeTasksCountReportForm form = new StateEmployeeTasksCountReportForm();
            form.ShowDialog();
        }

        private void CtlReport3_Click(object sender, EventArgs e)
        {
            TimeOutTasksReportForm reportForm = new TimeOutTasksReportForm();
            reportForm.ShowDialog();
        }

        private void CtlReport4_Click(object sender, EventArgs e)
        {
            DetailTimeOutReportForm reportForm = new DetailTimeOutReportForm();
            reportForm.ShowDialog();
        }
    }
}
