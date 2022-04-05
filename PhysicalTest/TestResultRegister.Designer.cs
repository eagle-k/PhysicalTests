namespace PhysicalTest
{
    partial class TestResultRegister
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
            this.buttonExamineeSearch = new System.Windows.Forms.Button();
            this.comboBoxTestEvents = new System.Windows.Forms.ComboBox();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxExamineeID = new System.Windows.Forms.TextBox();
            this.labelTestEvent = new System.Windows.Forms.Label();
            this.labelExamineeID = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelInput, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelFooter, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(624, 161);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.buttonExamineeSearch);
            this.panelInput.Controls.Add(this.comboBoxTestEvents);
            this.panelInput.Controls.Add(this.textBoxFullName);
            this.panelInput.Controls.Add(this.textBoxScore);
            this.panelInput.Controls.Add(this.textBoxExamineeID);
            this.panelInput.Controls.Add(this.labelScore);
            this.panelInput.Controls.Add(this.labelTestEvent);
            this.panelInput.Controls.Add(this.labelExamineeID);
            this.panelInput.Location = new System.Drawing.Point(3, 3);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(618, 105);
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
            this.panelFooter.Controls.Add(this.buttonRegister);
            this.panelFooter.Controls.Add(this.buttonClose);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFooter.Location = new System.Drawing.Point(3, 114);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(618, 44);
            this.panelFooter.TabIndex = 1;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(84, 3);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(75, 23);
            this.buttonRegister.TabIndex = 1;
            this.buttonRegister.Text = "登録";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(3, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "閉じる";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(10, 72);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(29, 12);
            this.labelScore.TabIndex = 6;
            this.labelScore.Text = "得点";
            // 
            // textBoxScore
            // 
            this.textBoxScore.Location = new System.Drawing.Point(84, 65);
            this.textBoxScore.MaxLength = 8;
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(100, 19);
            this.textBoxScore.TabIndex = 7;
            this.textBoxScore.Leave += new System.EventHandler(this.textBoxExamineeID_Leave);
            // 
            // TestResultRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 161);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TestResultRegister";
            this.Text = "結果登録";
            this.Load += new System.EventHandler(this.TestResultRegister_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Button buttonExamineeSearch;
        private System.Windows.Forms.ComboBox comboBoxTestEvents;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.TextBox textBoxExamineeID;
        private System.Windows.Forms.Label labelTestEvent;
        private System.Windows.Forms.Label labelExamineeID;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Label labelScore;
    }
}