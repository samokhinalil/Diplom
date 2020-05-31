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
    public partial class DBConnectionForm : Form
    {
        private ConnectionStringController controller = new ConnectionStringController();

        public DBConnectionForm()
        {
            InitializeComponent();
            
            var get = controller.ConnectionString;

            tbDataSource.Text = get.DataSource;
            tbInitialCatalog.Text = get.InitialCatalog;
            cbIntegratedSecurity.SelectedItem = get.IntegratedSecurity;
            tbConnectTimeout.Text = get.ConnectTimeout;
            cbEncrypt.SelectedItem = get.Encrypt;
        }

        private void BtnCheckConnection_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string message;
            bool isConnect = controller.CheckConnection(new ConnectionString(tbDataSource.Text,
                tbInitialCatalog.Text, cbIntegratedSecurity.Text,
                tbConnectTimeout.Text, cbEncrypt.Text),
                out message);

            Cursor.Current = Cursors.Default;

            if (isConnect)
            {
                MessageBox.Show(message, "Результат проверки соединения с БД",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                btnSave.Enabled = true;
            }
            else
            {
                MessageBox.Show(message, "Результат проверки соединения с БД",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                btnSave.Enabled = false;
            }            
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {

        }
    }
}
