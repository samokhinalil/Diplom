namespace Diplom
{
    partial class BackUpForm
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
            this.btnCreateBackUp = new System.Windows.Forms.Button();
            this.btnRestoreDB = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChooseBackUpDirectory = new System.Windows.Forms.Button();
            this.btnChooseRestoreFile = new System.Windows.Forms.Button();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.tbRestoreFileName = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateBackUp
            // 
            this.btnCreateBackUp.Location = new System.Drawing.Point(83, 65);
            this.btnCreateBackUp.Name = "btnCreateBackUp";
            this.btnCreateBackUp.Size = new System.Drawing.Size(251, 28);
            this.btnCreateBackUp.TabIndex = 0;
            this.btnCreateBackUp.Text = "Создать резервную копию";
            this.btnCreateBackUp.UseVisualStyleBackColor = true;
            this.btnCreateBackUp.Click += new System.EventHandler(this.BtnCreateBackUp_Click);
            // 
            // btnRestoreDB
            // 
            this.btnRestoreDB.Location = new System.Drawing.Point(83, 70);
            this.btnRestoreDB.Name = "btnRestoreDB";
            this.btnRestoreDB.Size = new System.Drawing.Size(251, 27);
            this.btnRestoreDB.TabIndex = 1;
            this.btnRestoreDB.Text = "Восстановить БД";
            this.btnRestoreDB.UseVisualStyleBackColor = true;
            this.btnRestoreDB.Click += new System.EventHandler(this.BtnRestoreDB_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(209, 275);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(290, 275);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnChooseBackUpDirectory
            // 
            this.btnChooseBackUpDirectory.Location = new System.Drawing.Point(301, 26);
            this.btnChooseBackUpDirectory.Name = "btnChooseBackUpDirectory";
            this.btnChooseBackUpDirectory.Size = new System.Drawing.Size(33, 24);
            this.btnChooseBackUpDirectory.TabIndex = 4;
            this.btnChooseBackUpDirectory.Text = "...";
            this.btnChooseBackUpDirectory.UseVisualStyleBackColor = true;
            this.btnChooseBackUpDirectory.Click += new System.EventHandler(this.BtnChooseBackUpDirectory_Click);
            // 
            // btnChooseRestoreFile
            // 
            this.btnChooseRestoreFile.Location = new System.Drawing.Point(301, 30);
            this.btnChooseRestoreFile.Name = "btnChooseRestoreFile";
            this.btnChooseRestoreFile.Size = new System.Drawing.Size(33, 24);
            this.btnChooseRestoreFile.TabIndex = 5;
            this.btnChooseRestoreFile.Text = "...";
            this.btnChooseRestoreFile.UseVisualStyleBackColor = true;
            this.btnChooseRestoreFile.Click += new System.EventHandler(this.BtnChooseRestoreFile_Click);
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(18, 26);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(277, 24);
            this.tbFilePath.TabIndex = 6;
            // 
            // tbRestoreFileName
            // 
            this.tbRestoreFileName.Location = new System.Drawing.Point(18, 30);
            this.tbRestoreFileName.Name = "tbRestoreFileName";
            this.tbRestoreFileName.Size = new System.Drawing.Size(277, 24);
            this.tbRestoreFileName.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbFilePath);
            this.groupBox1.Controls.Add(this.btnChooseBackUpDirectory);
            this.groupBox1.Controls.Add(this.btnCreateBackUp);
            this.groupBox1.Location = new System.Drawing.Point(4, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 113);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создание резервной копии БД";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbRestoreFileName);
            this.groupBox2.Controls.Add(this.btnChooseRestoreFile);
            this.groupBox2.Controls.Add(this.btnRestoreDB);
            this.groupBox2.Location = new System.Drawing.Point(4, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 119);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Восстановление БД";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "D:\\Мои документы\\ВКР\\Резервные копии";
            // 
            // BackUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 302);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BackUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Резервное копирование";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateBackUp;
        private System.Windows.Forms.Button btnRestoreDB;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChooseBackUpDirectory;
        private System.Windows.Forms.Button btnChooseRestoreFile;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.TextBox tbRestoreFileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}