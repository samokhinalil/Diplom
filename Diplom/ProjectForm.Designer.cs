namespace Diplom
{
    partial class ProjectForm
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
            this.ctlProjectStartTime = new System.Windows.Forms.DateTimePicker();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.lblProjectStartDate = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctlProjectStartTime
            // 
            this.ctlProjectStartTime.Location = new System.Drawing.Point(179, 44);
            this.ctlProjectStartTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlProjectStartTime.Name = "ctlProjectStartTime";
            this.ctlProjectStartTime.Size = new System.Drawing.Size(244, 24);
            this.ctlProjectStartTime.TabIndex = 17;
            // 
            // tbProjectName
            // 
            this.tbProjectName.Location = new System.Drawing.Point(179, 9);
            this.tbProjectName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(484, 24);
            this.tbProjectName.TabIndex = 16;
            this.tbProjectName.Validating += new System.ComponentModel.CancelEventHandler(this.TbProjectName_Validating);
            this.tbProjectName.Validated += new System.EventHandler(this.TbProjectName_Validated);
            // 
            // lblProjectStartDate
            // 
            this.lblProjectStartDate.AutoSize = true;
            this.lblProjectStartDate.Location = new System.Drawing.Point(9, 44);
            this.lblProjectStartDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProjectStartDate.Name = "lblProjectStartDate";
            this.lblProjectStartDate.Size = new System.Drawing.Size(160, 18);
            this.lblProjectStartDate.TabIndex = 15;
            this.lblProjectStartDate.Text = "Дата начала проекта:";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(30, 9);
            this.lblProjectName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(139, 18);
            this.lblProjectName.TabIndex = 14;
            this.lblProjectName.Text = "Название проекта:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(572, 78);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(491, 78);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 18;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 104);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.ctlProjectStartTime);
            this.Controls.Add(this.tbProjectName);
            this.Controls.Add(this.lblProjectStartDate);
            this.Controls.Add(this.lblProjectName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить проект";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker ctlProjectStartTime;
        private System.Windows.Forms.TextBox tbProjectName;
        private System.Windows.Forms.Label lblProjectStartDate;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}