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
    public partial class TaskForm : Form
    {
        private Access _access;

        public int ID { get; set; }
        public string IssueName { get; set; }
        public IssueType Type { get; set; }
        public Priority Priority { get; set; }
        public Complexity Complexity { get; set; }
        public State CurrentState { get; set; }
        public Project Project { get; set; }
        public string Description { get; set; }
        public List<IssueView> SubIssues { get; set; } = new List<IssueView>();

        public bool IsCreate;

        public TaskForm(Access access)
        {
            InitializeComponent();

            _access = access;
            IsCreate = true;
            InitTypeComboBox(0);
            InitPriorityComboBox(0);
            InitComplexityComboBox(0);
            InitStateComboBox(0);
            InitProjectComboBox(0);
            dgvSubTasks.AutoGenerateColumns = false;
        }

        public TaskForm(IssueView issueView, Access access)
        {
            InitializeComponent();

            _access = access;
            IsCreate = false;
            btnDeleteSubTask.Visible = false;

            ID = issueView.ID;
            tbTaskName.Text = issueView.IssueName;
            InitTypeComboBox(issueView.TypeID);
            InitPriorityComboBox(issueView.PriorityID);
            InitComplexityComboBox(issueView.ComplexityID);
            InitProjectComboBox(issueView.ProjectID);
            InitStateComboBox(issueView.CurrentState.ID);
            tbDescription.Text = issueView.Description;

            dgvSubTasks.AutoGenerateColumns = false;

            SubIssues = issueView.SubIssues;
            UpdateDgvSubIssues();
        }

        private void UpdateDgvSubIssues()
        {
            dgvSubTasks.DataSource = null;
            dgvSubTasks.DataSource = SubIssues;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                IssueName = tbTaskName.Text;
                Type = (IssueType)cbType.SelectedItem;
                Priority = (Priority)cbPriority.SelectedItem;
                Complexity = (Complexity)cbComplexity.SelectedItem;
                Project = (Project)cbProject.SelectedItem;
                Description = tbDescription.Text;
                CurrentState = (State)cbState.SelectedItem;

                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        private void BtnAddSubTask_Click_1(object sender, EventArgs e)
        {
            TaskForm subTaskForm = new TaskForm(_access);
            SetUpFormForAddSubTask(subTaskForm);

            subTaskForm.ShowDialog();
            if (subTaskForm.DialogResult == DialogResult.OK)
            {
                IssueView subIssue = new IssueView(
                    subTaskForm.IssueName,
                    subTaskForm.Priority.ID,
                    subTaskForm.Complexity.ID,
                    subTaskForm.Type.ID,
                    subTaskForm.Project.ID,
                    subTaskForm.Description,
                    subTaskForm.CurrentState.ID,
                    subTaskForm.CurrentState.StateName);

                subIssue.ID = IssueDao.Add(subIssue.IssueName,
                              subIssue.PriorityID,
                              subIssue.ComplexityID,
                              subIssue.TypeID,
                              subIssue.CurrentState.ID,
                              subIssue.ProjectID,
                              subIssue.Description,
                              _access.Employee.ID);
                SubIssues.Add(subIssue);
                UpdateDgvSubIssues();
            }
        }

        private void BtnEditSubTask_Click(object sender, EventArgs e)
        {
            if (dgvSubTasks.SelectedRows.Count != 0)
            {
                IssueView subissue = (IssueView)dgvSubTasks.SelectedRows[0].DataBoundItem;
                TaskForm subTaskForm = new TaskForm(subissue, _access);
                SetUpFormForEditSubTask(subissue, subTaskForm);

                subTaskForm.ShowDialog();
                if (subTaskForm.DialogResult == DialogResult.OK)
                {
                    IssueView editedSubIssue = new IssueView(
                    subTaskForm.ID,
                    subTaskForm.IssueName,
                    subTaskForm.Priority.ID,
                    subTaskForm.Complexity.ID,
                    subTaskForm.Type.ID,
                    subTaskForm.Project.ID,
                    subTaskForm.Description,
                    subTaskForm.CurrentState.ID,
                    subTaskForm.CurrentState.StateName);

                    IssueDao.Edit(editedSubIssue.ID,
                                  editedSubIssue.IssueName,
                                  editedSubIssue.PriorityID,
                                  editedSubIssue.ComplexityID,
                                  editedSubIssue.TypeID,
                                  editedSubIssue.ProjectID,
                                  editedSubIssue.Description,
                                  editedSubIssue.CurrentState.ID,
                                  _access.Employee.ID);

                    int index = SubIssues.FindIndex(i => i.ID == subissue.ID);
                    SubIssues.RemoveAt(index);
                    SubIssues.Add(editedSubIssue);
                    UpdateDgvSubIssues();
                }
            }
            else
            {
                MessageBox.Show("Подзадача не выбрана!",
                    "Предупреждение",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
            }
        }

        private void SetUpFormForAddSubTask(TaskForm subTaskForm)
        {
            subTaskForm.Text = "Добавить подзадачу";
            subTaskForm.gbSubTasks.Visible = false;

            subTaskForm.cbComplexity.DataSource = cbComplexity.DataSource;
            subTaskForm.cbPriority.DataSource = cbPriority.DataSource;
            subTaskForm.cbProject.DataSource = cbProject.DataSource;
            subTaskForm.cbType.DataSource = cbType.DataSource;

            if (cbComplexity.SelectedItem != null)
            {
                subTaskForm.cbComplexity.SelectedItem = cbComplexity.SelectedItem;
            }
            if (cbPriority.SelectedItem != null)
            {
                subTaskForm.cbPriority.SelectedItem = cbPriority.SelectedItem;
            }
            if (cbType.SelectedItem != null)
            {
                subTaskForm.cbType.SelectedItem = cbType.SelectedItem;
            }
            if (cbProject.SelectedItem != null)
            {
                subTaskForm.cbProject.SelectedItem = cbProject.SelectedItem;
            }
            subTaskForm.cbProject.Enabled = false;
            subTaskForm.Height = 355;
        }

        private void SetUpFormForEditSubTask(IssueView subissue, TaskForm subTaskForm)
        {
            subTaskForm.Text = "Редактировать подзадачу";
            subTaskForm.gbSubTasks.Visible = false;

            subTaskForm.cbComplexity.DataSource = cbComplexity.DataSource;
            subTaskForm.cbPriority.DataSource = cbPriority.DataSource;
            subTaskForm.cbProject.DataSource = cbProject.DataSource;
            subTaskForm.cbType.DataSource = cbType.DataSource;

            subTaskForm.cbComplexity.SelectedValue = subissue.ComplexityID;
            subTaskForm.cbPriority.SelectedValue = subissue.PriorityID;
            subTaskForm.cbProject.SelectedValue = subissue.ProjectID;
            subTaskForm.cbState.SelectedValue = subissue.CurrentState.ID;
            subTaskForm.IssueName = subissue.IssueName;
            subTaskForm.Description = subissue.Description;

            subTaskForm.cbProject.Enabled = false;
            subTaskForm.Height = 355;
        }

        private void BtnDeleteSubTask_Click(object sender, EventArgs e)
        {
            if (dgvSubTasks.SelectedRows.Count != 0)
            {
                IssueView subissue = (IssueView)dgvSubTasks.SelectedRows[0].DataBoundItem;

                if (MessageBox.Show("Удалить выбранную подзадачу?",
                    "Предупреждение",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    IssueDao.DeleteSubIssue(subissue.ID);

                    int index = SubIssues.FindIndex(i => i.ID == subissue.ID);
                    SubIssues.RemoveAt(index);
                    UpdateDgvSubIssues();
                }
            }
            else
            {
                MessageBox.Show("Подзадача не выбрана!",
                    "Предупреждение",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
            }
        }

        private void InitTypeComboBox(int selected)
        {
            cbType.DataSource = null;
            cbType.DisplayMember = "TypeName";
            cbType.ValueMember = "ID";
            cbType.DataSource = IssueTypeDao.SelectList();
            cbType.SelectedValue = selected;
        }

        private void InitPriorityComboBox(int selected)
        {
            cbPriority.DataSource = null;
            cbPriority.DataSource = PriorityDao.SelectList();
            cbPriority.DisplayMember = "PriorityName";
            cbPriority.ValueMember = "ID";
            cbPriority.SelectedValue = selected;
        }

        private void InitComplexityComboBox(int selected)
        {
            cbComplexity.DataSource = null;
            cbComplexity.DataSource = ComplexityDao.SelectList();
            cbComplexity.DisplayMember = "ComplexityName";
            cbComplexity.ValueMember = "ID";
            cbComplexity.SelectedValue = selected;
        }

        private void InitProjectComboBox(int selected)
        {
            cbProject.DataSource = null;
            cbProject.DataSource = ProjectDao.SelectList();
            cbProject.DisplayMember = "ProjectName";
            cbProject.ValueMember = "ID";
            cbProject.SelectedValue = selected;
        }

        private void InitStateComboBox(int selected)
        {
            cbState.DataSource = null;
            cbState.DataSource = StateDao.SelectList();
            cbState.DisplayMember = "StateName";
            cbState.ValueMember = "ID";
            cbState.SelectedValue = selected;
        }

        private void BtnChangeSubIssueState_Click(object sender, EventArgs e)
        {
            if (dgvSubTasks.CurrentCell != null)
            {
                int id = ((IssueView)dgvSubTasks.SelectedRows[0].DataBoundItem).ID;
                StateListForm stateListForm = new StateListForm();
                stateListForm.ShowDialog();
                if (stateListForm.DialogResult == DialogResult.OK)
                {
                    if (id != 0)
                    {
                        IssueDao.ChangeIssueState(
                            id,
                            stateListForm.State.ID,
                            _access.Employee.ID);
                        MessageBox.Show("Статус задачи изменен.", "Информационное сообщение",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        UpdateDgvSubIssues();
                    }
                }
            }
            else
            {
                MessageBox.Show("Не выбрана подзадача!", "Предупреждение",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
