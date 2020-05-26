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
    public partial class DetailTimeOutReportForm : Form
    {
        public DetailTimeOutReportForm()
        {
            InitializeComponent();
        }

        private void BtnGenerateReport_Click(object sender, EventArgs e)
        {
            var myData = ReportDao.GetTimeOutTasksInfoReport(
                ctlDateFrom.Value.Date, ctlDateTo.Value.Date);

            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(
                new ReportDataSource("ITTasksDataSet", myData));

            reportViewer2.RefreshReport();
        }
    }
}
