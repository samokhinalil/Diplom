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
    public partial class EmployeeForm : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();

        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public string Passport { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Position Position { get; set; } = new Position();
        public Project Project { get; set; }
        public bool IsCreate;

        public EmployeeForm()
        {
            InitializeComponent();

            Text = "Добавить сотрудника";
            InitPositionComboBox();
        }

        private void InitPositionComboBox()
        {
            cbEmployeePosition.DataSource = null;
            cbEmployeePosition.DataSource = PositionDao.SelectList();
            cbEmployeePosition.DisplayMember = "PositionName";
            cbEmployeePosition.ValueMember = "ID";
        }

        public EmployeeForm(Employee employee)
        {
            InitializeComponent();

            Text = "Редактировать сотрудника";
            InitPositionComboBox();

            tbEmployeeName.Text = employee.FullName;
            tbEmployeePassport.Text = employee.Passport;
            tbEmployeePhone.Text = employee.Phone;
            tbEmployeeEmail.Text = employee.Email;
            cbEmployeePosition.SelectedValue = employee.Position.ID;

            laProject.Visible = false;
            cbProjects.Visible = false;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
                FullName = tbEmployeeName.Text;
                Passport = tbEmployeePassport.Text;
                Phone = tbEmployeePhone.Text;
                Email = tbEmployeeEmail.Text;
                Position = (Position)cbEmployeePosition.SelectedItem;

                if(cbProjects.SelectedItem != null)
                {
                    Project = (Project)cbProjects.SelectedItem;
                }
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        private void TbEmployeeName_Validated(object sender, EventArgs e)
        {
            FullName = tbEmployeeName.Text.Trim();
        }

        private void TbEmployeePassport_Validated(object sender, EventArgs e)
        {
            Passport = tbEmployeePassport.Text;
        }

        private void TbEmployeePhone_Validated(object sender, EventArgs e)
        {
            Phone = tbEmployeePhone.Text;
        }

        private void TbEmployeeEmail_Validated(object sender, EventArgs e)
        {
            Email = tbEmployeeEmail.Text.Trim();
        }

        private void TbEmployeeName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbEmployeeName.Text.Trim()))
            {
                errorProvider.SetError(tbEmployeeName, "Поле не может быть пустым!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbEmployeeName, string.Empty);
            }
        }

        private void TbEmployeePassport_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbEmployeePassport.Text))
            {
                errorProvider.SetError(tbEmployeePassport, "Поле не может быть пустым!");
                e.Cancel = true;
            }
            else if (tbEmployeePassport.Text.Length < 10)
            {
                errorProvider.SetError(tbEmployeePassport, "Паспорт должен содержать 10 цифр!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbEmployeePassport, string.Empty);
            }
        }

        private void TbEmployeePhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbEmployeePhone.Text))
            {
                errorProvider.SetError(tbEmployeePhone, "Поле не может быть пустым!");
                e.Cancel = true;
            }
            else if (tbEmployeePhone.Text.Length < 11)
            {
                errorProvider.SetError(tbEmployeePhone, "Слишком короткий номер телефона!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbEmployeePhone, string.Empty);
            }
        }

        private void TbEmployeeEmail_Validating(object sender, CancelEventArgs e)
        {
            string input = tbEmployeeEmail.Text.Trim();

            if (string.IsNullOrEmpty(tbEmployeeEmail.Text))
            {
                errorProvider.SetError(tbEmployeeEmail, "Поле не может быть пустым!");
                e.Cancel = true;
            }
            else if (!tbEmployeeEmail.Text.Contains("@"))
            {
                errorProvider.SetError(tbEmployeeEmail, "Email должен содержать @");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbEmployeeEmail, string.Empty);
            }
        }
    }
}
