namespace Diplom
{
    partial class TimeOutTasksReportForm
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
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ITTasksDataSet = new Diplom.ITTasksDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.ITTasksDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(459, 11);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(140, 21);
            this.btnGenerateReport.TabIndex = 15;
            this.btnGenerateReport.Text = "Сформировать отчет";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.BtnGenerateReport_Click);
            // 
            // ctlDateTo
            // 
            this.ctlDateTo.Location = new System.Drawing.Point(292, 11);
            this.ctlDateTo.Name = "ctlDateTo";
            this.ctlDateTo.Size = new System.Drawing.Size(137, 20);
            this.ctlDateTo.TabIndex = 14;
            // 
            // ctlDateFrom
            // 
            this.ctlDateFrom.Location = new System.Drawing.Point(101, 12);
            this.ctlDateFrom.Name = "ctlDateFrom";
            this.ctlDateFrom.Size = new System.Drawing.Size(137, 20);
            this.ctlDateFrom.TabIndex = 13;
            // 
            // laDateTo
            // 
            this.laDateTo.AutoSize = true;
            this.laDateTo.Location = new System.Drawing.Point(264, 11);
            this.laDateTo.Name = "laDateTo";
            this.laDateTo.Size = new System.Drawing.Size(22, 13);
            this.laDateTo.TabIndex = 12;
            this.laDateTo.Text = "по:";
            // 
            // laDateFrom
            // 
            this.laDateFrom.AutoSize = true;
            this.laDateFrom.Location = new System.Drawing.Point(79, 11);
            this.laDateFrom.Name = "laDateFrom";
            this.laDateFrom.Size = new System.Drawing.Size(16, 13);
            this.laDateFrom.TabIndex = 11;
            this.laDateFrom.Text = "с:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Diplom.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 38);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(389, 235);
            this.reportViewer1.TabIndex = 16;
            // 
            // reportViewer2
            // 
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Diplom.Report4.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(12, 279);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(686, 265);
            this.reportViewer2.TabIndex = 17;
            // 
            // ITTasksDataSet
            // 
            this.ITTasksDataSet.DataSetName = "ITTasksDataSet";
            this.ITTasksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TimeOutTasksReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 556);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.ctlDateTo);
            this.Controls.Add(this.ctlDateFrom);
            this.Controls.Add(this.laDateTo);
            this.Controls.Add(this.laDateFrom);
            this.Name = "TimeOutTasksReportForm";
            this.Text = "Отчет о превышении срока выполнения задач";
            this.Load += new System.EventHandler(this.TimeOutTasksReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ITTasksDataSet)).EndInit();
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
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private ITTasksDataSet ITTasksDataSet;
    }
}