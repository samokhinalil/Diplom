namespace Diplom
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTasks = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnProjects = new System.Windows.Forms.Button();
            this.btnTaskIssuing = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ctlFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlChangeUser = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlTaskSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlShowPositions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctlExit = new System.Windows.Forms.ToolStripMenuItem();
            this.laAccess = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTasks
            // 
            this.btnTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTasks.Location = new System.Drawing.Point(0, 24);
            this.btnTasks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(501, 55);
            this.btnTasks.TabIndex = 0;
            this.btnTasks.Text = "Задачи";
            this.btnTasks.UseVisualStyleBackColor = true;
            this.btnTasks.Click += new System.EventHandler(this.BtnTasks_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployees.Location = new System.Drawing.Point(0, 79);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(501, 55);
            this.btnEmployees.TabIndex = 1;
            this.btnEmployees.Text = "Сотрудники";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.BtnEmployees_Click);
            // 
            // btnProjects
            // 
            this.btnProjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProjects.Location = new System.Drawing.Point(0, 134);
            this.btnProjects.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Size = new System.Drawing.Size(501, 55);
            this.btnProjects.TabIndex = 2;
            this.btnProjects.Text = "Проекты";
            this.btnProjects.UseVisualStyleBackColor = true;
            this.btnProjects.Click += new System.EventHandler(this.BtnProjects_Click);
            // 
            // btnTaskIssuing
            // 
            this.btnTaskIssuing.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaskIssuing.Location = new System.Drawing.Point(0, 189);
            this.btnTaskIssuing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaskIssuing.Name = "btnTaskIssuing";
            this.btnTaskIssuing.Size = new System.Drawing.Size(501, 55);
            this.btnTaskIssuing.TabIndex = 3;
            this.btnTaskIssuing.Text = "Распределение задач";
            this.btnTaskIssuing.UseVisualStyleBackColor = true;
            this.btnTaskIssuing.Click += new System.EventHandler(this.BtnTaskIssuing_Click);
            // 
            // btnReports
            // 
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.Location = new System.Drawing.Point(0, 244);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(501, 55);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "Формирование отчетов";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.BtnReports_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlFile});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(501, 24);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ctlFile
            // 
            this.ctlFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlChangeUser,
            this.ctlTaskSettings,
            this.ctlShowPositions,
            this.toolStripMenuItem1,
            this.ctlExit});
            this.ctlFile.Name = "ctlFile";
            this.ctlFile.Size = new System.Drawing.Size(48, 20);
            this.ctlFile.Text = "Файл";
            // 
            // ctlChangeUser
            // 
            this.ctlChangeUser.Name = "ctlChangeUser";
            this.ctlChangeUser.Size = new System.Drawing.Size(228, 22);
            this.ctlChangeUser.Text = "Сменить пользователя";
            this.ctlChangeUser.Click += new System.EventHandler(this.CtlChangeUser_Click);
            // 
            // ctlTaskSettings
            // 
            this.ctlTaskSettings.Name = "ctlTaskSettings";
            this.ctlTaskSettings.Size = new System.Drawing.Size(228, 22);
            this.ctlTaskSettings.Text = "Конфигурация приложения";
            this.ctlTaskSettings.Click += new System.EventHandler(this.CtlTaskSettings_Click);
            // 
            // ctlShowPositions
            // 
            this.ctlShowPositions.Name = "ctlShowPositions";
            this.ctlShowPositions.Size = new System.Drawing.Size(228, 22);
            this.ctlShowPositions.Text = "Просмотр должностей";
            this.ctlShowPositions.Click += new System.EventHandler(this.CtlShowPositions_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(225, 6);
            // 
            // ctlExit
            // 
            this.ctlExit.Name = "ctlExit";
            this.ctlExit.Size = new System.Drawing.Size(228, 22);
            this.ctlExit.Text = "Выйти";
            this.ctlExit.Click += new System.EventHandler(this.CtlExit_Click);
            // 
            // laAccess
            // 
            this.laAccess.AutoSize = true;
            this.laAccess.Location = new System.Drawing.Point(12, 308);
            this.laAccess.Name = "laAccess";
            this.laAccess.Size = new System.Drawing.Size(59, 20);
            this.laAccess.TabIndex = 8;
            this.laAccess.Text = "access";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 337);
            this.Controls.Add(this.laAccess);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnTaskIssuing);
            this.Controls.Add(this.btnProjects);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnTasks);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnProjects;
        private System.Windows.Forms.Button btnTaskIssuing;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ctlFile;
        private System.Windows.Forms.ToolStripMenuItem ctlChangeUser;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ctlExit;
        private System.Windows.Forms.ToolStripMenuItem ctlTaskSettings;
        private System.Windows.Forms.ToolStripMenuItem ctlShowPositions;
        private System.Windows.Forms.Label laAccess;
    }
}

