using EntityLibrary;
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
    public partial class TimeOutTasksReportForm : Form
    {
        public TimeOutTasksReportForm()
        {
            InitializeComponent();
        }

        private void TimeOutTasksReportForm_Load(object sender, EventArgs e)
        {
        }

        private void BtnGenerateReport_Click(object sender, EventArgs e)
        {
            ReportDao reportDao = new ReportDao(ConnectionString.ConnectionStringName);
            var myData = reportDao.GetTimeOutTasksCountReport(
                ctlDateFrom.Value.Date, ctlDateTo.Value.Date);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("ITTasksDataSet", myData));

            reportViewer1.RefreshReport();
        }
    }
}
