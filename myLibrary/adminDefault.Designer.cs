namespace myLibrary
{
    partial class adminDefault
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtn_addbook = new System.Windows.Forms.RadioButton();
            this.rbtn_addcat = new System.Windows.Forms.RadioButton();
            this.rbtn_issue = new System.Windows.Forms.RadioButton();
            this.rbtn_retbook = new System.Windows.Forms.RadioButton();
            this.rbtn_rpt = new System.Windows.Forms.RadioButton();
            this.rbtn_chpwd = new System.Windows.Forms.RadioButton();
            this.btn_submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.rbtn_userrpt = new System.Windows.Forms.RadioButton();
            this.rbtn_recharge = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 18F);
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(232, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome";
            // 
            // rbtn_addbook
            // 
            this.rbtn_addbook.AutoSize = true;
            this.rbtn_addbook.Font = new System.Drawing.Font("Calibri", 13F);
            this.rbtn_addbook.Location = new System.Drawing.Point(81, 152);
            this.rbtn_addbook.Name = "rbtn_addbook";
            this.rbtn_addbook.Size = new System.Drawing.Size(172, 26);
            this.rbtn_addbook.TabIndex = 1;
            this.rbtn_addbook.TabStop = true;
            this.rbtn_addbook.Text = "Add/Remove Books";
            this.rbtn_addbook.UseVisualStyleBackColor = true;
            // 
            // rbtn_addcat
            // 
            this.rbtn_addcat.AutoSize = true;
            this.rbtn_addcat.Font = new System.Drawing.Font("Calibri", 13F);
            this.rbtn_addcat.Location = new System.Drawing.Point(382, 152);
            this.rbtn_addcat.Name = "rbtn_addcat";
            this.rbtn_addcat.Size = new System.Drawing.Size(205, 26);
            this.rbtn_addcat.TabIndex = 2;
            this.rbtn_addcat.TabStop = true;
            this.rbtn_addcat.Text = "Add/Remove Categories";
            this.rbtn_addcat.UseVisualStyleBackColor = true;
            // 
            // rbtn_issue
            // 
            this.rbtn_issue.AutoSize = true;
            this.rbtn_issue.Font = new System.Drawing.Font("Calibri", 13F);
            this.rbtn_issue.Location = new System.Drawing.Point(81, 223);
            this.rbtn_issue.Name = "rbtn_issue";
            this.rbtn_issue.Size = new System.Drawing.Size(170, 26);
            this.rbtn_issue.TabIndex = 3;
            this.rbtn_issue.TabStop = true;
            this.rbtn_issue.Text = "Search/Issue Books";
            this.rbtn_issue.UseVisualStyleBackColor = true;
            // 
            // rbtn_retbook
            // 
            this.rbtn_retbook.AutoSize = true;
            this.rbtn_retbook.Font = new System.Drawing.Font("Calibri", 13F);
            this.rbtn_retbook.Location = new System.Drawing.Point(383, 223);
            this.rbtn_retbook.Name = "rbtn_retbook";
            this.rbtn_retbook.Size = new System.Drawing.Size(126, 26);
            this.rbtn_retbook.TabIndex = 4;
            this.rbtn_retbook.TabStop = true;
            this.rbtn_retbook.Text = "Return Books";
            this.rbtn_retbook.UseVisualStyleBackColor = true;
            // 
            // rbtn_rpt
            // 
            this.rbtn_rpt.AutoSize = true;
            this.rbtn_rpt.Font = new System.Drawing.Font("Calibri", 13F);
            this.rbtn_rpt.Location = new System.Drawing.Point(81, 294);
            this.rbtn_rpt.Name = "rbtn_rpt";
            this.rbtn_rpt.Size = new System.Drawing.Size(125, 26);
            this.rbtn_rpt.TabIndex = 5;
            this.rbtn_rpt.TabStop = true;
            this.rbtn_rpt.Text = "View Reports";
            this.rbtn_rpt.UseVisualStyleBackColor = true;
            // 
            // rbtn_chpwd
            // 
            this.rbtn_chpwd.AutoSize = true;
            this.rbtn_chpwd.Font = new System.Drawing.Font("Calibri", 13F);
            this.rbtn_chpwd.Location = new System.Drawing.Point(383, 294);
            this.rbtn_chpwd.Name = "rbtn_chpwd";
            this.rbtn_chpwd.Size = new System.Drawing.Size(156, 26);
            this.rbtn_chpwd.TabIndex = 6;
            this.rbtn_chpwd.TabStop = true;
            this.rbtn_chpwd.Text = "Change Password";
            this.rbtn_chpwd.UseVisualStyleBackColor = true;
            // 
            // btn_submit
            // 
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_submit.Font = new System.Drawing.Font("Calibri", 12F);
            this.btn_submit.Location = new System.Drawing.Point(118, 441);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(88, 30);
            this.btn_submit.TabIndex = 8;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13F);
            this.label3.Location = new System.Drawing.Point(331, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 22);
            this.label3.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Font = new System.Drawing.Font("Calibri", 12F);
            this.btn_exit.Location = new System.Drawing.Point(427, 441);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(81, 30);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "LogOut";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Font = new System.Drawing.Font("Calibri", 12F);
            this.btn_cancel.Location = new System.Drawing.Point(277, 441);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(82, 30);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // rbtn_userrpt
            // 
            this.rbtn_userrpt.AutoSize = true;
            this.rbtn_userrpt.Font = new System.Drawing.Font("Calibri", 13F);
            this.rbtn_userrpt.Location = new System.Drawing.Point(81, 362);
            this.rbtn_userrpt.Name = "rbtn_userrpt";
            this.rbtn_userrpt.Size = new System.Drawing.Size(130, 26);
            this.rbtn_userrpt.TabIndex = 7;
            this.rbtn_userrpt.TabStop = true;
            this.rbtn_userrpt.Text = "Users Reports";
            this.rbtn_userrpt.UseVisualStyleBackColor = true;
            // 
            // rbtn_recharge
            // 
            this.rbtn_recharge.AutoSize = true;
            this.rbtn_recharge.Font = new System.Drawing.Font("Calibri", 13F);
            this.rbtn_recharge.Location = new System.Drawing.Point(383, 362);
            this.rbtn_recharge.Name = "rbtn_recharge";
            this.rbtn_recharge.Size = new System.Drawing.Size(205, 26);
            this.rbtn_recharge.TabIndex = 11;
            this.rbtn_recharge.TabStop = true;
            this.rbtn_recharge.Text = "Recharge Users Account";
            this.rbtn_recharge.UseVisualStyleBackColor = true;
            // 
            // adminDefault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 526);
            this.Controls.Add(this.rbtn_recharge);
            this.Controls.Add(this.rbtn_userrpt);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.rbtn_chpwd);
            this.Controls.Add(this.rbtn_rpt);
            this.Controls.Add(this.rbtn_retbook);
            this.Controls.Add(this.rbtn_issue);
            this.Controls.Add(this.rbtn_addcat);
            this.Controls.Add(this.rbtn_addbook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(664, 564);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(664, 564);
            this.Name = "adminDefault";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page - Library Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtn_addbook;
        private System.Windows.Forms.RadioButton rbtn_addcat;
        private System.Windows.Forms.RadioButton rbtn_issue;
        private System.Windows.Forms.RadioButton rbtn_retbook;
        private System.Windows.Forms.RadioButton rbtn_rpt;
        private System.Windows.Forms.RadioButton rbtn_chpwd;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.RadioButton rbtn_userrpt;
        private System.Windows.Forms.RadioButton rbtn_recharge;
    }
}