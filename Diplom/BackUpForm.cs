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
    public partial class BackUpForm : Form
    {
        public BackUpForm()
        {
            InitializeComponent();
        }

        private void BtnCreateBackUp_Click(object sender, EventArgs e)
        {
            //BackupDAO.CreateBackup(txtBackupPath.Text);
        }

        private void BtnRestoreDB_Click(object sender, EventArgs e)
        {
            //BackupDAO.RestoreDatabase("Rent", txtRestoreFilePath.Text);
        }
    }
}
