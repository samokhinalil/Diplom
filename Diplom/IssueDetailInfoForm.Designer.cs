﻿namespace Diplom
{
    partial class IssueDetailInfoForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ITTasksDataSet = new Diplom.ITTasksDataSet();
            this.GetDetailTaskInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GetDetailTaskInfoTableAdapter = new Diplom.ITTasksDataSetTableAdapters.GetDetailTaskInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ITTasksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetDetailTaskInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ITTasksDataSet";
            reportDataSource1.Value = this.GetDetailTaskInfoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Diplom.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(636, 578);
            this.reportViewer1.TabIndex = 0;
            // 
            // ITTasksDataSet
            // 
            this.ITTasksDataSet.DataSetName = "ITTasksDataSet";
            this.ITTasksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GetDetailTaskInfoBindingSource
            // 
            this.GetDetailTaskInfoBindingSource.DataMember = "GetDetailTaskInfo";
            this.GetDetailTaskInfoBindingSource.DataSource = this.ITTasksDataSet;
            // 
            // GetDetailTaskInfoTableAdapter
            // 
            this.GetDetailTaskInfoTableAdapter.ClearBeforeFill = true;
            // 
            // IssueDetailInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 578);
            this.Controls.Add(this.reportViewer1);
            this.Name = "IssueDetailInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подробная информация о задаче";
            this.Load += new System.EventHandler(this.IssueDetailInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ITTasksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetDetailTaskInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GetDetailTaskInfoBindingSource;
        private ITTasksDataSet ITTasksDataSet;
        private ITTasksDataSetTableAdapters.GetDetailTaskInfoTableAdapter GetDetailTaskInfoTableAdapter;
    }
}