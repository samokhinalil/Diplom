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
    public partial class TaskListForm : Form
    {
        private Access _access;
        private int taskSelector = -1;
        private const string pmRoleName = "Менеджер проекта";
        private const string devRoleName = "Разработчик";

        private enum SortMode { Asceding, Desceding };
        private SortMode _sortMode = SortMode.Asceding;

        public TaskListForm(Access access)
        {
            InitializeComponent();

            _access = access;

            InitProjectComboBox(_access.Employee.ID);

            int projectId = ((Project)cbProject.SelectedItem).ID;

            UpdateDgvTasks(projectId);
            UpdateComboBoxEmployees(projectId);

            InitTypeComboBox(0);
            InitStateComboBox(0);
            InitPriorityComboBox(0);
            InitComplexityComboBox(0);

        }

        public TaskListForm(Access access, int taskSelector)
        {
            InitializeComponent();

            _access = access;
            this.taskSelector = taskSelector;

            InitProjectComboBox(_access.Employee.ID);

            int projectId = ((Project)cbProject.SelectedItem).ID;

            UpdateDgvTasks(access.Employee.ID, projectId, taskSelector);
            UpdateComboBoxEmployees(projectId);

            InitTypeComboBox(0);
            InitStateComboBox(0);
            InitPriorityComboBox(0);
            InitComplexityComboBox(0);

        }

        private void UpdateDgvTasks(int employeeId, int projectId, int selector)
        {
            dgvTasks.AutoGenerateColumns = false;

            dgvTasks.DataSource = null;
            if (_access.Role.RoleName.Equals(devRoleName))
            {
                if (selector == 1)//открытые задачи
                {
                    dgvTasks.DataSource = IssueDao.GetEmployeeOpenIssues(employeeId, projectId);
                    

                }
                else if (selector == 2)//выполненные задачи
                {
                    dgvTasks.DataSource = IssueDao.GetEmployeeExecutedIssues(employeeId, projectId);
                }

                if (dgvTasks.DataSource == null)
                {
                    MessageBox.Show("Задач нет");
                }
            }
        }

        private void UpdateComboBoxEmployees(int projectId)
        {
            if (_access.Role.RoleName.Equals(pmRoleName))
            {
                UpdateComboBoxProjectEmployees(projectId);
            }

            if (_access.Role.RoleName.Equals(devRoleName))
            {
                UpdateComboBoxEmployee(_access.Employee.ID);
            }
        }

        private void UpdateComboBoxEmployee(int employeeId)
        {
            cbEmployee.Items.Clear();
            cbEmployee.Items.Add(EmployeeDao.GetByID(employeeId));
            cbEmployee.DisplayMember = "FullName";
            cbEmployee.ValueMember = "ID";
            if (cbEmployee.Items != null)
            {
                cbEmployee.SelectedIndex = 0;
            }
        }

        private void UpdateComboBoxProjectEmployees(int projectId)
        {
            cbEmployee.DataSource = null;
            cbEmployee.DataSource = TeamDao.GetProjectTeam(projectId);
            cbEmployee.DisplayMember = "FullName";
            cbEmployee.ValueMember = "ID";
            if (cbEmployee.DataSource != null)
            {
                cbEmployee.SelectedValue = 0;
            }
        }

        private void UpdateDgvTasks()
        {
            dgvTasks.DataSource = null;
            dgvTasks.DataSource = IssueDao.SelectList();
        }

        private void UpdateDgvTasks(int projectId)
        {
            dgvTasks.AutoGenerateColumns = false;
            if (_access.Role.RoleName.Equals(pmRoleName))
            {
                dgvTasks.DataSource = null;
                dgvTasks.DataSource = IssueDao.GetProjectIssues(projectId);
            }

            if (_access.Role.RoleName.Equals(devRoleName))
            {
                UpdateDgvEmployeeTasks(_access.Employee.ID, projectId);
            }
        }

        private void UpdateDgvEmployeeTasks(int employeeId, int projectId)
        {
            dgvTasks.DataSource = null;
            dgvTasks.DataSource = IssueDao.GetEmployeeIssues(employeeId, projectId);
        }

        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            TaskForm taskForm = new TaskForm(_access);
            taskForm.ShowDialog();
            if (taskForm.DialogResult == DialogResult.OK)
            {
                int issueID = IssueDao.Add(taskForm.IssueName,
                             taskForm.Priority.ID,
                             taskForm.Complexity.ID,
                             taskForm.Type.ID,
                             taskForm.CurrentState.ID,
                             taskForm.Project.ID,
                             taskForm.Description,
                             _access.Employee.ID);
                if (taskForm.SubIssues.Count != 0)
                {
                    //add subtasks
                    IssueDao.InsertIssueSubIssues(issueID, taskForm.SubIssues);
                }

                int projectId = ((Project)cbProject.SelectedItem).ID;
                if (_access.Role.RoleName.Equals("Разработчик"))
                {
                    UpdateDgvTasks(_access.Employee.ID, projectId, taskSelector);
                }
                else
                {
                    UpdateDgvTasks(projectId);
                }

                //update filter if it exists
                dgvTasks.CurrentCell = null;
                Filter(cbState, StateFilter);
                Filter(cbPriority, PriorityFilter);
                Filter(cbComplexity, ComplexityFilter);
                Filter(cbType, TypeFilter);
            }
        }

        private void BtnEditTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.CurrentCell != null)
            {
                int issueID = ((IssueListView)dgvTasks.CurrentRow.DataBoundItem).ID;
                IssueView issueView = IssueDao.GetByID(issueID);

                TaskForm taskForm = new TaskForm(issueView, _access);
                taskForm.ShowDialog();
                if (taskForm.DialogResult == DialogResult.OK)
                {
                    IssueDao.Edit(taskForm.ID,
                                  taskForm.IssueName,
                                  taskForm.Priority.ID,
                                  taskForm.Complexity.ID,
                                  taskForm.Type.ID,
                                  taskForm.Project.ID,
                                  taskForm.Description,
                                  taskForm.CurrentState.ID,
                                  _access.Employee.ID);
                    if (taskForm.SubIssues.Count != 0)
                    {
                        //edit subtasks
                        IssueDao.InsertIssueSubIssues(taskForm.ID, taskForm.SubIssues);
                    }

                    int projectId = ((Project)cbProject.SelectedItem).ID;
                    if (_access.Role.RoleName.Equals("Разработчик"))
                    {
                        UpdateDgvTasks(_access.Employee.ID, projectId, taskSelector);
                    }
                    else
                    {
                        UpdateDgvTasks(projectId);
                    }
                }
            }
            else
            {
                MessageBox.Show("Задача не выбрана!", "Предупреждение",
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

        private void InitProjectComboBox(int employeeId)
        {
            cbProject.DataSource = null;
            cbProject.DataSource = ProjectDao.GetEmployeeProjects(employeeId);
            cbProject.DisplayMember = "ProjectName";
            cbProject.ValueMember = "ID";
            if (cbProject.DataSource != null)
            {
                cbProject.SelectedValue = 1;
            }
        }

        private void InitStateComboBox(int selected)
        {
            cbState.DataSource = null;
            cbState.DataSource = StateDao.SelectList();
            cbState.DisplayMember = "StateName";
            cbState.ValueMember = "ID";
            cbState.SelectedValue = selected;
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            dgvTasks.CurrentCell = null;
            Filter(cbState, StateFilter);
            Filter(cbPriority, PriorityFilter);
            Filter(cbComplexity, ComplexityFilter);
            Filter(cbType, TypeFilter);
        }

        private void Filter(ComboBox comboBox, FilterCondition filter)
        {
            if (comboBox.SelectedItem != null)
            {
                foreach (DataGridViewRow row in dgvTasks.Rows)
                {
                    if (filter(row))
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private delegate bool FilterCondition(DataGridViewRow row);

        private bool StateFilter(DataGridViewRow row)
        {
            return !row.Cells["CurrentStateName"].Value.ToString()
                        .Contains(((State)cbState.SelectedItem).StateName);
        }

        private bool TypeFilter(DataGridViewRow row)
        {
            return !row.Cells["TypeName"].Value.ToString()
                        .Contains(((IssueType)cbType.SelectedItem).TypeName);
        }

        private bool ComplexityFilter(DataGridViewRow row)
        {
            return !row.Cells["ComplexityName"].Value.ToString()
                        .Contains(((Complexity)cbComplexity.SelectedItem).ComplexityName);
        }

        private bool PriorityFilter(DataGridViewRow row)
        {
            return !row.Cells["PriorityName"].Value.ToString()
                        .Contains(((Priority)cbPriority.SelectedItem).PriorityName);
        }

        private void BtnResetFilter_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvTasks.Rows)
            {
                row.Visible = true;
            }
            cbComplexity.SelectedValue = 0;
            cbPriority.SelectedValue = 0;
            cbState.SelectedValue = 0;
            cbType.SelectedValue = 0;
        }

        private void BtnChangeState_Click(object sender, EventArgs e)
        {
            if (dgvTasks.CurrentCell != null)
            {
                int id = ((IssueListView)dgvTasks.SelectedRows[0].DataBoundItem).ID;
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

                        int projectId = ((Project)cbProject.SelectedItem).ID;
                        if (_access.Role.RoleName.Equals("Разработчик"))
                        {
                            UpdateDgvTasks(_access.Employee.ID, projectId, taskSelector);
                        }
                        else
                        {
                            UpdateDgvTasks(projectId);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Не выбрана задача!", "Предупреждение",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void CbProject_SelectedValueChanged(object sender, EventArgs e)
        {
            int projectId = ((Project)cbProject.SelectedItem).ID;
            UpdateDgvTasks(projectId);
            UpdateComboBoxEmployees(projectId);
        }

        private void CbEmployee_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbProject.SelectedItem != null)
            {
                int projectId = ((Project)cbProject.SelectedItem).ID;

                if (cbEmployee.SelectedItem != null)
                {
                    int employeeId = ((Employee)cbEmployee.SelectedItem).ID;
                    if (taskSelector == 1)
                    {
                        UpdateDgvTasks(employeeId, projectId, 1);
                    }
                    else if (taskSelector == 2)
                    {
                        UpdateDgvTasks(employeeId, projectId, 2);
                    }
                    else
                    {
                        UpdateDgvEmployeeTasks(employeeId, projectId);
                    }

                }
                else
                {
                    UpdateDgvTasks(projectId);
                }
            }
        }

        private void BtnCloseAllTasks_Click(object sender, EventArgs e)
        {
            List<IssueListView> issues = (List<IssueListView>)dgvTasks.DataSource;
            IssueDao.CloseAllExecutedIssues(_access.Employee.ID, issues);
            if (cbProject.SelectedItem != null)
            {
                int projectId = ((Project)cbProject.SelectedItem).ID;
                UpdateDgvTasks(projectId);
            }
        }

        private void BtnCloseTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.CurrentCell != null)
            {
                IssueListView issue = (IssueListView)dgvTasks.CurrentRow.DataBoundItem;
                IssueDao.CloseExecutedIssue(_access.Employee.ID, issue.ID);

                if (cbProject.SelectedItem != null)
                {
                    int projectId = ((Project)cbProject.SelectedItem).ID;
                    UpdateDgvTasks(projectId);
                }
            }
        }

        private void DgvTasks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTasks.CurrentCell != null)
            {
                IssueListView issue = (IssueListView)dgvTasks.CurrentRow.DataBoundItem;
                string stateName = issue.CurrentStateName;
                btnCloseTask.Enabled = stateName.Equals("Выполнено");
                btnChangeState.Enabled = !stateName.Equals("Выполнено");
                btnIssueTask.Enabled = stateName.Contains("Подготовлено");
                btnDetailInfo.Enabled = !(stateName.Contains("Подготовлено")
                    || stateName.Equals("Выдано"));
            }
        }

        private void BtnIssueTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.CurrentCell != null)
            {
                IssueListView issue = (IssueListView)dgvTasks.CurrentRow.DataBoundItem;
                TaskIssuingForm taskIssuingForm = new TaskIssuingForm(_access, issue);
                taskIssuingForm.ShowDialog();
                if (taskIssuingForm.DialogResult == DialogResult.OK)
                {
                    int projectId = ((Project)cbProject.SelectedItem).ID;


                    UpdateDgvTasks(projectId);

                    dgvTasks.CurrentCell = null;
                    Filter(cbState, StateFilter);
                    Filter(cbPriority, PriorityFilter);
                    Filter(cbComplexity, ComplexityFilter);
                    Filter(cbType, TypeFilter);
                }
            }
        }

        private void DgvTasks_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    if (_sortMode == SortMode.Asceding)
                    {
                        List<IssueListView> list = (List<IssueListView>)dgvTasks.DataSource;
                        dgvTasks.DataSource = null;
                        dgvTasks.DataSource = list
                            .OrderBy(o => o.ID).ToList();

                        _sortMode = SortMode.Desceding;
                    }
                    else
                    {
                        List<IssueListView> list = (List<IssueListView>)dgvTasks.DataSource;
                        dgvTasks.DataSource = null;
                        dgvTasks.DataSource = list
                            .OrderByDescending(o => o.ID).ToList();

                        _sortMode = SortMode.Asceding;
                    }
                    break;
                case 1:
                    if (_sortMode == SortMode.Asceding)
                    {
                        List<IssueListView> list = (List<IssueListView>)dgvTasks.DataSource;
                        dgvTasks.DataSource = null;
                        dgvTasks.DataSource = list
                            .OrderBy(o => o.IssueName).ToList();

                        _sortMode = SortMode.Desceding;
                    }
                    else
                    {
                        List<IssueListView> list = (List<IssueListView>)dgvTasks.DataSource;
                        dgvTasks.DataSource = null;
                        dgvTasks.DataSource = list
                            .OrderByDescending(o => o.IssueName).ToList();

                        _sortMode = SortMode.Asceding;
                    }
                    break;
                case 2:
                    if (_sortMode == SortMode.Asceding)
                    {
                        List<IssueListView> list = (List<IssueListView>)dgvTasks.DataSource;
                        dgvTasks.DataSource = null;
                        dgvTasks.DataSource = list
                            .OrderBy(o => o.PriorityName).ToList();

                        _sortMode = SortMode.Desceding;
                    }
                    else
                    {
                        List<IssueListView> list = (List<IssueListView>)dgvTasks.DataSource;
                        dgvTasks.DataSource = null;
                        dgvTasks.DataSource = list
                            .OrderByDescending(o => o.PriorityName).ToList();

                        _sortMode = SortMode.Asceding;
                    }
                    break;
                case 3:
                    if (_sortMode == SortMode.Asceding)
                    {
                        List<IssueListView> list = (List<IssueListView>)dgvTasks.DataSource;
                        dgvTasks.DataSource = null;
                        dgvTasks.DataSource = list
                            .OrderBy(o => o.ComplexityName).ToList();

                        _sortMode = SortMode.Desceding;
                    }
                    else
                    {
                        List<IssueListView> list = (List<IssueListView>)dgvTasks.DataSource;
                        dgvTasks.DataSource = null;
                        dgvTasks.DataSource = list
                            .OrderByDescending(o => o.ComplexityName).ToList();

                        _sortMode = SortMode.Asceding;
                    }
                    break;
                case 4:
                    if (_sortMode == SortMode.Asceding)
                    {
                        List<IssueListView> list = (List<IssueListView>)dgvTasks.DataSource;
                        dgvTasks.DataSource = null;
                        dgvTasks.DataSource = list
                            .OrderBy(o => o.TypeName).ToList();

                        _sortMode = SortMode.Desceding;
                    }
                    else
                    {
                        List<IssueListView> list = (List<IssueListView>)dgvTasks.DataSource;
                        dgvTasks.DataSource = null;
                        dgvTasks.DataSource = list
                            .OrderByDescending(o => o.TypeName).ToList();

                        _sortMode = SortMode.Asceding;
                    }
                    break;
                case 5:
                    if (_sortMode == SortMode.Asceding)
                    {
                        List<IssueListView> list = (List<IssueListView>)dgvTasks.DataSource;
                        dgvTasks.DataSource = null;
                        dgvTasks.DataSource = list
                            .OrderBy(o => o.CurrentStateName).ToList();

                        _sortMode = SortMode.Desceding;
                    }
                    else
                    {
                        List<IssueListView> list = (List<IssueListView>)dgvTasks.DataSource;
                        dgvTasks.DataSource = null;
                        dgvTasks.DataSource = list
                            .OrderByDescending(o => o.CurrentStateName).ToList();

                        _sortMode = SortMode.Asceding;
                    }
                    break;
                default:
                    break;
            }
        }

        private void BtnDetailInfo_Click(object sender, EventArgs e)
        {
            int issueId = ((IssueListView)dgvTasks.CurrentRow.DataBoundItem).ID;

            IssueDetailInfoForm issueDetailInfoForm = new IssueDetailInfoForm(issueId);
            issueDetailInfoForm.ShowDialog();
        }
    }
}
