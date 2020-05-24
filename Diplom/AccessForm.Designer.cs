namespace Diplom
{
    partial class AccessForm
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
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.laEmployee = new System.Windows.Forms.Label();
            this.laLogin = new System.Windows.Forms.Label();
            this.laPassword = new System.Windows.Forms.Label();
            this.laRole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbEmployee
            // 
            this.cbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(131, 12);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(294, 26);
            this.cbEmployee.TabIndex = 0;
            this.cbEmployee.SelectedValueChanged += new System.EventHandler(this.CbEmployee_SelectedValueChanged);
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(131, 109);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(202, 26);
            this.cbRole.TabIndex = 1;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(131, 46);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(294, 24);
            this.tbLogin.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(131, 79);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(202, 24);
            this.tbPassword.TabIndex = 3;
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.Location = new System.Drawing.Point(339, 79);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(86, 24);
            this.btnShowPassword.TabIndex = 4;
            this.btnShowPassword.Text = "Показать";
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.BtnShowPassword_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(293, 154);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(374, 154);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // laEmployee
            // 
            this.laEmployee.AutoSize = true;
            this.laEmployee.Location = new System.Drawing.Point(11, 12);
            this.laEmployee.Name = "laEmployee";
            this.laEmployee.Size = new System.Drawing.Size(114, 18);
            this.laEmployee.TabIndex = 7;
            this.laEmployee.Text = "Пользователь:";
            // 
            // laLogin
            // 
            this.laLogin.AutoSize = true;
            this.laLogin.Location = new System.Drawing.Point(71, 49);
            this.laLogin.Name = "laLogin";
            this.laLogin.Size = new System.Drawing.Size(54, 18);
            this.laLogin.TabIndex = 8;
            this.laLogin.Text = "Логин:";
            // 
            // laPassword
            // 
            this.laPassword.AutoSize = true;
            this.laPassword.Location = new System.Drawing.Point(60, 79);
            this.laPassword.Name = "laPassword";
            this.laPassword.Size = new System.Drawing.Size(65, 18);
            this.laPassword.TabIndex = 9;
            this.laPassword.Text = "Пароль:";
            // 
            // laRole
            // 
            this.laRole.AutoSize = true;
            this.laRole.Location = new System.Drawing.Point(77, 109);
            this.laRole.Name = "laRole";
            this.laRole.Size = new System.Drawing.Size(48, 18);
            this.laRole.TabIndex = 10;
            this.laRole.Text = "Роль:";
            // 
            // AccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 180);
            this.Controls.Add(this.laRole);
            this.Controls.Add(this.laPassword);
            this.Controls.Add(this.laLogin);
            this.Controls.Add(this.laEmployee);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.cbEmployee);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AccessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выдать права доступа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label laEmployee;
        private System.Windows.Forms.Label laLogin;
        private System.Windows.Forms.Label laPassword;
        private System.Windows.Forms.Label laRole;
    }
}