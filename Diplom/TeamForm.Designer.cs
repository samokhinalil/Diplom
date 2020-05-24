namespace Diplom
{
    partial class TeamForm
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
            this.gbAppropriateEmployees = new System.Windows.Forms.GroupBox();
            this.dgvAppropriateEmployees = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddEmployeeToProject = new System.Windows.Forms.Button();
            this.dgvTeamEmployees = new System.Windows.Forms.DataGridView();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemoveEmployeeFromProject = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.gbTeam = new System.Windows.Forms.GroupBox();
            this.gbAppropriateEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppropriateEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamEmployees)).BeginInit();
            this.gbTeam.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAppropriateEmployees
            // 
            this.gbAppropriateEmployees.Controls.Add(this.dgvAppropriateEmployees);
            this.gbAppropriateEmployees.Controls.Add(this.btnAddEmployeeToProject);
            this.gbAppropriateEmployees.Location = new System.Drawing.Point(2, 2);
            this.gbAppropriateEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.gbAppropriateEmployees.Name = "gbAppropriateEmployees";
            this.gbAppropriateEmployees.Padding = new System.Windows.Forms.Padding(4);
            this.gbAppropriateEmployees.Size = new System.Drawing.Size(819, 212);
            this.gbAppropriateEmployees.TabIndex = 21;
            this.gbAppropriateEmployees.TabStop = false;
            this.gbAppropriateEmployees.Text = "Все сотрудники";
            // 
            // dgvAppropriateEmployees
            // 
            this.dgvAppropriateEmployees.AllowUserToAddRows = false;
            this.dgvAppropriateEmployees.AllowUserToDeleteRows = false;
            this.dgvAppropriateEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppropriateEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppropriateEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6});
            this.dgvAppropriateEmployees.Location = new System.Drawing.Point(13, 28);
            this.dgvAppropriateEmployees.Margin = new System.Windows.Forms.Padding(5);
            this.dgvAppropriateEmployees.MultiSelect = false;
            this.dgvAppropriateEmployees.Name = "dgvAppropriateEmployees";
            this.dgvAppropriateEmployees.ReadOnly = true;
            this.dgvAppropriateEmployees.Size = new System.Drawing.Size(796, 137);
            this.dgvAppropriateEmployees.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.FillWeight = 20F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 93.27411F;
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 93.27411F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // btnAddEmployeeToProject
            // 
            this.btnAddEmployeeToProject.Location = new System.Drawing.Point(247, 174);
            this.btnAddEmployeeToProject.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEmployeeToProject.Name = "btnAddEmployeeToProject";
            this.btnAddEmployeeToProject.Size = new System.Drawing.Size(356, 30);
            this.btnAddEmployeeToProject.TabIndex = 1;
            this.btnAddEmployeeToProject.Text = "Добавить сотрудника в команду";
            this.btnAddEmployeeToProject.UseVisualStyleBackColor = true;
            this.btnAddEmployeeToProject.Click += new System.EventHandler(this.BtnAddEmployeeToProject_Click);
            // 
            // dgvTeamEmployees
            // 
            this.dgvTeamEmployees.AllowUserToAddRows = false;
            this.dgvTeamEmployees.AllowUserToDeleteRows = false;
            this.dgvTeamEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeamEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N,
            this.FullName,
            this.Position});
            this.dgvTeamEmployees.Location = new System.Drawing.Point(13, 25);
            this.dgvTeamEmployees.Margin = new System.Windows.Forms.Padding(5);
            this.dgvTeamEmployees.MultiSelect = false;
            this.dgvTeamEmployees.Name = "dgvTeamEmployees";
            this.dgvTeamEmployees.ReadOnly = true;
            this.dgvTeamEmployees.Size = new System.Drawing.Size(796, 159);
            this.dgvTeamEmployees.TabIndex = 16;
            // 
            // N
            // 
            this.N.FillWeight = 20F;
            this.N.HeaderText = "N";
            this.N.Name = "N";
            this.N.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "ФИО";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Position
            // 
            this.Position.HeaderText = "Должность";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // btnRemoveEmployeeFromProject
            // 
            this.btnRemoveEmployeeFromProject.Location = new System.Drawing.Point(247, 193);
            this.btnRemoveEmployeeFromProject.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveEmployeeFromProject.Name = "btnRemoveEmployeeFromProject";
            this.btnRemoveEmployeeFromProject.Size = new System.Drawing.Size(356, 30);
            this.btnRemoveEmployeeFromProject.TabIndex = 15;
            this.btnRemoveEmployeeFromProject.Text = "Удалить сотрудника из команды";
            this.btnRemoveEmployeeFromProject.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(723, 460);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 23);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(642, 460);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 23;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // gbTeam
            // 
            this.gbTeam.Controls.Add(this.dgvTeamEmployees);
            this.gbTeam.Controls.Add(this.btnRemoveEmployeeFromProject);
            this.gbTeam.Location = new System.Drawing.Point(2, 222);
            this.gbTeam.Margin = new System.Windows.Forms.Padding(4);
            this.gbTeam.Name = "gbTeam";
            this.gbTeam.Padding = new System.Windows.Forms.Padding(4);
            this.gbTeam.Size = new System.Drawing.Size(819, 231);
            this.gbTeam.TabIndex = 22;
            this.gbTeam.TabStop = false;
            this.gbTeam.Text = "Состав команды";
            // 
            // TeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 486);
            this.Controls.Add(this.gbAppropriateEmployees);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbTeam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TeamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Команда проекта";
            this.gbAppropriateEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppropriateEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamEmployees)).EndInit();
            this.gbTeam.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAppropriateEmployees;
        private System.Windows.Forms.DataGridView dgvAppropriateEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btnAddEmployeeToProject;
        private System.Windows.Forms.DataGridView dgvTeamEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.Button btnRemoveEmployeeFromProject;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox gbTeam;
    }
}