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
    public partial class SimpleReportForm : Form
    {
        public SimpleReportForm()
        {
            InitializeComponent();
        }

        private void SimpleReportForm_Load(object sender, EventArgs e)
        {
            //var list = ReportDao.GetPriorityReport();
            //var rdc = new ReportDataSource("DataSet1", list);
            //reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.DataSources.Add(rdc);
            //reportViewer1.LocalReport.Refresh();
            //this.reportViewer1.RefreshReport();
        }
    }
}
