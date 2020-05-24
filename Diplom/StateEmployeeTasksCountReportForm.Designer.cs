namespace Diplom
{
    partial class StateEmployeeTasksCountReportForm
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
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.ctlDateTo = new System.Windows.Forms.DateTimePicker();
            this.ctlDateFrom = new System.Windows.Forms.DateTimePicker();
            this.laDateTo = new System.Windows.Forms.Label();
            this.laDateFrom = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.laEmployee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(393, 48);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(140, 21);
            this.btnGenerateReport.TabIndex = 10;
            this.btnGenerateReport.Text = "Сформировать отчет";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.BtnGenerateReport_Click);
            // 
            // ctlDateTo
            // 
            this.ctlDateTo.Location = new System.Drawing.Point(226, 48);
            this.ctlDateTo.Name = "ctlDateTo";
            this.ctlDateTo.Size = new System.Drawing.Size(137, 20);
            this.ctlDateTo.TabIndex = 9;
            // 
            // ctlDateFrom
            // 
            this.ctlDateFrom.Location = new System.Drawing.Point(35, 49);
            this.ctlDateFrom.Name = "ctlDateFrom";
            this.ctlDateFrom.Size = new System.Drawing.Size(137, 20);
            this.ctlDateFrom.TabIndex = 8;
            // 
            // laDateTo
            // 
            this.laDateTo.AutoSize = true;
            this.laDateTo.Location = new System.Drawing.Point(198, 48);
            this.laDateTo.Name = "laDateTo";
            this.laDateTo.Size = new System.Drawing.Size(22, 13);
            this.laDateTo.TabIndex = 7;
            this.laDateTo.Text = "по:";
            // 
            // laDateFrom
            // 
            this.laDateFrom.AutoSize = true;
            this.laDateFrom.Location = new System.Drawing.Point(13, 48);
            this.laDateFrom.Name = "laDateFrom";
            this.laDateFrom.Size = new System.Drawing.Size(16, 13);
            this.laDateFrom.TabIndex = 6;
            this.laDateFrom.Text = "с:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Diplom.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 75);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(620, 366);
            this.reportViewer1.TabIndex = 11;
            // 
            // cbEmployee
            // 
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(82, 12);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(281, 21);
            this.cbEmployee.TabIndex = 12;
            // 
            // laEmployee
            // 
            this.laEmployee.AutoSize = true;
            this.laEmployee.Location = new System.Drawing.Point(13, 12);
            this.laEmployee.Name = "laEmployee";
            this.laEmployee.Size = new System.Drawing.Size(63, 13);
            this.laEmployee.TabIndex = 13;
            this.laEmployee.Text = "Сотрудник:";
            // 
            // StateEmployeeTasksCountReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 441);
            this.Controls.Add(this.laEmployee);
            this.Controls.Add(this.cbEmployee);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.ctlDateTo);
            this.Controls.Add(this.ctlDateFrom);
            this.Controls.Add(this.laDateTo);
            this.Controls.Add(this.laDateFrom);
            this.Name = "StateEmployeeTasksCountReportForm";
            this.Text = "Отчет по статусу задач сотрудника";
            this.Load += new System.EventHandler(this.StateEmployeeTasksCountReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.DateTimePicker ctlDateTo;
        private System.Windows.Forms.DateTimePicker ctlDateFrom;
        private System.Windows.Forms.Label laDateTo;
        private System.Windows.Forms.Label laDateFrom;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Label laEmployee;
    }
}