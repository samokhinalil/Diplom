namespace Diplom
{
    partial class EmployeeMenuForm
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
            this.btnOpenTasks = new System.Windows.Forms.Button();
            this.btnDoneTasks = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ctlFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlChangeUser = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlEditEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctlExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGetIssuesStates = new System.Windows.Forms.Button();
            this.btnGenerateReports = new System.Windows.Forms.Button();
            this.btnMyTeam = new System.Windows.Forms.Button();
            this.laAccess = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenTasks
            // 
            this.btnOpenTasks.Location = new System.Drawing.Point(0, 29);
            this.btnOpenTasks.Name = "btnOpenTasks";
            this.btnOpenTasks.Size = new System.Drawing.Size(300, 44);
            this.btnOpenTasks.TabIndex = 0;
            this.btnOpenTasks.Text = "Открытые задачи";
            this.btnOpenTasks.UseVisualStyleBackColor = true;
            this.btnOpenTasks.Click += new System.EventHandler(this.BtnOpenTasks_Click);
            // 
            // btnDoneTasks
            // 
            this.btnDoneTasks.Location = new System.Drawing.Point(0, 79);
            this.btnDoneTasks.Name = "btnDoneTasks";
            this.btnDoneTasks.Size = new System.Drawing.Size(300, 48);
            this.btnDoneTasks.TabIndex = 1;
            this.btnDoneTasks.Text = "Выполненные задачи";
            this.btnDoneTasks.UseVisualStyleBackColor = true;
            this.btnDoneTasks.Click += new System.EventHandler(this.BtnDoneTasks_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(300, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ctlFile
            // 
            this.ctlFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlChangeUser,
            this.ctlEditEmployee,
            this.ctlChangePassword,
            this.toolStripMenuItem1,
            this.ctlExit});
            this.ctlFile.Name = "ctlFile";
            this.ctlFile.Size = new System.Drawing.Size(48, 20);
            this.ctlFile.Text = "Файл";
            // 
            // ctlChangeUser
            // 
            this.ctlChangeUser.Name = "ctlChangeUser";
            this.ctlChangeUser.Size = new System.Drawing.Size(271, 22);
            this.ctlChangeUser.Text = "Сменить пользователя";
            this.ctlChangeUser.Click += new System.EventHandler(this.CtlChangeUser_Click);
            // 
            // ctlEditEmployee
            // 
            this.ctlEditEmployee.Name = "ctlEditEmployee";
            this.ctlEditEmployee.Size = new System.Drawing.Size(271, 22);
            this.ctlEditEmployee.Text = "Редактировать информацию о себе";
            this.ctlEditEmployee.Click += new System.EventHandler(this.CtlEditEmployee_Click);
            // 
            // ctlChangePassword
            // 
            this.ctlChangePassword.Name = "ctlChangePassword";
            this.ctlChangePassword.Size = new System.Drawing.Size(271, 22);
            this.ctlChangePassword.Text = "Изменить пароль";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(268, 6);
            // 
            // ctlExit
            // 
            this.ctlExit.Name = "ctlExit";
            this.ctlExit.Size = new System.Drawing.Size(271, 22);
            this.ctlExit.Text = "Выйти";
            this.ctlExit.Click += new System.EventHandler(this.CtlExit_Click);
            // 
            // btnGetIssuesStates
            // 
            this.btnGetIssuesStates.Location = new System.Drawing.Point(0, 133);
            this.btnGetIssuesStates.Name = "btnGetIssuesStates";
            this.btnGetIssuesStates.Size = new System.Drawing.Size(300, 44);
            this.btnGetIssuesStates.TabIndex = 3;
            this.btnGetIssuesStates.Text = "История выполнения задач";
            this.btnGetIssuesStates.UseVisualStyleBackColor = true;
            this.btnGetIssuesStates.Click += new System.EventHandler(this.BtnGetIssuesStates_Click);
            // 
            // btnGenerateReports
            // 
            this.btnGenerateReports.Location = new System.Drawing.Point(0, 183);
            this.btnGenerateReports.Name = "btnGenerateReports";
            this.btnGenerateReports.Size = new System.Drawing.Size(300, 44);
            this.btnGenerateReports.TabIndex = 4;
            this.btnGenerateReports.Text = "Формирование отчетов";
            this.btnGenerateReports.UseVisualStyleBackColor = true;
            // 
            // btnMyTeam
            // 
            this.btnMyTeam.Location = new System.Drawing.Point(0, 233);
            this.btnMyTeam.Name = "btnMyTeam";
            this.btnMyTeam.Size = new System.Drawing.Size(300, 42);
            this.btnMyTeam.TabIndex = 5;
            this.btnMyTeam.Text = "Моя команда";
            this.btnMyTeam.UseVisualStyleBackColor = true;
            this.btnMyTeam.Click += new System.EventHandler(this.BtnMyTeam_Click);
            // 
            // laAccess
            // 
            this.laAccess.AutoSize = true;
            this.laAccess.Location = new System.Drawing.Point(12, 280);
            this.laAccess.Name = "laAccess";
            this.laAccess.Size = new System.Drawing.Size(56, 18);
            this.laAccess.TabIndex = 9;
            this.laAccess.Text = "access";
            // 
            // EmployeeMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 307);
            this.Controls.Add(this.laAccess);
            this.Controls.Add(this.btnMyTeam);
            this.Controls.Add(this.btnGenerateReports);
            this.Controls.Add(this.btnGetIssuesStates);
            this.Controls.Add(this.btnDoneTasks);
            this.Controls.Add(this.btnOpenTasks);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeMenuForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeMenuForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenTasks;
        private System.Windows.Forms.Button btnDoneTasks;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctlFile;
        private System.Windows.Forms.ToolStripMenuItem ctlChangeUser;
        private System.Windows.Forms.ToolStripMenuItem ctlEditEmployee;
        private System.Windows.Forms.ToolStripMenuItem ctlChangePassword;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ctlExit;
        private System.Windows.Forms.Button btnGetIssuesStates;
        private System.Windows.Forms.Button btnGenerateReports;
        private System.Windows.Forms.Button btnMyTeam;
        private System.Windows.Forms.Label laAccess;
    }
}