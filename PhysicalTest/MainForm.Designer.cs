namespace PhysicalTest
{
    partial class MainForm
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
            this.buttonTestEventRegister = new System.Windows.Forms.Button();
            this.buttonExamineeList = new System.Windows.Forms.Button();
            this.buttonTestResultList = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTestEventRegister
            // 
            this.buttonTestEventRegister.Location = new System.Drawing.Point(26, 36);
            this.buttonTestEventRegister.Name = "buttonTestEventRegister";
            this.buttonTestEventRegister.Size = new System.Drawing.Size(75, 23);
            this.buttonTestEventRegister.TabIndex = 0;
            this.buttonTestEventRegister.Text = "種目管理";
            this.buttonTestEventRegister.UseVisualStyleBackColor = true;
            this.buttonTestEventRegister.Click += new System.EventHandler(this.buttonTestEventRegister_Click);
            // 
            // buttonExamineeList
            // 
            this.buttonExamineeList.Location = new System.Drawing.Point(139, 36);
            this.buttonExamineeList.Name = "buttonExamineeList";
            this.buttonExamineeList.Size = new System.Drawing.Size(75, 23);
            this.buttonExamineeList.TabIndex = 1;
            this.buttonExamineeList.Text = "受験者管理";
            this.buttonExamineeList.UseVisualStyleBackColor = true;
            this.buttonExamineeList.Click += new System.EventHandler(this.buttonExamineeList_Click);
            // 
            // buttonTestResultList
            // 
            this.buttonTestResultList.Location = new System.Drawing.Point(253, 36);
            this.buttonTestResultList.Name = "buttonTestResultList";
            this.buttonTestResultList.Size = new System.Drawing.Size(75, 23);
            this.buttonTestResultList.TabIndex = 1;
            this.buttonTestResultList.Text = "結果管理";
            this.buttonTestResultList.UseVisualStyleBackColor = true;
            this.buttonTestResultList.Click += new System.EventHandler(this.buttonTestResult_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(26, 192);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "終了";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 261);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonTestResultList);
            this.Controls.Add(this.buttonExamineeList);
            this.Controls.Add(this.buttonTestEventRegister);
            this.Name = "MainForm";
            this.Text = "体力テスト管理システム";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTestEventRegister;
        private System.Windows.Forms.Button buttonExamineeList;
        private System.Windows.Forms.Button buttonTestResultList;
        private System.Windows.Forms.Button buttonClose;
    }
}

