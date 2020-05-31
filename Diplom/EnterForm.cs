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
    public partial class EnterForm : Form
    {
        private string adminLogin = "admin";
        private string adminPassword = "admin";
        public Access Access { get; set; }

        public EnterForm()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (!tbLogin.Text.Equals(string.Empty) && !tbPassword.Text.Equals(string.Empty))
            {
                if (adminLogin.Equals(tbLogin.Text) &&
                        SHA1Hasher.GetHash(adminPassword).Equals(
                            SHA1Hasher.GetHash(tbPassword.Text)))
                {
                    AdminMenuForm adminMenuForm = new AdminMenuForm();
                    adminMenuForm.Show();
                    this.Hide();
                    DialogResult = DialogResult.OK;
                    return;
                }
                else
                {
                    AccessDao accessDao = new AccessDao("DefaultConnectionString");
                    Access = accessDao.CheckAccess(tbLogin.Text, SHA1Hasher.GetHash(tbPassword.Text));
                    if (Access != null)
                    {
                        if (Access.Role.RoleName.Equals("Менеджер проекта"))
                        {
                            MainForm mainForm = new MainForm(Access);
                            mainForm.Show();
                            this.Hide();
                            DialogResult = DialogResult.OK;
                            return;
                        }
                        else if (Access.Role.RoleName.Equals("Разработчик"))
                        {
                            EmployeeMenuForm mainForm = new EmployeeMenuForm(Access);
                            mainForm.Show();
                            this.Hide();
                            DialogResult = DialogResult.OK;
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Error);
                        DialogResult = DialogResult.None;
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите логин и пароль!", "Предупреждение", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
            }
        }
    }
}
