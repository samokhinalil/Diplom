namespace Diplom
{
    partial class TaskListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriorityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComplexityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentStateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laProject = new System.Windows.Forms.Label();
            this.laEmployee = new System.Windows.Forms.Label();
            this.cbProject = new System.Windows.Forms.ComboBox();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCloseAllTasks = new System.Windows.Forms.Button();
            this.gbTaskFilter = new System.Windows.Forms.GroupBox();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.laType = new System.Windows.Forms.Label();
            this.laState = new System.Windows.Forms.Label();
            this.laComplexity = new System.Windows.Forms.Label();
            this.laPriority = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.cbComplexity = new System.Windows.Forms.ComboBox();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.btnIssueTask = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.btnChangeState = new System.Windows.Forms.Button();
            this.btnCloseTask = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.gbTaskFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTasks
            // 
            this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IssueName,
            this.PriorityName,
            this.ComplexityName,
            this.TypeName,
            this.CurrentStateName});
            this.dgvTasks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTasks.Location = new System.Drawing.Point(4, 47);
            this.dgvTasks.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTasks.MultiSelect = false;
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.ReadOnly = true;
            this.dgvTasks.RowHeadersVisible = false;
            this.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTasks.Size = new System.Drawing.Size(723, 280);
            this.dgvTasks.TabIndex = 0;
            this.dgvTasks.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvTasks_ColumnHeaderMouseClick);
            this.dgvTasks.SelectionChanged += new System.EventHandler(this.DgvTasks_SelectionChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 50F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // IssueName
            // 
            this.IssueName.DataPropertyName = "IssueName";
            this.IssueName.HeaderText = "Название задачи";
            this.IssueName.Name = "IssueName";
            this.IssueName.ReadOnly = true;
            // 
            // PriorityName
            // 
            this.PriorityName.DataPropertyName = "PriorityName";
            this.PriorityName.HeaderText = "Приоритет";
            this.PriorityName.Name = "PriorityName";
            this.PriorityName.ReadOnly = true;
            // 
            // ComplexityName
            // 
            this.ComplexityName.DataPropertyName = "ComplexityName";
            this.ComplexityName.HeaderText = "Уровень сложности";
            this.ComplexityName.Name = "ComplexityName";
            this.ComplexityName.ReadOnly = true;
            // 
            // TypeName
            // 
            this.TypeName.DataPropertyName = "TypeName";
            this.TypeName.HeaderText = "Тип";
            this.TypeName.Name = "TypeName";
            this.TypeName.ReadOnly = true;
            // 
            // CurrentStateName
            // 
            this.CurrentStateName.DataPropertyName = "CurrentStateName";
            this.CurrentStateName.HeaderText = "Текущий статус";
            this.CurrentStateName.Name = "CurrentStateName";
            this.CurrentStateName.ReadOnly = true;
            // 
            // laProject
            // 
            this.laProject.AutoSize = true;
            this.laProject.Location = new System.Drawing.Point(1, 13);
            this.laProject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laProject.Name = "laProject";
            this.laProject.Size = new System.Drawing.Size(63, 18);
            this.laProject.TabIndex = 1;
            this.laProject.Text = "Проект:";
            // 
            // laEmployee
            // 
            this.laEmployee.AutoSize = true;
            this.laEmployee.Location = new System.Drawing.Point(249, 13);
            this.laEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laEmployee.Name = "laEmployee";
            this.laEmployee.Size = new System.Drawing.Size(87, 18);
            this.laEmployee.TabIndex = 2;
            this.laEmployee.Text = "Сотрудник:";
            // 
            // cbProject
            // 
            this.cbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProject.FormattingEnabled = true;
            this.cbProject.Location = new System.Drawing.Point(61, 13);
            this.cbProject.Margin = new System.Windows.Forms.Padding(4);
            this.cbProject.Name = "cbProject";
            this.cbProject.Size = new System.Drawing.Size(180, 26);
            this.cbProject.TabIndex = 3;
            this.cbProject.SelectedValueChanged += new System.EventHandler(this.CbProject_SelectedValueChanged);
            // 
            // cbEmployee
            // 
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(344, 13);
            this.cbEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(230, 26);
            this.cbEmployee.TabIndex = 4;
            this.cbEmployee.SelectedValueChanged += new System.EventHandler(this.CbEmployee_SelectedValueChanged);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(756, 374);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(74, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(836, 374);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCloseAllTasks
            // 
            this.btnCloseAllTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCloseAllTasks.Location = new System.Drawing.Point(157, 334);
            this.btnCloseAllTasks.Name = "btnCloseAllTasks";
            this.btnCloseAllTasks.Size = new System.Drawing.Size(265, 28);
            this.btnCloseAllTasks.TabIndex = 7;
            this.btnCloseAllTasks.Text = "Завершить все выполненные задачи";
            this.btnCloseAllTasks.UseVisualStyleBackColor = true;
            this.btnCloseAllTasks.Click += new System.EventHandler(this.BtnCloseAllTasks_Click);
            // 
            // gbTaskFilter
            // 
            this.gbTaskFilter.Controls.Add(this.btnResetFilter);
            this.gbTaskFilter.Controls.Add(this.btnFilter);
            this.gbTaskFilter.Controls.Add(this.laType);
            this.gbTaskFilter.Controls.Add(this.laState);
            this.gbTaskFilter.Controls.Add(this.laComplexity);
            this.gbTaskFilter.Controls.Add(this.laPriority);
            this.gbTaskFilter.Controls.Add(this.cbType);
            this.gbTaskFilter.Controls.Add(this.cbState);
            this.gbTaskFilter.Controls.Add(this.cbComplexity);
            this.gbTaskFilter.Controls.Add(this.cbPriority);
            this.gbTaskFilter.Location = new System.Drawing.Point(734, 47);
            this.gbTaskFilter.Name = "gbTaskFilter";
            this.gbTaskFilter.Size = new System.Drawing.Size(200, 283);
            this.gbTaskFilter.TabIndex = 8;
            this.gbTaskFilter.TabStop = false;
            this.gbTaskFilter.Text = "Фильтры:";
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResetFilter.Location = new System.Drawing.Point(116, 251);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(78, 23);
            this.btnResetFilter.TabIndex = 39;
            this.btnResetFilter.Text = "Сбросить";
            this.btnResetFilter.UseVisualStyleBackColor = true;
            this.btnResetFilter.Click += new System.EventHandler(this.BtnResetFilter_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilter.Location = new System.Drawing.Point(6, 251);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(89, 23);
            this.btnFilter.TabIndex = 38;
            this.btnFilter.Text = "Применить";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // laType
            // 
            this.laType.AutoSize = true;
            this.laType.Location = new System.Drawing.Point(3, 135);
            this.laType.Name = "laType";
            this.laType.Size = new System.Drawing.Size(37, 18);
            this.laType.TabIndex = 37;
            this.laType.Text = "Тип:";
            // 
            // laState
            // 
            this.laState.AutoSize = true;
            this.laState.Location = new System.Drawing.Point(3, 187);
            this.laState.Name = "laState";
            this.laState.Size = new System.Drawing.Size(60, 18);
            this.laState.TabIndex = 36;
            this.laState.Text = "Статус:";
            // 
            // laComplexity
            // 
            this.laComplexity.AutoSize = true;
            this.laComplexity.Location = new System.Drawing.Point(3, 85);
            this.laComplexity.Name = "laComplexity";
            this.laComplexity.Size = new System.Drawing.Size(152, 18);
            this.laComplexity.TabIndex = 35;
            this.laComplexity.Text = "Уровень сложности:";
            // 
            // laPriority
            // 
            this.laPriority.AutoSize = true;
            this.laPriority.Location = new System.Drawing.Point(3, 35);
            this.laPriority.Name = "laPriority";
            this.laPriority.Size = new System.Drawing.Size(86, 18);
            this.laPriority.TabIndex = 34;
            this.laPriority.Text = "Приоритет:";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(6, 156);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(188, 26);
            this.cbType.TabIndex = 3;
            // 
            // cbState
            // 
            this.cbState.FormattingEnabled = true;
            this.cbState.Location = new System.Drawing.Point(6, 208);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(188, 26);
            this.cbState.TabIndex = 2;
            // 
            // cbComplexity
            // 
            this.cbComplexity.FormattingEnabled = true;
            this.cbComplexity.Location = new System.Drawing.Point(5, 106);
            this.cbComplexity.Name = "cbComplexity";
            this.cbComplexity.Size = new System.Drawing.Size(188, 26);
            this.cbComplexity.TabIndex = 1;
            // 
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(6, 56);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(188, 26);
            this.cbPriority.TabIndex = 0;
            // 
            // btnIssueTask
            // 
            this.btnIssueTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIssueTask.Location = new System.Drawing.Point(4, 368);
            this.btnIssueTask.Name = "btnIssueTask";
            this.btnIssueTask.Size = new System.Drawing.Size(147, 25);
            this.btnIssueTask.TabIndex = 9;
            this.btnIssueTask.Text = "Выдать задачу";
            this.btnIssueTask.UseVisualStyleBackColor = true;
            this.btnIssueTask.Click += new System.EventHandler(this.BtnIssueTask_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddTask.Location = new System.Drawing.Point(427, 368);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(147, 25);
            this.btnAddTask.TabIndex = 40;
            this.btnAddTask.Text = "Добавить";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.BtnAddTask_Click);
            // 
            // btnEditTask
            // 
            this.btnEditTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditTask.Location = new System.Drawing.Point(580, 368);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(147, 25);
            this.btnEditTask.TabIndex = 41;
            this.btnEditTask.Text = "Редактировать";
            this.btnEditTask.UseVisualStyleBackColor = true;
            this.btnEditTask.Click += new System.EventHandler(this.BtnEditTask_Click);
            // 
            // btnChangeState
            // 
            this.btnChangeState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeState.Location = new System.Drawing.Point(580, 334);
            this.btnChangeState.Name = "btnChangeState";
            this.btnChangeState.Size = new System.Drawing.Size(147, 27);
            this.btnChangeState.TabIndex = 40;
            this.btnChangeState.Text = "Изменить статус";
            this.btnChangeState.UseVisualStyleBackColor = true;
            this.btnChangeState.Click += new System.EventHandler(this.BtnChangeState_Click);
            // 
            // btnCloseTask
            // 
            this.btnCloseTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCloseTask.Location = new System.Drawing.Point(4, 334);
            this.btnCloseTask.Name = "btnCloseTask";
            this.btnCloseTask.Size = new System.Drawing.Size(147, 28);
            this.btnCloseTask.TabIndex = 42;
            this.btnCloseTask.Text = "Завершить";
            this.btnCloseTask.UseVisualStyleBackColor = true;
            this.btnCloseTask.Click += new System.EventHandler(this.BtnCloseTask_Click);
            // 
            // TaskListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 398);
            this.Controls.Add(this.btnCloseTask);
            this.Controls.Add(this.btnChangeState);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.btnEditTask);
            this.Controls.Add(this.btnIssueTask);
            this.Controls.Add(this.gbTaskFilter);
            this.Controls.Add(this.btnCloseAllTasks);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbEmployee);
            this.Controls.Add(this.cbProject);
            this.Controls.Add(this.laEmployee);
            this.Controls.Add(this.laProject);
            this.Controls.Add(this.dgvTasks);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaskListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список задач";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.gbTaskFilter.ResumeLayout(false);
            this.gbTaskFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.Label laProject;
        private System.Windows.Forms.Label laEmployee;
        private System.Windows.Forms.ComboBox cbProject;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCloseAllTasks;
        private System.Windows.Forms.GroupBox gbTaskFilter;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.ComboBox cbComplexity;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.Label laType;
        private System.Windows.Forms.Label laState;
        private System.Windows.Forms.Label laComplexity;
        private System.Windows.Forms.Label laPriority;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnIssueTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriorityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComplexityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentStateName;
        private System.Windows.Forms.Button btnChangeState;
        private System.Windows.Forms.Button btnCloseTask;
    }
}