namespace Diplom
{
    partial class IssueHistoryForm
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
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.gbHistorySearch = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctlDateTo = new System.Windows.Forms.DateTimePicker();
            this.ctlDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblSearchFromDate = new System.Windows.Forms.Label();
            this.btnResetSearchingResults = new System.Windows.Forms.Button();
            this.lblIssueName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearchName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.IssueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.gbHistorySearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHistory
            // 
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IssueID,
            this.IssueName,
            this.StateName,
            this.StateDate});
            this.dgvHistory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvHistory.Location = new System.Drawing.Point(0, 0);
            this.dgvHistory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvHistory.MultiSelect = false;
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.RowHeadersVisible = false;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.Size = new System.Drawing.Size(617, 234);
            this.dgvHistory.TabIndex = 1;
            this.dgvHistory.SelectionChanged += new System.EventHandler(this.DgvHistory_SelectionChanged);
            // 
            // gbHistorySearch
            // 
            this.gbHistorySearch.Controls.Add(this.label1);
            this.gbHistorySearch.Controls.Add(this.ctlDateTo);
            this.gbHistorySearch.Controls.Add(this.ctlDateFrom);
            this.gbHistorySearch.Controls.Add(this.lblSearchFromDate);
            this.gbHistorySearch.Controls.Add(this.btnResetSearchingResults);
            this.gbHistorySearch.Controls.Add(this.lblIssueName);
            this.gbHistorySearch.Controls.Add(this.btnSearch);
            this.gbHistorySearch.Controls.Add(this.tbSearchName);
            this.gbHistorySearch.Location = new System.Drawing.Point(0, 244);
            this.gbHistorySearch.Margin = new System.Windows.Forms.Padding(4);
            this.gbHistorySearch.Name = "gbHistorySearch";
            this.gbHistorySearch.Padding = new System.Windows.Forms.Padding(4);
            this.gbHistorySearch.Size = new System.Drawing.Size(617, 112);
            this.gbHistorySearch.TabIndex = 14;
            this.gbHistorySearch.TabStop = false;
            this.gbHistorySearch.Text = "Поиск по истории:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "_";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ctlDateTo
            // 
            this.ctlDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ctlDateTo.Location = new System.Drawing.Point(343, 52);
            this.ctlDateTo.Name = "ctlDateTo";
            this.ctlDateTo.Size = new System.Drawing.Size(110, 24);
            this.ctlDateTo.TabIndex = 29;
            // 
            // ctlDateFrom
            // 
            this.ctlDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ctlDateFrom.Location = new System.Drawing.Point(205, 51);
            this.ctlDateFrom.Name = "ctlDateFrom";
            this.ctlDateFrom.Size = new System.Drawing.Size(110, 24);
            this.ctlDateFrom.TabIndex = 27;
            // 
            // lblSearchFromDate
            // 
            this.lblSearchFromDate.AutoSize = true;
            this.lblSearchFromDate.Location = new System.Drawing.Point(90, 52);
            this.lblSearchFromDate.Name = "lblSearchFromDate";
            this.lblSearchFromDate.Size = new System.Drawing.Size(113, 18);
            this.lblSearchFromDate.TabIndex = 25;
            this.lblSearchFromDate.Text = "Поиск по дате:";
            // 
            // btnResetSearchingResults
            // 
            this.btnResetSearchingResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetSearchingResults.Location = new System.Drawing.Point(516, 82);
            this.btnResetSearchingResults.Name = "btnResetSearchingResults";
            this.btnResetSearchingResults.Size = new System.Drawing.Size(94, 23);
            this.btnResetSearchingResults.TabIndex = 22;
            this.btnResetSearchingResults.Text = "Сбросить";
            this.btnResetSearchingResults.UseVisualStyleBackColor = true;
            this.btnResetSearchingResults.Click += new System.EventHandler(this.BtnResetSearchingResults_Click);
            // 
            // lblIssueName
            // 
            this.lblIssueName.AutoSize = true;
            this.lblIssueName.Location = new System.Drawing.Point(12, 23);
            this.lblIssueName.Name = "lblIssueName";
            this.lblIssueName.Size = new System.Drawing.Size(191, 18);
            this.lblIssueName.TabIndex = 21;
            this.lblIssueName.Text = "Введите название задачи:";
            this.lblIssueName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(425, 82);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 23);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // tbSearchName
            // 
            this.tbSearchName.Location = new System.Drawing.Point(205, 23);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(371, 24);
            this.tbSearchName.TabIndex = 19;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(519, 363);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(439, 363);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(74, 23);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // IssueID
            // 
            this.IssueID.DataPropertyName = "IssueID";
            this.IssueID.FillWeight = 30F;
            this.IssueID.HeaderText = "ID задачи";
            this.IssueID.Name = "IssueID";
            this.IssueID.ReadOnly = true;
            // 
            // IssueName
            // 
            this.IssueName.DataPropertyName = "IssueName";
            this.IssueName.FillWeight = 85.95601F;
            this.IssueName.HeaderText = "Название задачи";
            this.IssueName.Name = "IssueName";
            this.IssueName.ReadOnly = true;
            // 
            // StateName
            // 
            this.StateName.DataPropertyName = "StateName";
            this.StateName.FillWeight = 85.95601F;
            this.StateName.HeaderText = "Статус";
            this.StateName.Name = "StateName";
            this.StateName.ReadOnly = true;
            // 
            // StateDate
            // 
            this.StateDate.DataPropertyName = "StateDate";
            this.StateDate.FillWeight = 85.95601F;
            this.StateDate.HeaderText = "Дата";
            this.StateDate.Name = "StateDate";
            this.StateDate.ReadOnly = true;
            // 
            // IssueHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 392);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbHistorySearch);
            this.Controls.Add(this.dgvHistory);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "IssueHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "История выполнения задач";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.gbHistorySearch.ResumeLayout(false);
            this.gbHistorySearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.GroupBox gbHistorySearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ctlDateTo;
        private System.Windows.Forms.DateTimePicker ctlDateFrom;
        private System.Windows.Forms.Label lblSearchFromDate;
        private System.Windows.Forms.Button btnResetSearchingResults;
        private System.Windows.Forms.Label lblIssueName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearchName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateDate;
    }
}