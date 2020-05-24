using Microsoft.Reporting.WinForms;
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
    public partial class SolvedTasksComplexityCountReportForm : Form
    {
        public SolvedTasksComplexityCountReportForm()
        {
            InitializeComponent();
        }

        private void SolvedTasksComplexityCountReportForm_Load(object sender, EventArgs e)
        {
            //this.reportViewer1.RefreshReport();
        }

        private void BtnGenerateReport_Click(object sender, EventArgs e)
        {
            var myData = ReportDao.GetSolvedTasksComplexityCountReportReport(
                ctlDateFrom.Value.Date, ctlDateTo.Value.Date);

            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("ITTasksDataSet", myData));
            ReportParameter[] rparams = new ReportParameter[]
            {
                new ReportParameter("dateFrom", ctlDateFrom.Value.Date.ToShortDateString()),
                new ReportParameter("dateTo", ctlDateTo.Value.Date.ToShortDateString())
            };
            reportViewer1.LocalReport.SetParameters(rparams);
            
            reportViewer1.RefreshReport();
        }
    }
}
