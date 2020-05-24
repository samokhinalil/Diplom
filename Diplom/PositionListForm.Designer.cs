namespace Diplom
{
    partial class PositionListForm
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
            this.dgvPositions = new System.Windows.Forms.DataGridView();
            this.btnAddPosition = new System.Windows.Forms.Button();
            this.btnEditPosition = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbEditPosition = new System.Windows.Forms.GroupBox();
            this.tbPositionName = new System.Windows.Forms.TextBox();
            this.laPositionName = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositions)).BeginInit();
            this.gbEditPosition.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPositions
            // 
            this.dgvPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPositions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PositionName});
            this.dgvPositions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPositions.Location = new System.Drawing.Point(4, 4);
            this.dgvPositions.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPositions.MultiSelect = false;
            this.dgvPositions.Name = "dgvPositions";
            this.dgvPositions.RowHeadersVisible = false;
            this.dgvPositions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPositions.Size = new System.Drawing.Size(483, 264);
            this.dgvPositions.TabIndex = 0;
            this.dgvPositions.SelectionChanged += new System.EventHandler(this.DgvPositions_SelectionChanged);
            // 
            // btnAddPosition
            // 
            this.btnAddPosition.Location = new System.Drawing.Point(101, 86);
            this.btnAddPosition.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPosition.Name = "btnAddPosition";
            this.btnAddPosition.Size = new System.Drawing.Size(112, 29);
            this.btnAddPosition.TabIndex = 1;
            this.btnAddPosition.Text = "Добавить";
            this.btnAddPosition.UseVisualStyleBackColor = true;
            this.btnAddPosition.Click += new System.EventHandler(this.BtnAddPosition_Click);
            // 
            // btnEditPosition
            // 
            this.btnEditPosition.Location = new System.Drawing.Point(221, 86);
            this.btnEditPosition.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditPosition.Name = "btnEditPosition";
            this.btnEditPosition.Size = new System.Drawing.Size(128, 29);
            this.btnEditPosition.TabIndex = 2;
            this.btnEditPosition.Text = "Редактировать";
            this.btnEditPosition.UseVisualStyleBackColor = true;
            this.btnEditPosition.Click += new System.EventHandler(this.BtnEditPosition_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(377, 86);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(106, 29);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // gbEditPosition
            // 
            this.gbEditPosition.Controls.Add(this.tbPositionName);
            this.gbEditPosition.Controls.Add(this.btnBack);
            this.gbEditPosition.Controls.Add(this.laPositionName);
            this.gbEditPosition.Controls.Add(this.btnEditPosition);
            this.gbEditPosition.Controls.Add(this.btnAddPosition);
            this.gbEditPosition.Location = new System.Drawing.Point(4, 275);
            this.gbEditPosition.Name = "gbEditPosition";
            this.gbEditPosition.Size = new System.Drawing.Size(483, 125);
            this.gbEditPosition.TabIndex = 7;
            this.gbEditPosition.TabStop = false;
            this.gbEditPosition.Text = "Добавление/редактирование должности";
            // 
            // tbPositionName
            // 
            this.tbPositionName.Location = new System.Drawing.Point(9, 48);
            this.tbPositionName.Name = "tbPositionName";
            this.tbPositionName.Size = new System.Drawing.Size(340, 24);
            this.tbPositionName.TabIndex = 6;
            // 
            // laPositionName
            // 
            this.laPositionName.AutoSize = true;
            this.laPositionName.Location = new System.Drawing.Point(6, 27);
            this.laPositionName.Name = "laPositionName";
            this.laPositionName.Size = new System.Drawing.Size(138, 18);
            this.laPositionName.TabIndex = 5;
            this.laPositionName.Text = "Введите название:";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 101.5228F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // PositionName
            // 
            this.PositionName.DataPropertyName = "PositionName";
            this.PositionName.FillWeight = 98.47716F;
            this.PositionName.HeaderText = "Название";
            this.PositionName.Name = "PositionName";
            this.PositionName.Width = 330;
            // 
            // PositionListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 403);
            this.Controls.Add(this.gbEditPosition);
            this.Controls.Add(this.dgvPositions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PositionListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Должности";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositions)).EndInit();
            this.gbEditPosition.ResumeLayout(false);
            this.gbEditPosition.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPositions;
        private System.Windows.Forms.Button btnAddPosition;
        private System.Windows.Forms.Button btnEditPosition;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gbEditPosition;
        private System.Windows.Forms.TextBox tbPositionName;
        private System.Windows.Forms.Label laPositionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionName;
    }
}