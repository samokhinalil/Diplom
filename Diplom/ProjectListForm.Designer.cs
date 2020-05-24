namespace Diplom
{
    partial class ProjectListForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnBackToMainForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbProjectSearch = new System.Windows.Forms.GroupBox();
            this.ctlDateTo = new System.Windows.Forms.DateTimePicker();
            this.ctlDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblSearchFromDate = new System.Windows.Forms.Label();
            this.btnResetSearchingResults = new System.Windows.Forms.Button();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.btnSearchProject = new System.Windows.Forms.Button();
            this.tbSearchProject = new System.Windows.Forms.TextBox();
            this.btnEditProject = new System.Windows.Forms.Button();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.btnEditTeam = new System.Windows.Forms.Button();
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbProjectSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(624, 300);
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
            this.btnOK.Location = new System.Drawing.Point(544, 300);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(74, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.AllowCurrentPage = true;
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.ShowHelp = true;
            this.printDialog1.UseEXDialog = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(593, 143);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(129, 28);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "Печать";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnBackToMainForm
            // 
            this.btnBackToMainForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBackToMainForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackToMainForm.Location = new System.Drawing.Point(593, 261);
            this.btnBackToMainForm.Name = "btnBackToMainForm";
            this.btnBackToMainForm.Size = new System.Drawing.Size(129, 23);
            this.btnBackToMainForm.TabIndex = 14;
            this.btnBackToMainForm.Text = "В главное меню";
            this.btnBackToMainForm.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "_";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbProjectSearch
            // 
            this.gbProjectSearch.Controls.Add(this.label1);
            this.gbProjectSearch.Controls.Add(this.ctlDateTo);
            this.gbProjectSearch.Controls.Add(this.ctlDateFrom);
            this.gbProjectSearch.Controls.Add(this.lblSearchFromDate);
            this.gbProjectSearch.Controls.Add(this.btnResetSearchingResults);
            this.gbProjectSearch.Controls.Add(this.lblProjectName);
            this.gbProjectSearch.Controls.Add(this.btnSearchProject);
            this.gbProjectSearch.Controls.Add(this.tbSearchProject);
            this.gbProjectSearch.Location = new System.Drawing.Point(3, 179);
            this.gbProjectSearch.Margin = new System.Windows.Forms.Padding(4);
            this.gbProjectSearch.Name = "gbProjectSearch";
            this.gbProjectSearch.Padding = new System.Windows.Forms.Padding(4);
            this.gbProjectSearch.Size = new System.Drawing.Size(583, 112);
            this.gbProjectSearch.TabIndex = 13;
            this.gbProjectSearch.TabStop = false;
            this.gbProjectSearch.Text = "Поиск проектов:";
            // 
            // ctlDateTo
            // 
            this.ctlDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ctlDateTo.Location = new System.Drawing.Point(343, 52);
            this.ctlDateTo.Name = "ctlDateTo";
            this.ctlDateTo.Size = new System.Drawing.Size(110, 24);
            this.ctlDateTo.TabIndex = 29;
            // 
            // ctlDateFrom
            // 
            this.ctlDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ctlDateFrom.Location = new System.Drawing.Point(205, 51);
            this.ctlDateFrom.Name = "ctlDateFrom";
            this.ctlDateFrom.Size = new System.Drawing.Size(110, 24);
            this.ctlDateFrom.TabIndex = 27;
            // 
            // lblSearchFromDate
            // 
            this.lblSearchFromDate.AutoSize = true;
            this.lblSearchFromDate.Location = new System.Drawing.Point(49, 49);
            this.lblSearchFromDate.Name = "lblSearchFromDate";
            this.lblSearchFromDate.Size = new System.Drawing.Size(160, 18);
            this.lblSearchFromDate.TabIndex = 25;
            this.lblSearchFromDate.Text = "Дата начала проекта:";
            // 
            // btnResetSearchingResults
            // 
            this.btnResetSearchingResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetSearchingResults.Location = new System.Drawing.Point(482, 82);
            this.btnResetSearchingResults.Name = "btnResetSearchingResults";
            this.btnResetSearchingResults.Size = new System.Drawing.Size(94, 23);
            this.btnResetSearchingResults.TabIndex = 22;
            this.btnResetSearchingResults.Text = "Сбросить";
            this.btnResetSearchingResults.UseVisualStyleBackColor = true;
            this.btnResetSearchingResults.Click += new System.EventHandler(this.BtnResetSearchingResults_Click);
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(1, 23);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(198, 18);
            this.lblProjectName.TabIndex = 21;
            this.lblProjectName.Text = "Введите название проекта:";
            this.lblProjectName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSearchProject
            // 
            this.btnSearchProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchProject.Location = new System.Drawing.Point(391, 82);
            this.btnSearchProject.Name = "btnSearchProject";
            this.btnSearchProject.Size = new System.Drawing.Size(85, 23);
            this.btnSearchProject.TabIndex = 20;
            this.btnSearchProject.Text = "Найти";
            this.btnSearchProject.UseVisualStyleBackColor = true;
            this.btnSearchProject.Click += new System.EventHandler(this.BtnSearchProject_Click);
            // 
            // tbSearchProject
            // 
            this.tbSearchProject.Location = new System.Drawing.Point(205, 23);
            this.tbSearchProject.Name = "tbSearchProject";
            this.tbSearchProject.Size = new System.Drawing.Size(371, 24);
            this.tbSearchProject.TabIndex = 19;
            // 
            // btnEditProject
            // 
            this.btnEditProject.Location = new System.Drawing.Point(594, 38);
            this.btnEditProject.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditProject.Name = "btnEditProject";
            this.btnEditProject.Size = new System.Drawing.Size(129, 28);
            this.btnEditProject.TabIndex = 11;
            this.btnEditProject.Text = "Редактировать";
            this.btnEditProject.UseVisualStyleBackColor = true;
            this.btnEditProject.Click += new System.EventHandler(this.BtnEditProject_Click);
            // 
            // btnAddProject
            // 
            this.btnAddProject.Location = new System.Drawing.Point(594, 2);
            this.btnAddProject.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(129, 28);
            this.btnAddProject.TabIndex = 10;
            this.btnAddProject.Text = "Добавить";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.BtnAddProject_Click);
            // 
            // btnEditTeam
            // 
            this.btnEditTeam.Location = new System.Drawing.Point(594, 73);
            this.btnEditTeam.Name = "btnEditTeam";
            this.btnEditTeam.Size = new System.Drawing.Size(129, 64);
            this.btnEditTeam.TabIndex = 12;
            this.btnEditTeam.Text = "Изменить состав команды";
            this.btnEditTeam.UseVisualStyleBackColor = true;
            this.btnEditTeam.Click += new System.EventHandler(this.BtnEditTeam_Click);
            // 
            // dgvProjects
            // 
            this.dgvProjects.AllowUserToAddRows = false;
            this.dgvProjects.AllowUserToDeleteRows = false;
            this.dgvProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ProjectName,
            this.StartDate});
            this.dgvProjects.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProjects.Location = new System.Drawing.Point(3, 2);
            this.dgvProjects.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProjects.MultiSelect = false;
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.ReadOnly = true;
            this.dgvProjects.RowHeadersVisible = false;
            this.dgvProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjects.Size = new System.Drawing.Size(583, 169);
            this.dgvProjects.TabIndex = 9;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 25F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // ProjectName
            // 
            this.ProjectName.DataPropertyName = "ProjectName";
            this.ProjectName.HeaderText = "Название проекта";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.FillWeight = 53.45538F;
            this.StartDate.HeaderText = "Дата начала";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // ProjectListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 324);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnBackToMainForm);
            this.Controls.Add(this.gbProjectSearch);
            this.Controls.Add(this.btnEditProject);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.btnEditTeam);
            this.Controls.Add(this.dgvProjects);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProjectListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список проектов";
            this.gbProjectSearch.ResumeLayout(false);
            this.gbProjectSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnBackToMainForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbProjectSearch;
        private System.Windows.Forms.DateTimePicker ctlDateTo;
        private System.Windows.Forms.DateTimePicker ctlDateFrom;
        private System.Windows.Forms.Label lblSearchFromDate;
        private System.Windows.Forms.Button btnResetSearchingResults;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Button btnSearchProject;
        private System.Windows.Forms.TextBox tbSearchProject;
        private System.Windows.Forms.Button btnEditProject;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Button btnEditTeam;
        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
    }
}