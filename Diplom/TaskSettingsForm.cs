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
    public partial class TaskSettingsForm : Form
    {
        FieldValidator validator = new FieldValidator();

        public TaskSettingsForm()
        {
            InitializeComponent();

            AutoValidate = AutoValidate.EnableAllowFocusChange;

            dgvComplexity.AutoGenerateColumns = false;
            dgvPriorities.AutoGenerateColumns = false;
            dgvState.AutoGenerateColumns = false;
            dgvTypes.AutoGenerateColumns = false;

            UpdateDgvComplexity();
            UpdateDgvPriorities();
            UpdateDgvState();
            UpdateDgvTypes();
        }

        private void UpdateDgvTypes()
        {
            dgvTypes.DataSource = null;
            dgvTypes.DataSource = IssueTypeDao.SelectList();
        }

        private void UpdateDgvState()
        {
            dgvState.DataSource = null;
            dgvState.DataSource = StateDao.SelectList();
        }

        private void UpdateDgvPriorities()
        {
            dgvPriorities.DataSource = null;
            dgvPriorities.DataSource = PriorityDao.SelectList();
        }

        private void UpdateDgvComplexity()
        {
            dgvComplexity.DataSource = null;
            dgvComplexity.DataSource = ComplexityDao.SelectList();
        }

        private void BtnAddPriority_Click(object sender, EventArgs e)
        {
            if (!tbPriorityName.Text.Equals(string.Empty))
            {
                if (int.TryParse(tbPriorityValue.Text, out int r))
                {
                    PriorityDao.Add(new Priority(tbPriorityName.Text, int.Parse(tbPriorityValue.Text)));
                    UpdateDgvPriorities();
                    tbPriorityName.Clear();
                    tbPriorityValue.Clear();
                }
                else
                {
                    MessageBox.Show(validator.IntErrorText, "Предупреждение",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(validator.ErrorText, "Предупреждение",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void BtnEditPriority_Click(object sender, EventArgs e)
        {
            if (!tbPriorityName.Text.Equals(string.Empty))
            {
                if (int.TryParse(tbPriorityValue.Text, out int r))
                {
                    Priority priority = (Priority)dgvPriorities.CurrentRow.DataBoundItem;
                    priority.PriorityName = tbPriorityName.Text;
                    priority.PriorityValue = int.Parse(tbPriorityValue.Text);
                    PriorityDao.Edit(priority);
                    UpdateDgvPriorities();
                }
                else
                {
                    MessageBox.Show(validator.IntErrorText, "Предупреждение",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(validator.ErrorText, "Предупреждение",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void DgvPriorities_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPriorities.SelectedRows.Count != 0)
            {
                tbPriorityName.Text = dgvPriorities.SelectedRows[0].Cells[1].Value.ToString();
                tbPriorityValue.Text = dgvPriorities.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        private void BtnAddComplexity_Click(object sender, EventArgs e)
        {
            if (!tbComplexityName.Text.Equals(string.Empty))
            {
                if (int.TryParse(tbComplexityValue.Text, out int r))
                {
                    ComplexityDao.Add(new Complexity(tbComplexityName.Text, int.Parse(tbComplexityValue.Text)));
                    UpdateDgvComplexity();
                    tbComplexityName.Clear();
                    tbComplexityValue.Clear();
                }
                else
                {
                    MessageBox.Show(validator.IntErrorText, "Предупреждение",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(validator.ErrorText, "Предупреждение",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void BtnEditComplexity_Click(object sender, EventArgs e)
        {
            if (!tbComplexityName.Text.Equals(string.Empty))
            {
                if (int.TryParse(tbComplexityValue.Text, out int r))
                {
                    Complexity complexity = (Complexity)dgvComplexity.CurrentRow.DataBoundItem;
                    complexity.ComplexityName = tbComplexityName.Text;
                    complexity.ComplexityValue = int.Parse(tbComplexityValue.Text);
                    ComplexityDao.Edit(complexity);
                    UpdateDgvComplexity();
                }
                else
                {
                    MessageBox.Show(validator.IntErrorText, "Предупреждение",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(validator.ErrorText, "Предупреждение",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void DgvComplexity_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvComplexity.SelectedRows.Count != 0)
            {
                tbComplexityName.Text = dgvComplexity.SelectedRows[0].Cells[1].Value.ToString();
                tbComplexityValue.Text = dgvComplexity.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        private void BtnAddState_Click(object sender, EventArgs e)
        {
            if (!tbStateName.Text.Equals(string.Empty))
            {
                StateDao.Add(new State(tbStateName.Text));
                UpdateDgvState();
                tbStateName.Clear();
            }
            else
            {
                MessageBox.Show(validator.ErrorText, "Предупреждение",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void BtnEditState_Click(object sender, EventArgs e)
        {
            if (!tbStateName.Text.Equals(string.Empty))
            {
                State state = (State)dgvState.CurrentRow.DataBoundItem;
                state.StateName = tbStateName.Text;
                StateDao.Edit(state);
                UpdateDgvState();
            }
            else
            {
                MessageBox.Show(validator.ErrorText, "Предупреждение",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void DgvState_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvState.SelectedRows.Count != 0)
            {
                tbStateName.Text = dgvState.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void BtnAddType_Click(object sender, EventArgs e)
        {
            if (!tbTypeName.Text.Equals(string.Empty))
            {
                IssueTypeDao.Add(new IssueType(tbTypeName.Text.Trim()));
                UpdateDgvTypes();
                tbTypeName.Clear();
            }
            else
            {
                MessageBox.Show(validator.ErrorText, "Предупреждение",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void BtnEditType_Click(object sender, EventArgs e)
        {
            if (!tbTypeName.Text.Equals(string.Empty))
            {
                IssueType type = (IssueType)dgvTypes.CurrentRow.DataBoundItem;
                type.TypeName = tbTypeName.Text.Trim();
                IssueTypeDao.Edit(type);
                UpdateDgvTypes();
            }
            else
            {
                MessageBox.Show(validator.ErrorText, "Предупреждение",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void DgvTypes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTypes.SelectedRows.Count != 0)
            {
                tbTypeName.Text = dgvTypes.SelectedRows[0].Cells[1].Value.ToString();
            }
        }
    }
}
