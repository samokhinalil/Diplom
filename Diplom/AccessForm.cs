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
    public partial class AccessForm : Form
    {
        public AccessForm()
        {
            InitializeComponent();

            InitEmployeeComboBox();
            InitRoleComboBox();
        }
        private void InitEmployeeComboBox()
        {
            cbEmployee.DataSource = null;
            EmployeeDao employeeDao = new EmployeeDao(ConnectionString.ConnectionStringName);
            cbEmployee.DataSource = employeeDao.SelectList();
            cbEmployee.DisplayMember = "FullName";
            cbEmployee.ValueMember = "ID";

            FillEmployeeLogin();
        }

        private void FillEmployeeLogin()
        {
            Employee e = (Employee)cbEmployee.SelectedItem;
            tbLogin.Text = e.Email;
        }

        private void InitRoleComboBox()
        {
            cbRole.DataSource = null;
            RoleDao roleDao = new RoleDao(ConnectionString.ConnectionStringName);
            cbRole.DataSource = roleDao.SelectList();
            cbRole.DisplayMember = "RoleName";
            cbRole.ValueMember = "ID";
        }

        private void BtnShowPassword_Click(object sender, EventArgs e)
        {
            if(tbPassword.PasswordChar.Equals('*'))
            {
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '*';
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if(cbEmployee.Text.Equals(string.Empty)||tbLogin.Text.Equals(string.Empty)||
                tbPassword.Text.Equals(string.Empty) || cbRole.Text.Equals(string.Empty))
            {
                MessageBox.Show("Заполните все поля!", "Предупреждение", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
            }
            else
            {
                AccessDao accessDao = new AccessDao("DefaultConnectionString");
                accessDao.GrantAccessRights(new Access(
                    (Employee)cbEmployee.SelectedItem,
                    tbLogin.Text,
                    tbPassword.Text,
                    (Role)cbRole.SelectedItem));
                MessageBox.Show("Были добавлены права доступа для пользователя.",
                    "Информационное сообщение", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information);
                DialogResult = DialogResult.None;
                tbLogin.Clear();
                tbPassword.Clear();
            }
        }

        private void CbEmployee_SelectedValueChanged(object sender, EventArgs e)
        {
            FillEmployeeLogin();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
