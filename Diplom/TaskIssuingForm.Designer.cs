namespace Diplom
{
    partial class TaskIssuingForm
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
            this.laEmployee = new System.Windows.Forms.Label();
            this.laProject = new System.Windows.Forms.Label();
            this.btnSelectEmployee = new System.Windows.Forms.Button();
            this.laTask = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.laDate = new System.Windows.Forms.Label();
            this.btnCalculateDate = new System.Windows.Forms.Button();
            this.cbTask = new System.Windows.Forms.ComboBox();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbPriority = new System.Windows.Forms.TextBox();
            this.tbComplexity = new System.Windows.Forms.TextBox();
            this.ctlEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblCalculateMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbProject
            // 
            this.cbProject.FormattingEnabled = true;
            this.cbProject.Location = new System.Drawing.Point(156, 13);
            this.cbProject.Margin = new System.Windows.Forms.Padding(4);
            this.cbProject.Name = "cbProject";
            this.cbProject.Size = new System.Drawing.Size(221, 26);
            this.cbProject.TabIndex = 7;
            this.cbProject.SelectedValueChanged += new System.EventHandler(this.CbProject_SelectedValueChanged);
            // 
            // laEmployee
            // 
            this.laEmployee.AutoSize = true;
            this.laEmployee.Location = new System.Drawing.Point(59, 165);
            this.laEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laEmployee.Name = "laEmployee";
            this.laEmployee.Size = new System.Drawing.Size(87, 18);
            this.laEmployee.TabIndex = 6;
            this.laEmployee.Text = "Сотрудник:";
            // 
            // laProject
            // 
            this.laProject.AutoSize = true;
            this.laProject.Location = new System.Drawing.Point(87, 13);
            this.laProject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laProject.Name = "laProject";
            this.laProject.Size = new System.Drawing.Size(63, 18);
            this.laProject.TabIndex = 5;
            this.laProject.Text = "Проект:";
            // 
            // btnSelectEmployee
            // 
            this.btnSelectEmployee.Location = new System.Drawing.Point(156, 198);
            this.btnSelectEmployee.Name = "btnSelectEmployee";
            this.btnSelectEmployee.Size = new System.Drawing.Size(221, 26);
            this.btnSelectEmployee.TabIndex = 9;
            this.btnSelectEmployee.Text = "Подобрать сотрудников";
            this.btnSelectEmployee.UseVisualStyleBackColor = true;
            this.btnSelectEmployee.Click += new System.EventHandler(this.BtnSelectEmployee_Click);
            // 
            // laTask
            // 
            this.laTask.AutoSize = true;
            this.laTask.Location = new System.Drawing.Point(87, 60);
            this.laTask.Name = "laTask";
            this.laTask.Size = new System.Drawing.Size(63, 18);
            this.laTask.TabIndex = 10;
            this.laTask.Text = "Задача:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Приоритет:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Уровень сложности:";
            // 
            // laDate
            // 
            this.laDate.AutoSize = true;
            this.laDate.Location = new System.Drawing.Point(19, 243);
            this.laDate.Name = "laDate";
            this.laDate.Size = new System.Drawing.Size(131, 36);
            this.laDate.TabIndex = 14;
            this.laDate.Text = "Предполагаемая\r\nдата завершения:";
            // 
            // btnCalculateDate
            // 
            this.btnCalculateDate.Location = new System.Drawing.Point(156, 285);
            this.btnCalculateDate.Name = "btnCalculateDate";
            this.btnCalculateDate.Size = new System.Drawing.Size(221, 25);
            this.btnCalculateDate.TabIndex = 15;
            this.btnCalculateDate.Text = "Рассчитать";
            this.btnCalculateDate.UseVisualStyleBackColor = true;
            this.btnCalculateDate.Click += new System.EventHandler(this.BtnCalculateDate_Click);
            // 
            // cbTask
            // 
            this.cbTask.FormattingEnabled = true;
            this.cbTask.Location = new System.Drawing.Point(156, 60);
            this.cbTask.Margin = new System.Windows.Forms.Padding(4);
            this.cbTask.Name = "cbTask";
            this.cbTask.Size = new System.Drawing.Size(221, 26);
            this.cbTask.TabIndex = 16;
            this.cbTask.SelectedValueChanged += new System.EventHandler(this.CbTask_SelectedValueChanged);
            // 
            // cbEmployee
            // 
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(156, 165);
            this.cbEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(221, 26);
            this.cbEmployee.TabIndex = 19;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(279, 375);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(199, 375);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(74, 23);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // tbPriority
            // 
            this.tbPriority.Location = new System.Drawing.Point(156, 95);
            this.tbPriority.Name = "tbPriority";
            this.tbPriority.Size = new System.Drawing.Size(221, 24);
            this.tbPriority.TabIndex = 22;
            // 
            // tbComplexity
            // 
            this.tbComplexity.Location = new System.Drawing.Point(156, 129);
            this.tbComplexity.Name = "tbComplexity";
            this.tbComplexity.Size = new System.Drawing.Size(221, 24);
            this.tbComplexity.TabIndex = 23;
            // 
            // ctlEndDate
            // 
            this.ctlEndDate.Location = new System.Drawing.Point(156, 255);
            this.ctlEndDate.Name = "ctlEndDate";
            this.ctlEndDate.Size = new System.Drawing.Size(221, 24);
            this.ctlEndDate.TabIndex = 24;
            // 
            // lblCalculateMessage
            // 
            this.lblCalculateMessage.AutoSize = true;
            this.lblCalculateMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCalculateMessage.ForeColor = System.Drawing.Color.Green;
            this.lblCalculateMessage.Location = new System.Drawing.Point(168, 313);
            this.lblCalculateMessage.Name = "lblCalculateMessage";
            this.lblCalculateMessage.Size = new System.Drawing.Size(209, 30);
            this.lblCalculateMessage.TabIndex = 25;
            this.lblCalculateMessage.Text = "Завершен автоматический расчет\r\nдаты выполнения";
            this.lblCalculateMessage.Visible = false;
            // 
            // TaskIssuingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 410);
            this.Controls.Add(this.lblCalculateMessage);
            this.Controls.Add(this.ctlEndDate);
            this.Controls.Add(this.tbComplexity);
            this.Controls.Add(this.tbPriority);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbEmployee);
            this.Controls.Add(this.cbTask);
            this.Controls.Add(this.btnCalculateDate);
            this.Controls.Add(this.laDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.laTask);
            this.Controls.Add(this.btnSelectEmployee);
            this.Controls.Add(this.cbProject);
            this.Controls.Add(this.laEmployee);
            this.Controls.Add(this.laProject);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaskIssuingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выдать задачу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProject;
        private System.Windows.Forms.Label laEmployee;
        private System.Windows.Forms.Label laProject;
        private System.Windows.Forms.Button btnSelectEmployee;
        private System.Windows.Forms.Label laTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label laDate;
        private System.Windows.Forms.Button btnCalculateDate;
        private System.Windows.Forms.ComboBox cbTask;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox tbPriority;
        private System.Windows.Forms.TextBox tbComplexity;
        private System.Windows.Forms.DateTimePicker ctlEndDate;
        private System.Windows.Forms.Label lblCalculateMessage;
    }
}