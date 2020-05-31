namespace Diplom
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ctlReportType = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlReport1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlReport2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlReport3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlReport4 = new System.Windows.Forms.ToolStripMenuItem();
            this.laMessage = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlReportType});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ctlReportType
            // 
            this.ctlReportType.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlReport1,
            this.ctlReport2,
            this.ctlReport3,
            this.ctlReport4});
            this.ctlReportType.Name = "ctlReportType";
            this.ctlReportType.Size = new System.Drawing.Size(78, 20);
            this.ctlReportType.Text = "Тип отчета";
            // 
            // ctlReport1
            // 
            this.ctlReport1.Name = "ctlReport1";
            this.ctlReport1.Size = new System.Drawing.Size(406, 22);
            this.ctlReport1.Text = "Отчет \"Количество решенных задач по уровню сложности\"";
            this.ctlReport1.Click += new System.EventHandler(this.CtlReport1_Click);
            // 
            // ctlReport2
            // 
            this.ctlReport2.Name = "ctlReport2";
            this.ctlReport2.Size = new System.Drawing.Size(406, 22);
            this.ctlReport2.Text = "Отчет о статусе задач сотрудника";
            this.ctlReport2.Click += new System.EventHandler(this.CtlReport2_Click);
            // 
            // ctlReport3
            // 
            this.ctlReport3.Name = "ctlReport3";
            this.ctlReport3.Size = new System.Drawing.Size(406, 22);
            this.ctlReport3.Text = "Отчет \"Количество невыполненных в срок задач\"";
            this.ctlReport3.Click += new System.EventHandler(this.CtlReport3_Click);
            // 
            // ctlReport4
            // 
            this.ctlReport4.Name = "ctlReport4";
            this.ctlReport4.Size = new System.Drawing.Size(406, 22);
            this.ctlReport4.Text = "Детальный отчет по невыполненным в срок задачам";
            this.ctlReport4.Click += new System.EventHandler(this.CtlReport4_Click);
            // 
            // laMessage
            // 
            this.laMessage.AutoSize = true;
            this.laMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laMessage.Location = new System.Drawing.Point(183, 64);
            this.laMessage.Name = "laMessage";
            this.laMessage.Size = new System.Drawing.Size(437, 20);
            this.laMessage.TabIndex = 2;
            this.laMessage.Text = "Для начала работы выберите тип отчета из меню";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(151, 119);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(498, 340);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.laMessage);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Формирование отчетов";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Label laMessage;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStripMenuItem ctlReportType;
        private System.Windows.Forms.ToolStripMenuItem ctlReport1;
        private System.Windows.Forms.ToolStripMenuItem ctlReport2;
        private System.Windows.Forms.ToolStripMenuItem ctlReport3;
        private System.Windows.Forms.ToolStripMenuItem ctlReport4;
    }
}