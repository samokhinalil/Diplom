namespace Diplom
{
    partial class TaskForm
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
            this.laTaskName = new System.Windows.Forms.Label();
            this.laPriority = new System.Windows.Forms.Label();
            this.laComplexity = new System.Windows.Forms.Label();
            this.laState = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.laType = new System.Windows.Forms.Label();
            this.laDescription = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbComplexity = new System.Windows.Forms.ComboBox();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.tbTaskName = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.btnAddSubTask = new System.Windows.Forms.Button();
            this.btnDeleteSubTask = new System.Windows.Forms.Button();
            this.cbProject = new System.Windows.Forms.ComboBox();
            this.laProject = new System.Windows.Forms.Label();
            this.btnEditSubTask = new System.Windows.Forms.Button();
            this.dgvSubTasks = new System.Windows.Forms.DataGridView();
            this.gbSubTasks = new System.Windows.Forms.GroupBox();
            this.btnChangeSubIssueState = new System.Windows.Forms.Button();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.SubTaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubTasks)).BeginInit();
            this.gbSubTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // laTaskName
            // 
            this.laTaskName.AutoSize = true;
            this.laTaskName.Location = new System.Drawing.Point(25, 14);
            this.laTaskName.Name = "laTaskName";
            this.laTaskName.Size = new System.Drawing.Size(132, 18);
            this.laTaskName.TabIndex = 0;
            this.laTaskName.Text = "Название задачи:";
            // 
            // laPriority
            // 
            this.laPriority.AutoSize = true;
            this.laPriority.Location = new System.Drawing.Point(71, 75);
            this.laPriority.Name = "laPriority";
            this.laPriority.Size = new System.Drawing.Size(86, 18);
            this.laPriority.TabIndex = 1;
            this.laPriority.Text = "Приоритет:";
            // 
            // laComplexity
            // 
            this.laComplexity.AutoSize = true;
            this.laComplexity.Location = new System.Drawing.Point(8, 107);
            this.laComplexity.Name = "laComplexity";
            this.laComplexity.Size = new System.Drawing.Size(152, 18);
            this.laComplexity.TabIndex = 2;
            this.laComplexity.Text = "Уровень сложности:";
            // 
            // laState
            // 
            this.laState.AutoSize = true;
            this.laState.Location = new System.Drawing.Point(97, 139);
            this.laState.Name = "laState";
            this.laState.Size = new System.Drawing.Size(60, 18);
            this.laState.TabIndex = 3;
            this.laState.Text = "Статус:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(442, 462);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(362, 462);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 31;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // laType
            // 
            this.laType.AutoSize = true;
            this.laType.Location = new System.Drawing.Point(120, 44);
            this.laType.Name = "laType";
            this.laType.Size = new System.Drawing.Size(37, 18);
            this.laType.TabIndex = 33;
            this.laType.Text = "Тип:";
            // 
            // laDescription
            // 
            this.laDescription.AutoSize = true;
            this.laDescription.Location = new System.Drawing.Point(77, 212);
            this.laDescription.Name = "laDescription";
            this.laDescription.Size = new System.Drawing.Size(80, 18);
            this.laDescription.TabIndex = 35;
            this.laDescription.Text = "Описание:";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(163, 44);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(217, 26);
            this.cbType.TabIndex = 39;
            // 
            // cbComplexity
            // 
            this.cbComplexity.FormattingEnabled = true;
            this.cbComplexity.Location = new System.Drawing.Point(163, 107);
            this.cbComplexity.Name = "cbComplexity";
            this.cbComplexity.Size = new System.Drawing.Size(217, 26);
            this.cbComplexity.TabIndex = 37;
            // 
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(163, 75);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(217, 26);
            this.cbPriority.TabIndex = 36;
            // 
            // tbTaskName
            // 
            this.tbTaskName.Location = new System.Drawing.Point(163, 14);
            this.tbTaskName.Name = "tbTaskName";
            this.tbTaskName.Size = new System.Drawing.Size(366, 24);
            this.tbTaskName.TabIndex = 40;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(163, 212);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(366, 70);
            this.tbDescription.TabIndex = 41;
            // 
            // btnAddSubTask
            // 
            this.btnAddSubTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddSubTask.Location = new System.Drawing.Point(391, 22);
            this.btnAddSubTask.Name = "btnAddSubTask";
            this.btnAddSubTask.Size = new System.Drawing.Size(120, 23);
            this.btnAddSubTask.TabIndex = 43;
            this.btnAddSubTask.Text = "Добавить";
            this.btnAddSubTask.UseVisualStyleBackColor = true;
            this.btnAddSubTask.Click += new System.EventHandler(this.BtnAddSubTask_Click_1);
            // 
            // btnDeleteSubTask
            // 
            this.btnDeleteSubTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteSubTask.Location = new System.Drawing.Point(391, 129);
            this.btnDeleteSubTask.Name = "btnDeleteSubTask";
            this.btnDeleteSubTask.Size = new System.Drawing.Size(120, 23);
            this.btnDeleteSubTask.TabIndex = 45;
            this.btnDeleteSubTask.Text = "Удалить";
            this.btnDeleteSubTask.UseVisualStyleBackColor = true;
            this.btnDeleteSubTask.Click += new System.EventHandler(this.BtnDeleteSubTask_Click);
            // 
            // cbProject
            // 
            this.cbProject.FormattingEnabled = true;
            this.cbProject.Location = new System.Drawing.Point(163, 172);
            this.cbProject.Name = "cbProject";
            this.cbProject.Size = new System.Drawing.Size(367, 26);
            this.cbProject.TabIndex = 48;
            // 
            // laProject
            // 
            this.laProject.AutoSize = true;
            this.laProject.Location = new System.Drawing.Point(97, 172);
            this.laProject.Name = "laProject";
            this.laProject.Size = new System.Drawing.Size(63, 18);
            this.laProject.TabIndex = 47;
            this.laProject.Text = "Проект:";
            // 
            // btnEditSubTask
            // 
            this.btnEditSubTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditSubTask.Location = new System.Drawing.Point(391, 51);
            this.btnEditSubTask.Name = "btnEditSubTask";
            this.btnEditSubTask.Size = new System.Drawing.Size(120, 23);
            this.btnEditSubTask.TabIndex = 44;
            this.btnEditSubTask.Text = "Редактировать";
            this.btnEditSubTask.UseVisualStyleBackColor = true;
            this.btnEditSubTask.Click += new System.EventHandler(this.BtnEditSubTask_Click);
            // 
            // dgvSubTasks
            // 
            this.dgvSubTasks.AllowUserToAddRows = false;
            this.dgvSubTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubTaskName,
            this.StateName});
            this.dgvSubTasks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSubTasks.Location = new System.Drawing.Point(9, 23);
            this.dgvSubTasks.MultiSelect = false;
            this.dgvSubTasks.Name = "dgvSubTasks";
            this.dgvSubTasks.RowHeadersVisible = false;
            this.dgvSubTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubTasks.Size = new System.Drawing.Size(376, 130);
            this.dgvSubTasks.TabIndex = 42;
            // 
            // gbSubTasks
            // 
            this.gbSubTasks.Controls.Add(this.btnChangeSubIssueState);
            this.gbSubTasks.Controls.Add(this.btnAddSubTask);
            this.gbSubTasks.Controls.Add(this.btnEditSubTask);
            this.gbSubTasks.Controls.Add(this.btnDeleteSubTask);
            this.gbSubTasks.Controls.Add(this.dgvSubTasks);
            this.gbSubTasks.Location = new System.Drawing.Point(12, 288);
            this.gbSubTasks.Name = "gbSubTasks";
            this.gbSubTasks.Size = new System.Drawing.Size(517, 166);
            this.gbSubTasks.TabIndex = 51;
            this.gbSubTasks.TabStop = false;
            this.gbSubTasks.Text = "Подзадачи:";
            // 
            // btnChangeSubIssueState
            // 
            this.btnChangeSubIssueState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeSubIssueState.Location = new System.Drawing.Point(391, 80);
            this.btnChangeSubIssueState.Name = "btnChangeSubIssueState";
            this.btnChangeSubIssueState.Size = new System.Drawing.Size(120, 43);
            this.btnChangeSubIssueState.TabIndex = 46;
            this.btnChangeSubIssueState.Text = "Изменить статус";
            this.btnChangeSubIssueState.UseVisualStyleBackColor = true;
            this.btnChangeSubIssueState.Click += new System.EventHandler(this.BtnChangeSubIssueState_Click);
            // 
            // cbState
            // 
            this.cbState.FormattingEnabled = true;
            this.cbState.Location = new System.Drawing.Point(163, 140);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(217, 26);
            this.cbState.TabIndex = 52;
            // 
            // SubTaskName
            // 
            this.SubTaskName.DataPropertyName = "IssueName";
            this.SubTaskName.FillWeight = 150F;
            this.SubTaskName.HeaderText = "Название подзадачи";
            this.SubTaskName.Name = "SubTaskName";
            // 
            // StateName
            // 
            this.StateName.DataPropertyName = "CurrentState";
            this.StateName.HeaderText = "Текущий статус";
            this.StateName.Name = "StateName";
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 488);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.gbSubTasks);
            this.Controls.Add(this.cbProject);
            this.Controls.Add(this.laProject);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbTaskName);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.cbComplexity);
            this.Controls.Add(this.cbPriority);
            this.Controls.Add(this.laDescription);
            this.Controls.Add(this.laType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.laState);
            this.Controls.Add(this.laComplexity);
            this.Controls.Add(this.laPriority);
            this.Controls.Add(this.laTaskName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить задачу";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubTasks)).EndInit();
            this.gbSubTasks.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laTaskName;
        private System.Windows.Forms.Label laPriority;
        private System.Windows.Forms.Label laComplexity;
        private System.Windows.Forms.Label laState;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label laType;
        private System.Windows.Forms.Label laDescription;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbComplexity;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.TextBox tbTaskName;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button btnAddSubTask;
        private System.Windows.Forms.Button btnDeleteSubTask;
        private System.Windows.Forms.ComboBox cbProject;
        private System.Windows.Forms.Label laProject;
        private System.Windows.Forms.Button btnEditSubTask;
        private System.Windows.Forms.DataGridView dgvSubTasks;
        private System.Windows.Forms.GroupBox gbSubTasks;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.Button btnChangeSubIssueState;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateName;
    }
}