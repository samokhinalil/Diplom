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
    public partial class StateEmployeeTasksCountReportForm : Form
    {
        public StateEmployeeTasksCountReportForm()
        {
            InitializeComponent();
        }

        private void StateEmployeeTasksCountReportForm_Load(object sender, EventArgs e)
        {
            UpdateComboBoxEmployees();
        }

        private void BtnGenerateReport_Click(object sender, EventArgs e)
        {
            if(cbEmployee.SelectedItem != null)
            {
                int employeeId = ((Employee)cbEmployee.SelectedItem).ID;
                var myData = ReportDao.GetStateEmployeeTasksCountReport(employeeId,
                    ctlDateFrom.Value.Date, ctlDateTo.Value.Date);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("ITTasksDataSet", myData));

                ReportParameter[] rparams = new ReportParameter[]
                {
                    new ReportParameter("employee", ((Employee)cbEmployee.SelectedItem).FullName),
                    new ReportParameter("dateFrom", ctlDateFrom.Value.Date.ToShortDateString()),
                    new ReportParameter("dateTo", ctlDateTo.Value.Date.ToShortDateString())
                };

                reportViewer1.LocalReport.SetParameters(rparams);

                reportViewer1.RefreshReport();
            }
            else
            {
                var myData = ReportDao.GetStateTasksCountReport(
                    ctlDateFrom.Value.Date, ctlDateTo.Value.Date);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("ITTasksDataSet", myData));

                ReportParameter[] rparams = new ReportParameter[]
                {
                    new ReportParameter("employee", "Для всех сотрудников"),
                    new ReportParameter("dateFrom", ctlDateFrom.Value.Date.ToShortDateString()),
                    new ReportParameter("dateTo", ctlDateTo.Value.Date.ToShortDateString())
                };

                reportViewer1.LocalReport.SetParameters(rparams);

                reportViewer1.RefreshReport();
            }
        }
        

        private void UpdateComboBoxEmployees()
        {
            cbEmployee.DataSource = null;
            cbEmployee.DataSource = EmployeeDao.SelectList();
            cbEmployee.DisplayMember = "FullName";
            cbEmployee.ValueMember = "ID";
            if (cbEmployee.DataSource != null)
            {
                cbEmployee.SelectedValue = 0;
            }
        }
    }
}
