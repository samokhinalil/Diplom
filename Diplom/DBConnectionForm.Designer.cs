namespace Diplom
{
    partial class DBConnectionForm
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
            this.laConnectionString = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDataSource = new System.Windows.Forms.TextBox();
            this.tbInitialCatalog = new System.Windows.Forms.TextBox();
            this.tbConnectTimeout = new System.Windows.Forms.TextBox();
            this.cbIntegratedSecurity = new System.Windows.Forms.ComboBox();
            this.cbEncrypt = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCheckConnection = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // laConnectionString
            // 
            this.laConnectionString.AutoSize = true;
            this.laConnectionString.Location = new System.Drawing.Point(12, 9);
            this.laConnectionString.Name = "laConnectionString";
            this.laConnectionString.Size = new System.Drawing.Size(165, 18);
            this.laConnectionString.TabIndex = 0;
            this.laConnectionString.Text = "Строка  подключения:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Source:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Initial Catalog:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Integrated Security:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Connect Timeout:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Encrypt:";
            // 
            // tbDataSource
            // 
            this.tbDataSource.Location = new System.Drawing.Point(205, 41);
            this.tbDataSource.Name = "tbDataSource";
            this.tbDataSource.Size = new System.Drawing.Size(210, 24);
            this.tbDataSource.TabIndex = 6;
            // 
            // tbInitialCatalog
            // 
            this.tbInitialCatalog.Location = new System.Drawing.Point(205, 81);
            this.tbInitialCatalog.Name = "tbInitialCatalog";
            this.tbInitialCatalog.Size = new System.Drawing.Size(210, 24);
            this.tbInitialCatalog.TabIndex = 7;
            // 
            // tbConnectTimeout
            // 
            this.tbConnectTimeout.Location = new System.Drawing.Point(205, 161);
            this.tbConnectTimeout.Name = "tbConnectTimeout";
            this.tbConnectTimeout.Size = new System.Drawing.Size(209, 24);
            this.tbConnectTimeout.TabIndex = 8;
            // 
            // cbIntegratedSecurity
            // 
            this.cbIntegratedSecurity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIntegratedSecurity.FormattingEnabled = true;
            this.cbIntegratedSecurity.Items.AddRange(new object[] {
            "Integrated Security = True",
            "Integrated Security = False"});
            this.cbIntegratedSecurity.Location = new System.Drawing.Point(205, 120);
            this.cbIntegratedSecurity.Name = "cbIntegratedSecurity";
            this.cbIntegratedSecurity.Size = new System.Drawing.Size(210, 26);
            this.cbIntegratedSecurity.TabIndex = 9;
            // 
            // cbEncrypt
            // 
            this.cbEncrypt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEncrypt.FormattingEnabled = true;
            this.cbEncrypt.Items.AddRange(new object[] {
            "Encrypt = False",
            "Encrypt = True"});
            this.cbEncrypt.Location = new System.Drawing.Point(205, 201);
            this.cbEncrypt.Name = "cbEncrypt";
            this.cbEncrypt.Size = new System.Drawing.Size(209, 26);
            this.cbEncrypt.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "с";
            // 
            // btnCheckConnection
            // 
            this.btnCheckConnection.Location = new System.Drawing.Point(205, 254);
            this.btnCheckConnection.Name = "btnCheckConnection";
            this.btnCheckConnection.Size = new System.Drawing.Size(210, 25);
            this.btnCheckConnection.TabIndex = 12;
            this.btnCheckConnection.Text = "Проверить соединение";
            this.btnCheckConnection.UseVisualStyleBackColor = true;
            this.btnCheckConnection.Click += new System.EventHandler(this.BtnCheckConnection_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(205, 315);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 25);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(324, 315);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 25);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // DBConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 347);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCheckConnection);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbEncrypt);
            this.Controls.Add(this.cbIntegratedSecurity);
            this.Controls.Add(this.tbConnectTimeout);
            this.Controls.Add(this.tbInitialCatalog);
            this.Controls.Add(this.tbDataSource);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.laConnectionString);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DBConnectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка соединения с базой данных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laConnectionString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDataSource;
        private System.Windows.Forms.TextBox tbInitialCatalog;
        private System.Windows.Forms.TextBox tbConnectTimeout;
        private System.Windows.Forms.ComboBox cbIntegratedSecurity;
        private System.Windows.Forms.ComboBox cbEncrypt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCheckConnection;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}