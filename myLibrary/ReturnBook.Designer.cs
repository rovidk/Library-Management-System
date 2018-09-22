namespace myLibrary
{
    partial class ReturnBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_auth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.booksIssueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myLibraryDataSet2 = new myLibrary.myLibraryDataSet2();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.books_IssueTableAdapter = new myLibrary.myLibraryDataSet2TableAdapters.Books_IssueTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksIssueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLibraryDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F);
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Management Software";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.txt_auth);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_cat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10F);
            this.groupBox1.Location = new System.Drawing.Point(13, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 313);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Return Books";
            // 
            // btn_search
            // 
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_search.Location = new System.Drawing.Point(427, 96);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(89, 30);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_auth
            // 
            this.txt_auth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_auth.Enabled = false;
            this.txt_auth.Location = new System.Drawing.Point(299, 229);
            this.txt_auth.Name = "txt_auth";
            this.txt_auth.Size = new System.Drawing.Size(217, 24);
            this.txt_auth.TabIndex = 0;
            this.txt_auth.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Author Name";
            // 
            // txt_cat
            // 
            this.txt_cat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cat.Enabled = false;
            this.txt_cat.Location = new System.Drawing.Point(299, 162);
            this.txt_cat.Name = "txt_cat";
            this.txt_cat.Size = new System.Drawing.Size(217, 24);
            this.txt_cat.TabIndex = 0;
            this.txt_cat.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Book Category";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.booksIssueBindingSource, "Bookname", true));
            this.comboBox1.DataSource = this.booksIssueBindingSource;
            this.comboBox1.DisplayMember = "Bookname";
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(299, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Bookname";
            // 
            // booksIssueBindingSource
            // 
            this.booksIssueBindingSource.DataMember = "Books_Issue";
            this.booksIssueBindingSource.DataSource = this.myLibraryDataSet2;
            // 
            // myLibraryDataSet2
            // 
            this.myLibraryDataSet2.DataSetName = "myLibraryDataSet2";
            this.myLibraryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Select Book to be Return";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F);
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // btn_exit
            // 
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_exit.Location = new System.Drawing.Point(444, 429);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(85, 30);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_return
            // 
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_return.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_return.Location = new System.Drawing.Point(117, 429);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(119, 30);
            this.btn_return.TabIndex = 2;
            this.btn_return.Text = "Return Book";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // books_IssueTableAdapter
            // 
            this.books_IssueTableAdapter.ClearBeforeFill = true;
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 526);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(664, 564);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(664, 564);
            this.Name = "ReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return Issued Books - Library Management System";
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksIssueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLibraryDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_auth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_search;
        private myLibraryDataSet2 myLibraryDataSet2;
        private System.Windows.Forms.BindingSource booksIssueBindingSource;
        private myLibraryDataSet2TableAdapters.Books_IssueTableAdapter books_IssueTableAdapter;
    }
}