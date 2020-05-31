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
    public partial class StateListForm : Form
    {
        public State State { get; set; }

        private StateDao stateDao = new StateDao(ConnectionString.ConnectionStringName);

        public StateListForm()
        {
            InitializeComponent();

            listBoxStates.DataSource = null;
            listBoxStates.DataSource = stateDao.SelectList();
            listBoxStates.DisplayMember = "StateName";
            listBoxStates.ValueMember = "ID";
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            State = (State)listBoxStates.SelectedItem;
            DialogResult = DialogResult.OK;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
        }
    }
}
