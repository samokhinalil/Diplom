namespace Diplom
{
    partial class AdminMenuForm
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
            this.laAccess = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ctlFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlChangeUser = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlGrantAccessRights = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlCheckConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlTaskSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlShowPositions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctlExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnBackups = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // laAccess
            // 
            this.laAccess.AutoSize = true;
            this.laAccess.Location = new System.Drawing.Point(3, 155);
            this.laAccess.Name = "laAccess";
            this.laAccess.Size = new System.Drawing.Size(222, 18);
            this.laAccess.TabIndex = 9;
            this.laAccess.Text = "Вы вошли как: Администратор";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlFile});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(513, 24);
            this.menuStrip.TabIndex = 12;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ctlFile
            // 
            this.ctlFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlChangeUser,
            this.ctlGrantAccessRights,
            this.ctlCheckConnection,
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
            // ctlGrantAccessRights
            // 
            this.ctlGrantAccessRights.Name = "ctlGrantAccessRights";
            this.ctlGrantAccessRights.Size = new System.Drawing.Size(228, 22);
            this.ctlGrantAccessRights.Text = "Выдать права доступа";
            this.ctlGrantAccessRights.Click += new System.EventHandler(this.CtlGrantAccessRights_Click);
            // 
            // ctlCheckConnection
            // 
            this.ctlCheckConnection.Name = "ctlCheckConnection";
            this.ctlCheckConnection.Size = new System.Drawing.Size(228, 22);
            this.ctlCheckConnection.Text = "Настроить соединение с БД";
            this.ctlCheckConnection.Click += new System.EventHandler(this.CtlCheckConnection_Click);
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
            // btnEmployees
            // 
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployees.Location = new System.Drawing.Point(0, 24);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(513, 55);
            this.btnEmployees.TabIndex = 15;
            this.btnEmployees.Text = "Сотрудники";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.BtnEmployees_Click);
            // 
            // btnBackups
            // 
            this.btnBackups.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBackups.Location = new System.Drawing.Point(0, 79);
            this.btnBackups.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBackups.Name = "btnBackups";
            this.btnBackups.Size = new System.Drawing.Size(513, 55);
            this.btnBackups.TabIndex = 16;
            this.btnBackups.Text = "Резервное копирование";
            this.btnBackups.UseVisualStyleBackColor = true;
            this.btnBackups.Click += new System.EventHandler(this.BtnBackups_Click);
            // 
            // AdminMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 179);
            this.Controls.Add(this.btnBackups);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.laAccess);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню администратора";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminMenuForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminMenuForm_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laAccess;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ctlFile;
        private System.Windows.Forms.ToolStripMenuItem ctlChangeUser;
        private System.Windows.Forms.ToolStripMenuItem ctlGrantAccessRights;
        private System.Windows.Forms.ToolStripMenuItem ctlCheckConnection;
        private System.Windows.Forms.ToolStripMenuItem ctlTaskSettings;
        private System.Windows.Forms.ToolStripMenuItem ctlShowPositions;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ctlExit;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnBackups;
    }
}