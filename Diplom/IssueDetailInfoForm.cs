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
    public partial class IssueDetailInfoForm : Form
    {
        private IssueDao issueDao = new IssueDao(ConnectionString.ConnectionStringName);

        public IssueDetailInfoForm(int issueId)
        {
            InitializeComponent();

            var data = issueDao.GetIssueDetailInfo(issueId);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("ITTasksDataSet", data));
            reportViewer1.RefreshReport();
        }

        private void IssueDetailInfoForm_Load(object sender, EventArgs e)
        {
        }
    }
}
