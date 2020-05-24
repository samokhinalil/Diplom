namespace Diplom
{
    partial class SolvedTasksComplexityCountReportForm
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.laDateFrom = new System.Windows.Forms.Label();
            this.laDateTo = new System.Windows.Forms.Label();
            this.ctlDateFrom = new System.Windows.Forms.DateTimePicker();
            this.ctlDateTo = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Diplom.Report1.rdlc";
            this.reportViewer1.LocalReport.ReportPath = "";
            this.reportViewer1.Location = new System.Drawing.Point(0, 44);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(661, 339);
            this.reportViewer1.TabIndex = 0;
            // 
            // laDateFrom
            // 
            this.laDateFrom.AutoSize = true;
            this.laDateFrom.Location = new System.Drawing.Point(12, 11);
            this.laDateFrom.Name = "laDateFrom";
            this.laDateFrom.Size = new System.Drawing.Size(16, 13);
            this.laDateFrom.TabIndex = 1;
            this.laDateFrom.Text = "с:";
            // 
            // laDateTo
            // 
            this.laDateTo.AutoSize = true;
            this.laDateTo.Location = new System.Drawing.Point(197, 11);
            this.laDateTo.Name = "laDateTo";
            this.laDateTo.Size = new System.Drawing.Size(22, 13);
            this.laDateTo.TabIndex = 2;
            this.laDateTo.Text = "по:";
            // 
            // ctlDateFrom
            // 
            this.ctlDateFrom.Location = new System.Drawing.Point(34, 12);
            this.ctlDateFrom.Name = "ctlDateFrom";
            this.ctlDateFrom.Size = new System.Drawing.Size(137, 20);
            this.ctlDateFrom.TabIndex = 3;
            // 
            // ctlDateTo
            // 
            this.ctlDateTo.Location = new System.Drawing.Point(225, 11);
            this.ctlDateTo.Name = "ctlDateTo";
            this.ctlDateTo.Size = new System.Drawing.Size(137, 20);
            this.ctlDateTo.TabIndex = 4;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(392, 11);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(140, 21);
            this.btnGenerateReport.TabIndex = 5;
            this.btnGenerateReport.Text = "Сформировать отчет";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.BtnGenerateReport_Click);
            // 
            // SolvedTasksComplexityCountReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 395);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.ctlDateTo);
            this.Controls.Add(this.ctlDateFrom);
            this.Controls.Add(this.laDateTo);
            this.Controls.Add(this.laDateFrom);
            this.Controls.Add(this.reportViewer1);
            this.Name = "SolvedTasksComplexityCountReportForm";
            this.Text = "Отчет о количестве решенных задач по уровню сложности";
            this.Load += new System.EventHandler(this.SolvedTasksComplexityCountReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label laDateFrom;
        private System.Windows.Forms.Label laDateTo;
        private System.Windows.Forms.DateTimePicker ctlDateFrom;
        private System.Windows.Forms.DateTimePicker ctlDateTo;
        private System.Windows.Forms.Button btnGenerateReport;
    }
}