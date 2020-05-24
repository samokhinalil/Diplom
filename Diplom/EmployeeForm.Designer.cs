namespace Diplom
{
    partial class EmployeeForm
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
            this.tbEmployeePassport = new System.Windows.Forms.MaskedTextBox();
            this.tbEmployeePhone = new System.Windows.Forms.MaskedTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbEmployeePosition = new System.Windows.Forms.ComboBox();
            this.tbEmployeeEmail = new System.Windows.Forms.TextBox();
            this.tbEmployeeName = new System.Windows.Forms.TextBox();
            this.lblEmployeePosition = new System.Windows.Forms.Label();
            this.lblEmployeeEmail = new System.Windows.Forms.Label();
            this.lblEmployeePhone = new System.Windows.Forms.Label();
            this.lblEmployeePassport = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.laProject = new System.Windows.Forms.Label();
            this.cbProjects = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbEmployeePassport
            // 
            this.tbEmployeePassport.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tbEmployeePassport.Location = new System.Drawing.Point(112, 51);
            this.tbEmployeePassport.Mask = "0000 000000";
            this.tbEmployeePassport.Name = "tbEmployeePassport";
            this.tbEmployeePassport.Size = new System.Drawing.Size(192, 24);
            this.tbEmployeePassport.TabIndex = 33;
            this.tbEmployeePassport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbEmployeePassport.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tbEmployeePassport.Validating += new System.ComponentModel.CancelEventHandler(this.TbEmployeePassport_Validating);
            this.tbEmployeePassport.Validated += new System.EventHandler(this.TbEmployeePassport_Validated);
            // 
            // tbEmployeePhone
            // 
            this.tbEmployeePhone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tbEmployeePhone.Location = new System.Drawing.Point(112, 90);
            this.tbEmployeePhone.Mask = "0 (000) 000 00 00";
            this.tbEmployeePhone.Name = "tbEmployeePhone";
            this.tbEmployeePhone.Size = new System.Drawing.Size(192, 24);
            this.tbEmployeePhone.TabIndex = 32;
            this.tbEmployeePhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbEmployeePhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tbEmployeePhone.Validating += new System.ComponentModel.CancelEventHandler(this.TbEmployeePhone_Validating);
            this.tbEmployeePhone.Validated += new System.EventHandler(this.TbEmployeePhone_Validated);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(337, 257);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 23);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(257, 257);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 29;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // cbEmployeePosition
            // 
            this.cbEmployeePosition.FormattingEnabled = true;
            this.cbEmployeePosition.Location = new System.Drawing.Point(112, 169);
            this.cbEmployeePosition.Name = "cbEmployeePosition";
            this.cbEmployeePosition.Size = new System.Drawing.Size(298, 26);
            this.cbEmployeePosition.TabIndex = 28;
            // 
            // tbEmployeeEmail
            // 
            this.tbEmployeeEmail.Location = new System.Drawing.Point(112, 130);
            this.tbEmployeeEmail.MaxLength = 50;
            this.tbEmployeeEmail.Name = "tbEmployeeEmail";
            this.tbEmployeeEmail.Size = new System.Drawing.Size(298, 24);
            this.tbEmployeeEmail.TabIndex = 27;
            this.tbEmployeeEmail.Validating += new System.ComponentModel.CancelEventHandler(this.TbEmployeeEmail_Validating);
            this.tbEmployeeEmail.Validated += new System.EventHandler(this.TbEmployeeEmail_Validated);
            // 
            // tbEmployeeName
            // 
            this.tbEmployeeName.Location = new System.Drawing.Point(112, 12);
            this.tbEmployeeName.MaxLength = 50;
            this.tbEmployeeName.Name = "tbEmployeeName";
            this.tbEmployeeName.Size = new System.Drawing.Size(298, 24);
            this.tbEmployeeName.TabIndex = 26;
            this.tbEmployeeName.Validating += new System.ComponentModel.CancelEventHandler(this.TbEmployeeName_Validating);
            this.tbEmployeeName.Validated += new System.EventHandler(this.TbEmployeeName_Validated);
            // 
            // lblEmployeePosition
            // 
            this.lblEmployeePosition.AutoSize = true;
            this.lblEmployeePosition.Location = new System.Drawing.Point(15, 169);
            this.lblEmployeePosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeePosition.Name = "lblEmployeePosition";
            this.lblEmployeePosition.Size = new System.Drawing.Size(93, 18);
            this.lblEmployeePosition.TabIndex = 25;
            this.lblEmployeePosition.Text = "Должность:";
            // 
            // lblEmployeeEmail
            // 
            this.lblEmployeeEmail.AutoSize = true;
            this.lblEmployeeEmail.Location = new System.Drawing.Point(59, 130);
            this.lblEmployeeEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeEmail.Name = "lblEmployeeEmail";
            this.lblEmployeeEmail.Size = new System.Drawing.Size(49, 18);
            this.lblEmployeeEmail.TabIndex = 24;
            this.lblEmployeeEmail.Text = "Email:";
            // 
            // lblEmployeePhone
            // 
            this.lblEmployeePhone.AutoSize = true;
            this.lblEmployeePhone.Location = new System.Drawing.Point(32, 90);
            this.lblEmployeePhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeePhone.Name = "lblEmployeePhone";
            this.lblEmployeePhone.Size = new System.Drawing.Size(76, 18);
            this.lblEmployeePhone.TabIndex = 23;
            this.lblEmployeePhone.Text = "Телефон:";
            // 
            // lblEmployeePassport
            // 
            this.lblEmployeePassport.AutoSize = true;
            this.lblEmployeePassport.Location = new System.Drawing.Point(37, 51);
            this.lblEmployeePassport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeePassport.Name = "lblEmployeePassport";
            this.lblEmployeePassport.Size = new System.Drawing.Size(71, 18);
            this.lblEmployeePassport.TabIndex = 22;
            this.lblEmployeePassport.Text = "Паспорт:";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(59, 12);
            this.lblEmployeeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(48, 18);
            this.lblEmployeeName.TabIndex = 21;
            this.lblEmployeeName.Text = "ФИО:";
            // 
            // laProject
            // 
            this.laProject.AutoSize = true;
            this.laProject.Location = new System.Drawing.Point(45, 213);
            this.laProject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laProject.Name = "laProject";
            this.laProject.Size = new System.Drawing.Size(63, 18);
            this.laProject.TabIndex = 35;
            this.laProject.Text = "Проект:";
            // 
            // cbProjects
            // 
            this.cbProjects.FormattingEnabled = true;
            this.cbProjects.Location = new System.Drawing.Point(112, 213);
            this.cbProjects.Name = "cbProjects";
            this.cbProjects.Size = new System.Drawing.Size(298, 26);
            this.cbProjects.TabIndex = 36;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 283);
            this.Controls.Add(this.cbProjects);
            this.Controls.Add(this.laProject);
            this.Controls.Add(this.tbEmployeePassport);
            this.Controls.Add(this.tbEmployeePhone);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbEmployeePosition);
            this.Controls.Add(this.tbEmployeeEmail);
            this.Controls.Add(this.tbEmployeeName);
            this.Controls.Add(this.lblEmployeePosition);
            this.Controls.Add(this.lblEmployeeEmail);
            this.Controls.Add(this.lblEmployeePhone);
            this.Controls.Add(this.lblEmployeePassport);
            this.Controls.Add(this.lblEmployeeName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить сотрудника";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox tbEmployeePassport;
        private System.Windows.Forms.MaskedTextBox tbEmployeePhone;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cbEmployeePosition;
        private System.Windows.Forms.TextBox tbEmployeeEmail;
        private System.Windows.Forms.TextBox tbEmployeeName;
        private System.Windows.Forms.Label lblEmployeePosition;
        private System.Windows.Forms.Label lblEmployeeEmail;
        private System.Windows.Forms.Label lblEmployeePhone;
        private System.Windows.Forms.Label lblEmployeePassport;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label laProject;
        private System.Windows.Forms.ComboBox cbProjects;
    }
}