namespace Diplom
{
    partial class EmployeeListForm
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
            this.cbProject = new System.Windows.Forms.ComboBox();
            this.laProject = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.gbEmployeeSearch = new System.Windows.Forms.GroupBox();
            this.btnResetSearchingResults = new System.Windows.Forms.Button();
            this.lblEmployeePosition = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.cbSearchEmployeePosition = new System.Windows.Forms.ComboBox();
            this.tbSearchEmployeeByName = new System.Windows.Forms.TextBox();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbEmployeeSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // cbProject
            // 
            this.cbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProject.FormattingEnabled = true;
            this.cbProject.Location = new System.Drawing.Point(81, 13);
            this.cbProject.Margin = new System.Windows.Forms.Padding(4);
            this.cbProject.Name = "cbProject";
            this.cbProject.Size = new System.Drawing.Size(253, 26);
            this.cbProject.TabIndex = 5;
            this.cbProject.SelectedValueChanged += new System.EventHandler(this.CbProject_SelectedValueChanged);
            // 
            // laProject
            // 
            this.laProject.AutoSize = true;
            this.laProject.Location = new System.Drawing.Point(10, 13);
            this.laProject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laProject.Name = "laProject";
            this.laProject.Size = new System.Drawing.Size(63, 18);
            this.laProject.TabIndex = 4;
            this.laProject.Text = "Проект:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(875, 429);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(795, 429);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(74, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // gbEmployeeSearch
            // 
            this.gbEmployeeSearch.Controls.Add(this.btnResetSearchingResults);
            this.gbEmployeeSearch.Controls.Add(this.lblEmployeePosition);
            this.gbEmployeeSearch.Controls.Add(this.lblEmployeeName);
            this.gbEmployeeSearch.Controls.Add(this.btnSearchEmployee);
            this.gbEmployeeSearch.Controls.Add(this.cbSearchEmployeePosition);
            this.gbEmployeeSearch.Controls.Add(this.tbSearchEmployeeByName);
            this.gbEmployeeSearch.Location = new System.Drawing.Point(2, 307);
            this.gbEmployeeSearch.Margin = new System.Windows.Forms.Padding(4);
            this.gbEmployeeSearch.Name = "gbEmployeeSearch";
            this.gbEmployeeSearch.Padding = new System.Windows.Forms.Padding(4);
            this.gbEmployeeSearch.Size = new System.Drawing.Size(682, 120);
            this.gbEmployeeSearch.TabIndex = 10;
            this.gbEmployeeSearch.TabStop = false;
            this.gbEmployeeSearch.Text = "Поиск сотрудников:";
            // 
            // btnResetSearchingResults
            // 
            this.btnResetSearchingResults.Location = new System.Drawing.Point(511, 52);
            this.btnResetSearchingResults.Name = "btnResetSearchingResults";
            this.btnResetSearchingResults.Size = new System.Drawing.Size(149, 25);
            this.btnResetSearchingResults.TabIndex = 14;
            this.btnResetSearchingResults.Text = "Сбросить";
            this.btnResetSearchingResults.UseVisualStyleBackColor = true;
            this.btnResetSearchingResults.Click += new System.EventHandler(this.BtnResetSearchingResults_Click);
            // 
            // lblEmployeePosition
            // 
            this.lblEmployeePosition.AutoSize = true;
            this.lblEmployeePosition.Location = new System.Drawing.Point(25, 49);
            this.lblEmployeePosition.Name = "lblEmployeePosition";
            this.lblEmployeePosition.Size = new System.Drawing.Size(161, 36);
            this.lblEmployeePosition.TabIndex = 13;
            this.lblEmployeePosition.Text = "и/или\r\nвыберите должность:";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(25, 23);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(101, 18);
            this.lblEmployeeName.TabIndex = 12;
            this.lblEmployeeName.Text = "Введите имя:";
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Location = new System.Drawing.Point(511, 23);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(149, 23);
            this.btnSearchEmployee.TabIndex = 11;
            this.btnSearchEmployee.Text = "Найти";
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            this.btnSearchEmployee.Click += new System.EventHandler(this.BtnSearchEmployee_Click);
            // 
            // cbSearchEmployeePosition
            // 
            this.cbSearchEmployeePosition.FormattingEnabled = true;
            this.cbSearchEmployeePosition.Location = new System.Drawing.Point(192, 69);
            this.cbSearchEmployeePosition.Name = "cbSearchEmployeePosition";
            this.cbSearchEmployeePosition.Size = new System.Drawing.Size(285, 26);
            this.cbSearchEmployeePosition.TabIndex = 10;
            // 
            // tbSearchEmployeeByName
            // 
            this.tbSearchEmployeeByName.Location = new System.Drawing.Point(127, 23);
            this.tbSearchEmployeeByName.Name = "tbSearchEmployeeByName";
            this.tbSearchEmployeeByName.Size = new System.Drawing.Size(350, 24);
            this.tbSearchEmployeeByName.TabIndex = 0;
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Location = new System.Drawing.Point(835, 13);
            this.btnEditEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(138, 28);
            this.btnEditEmployee.TabIndex = 12;
            this.btnEditEmployee.Text = "Редактировать";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.BtnEditEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(720, 13);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(107, 28);
            this.btnAddEmployee.TabIndex = 11;
            this.btnAddEmployee.Text = "Добавить";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.BtnAddEmployee_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FullName,
            this.Passport,
            this.Phone,
            this.Email,
            this.Position});
            this.dgvEmployees.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEmployees.Location = new System.Drawing.Point(2, 47);
            this.dgvEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmployees.MultiSelect = false;
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(971, 252);
            this.dgvEmployees.TabIndex = 13;
            this.dgvEmployees.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvEmployees_ColumnHeaderMouseClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 50F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.FillWeight = 89.54314F;
            this.FullName.HeaderText = "ФИО";
            this.FullName.Name = "FullName";
            // 
            // Passport
            // 
            this.Passport.DataPropertyName = "Passport";
            this.Passport.FillWeight = 89.54314F;
            this.Passport.HeaderText = "Паспорт";
            this.Passport.Name = "Passport";
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.FillWeight = 89.54314F;
            this.Phone.HeaderText = "Телефон";
            this.Phone.Name = "Phone";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.FillWeight = 89.54314F;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position";
            this.Position.FillWeight = 89.54314F;
            this.Position.HeaderText = "Должность";
            this.Position.Name = "Position";
            // 
            // EmployeeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 455);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.gbEmployeeSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbProject);
            this.Controls.Add(this.laProject);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список сотрудников";
            this.gbEmployeeSearch.ResumeLayout(false);
            this.gbEmployeeSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProject;
        private System.Windows.Forms.Label laProject;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox gbEmployeeSearch;
        private System.Windows.Forms.Button btnResetSearchingResults;
        private System.Windows.Forms.Label lblEmployeePosition;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.ComboBox cbSearchEmployeePosition;
        private System.Windows.Forms.TextBox tbSearchEmployeeByName;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
    }
}