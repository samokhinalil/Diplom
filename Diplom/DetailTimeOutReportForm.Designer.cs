namespace Diplom
{
    partial class DetailTimeOutReportForm
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
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.ctlDateTo = new System.Windows.Forms.DateTimePicker();
            this.ctlDateFrom = new System.Windows.Forms.DateTimePicker();
            this.laDateTo = new System.Windows.Forms.Label();
            this.laDateFrom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportViewer2
            // 
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Diplom.Report4.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(1, 45);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(799, 404);
            this.reportViewer2.TabIndex = 18;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(400, 11);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(140, 21);
            this.btnGenerateReport.TabIndex = 23;
            this.btnGenerateReport.Text = "Сформировать отчет";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.BtnGenerateReport_Click);
            // 
            // ctlDateTo
            // 
            this.ctlDateTo.Location = new System.Drawing.Point(233, 11);
            this.ctlDateTo.Name = "ctlDateTo";
            this.ctlDateTo.Size = new System.Drawing.Size(137, 20);
            this.ctlDateTo.TabIndex = 22;
            // 
            // ctlDateFrom
            // 
            this.ctlDateFrom.Location = new System.Drawing.Point(42, 12);
            this.ctlDateFrom.Name = "ctlDateFrom";
            this.ctlDateFrom.Size = new System.Drawing.Size(137, 20);
            this.ctlDateFrom.TabIndex = 21;
            // 
            // laDateTo
            // 
            this.laDateTo.AutoSize = true;
            this.laDateTo.Location = new System.Drawing.Point(205, 11);
            this.laDateTo.Name = "laDateTo";
            this.laDateTo.Size = new System.Drawing.Size(22, 13);
            this.laDateTo.TabIndex = 20;
            this.laDateTo.Text = "по:";
            // 
            // laDateFrom
            // 
            this.laDateFrom.AutoSize = true;
            this.laDateFrom.Location = new System.Drawing.Point(20, 11);
            this.laDateFrom.Name = "laDateFrom";
            this.laDateFrom.Size = new System.Drawing.Size(16, 13);
            this.laDateFrom.TabIndex = 19;
            this.laDateFrom.Text = "с:";
            // 
            // DetailTimeOutReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.ctlDateTo);
            this.Controls.Add(this.ctlDateFrom);
            this.Controls.Add(this.laDateTo);
            this.Controls.Add(this.laDateFrom);
            this.Controls.Add(this.reportViewer2);
            this.Name = "DetailTimeOutReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Детальный отчет о невыполненных в срок задачах";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.DateTimePicker ctlDateTo;
        private System.Windows.Forms.DateTimePicker ctlDateFrom;
        private System.Windows.Forms.Label laDateTo;
        private System.Windows.Forms.Label laDateFrom;
    }
}