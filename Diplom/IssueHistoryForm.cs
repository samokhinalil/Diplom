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
    public partial class IssueHistoryForm : Form
    {
        private IssueHistoryDao issueHistoryDao = new IssueHistoryDao(ConnectionString.ConnectionStringName);

        public IssueHistoryForm(Access access)
        {
            InitializeComponent();

            dgvHistory.DataSource = null;
            dgvHistory.DataSource = 
                issueHistoryDao.GetEmployeeIssuesHistory(access.Employee.ID);
        }

        private void DgvHistory_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvHistory.CurrentRow != null)
            {
                tbSearchName.Text =
                ((IssueHistory)dgvHistory.CurrentRow.DataBoundItem).IssueName;
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (!tbSearchName.Text.Equals(string.Empty))
            {
                foreach (DataGridViewRow row in dgvHistory.Rows)
                {
                    if (!row.Cells["IssueName"].Value.ToString()
                        .Contains(tbSearchName.Text))
                    {
                        row.Visible = false;
                    }
                }
            }

            if (ctlDateFrom.Text != ctlDateTo.Text)
            {
                DateTime dateFrom = DateTime.Parse(ctlDateFrom.Text);
                DateTime dateTo = DateTime.Parse(ctlDateTo.Text);

                foreach (DataGridViewRow row in dgvHistory.Rows)
                {
                    var currentStartDate = DateTime.Parse(row.Cells[2].Value.ToString());
                    if (!(currentStartDate <= dateTo && currentStartDate >= dateFrom))
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void BtnResetSearchingResults_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvHistory.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
