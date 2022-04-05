namespace PhysicalTest
{
    partial class ExamineeList
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelInput = new System.Windows.Forms.Panel();
            this.textBoxIDTo = new System.Windows.Forms.TextBox();
            this.textBoxIDFrom = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirthdateTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBirthdateFrom = new System.Windows.Forms.DateTimePicker();
            this.checkBoxBirthdate = new System.Windows.Forms.CheckBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelBirthdate = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelIDBetween = new System.Windows.Forms.Label();
            this.labelBirthdateBetween = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelInput, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelFooter, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(624, 441);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.textBoxIDTo);
            this.panelInput.Controls.Add(this.textBoxIDFrom);
            this.panelInput.Controls.Add(this.dateTimePickerBirthdateTo);
            this.panelInput.Controls.Add(this.dateTimePickerBirthdateFrom);
            this.panelInput.Controls.Add(this.checkBoxBirthdate);
            this.panelInput.Controls.Add(this.textBoxName);
            this.panelInput.Controls.Add(this.labelBirthdate);
            this.panelInput.Controls.Add(this.labelName);
            this.panelInput.Controls.Add(this.labelIDBetween);
            this.panelInput.Controls.Add(this.labelBirthdateBetween);
            this.panelInput.Controls.Add(this.labelID);
            this.panelInput.Location = new System.Drawing.Point(3, 3);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(618, 104);
            this.panelInput.TabIndex = 0;
            // 
            // textBoxIDTo
            // 
            this.textBoxIDTo.Location = new System.Drawing.Point(215, 10);
            this.textBoxIDTo.MaxLength = 8;
            this.textBoxIDTo.Name = "textBoxIDTo";
            this.textBoxIDTo.Size = new System.Drawing.Size(100, 19);
            this.textBoxIDTo.TabIndex = 3;
            // 
            // textBoxIDFrom
            // 
            this.textBoxIDFrom.Location = new System.Drawing.Point(86, 10);
            this.textBoxIDFrom.MaxLength = 8;
            this.textBoxIDFrom.Name = "textBoxIDFrom";
            this.textBoxIDFrom.Size = new System.Drawing.Size(100, 19);
            this.textBoxIDFrom.TabIndex = 1;
            // 
            // dateTimePickerBirthdateTo
            // 
            this.dateTimePickerBirthdateTo.Location = new System.Drawing.Point(388, 71);
            this.dateTimePickerBirthdateTo.Name = "dateTimePickerBirthdateTo";
            this.dateTimePickerBirthdateTo.Size = new System.Drawing.Size(200, 19);
            this.dateTimePickerBirthdateTo.TabIndex = 10;
            // 
            // dateTimePickerBirthdateFrom
            // 
            this.dateTimePickerBirthdateFrom.Location = new System.Drawing.Point(159, 71);
            this.dateTimePickerBirthdateFrom.Name = "dateTimePickerBirthdateFrom";
            this.dateTimePickerBirthdateFrom.Size = new System.Drawing.Size(200, 19);
            this.dateTimePickerBirthdateFrom.TabIndex = 8;
            // 
            // checkBoxBirthdate
            // 
            this.checkBoxBirthdate.AutoSize = true;
            this.checkBoxBirthdate.Location = new System.Drawing.Point(86, 74);
            this.checkBoxBirthdate.Name = "checkBoxBirthdate";
            this.checkBoxBirthdate.Size = new System.Drawing.Size(67, 16);
            this.checkBoxBirthdate.TabIndex = 7;
            this.checkBoxBirthdate.Text = "指定する";
            this.checkBoxBirthdate.UseVisualStyleBackColor = true;
            this.checkBoxBirthdate.CheckedChanged += new System.EventHandler(this.checkBoxBirthdate_CheckedChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(86, 39);
            this.textBoxName.MaxLength = 40;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(191, 19);
            this.textBoxName.TabIndex = 5;
            this.textBoxName.Text = "あいうえおかきくけこさしすせそたちつてと";
            // 
            // labelBirthdate
            // 
            this.labelBirthdate.AutoSize = true;
            this.labelBirthdate.Location = new System.Drawing.Point(10, 74);
            this.labelBirthdate.Name = "labelBirthdate";
            this.labelBirthdate.Size = new System.Drawing.Size(53, 12);
            this.labelBirthdate.TabIndex = 6;
            this.labelBirthdate.Text = "生年月日";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(10, 46);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(65, 12);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "受験者氏名";
            // 
            // labelIDBetween
            // 
            this.labelIDBetween.AutoSize = true;
            this.labelIDBetween.Location = new System.Drawing.Point(192, 13);
            this.labelIDBetween.Name = "labelIDBetween";
            this.labelIDBetween.Size = new System.Drawing.Size(17, 12);
            this.labelIDBetween.TabIndex = 2;
            this.labelIDBetween.Text = "～";
            // 
            // labelBirthdateBetween
            // 
            this.labelBirthdateBetween.AutoSize = true;
            this.labelBirthdateBetween.Location = new System.Drawing.Point(365, 76);
            this.labelBirthdateBetween.Name = "labelBirthdateBetween";
            this.labelBirthdateBetween.Size = new System.Drawing.Size(17, 12);
            this.labelBirthdateBetween.TabIndex = 9;
            this.labelBirthdateBetween.Text = "～";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(10, 18);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(52, 12);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "受験者ID";
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.buttonUpdate);
            this.panelFooter.Controls.Add(this.buttonSelect);
            this.panelFooter.Controls.Add(this.buttonDelete);
            this.panelFooter.Controls.Add(this.buttonInsert);
            this.panelFooter.Controls.Add(this.buttonSearch);
            this.panelFooter.Controls.Add(this.buttonClose);
            this.panelFooter.Location = new System.Drawing.Point(3, 394);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(618, 44);
            this.panelFooter.TabIndex = 2;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(524, 4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "更新";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(226, 4);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonSelect.TabIndex = 2;
            this.buttonSelect.Text = "選択";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(307, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "削除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(443, 4);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 3;
            this.buttonInsert.Text = "新規";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(86, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "絞込";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(4, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "閉じる";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.LastName,
            this.FirstName,
            this.Birthdate});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 113);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(618, 275);
            this.dataGridView1.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ExamineeID";
            this.ID.HeaderText = "受験者ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "姓";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "名";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // Birthdate
            // 
            this.Birthdate.DataPropertyName = "Birthdate";
            this.Birthdate.HeaderText = "生年月日";
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.ReadOnly = true;
            // 
            // ExamineeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ExamineeList";
            this.Text = "受験者検索";
            this.Load += new System.EventHandler(this.ExamineeList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthdateFrom;
        private System.Windows.Forms.CheckBox checkBoxBirthdate;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelBirthdate;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthdateTo;
        private System.Windows.Forms.Label labelBirthdateBetween;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxIDTo;
        private System.Windows.Forms.TextBox textBoxIDFrom;
        private System.Windows.Forms.Label labelIDBetween;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthdate;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonSelect;
    }
}