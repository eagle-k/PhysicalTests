namespace PhysicalTest
{
    partial class TestResultList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelInput = new System.Windows.Forms.Panel();
            this.buttonExamineeSearch = new System.Windows.Forms.Button();
            this.comboBoxTestEvents = new System.Windows.Forms.ComboBox();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxExamineeID = new System.Windows.Forms.TextBox();
            this.labelTestEvent = new System.Windows.Forms.Label();
            this.labelExamineeID = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ExamineeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestEventID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestEventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(624, 441);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.buttonExamineeSearch);
            this.panelInput.Controls.Add(this.comboBoxTestEvents);
            this.panelInput.Controls.Add(this.textBoxFullName);
            this.panelInput.Controls.Add(this.textBoxExamineeID);
            this.panelInput.Controls.Add(this.labelTestEvent);
            this.panelInput.Controls.Add(this.labelExamineeID);
            this.panelInput.Location = new System.Drawing.Point(3, 3);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(618, 64);
            this.panelInput.TabIndex = 0;
            // 
            // buttonExamineeSearch
            // 
            this.buttonExamineeSearch.Location = new System.Drawing.Point(443, 9);
            this.buttonExamineeSearch.Name = "buttonExamineeSearch";
            this.buttonExamineeSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonExamineeSearch.TabIndex = 3;
            this.buttonExamineeSearch.Text = "検索";
            this.buttonExamineeSearch.UseVisualStyleBackColor = true;
            this.buttonExamineeSearch.Click += new System.EventHandler(this.buttonExamineeSearch_Click);
            // 
            // comboBoxTestEvents
            // 
            this.comboBoxTestEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTestEvents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxTestEvents.FormattingEnabled = true;
            this.comboBoxTestEvents.Location = new System.Drawing.Point(86, 36);
            this.comboBoxTestEvents.Name = "comboBoxTestEvents";
            this.comboBoxTestEvents.Size = new System.Drawing.Size(181, 20);
            this.comboBoxTestEvents.TabIndex = 5;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(192, 10);
            this.textBoxFullName.MaxLength = 8;
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.ReadOnly = true;
            this.textBoxFullName.Size = new System.Drawing.Size(245, 19);
            this.textBoxFullName.TabIndex = 2;
            // 
            // textBoxExamineeID
            // 
            this.textBoxExamineeID.Location = new System.Drawing.Point(86, 10);
            this.textBoxExamineeID.MaxLength = 8;
            this.textBoxExamineeID.Name = "textBoxExamineeID";
            this.textBoxExamineeID.Size = new System.Drawing.Size(100, 19);
            this.textBoxExamineeID.TabIndex = 1;
            this.textBoxExamineeID.Leave += new System.EventHandler(this.textBoxExamineeID_Leave);
            // 
            // labelTestEvent
            // 
            this.labelTestEvent.AutoSize = true;
            this.labelTestEvent.Location = new System.Drawing.Point(10, 44);
            this.labelTestEvent.Name = "labelTestEvent";
            this.labelTestEvent.Size = new System.Drawing.Size(29, 12);
            this.labelTestEvent.TabIndex = 4;
            this.labelTestEvent.Text = "種目";
            // 
            // labelExamineeID
            // 
            this.labelExamineeID.AutoSize = true;
            this.labelExamineeID.Location = new System.Drawing.Point(10, 18);
            this.labelExamineeID.Name = "labelExamineeID";
            this.labelExamineeID.Size = new System.Drawing.Size(41, 12);
            this.labelExamineeID.TabIndex = 0;
            this.labelExamineeID.Text = "受験者";
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
            this.buttonUpdate.TabIndex = 5;
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
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(307, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "削除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(443, 4);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 4;
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
            this.ExamineeID,
            this.FullName,
            this.TestEventID,
            this.TestEventName,
            this.Score});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 73);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(618, 315);
            this.dataGridView1.TabIndex = 1;
            // 
            // ExamineeID
            // 
            this.ExamineeID.DataPropertyName = "ExamineeID";
            this.ExamineeID.HeaderText = "受験者ID";
            this.ExamineeID.Name = "ExamineeID";
            this.ExamineeID.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "受験者氏名";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // TestEventID
            // 
            this.TestEventID.DataPropertyName = "TestEventID";
            this.TestEventID.HeaderText = "種目ID";
            this.TestEventID.Name = "TestEventID";
            this.TestEventID.ReadOnly = true;
            // 
            // TestEventName
            // 
            this.TestEventName.DataPropertyName = "TestEventName";
            this.TestEventName.HeaderText = "種目名";
            this.TestEventName.Name = "TestEventName";
            this.TestEventName.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.DataPropertyName = "Score";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Score.DefaultCellStyle = dataGridViewCellStyle1;
            this.Score.HeaderText = "得点";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            // 
            // TestResultList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TestResultList";
            this.Text = "結果一覧";
            this.Load += new System.EventHandler(this.TestResultList_Load);
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
        private System.Windows.Forms.ComboBox comboBoxTestEvents;
        private System.Windows.Forms.TextBox textBoxExamineeID;
        private System.Windows.Forms.Label labelTestEvent;
        private System.Windows.Forms.Label labelExamineeID;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonExamineeSearch;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamineeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestEventID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestEventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
    }
}