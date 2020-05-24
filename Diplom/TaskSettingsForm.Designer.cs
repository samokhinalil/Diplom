namespace Diplom
{
    partial class TaskSettingsForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabType = new System.Windows.Forms.TabPage();
            this.dgvTypes = new System.Windows.Forms.DataGridView();
            this.TypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbTypeEdit = new System.Windows.Forms.GroupBox();
            this.tbTypeName = new System.Windows.Forms.TextBox();
            this.btnEditType = new System.Windows.Forms.Button();
            this.laTypeName = new System.Windows.Forms.Label();
            this.btnAddType = new System.Windows.Forms.Button();
            this.tabPriority = new System.Windows.Forms.TabPage();
            this.gbEditPriority = new System.Windows.Forms.GroupBox();
            this.tbPriorityValue = new System.Windows.Forms.TextBox();
            this.laPriorityValue = new System.Windows.Forms.Label();
            this.tbPriorityName = new System.Windows.Forms.TextBox();
            this.btnEditPriority = new System.Windows.Forms.Button();
            this.laPriorityName = new System.Windows.Forms.Label();
            this.btnAddPriority = new System.Windows.Forms.Button();
            this.dgvPriorities = new System.Windows.Forms.DataGridView();
            this.PriorityID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriorityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriorityValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabComplexity = new System.Windows.Forms.TabPage();
            this.dgvComplexity = new System.Windows.Forms.DataGridView();
            this.ComplexityID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComplexityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComplexityValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbComplexity = new System.Windows.Forms.GroupBox();
            this.tbComplexityValue = new System.Windows.Forms.TextBox();
            this.laComplexityValue = new System.Windows.Forms.Label();
            this.tbComplexityName = new System.Windows.Forms.TextBox();
            this.btnEditComplexity = new System.Windows.Forms.Button();
            this.laComlexityName = new System.Windows.Forms.Label();
            this.btnAddComplexity = new System.Windows.Forms.Button();
            this.tabTaskState = new System.Windows.Forms.TabPage();
            this.gbState = new System.Windows.Forms.GroupBox();
            this.tbStateName = new System.Windows.Forms.TextBox();
            this.btnEditState = new System.Windows.Forms.Button();
            this.laStateName = new System.Windows.Forms.Label();
            this.btnAddState = new System.Windows.Forms.Button();
            this.dgvState = new System.Windows.Forms.DataGridView();
            this.StateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypes)).BeginInit();
            this.gbTypeEdit.SuspendLayout();
            this.tabPriority.SuspendLayout();
            this.gbEditPriority.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriorities)).BeginInit();
            this.tabComplexity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplexity)).BeginInit();
            this.gbComplexity.SuspendLayout();
            this.tabTaskState.SuspendLayout();
            this.gbState.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvState)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabType);
            this.tabControl1.Controls.Add(this.tabPriority);
            this.tabControl1.Controls.Add(this.tabComplexity);
            this.tabControl1.Controls.Add(this.tabTaskState);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(348, 398);
            this.tabControl1.TabIndex = 0;
            // 
            // tabType
            // 
            this.tabType.Controls.Add(this.dgvTypes);
            this.tabType.Controls.Add(this.gbTypeEdit);
            this.tabType.Location = new System.Drawing.Point(4, 27);
            this.tabType.Name = "tabType";
            this.tabType.Padding = new System.Windows.Forms.Padding(3);
            this.tabType.Size = new System.Drawing.Size(340, 367);
            this.tabType.TabIndex = 0;
            this.tabType.Text = "Тип";
            this.tabType.UseVisualStyleBackColor = true;
            // 
            // dgvTypes
            // 
            this.dgvTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeID,
            this.TypeName});
            this.dgvTypes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTypes.Location = new System.Drawing.Point(6, 6);
            this.dgvTypes.MultiSelect = false;
            this.dgvTypes.Name = "dgvTypes";
            this.dgvTypes.RowHeadersVisible = false;
            this.dgvTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTypes.Size = new System.Drawing.Size(331, 178);
            this.dgvTypes.TabIndex = 6;
            this.dgvTypes.SelectionChanged += new System.EventHandler(this.DgvTypes_SelectionChanged);
            // 
            // TypeID
            // 
            this.TypeID.DataPropertyName = "ID";
            this.TypeID.HeaderText = "ID";
            this.TypeID.Name = "TypeID";
            this.TypeID.Width = 70;
            // 
            // TypeName
            // 
            this.TypeName.DataPropertyName = "TypeName";
            this.TypeName.HeaderText = "Название типа задач";
            this.TypeName.Name = "TypeName";
            this.TypeName.Width = 250;
            // 
            // gbTypeEdit
            // 
            this.gbTypeEdit.Controls.Add(this.tbTypeName);
            this.gbTypeEdit.Controls.Add(this.btnEditType);
            this.gbTypeEdit.Controls.Add(this.laTypeName);
            this.gbTypeEdit.Controls.Add(this.btnAddType);
            this.gbTypeEdit.Location = new System.Drawing.Point(6, 190);
            this.gbTypeEdit.Name = "gbTypeEdit";
            this.gbTypeEdit.Size = new System.Drawing.Size(331, 122);
            this.gbTypeEdit.TabIndex = 4;
            this.gbTypeEdit.TabStop = false;
            this.gbTypeEdit.Text = "Добавление/редактирование типа задач";
            // 
            // tbTypeName
            // 
            this.tbTypeName.Location = new System.Drawing.Point(9, 48);
            this.tbTypeName.Name = "tbTypeName";
            this.tbTypeName.Size = new System.Drawing.Size(295, 24);
            this.tbTypeName.TabIndex = 6;
            // 
            // btnEditType
            // 
            this.btnEditType.Location = new System.Drawing.Point(176, 87);
            this.btnEditType.Name = "btnEditType";
            this.btnEditType.Size = new System.Drawing.Size(128, 29);
            this.btnEditType.TabIndex = 3;
            this.btnEditType.Text = "Редактировать";
            this.btnEditType.UseVisualStyleBackColor = true;
            this.btnEditType.Click += new System.EventHandler(this.BtnEditType_Click);
            // 
            // laTypeName
            // 
            this.laTypeName.AutoSize = true;
            this.laTypeName.Location = new System.Drawing.Point(6, 27);
            this.laTypeName.Name = "laTypeName";
            this.laTypeName.Size = new System.Drawing.Size(138, 18);
            this.laTypeName.TabIndex = 5;
            this.laTypeName.Text = "Введите название:";
            // 
            // btnAddType
            // 
            this.btnAddType.Location = new System.Drawing.Point(60, 87);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(110, 29);
            this.btnAddType.TabIndex = 2;
            this.btnAddType.Text = "Добавить";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.BtnAddType_Click);
            // 
            // tabPriority
            // 
            this.tabPriority.Controls.Add(this.gbEditPriority);
            this.tabPriority.Controls.Add(this.dgvPriorities);
            this.tabPriority.Location = new System.Drawing.Point(4, 27);
            this.tabPriority.Name = "tabPriority";
            this.tabPriority.Padding = new System.Windows.Forms.Padding(3);
            this.tabPriority.Size = new System.Drawing.Size(340, 367);
            this.tabPriority.TabIndex = 1;
            this.tabPriority.Text = "Приоритет";
            this.tabPriority.UseVisualStyleBackColor = true;
            // 
            // gbEditPriority
            // 
            this.gbEditPriority.Controls.Add(this.tbPriorityValue);
            this.gbEditPriority.Controls.Add(this.laPriorityValue);
            this.gbEditPriority.Controls.Add(this.tbPriorityName);
            this.gbEditPriority.Controls.Add(this.btnEditPriority);
            this.gbEditPriority.Controls.Add(this.laPriorityName);
            this.gbEditPriority.Controls.Add(this.btnAddPriority);
            this.gbEditPriority.Location = new System.Drawing.Point(6, 189);
            this.gbEditPriority.Name = "gbEditPriority";
            this.gbEditPriority.Size = new System.Drawing.Size(328, 172);
            this.gbEditPriority.TabIndex = 6;
            this.gbEditPriority.TabStop = false;
            this.gbEditPriority.Text = "Добавление/редактирование приоритета";
            // 
            // tbPriorityValue
            // 
            this.tbPriorityValue.Location = new System.Drawing.Point(9, 107);
            this.tbPriorityValue.Name = "tbPriorityValue";
            this.tbPriorityValue.Size = new System.Drawing.Size(295, 24);
            this.tbPriorityValue.TabIndex = 8;
            // 
            // laPriorityValue
            // 
            this.laPriorityValue.AutoSize = true;
            this.laPriorityValue.Location = new System.Drawing.Point(6, 86);
            this.laPriorityValue.Name = "laPriorityValue";
            this.laPriorityValue.Size = new System.Drawing.Size(138, 18);
            this.laPriorityValue.TabIndex = 7;
            this.laPriorityValue.Text = "Введите значение:";
            // 
            // tbPriorityName
            // 
            this.tbPriorityName.Location = new System.Drawing.Point(9, 48);
            this.tbPriorityName.Name = "tbPriorityName";
            this.tbPriorityName.Size = new System.Drawing.Size(295, 24);
            this.tbPriorityName.TabIndex = 6;
            // 
            // btnEditPriority
            // 
            this.btnEditPriority.Location = new System.Drawing.Point(176, 137);
            this.btnEditPriority.Name = "btnEditPriority";
            this.btnEditPriority.Size = new System.Drawing.Size(128, 29);
            this.btnEditPriority.TabIndex = 3;
            this.btnEditPriority.Text = "Редактировать";
            this.btnEditPriority.UseVisualStyleBackColor = true;
            this.btnEditPriority.Click += new System.EventHandler(this.BtnEditPriority_Click);
            // 
            // laPriorityName
            // 
            this.laPriorityName.AutoSize = true;
            this.laPriorityName.Location = new System.Drawing.Point(6, 27);
            this.laPriorityName.Name = "laPriorityName";
            this.laPriorityName.Size = new System.Drawing.Size(138, 18);
            this.laPriorityName.TabIndex = 5;
            this.laPriorityName.Text = "Введите название:";
            // 
            // btnAddPriority
            // 
            this.btnAddPriority.Location = new System.Drawing.Point(60, 137);
            this.btnAddPriority.Name = "btnAddPriority";
            this.btnAddPriority.Size = new System.Drawing.Size(110, 29);
            this.btnAddPriority.TabIndex = 2;
            this.btnAddPriority.Text = "Добавить";
            this.btnAddPriority.UseVisualStyleBackColor = true;
            this.btnAddPriority.Click += new System.EventHandler(this.BtnAddPriority_Click);
            // 
            // dgvPriorities
            // 
            this.dgvPriorities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPriorities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PriorityID,
            this.PriorityName,
            this.PriorityValue});
            this.dgvPriorities.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPriorities.Location = new System.Drawing.Point(6, 5);
            this.dgvPriorities.MultiSelect = false;
            this.dgvPriorities.Name = "dgvPriorities";
            this.dgvPriorities.RowHeadersVisible = false;
            this.dgvPriorities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPriorities.Size = new System.Drawing.Size(328, 178);
            this.dgvPriorities.TabIndex = 5;
            this.dgvPriorities.SelectionChanged += new System.EventHandler(this.DgvPriorities_SelectionChanged);
            // 
            // PriorityID
            // 
            this.PriorityID.DataPropertyName = "ID";
            this.PriorityID.HeaderText = "ID";
            this.PriorityID.Name = "PriorityID";
            this.PriorityID.Width = 70;
            // 
            // PriorityName
            // 
            this.PriorityName.DataPropertyName = "PriorityName";
            this.PriorityName.HeaderText = "Название приоритета";
            this.PriorityName.Name = "PriorityName";
            this.PriorityName.Width = 150;
            // 
            // PriorityValue
            // 
            this.PriorityValue.DataPropertyName = "PriorityValue";
            this.PriorityValue.HeaderText = "Значение";
            this.PriorityValue.Name = "PriorityValue";
            // 
            // tabComplexity
            // 
            this.tabComplexity.Controls.Add(this.dgvComplexity);
            this.tabComplexity.Controls.Add(this.gbComplexity);
            this.tabComplexity.Location = new System.Drawing.Point(4, 27);
            this.tabComplexity.Name = "tabComplexity";
            this.tabComplexity.Size = new System.Drawing.Size(340, 367);
            this.tabComplexity.TabIndex = 2;
            this.tabComplexity.Text = "Сложность";
            this.tabComplexity.UseVisualStyleBackColor = true;
            // 
            // dgvComplexity
            // 
            this.dgvComplexity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComplexity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComplexityID,
            this.ComplexityName,
            this.ComplexityValue});
            this.dgvComplexity.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvComplexity.Location = new System.Drawing.Point(6, 5);
            this.dgvComplexity.MultiSelect = false;
            this.dgvComplexity.Name = "dgvComplexity";
            this.dgvComplexity.RowHeadersVisible = false;
            this.dgvComplexity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComplexity.Size = new System.Drawing.Size(328, 178);
            this.dgvComplexity.TabIndex = 7;
            this.dgvComplexity.SelectionChanged += new System.EventHandler(this.DgvComplexity_SelectionChanged);
            // 
            // ComplexityID
            // 
            this.ComplexityID.DataPropertyName = "ID";
            this.ComplexityID.HeaderText = "ID";
            this.ComplexityID.Name = "ComplexityID";
            this.ComplexityID.Width = 70;
            // 
            // ComplexityName
            // 
            this.ComplexityName.DataPropertyName = "ComplexityName";
            this.ComplexityName.HeaderText = "Название уровня сложности";
            this.ComplexityName.Name = "ComplexityName";
            this.ComplexityName.Width = 150;
            // 
            // ComplexityValue
            // 
            this.ComplexityValue.DataPropertyName = "ComplexityValue";
            this.ComplexityValue.HeaderText = "Значение";
            this.ComplexityValue.Name = "ComplexityValue";
            // 
            // gbComplexity
            // 
            this.gbComplexity.Controls.Add(this.tbComplexityValue);
            this.gbComplexity.Controls.Add(this.laComplexityValue);
            this.gbComplexity.Controls.Add(this.tbComplexityName);
            this.gbComplexity.Controls.Add(this.btnEditComplexity);
            this.gbComplexity.Controls.Add(this.laComlexityName);
            this.gbComplexity.Controls.Add(this.btnAddComplexity);
            this.gbComplexity.Location = new System.Drawing.Point(6, 189);
            this.gbComplexity.Name = "gbComplexity";
            this.gbComplexity.Size = new System.Drawing.Size(310, 175);
            this.gbComplexity.TabIndex = 6;
            this.gbComplexity.TabStop = false;
            this.gbComplexity.Text = "Добавление/редактирование сложности задач";
            // 
            // tbComplexityValue
            // 
            this.tbComplexityValue.Location = new System.Drawing.Point(9, 110);
            this.tbComplexityValue.Name = "tbComplexityValue";
            this.tbComplexityValue.Size = new System.Drawing.Size(295, 24);
            this.tbComplexityValue.TabIndex = 8;
            // 
            // laComplexityValue
            // 
            this.laComplexityValue.AutoSize = true;
            this.laComplexityValue.Location = new System.Drawing.Point(6, 89);
            this.laComplexityValue.Name = "laComplexityValue";
            this.laComplexityValue.Size = new System.Drawing.Size(138, 18);
            this.laComplexityValue.TabIndex = 7;
            this.laComplexityValue.Text = "Введите значение:";
            // 
            // tbComplexityName
            // 
            this.tbComplexityName.Location = new System.Drawing.Point(9, 57);
            this.tbComplexityName.Name = "tbComplexityName";
            this.tbComplexityName.Size = new System.Drawing.Size(295, 24);
            this.tbComplexityName.TabIndex = 6;
            // 
            // btnEditComplexity
            // 
            this.btnEditComplexity.Location = new System.Drawing.Point(176, 140);
            this.btnEditComplexity.Name = "btnEditComplexity";
            this.btnEditComplexity.Size = new System.Drawing.Size(128, 29);
            this.btnEditComplexity.TabIndex = 3;
            this.btnEditComplexity.Text = "Редактировать";
            this.btnEditComplexity.UseVisualStyleBackColor = true;
            this.btnEditComplexity.Click += new System.EventHandler(this.BtnEditComplexity_Click);
            // 
            // laComlexityName
            // 
            this.laComlexityName.AutoSize = true;
            this.laComlexityName.Location = new System.Drawing.Point(6, 36);
            this.laComlexityName.Name = "laComlexityName";
            this.laComlexityName.Size = new System.Drawing.Size(138, 18);
            this.laComlexityName.TabIndex = 5;
            this.laComlexityName.Text = "Введите название:";
            // 
            // btnAddComplexity
            // 
            this.btnAddComplexity.Location = new System.Drawing.Point(60, 140);
            this.btnAddComplexity.Name = "btnAddComplexity";
            this.btnAddComplexity.Size = new System.Drawing.Size(110, 29);
            this.btnAddComplexity.TabIndex = 2;
            this.btnAddComplexity.Text = "Добавить";
            this.btnAddComplexity.UseVisualStyleBackColor = true;
            this.btnAddComplexity.Click += new System.EventHandler(this.BtnAddComplexity_Click);
            // 
            // tabTaskState
            // 
            this.tabTaskState.Controls.Add(this.gbState);
            this.tabTaskState.Controls.Add(this.dgvState);
            this.tabTaskState.Location = new System.Drawing.Point(4, 27);
            this.tabTaskState.Name = "tabTaskState";
            this.tabTaskState.Size = new System.Drawing.Size(340, 367);
            this.tabTaskState.TabIndex = 3;
            this.tabTaskState.Text = "Статус";
            this.tabTaskState.UseVisualStyleBackColor = true;
            // 
            // gbState
            // 
            this.gbState.Controls.Add(this.tbStateName);
            this.gbState.Controls.Add(this.btnEditState);
            this.gbState.Controls.Add(this.laStateName);
            this.gbState.Controls.Add(this.btnAddState);
            this.gbState.Location = new System.Drawing.Point(15, 187);
            this.gbState.Name = "gbState";
            this.gbState.Size = new System.Drawing.Size(310, 122);
            this.gbState.TabIndex = 6;
            this.gbState.TabStop = false;
            this.gbState.Text = "Добавление/редактирование статуса";
            // 
            // tbStateName
            // 
            this.tbStateName.Location = new System.Drawing.Point(9, 57);
            this.tbStateName.Name = "tbStateName";
            this.tbStateName.Size = new System.Drawing.Size(295, 24);
            this.tbStateName.TabIndex = 6;
            // 
            // btnEditState
            // 
            this.btnEditState.Location = new System.Drawing.Point(176, 87);
            this.btnEditState.Name = "btnEditState";
            this.btnEditState.Size = new System.Drawing.Size(128, 29);
            this.btnEditState.TabIndex = 3;
            this.btnEditState.Text = "Редактировать";
            this.btnEditState.UseVisualStyleBackColor = true;
            this.btnEditState.Click += new System.EventHandler(this.BtnEditState_Click);
            // 
            // laStateName
            // 
            this.laStateName.AutoSize = true;
            this.laStateName.Location = new System.Drawing.Point(6, 36);
            this.laStateName.Name = "laStateName";
            this.laStateName.Size = new System.Drawing.Size(138, 18);
            this.laStateName.TabIndex = 5;
            this.laStateName.Text = "Введите название:";
            // 
            // btnAddState
            // 
            this.btnAddState.Location = new System.Drawing.Point(60, 87);
            this.btnAddState.Name = "btnAddState";
            this.btnAddState.Size = new System.Drawing.Size(110, 29);
            this.btnAddState.TabIndex = 2;
            this.btnAddState.Text = "Добавить";
            this.btnAddState.UseVisualStyleBackColor = true;
            this.btnAddState.Click += new System.EventHandler(this.BtnAddState_Click);
            // 
            // dgvState
            // 
            this.dgvState.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvState.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StateID,
            this.StateName});
            this.dgvState.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvState.Location = new System.Drawing.Point(6, 3);
            this.dgvState.MultiSelect = false;
            this.dgvState.Name = "dgvState";
            this.dgvState.RowHeadersVisible = false;
            this.dgvState.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvState.Size = new System.Drawing.Size(331, 178);
            this.dgvState.TabIndex = 5;
            this.dgvState.SelectionChanged += new System.EventHandler(this.DgvState_SelectionChanged);
            // 
            // StateID
            // 
            this.StateID.DataPropertyName = "ID";
            this.StateID.HeaderText = "ID";
            this.StateID.Name = "StateID";
            this.StateID.Width = 70;
            // 
            // StateName
            // 
            this.StateName.DataPropertyName = "StateName";
            this.StateName.HeaderText = "Название статуса";
            this.StateName.Name = "StateName";
            this.StateName.Width = 250;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(249, 406);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 23);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(169, 406);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 33;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // TaskSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 432);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaskSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка основных сущностей";
            this.tabControl1.ResumeLayout(false);
            this.tabType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypes)).EndInit();
            this.gbTypeEdit.ResumeLayout(false);
            this.gbTypeEdit.PerformLayout();
            this.tabPriority.ResumeLayout(false);
            this.gbEditPriority.ResumeLayout(false);
            this.gbEditPriority.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriorities)).EndInit();
            this.tabComplexity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplexity)).EndInit();
            this.gbComplexity.ResumeLayout(false);
            this.gbComplexity.PerformLayout();
            this.tabTaskState.ResumeLayout(false);
            this.gbState.ResumeLayout(false);
            this.gbState.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvState)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabType;
        private System.Windows.Forms.TabPage tabPriority;
        private System.Windows.Forms.TabPage tabComplexity;
        private System.Windows.Forms.TabPage tabTaskState;
        private System.Windows.Forms.GroupBox gbTypeEdit;
        private System.Windows.Forms.TextBox tbTypeName;
        private System.Windows.Forms.Button btnEditType;
        private System.Windows.Forms.Label laTypeName;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.GroupBox gbEditPriority;
        private System.Windows.Forms.TextBox tbPriorityName;
        private System.Windows.Forms.Button btnEditPriority;
        private System.Windows.Forms.Label laPriorityName;
        private System.Windows.Forms.Button btnAddPriority;
        private System.Windows.Forms.DataGridView dgvPriorities;
        private System.Windows.Forms.GroupBox gbComplexity;
        private System.Windows.Forms.TextBox tbComplexityName;
        private System.Windows.Forms.Button btnEditComplexity;
        private System.Windows.Forms.Label laComlexityName;
        private System.Windows.Forms.Button btnAddComplexity;
        private System.Windows.Forms.GroupBox gbState;
        private System.Windows.Forms.TextBox tbStateName;
        private System.Windows.Forms.Button btnEditState;
        private System.Windows.Forms.Label laStateName;
        private System.Windows.Forms.Button btnAddState;
        private System.Windows.Forms.DataGridView dgvState;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox tbPriorityValue;
        private System.Windows.Forms.Label laPriorityValue;
        private System.Windows.Forms.TextBox tbComplexityValue;
        private System.Windows.Forms.Label laComplexityValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriorityID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriorityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriorityValue;
        private System.Windows.Forms.DataGridView dgvComplexity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComplexityID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComplexityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComplexityValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateName;
        private System.Windows.Forms.DataGridView dgvTypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeName;
    }
}