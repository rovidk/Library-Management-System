namespace myLibrary
{
    partial class addBook
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
            this.add_price = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.add_author = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.add_qnt = new System.Windows.Forms.TextBox();
            this.add_book = new System.Windows.Forms.TextBox();
            this.add_cmb = new System.Windows.Forms.ComboBox();
            this.booksCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myLibraryDataSet = new myLibrary.myLibraryDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.rem_qntrem = new System.Windows.Forms.TextBox();
            this.rem_qnt = new System.Windows.Forms.TextBox();
            this.rem_authr = new System.Windows.Forms.TextBox();
            this.rem_cat = new System.Windows.Forms.TextBox();
            this.rem_cmb = new System.Windows.Forms.ComboBox();
            this.booksRecordBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.myLibraryDataSet1 = new myLibrary.myLibraryDataSet1();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.books_CategoryTableAdapter = new myLibrary.myLibraryDataSetTableAdapters.Books_CategoryTableAdapter();
            this.booksRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.books_RecordTableAdapter = new myLibrary.BooksDatasetTableAdapters.Books_RecordTableAdapter();
            this.books_RecordTableAdapter1 = new myLibrary.myLibraryDataSet1TableAdapters.Books_RecordTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_text = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLibraryDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksRecordBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLibraryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksRecordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F);
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 24);
            this.label1.TabIndex = 50;
            this.label1.Text = "Library Management System";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.add_price);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.add_author);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.add_qnt);
            this.groupBox1.Controls.Add(this.add_book);
            this.groupBox1.Controls.Add(this.add_cmb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10F);
            this.groupBox1.Location = new System.Drawing.Point(13, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 195);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Books";
            // 
            // add_price
            // 
            this.add_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add_price.Location = new System.Drawing.Point(171, 142);
            this.add_price.Name = "add_price";
            this.add_price.Size = new System.Drawing.Size(197, 24);
            this.add_price.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Book Price";
            // 
            // add_author
            // 
            this.add_author.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add_author.Location = new System.Drawing.Point(560, 96);
            this.add_author.Name = "add_author";
            this.add_author.Size = new System.Drawing.Size(178, 24);
            this.add_author.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(453, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Author Name";
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Location = new System.Drawing.Point(640, 144);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(98, 30);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add Book";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // add_qnt
            // 
            this.add_qnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add_qnt.Location = new System.Drawing.Point(560, 54);
            this.add_qnt.Name = "add_qnt";
            this.add_qnt.Size = new System.Drawing.Size(178, 24);
            this.add_qnt.TabIndex = 4;
            // 
            // add_book
            // 
            this.add_book.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add_book.Location = new System.Drawing.Point(171, 54);
            this.add_book.Name = "add_book";
            this.add_book.Size = new System.Drawing.Size(197, 24);
            this.add_book.TabIndex = 1;
            // 
            // add_cmb
            // 
            this.add_cmb.CausesValidation = false;
            this.add_cmb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.booksCategoryBindingSource, "Id", true));
            this.add_cmb.DataSource = this.booksCategoryBindingSource;
            this.add_cmb.DisplayMember = "Category";
            this.add_cmb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_cmb.FormattingEnabled = true;
            this.add_cmb.Location = new System.Drawing.Point(171, 96);
            this.add_cmb.Name = "add_cmb";
            this.add_cmb.Size = new System.Drawing.Size(197, 23);
            this.add_cmb.TabIndex = 2;
            this.add_cmb.ValueMember = "Id";
            // 
            // booksCategoryBindingSource
            // 
            this.booksCategoryBindingSource.DataMember = "Books_Category";
            this.booksCategoryBindingSource.DataSource = this.myLibraryDataSet;
            // 
            // myLibraryDataSet
            // 
            this.myLibraryDataSet.DataSetName = "myLibraryDataSet";
            this.myLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Book Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_remove);
            this.groupBox2.Controls.Add(this.rem_qntrem);
            this.groupBox2.Controls.Add(this.rem_qnt);
            this.groupBox2.Controls.Add(this.rem_authr);
            this.groupBox2.Controls.Add(this.rem_cat);
            this.groupBox2.Controls.Add(this.rem_cmb);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 10F);
            this.groupBox2.Location = new System.Drawing.Point(12, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 221);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove Book";
            // 
            // btn_remove
            // 
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_remove.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_remove.Location = new System.Drawing.Point(641, 144);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(98, 31);
            this.btn_remove.TabIndex = 5;
            this.btn_remove.Text = "Remove Book";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // rem_qntrem
            // 
            this.rem_qntrem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rem_qntrem.Font = new System.Drawing.Font("Calibri", 10F);
            this.rem_qntrem.Location = new System.Drawing.Point(607, 86);
            this.rem_qntrem.Name = "rem_qntrem";
            this.rem_qntrem.Size = new System.Drawing.Size(132, 24);
            this.rem_qntrem.TabIndex = 4;
            // 
            // rem_qnt
            // 
            this.rem_qnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rem_qnt.Enabled = false;
            this.rem_qnt.Font = new System.Drawing.Font("Calibri", 10F);
            this.rem_qnt.Location = new System.Drawing.Point(607, 37);
            this.rem_qnt.Name = "rem_qnt";
            this.rem_qnt.Size = new System.Drawing.Size(132, 24);
            this.rem_qnt.TabIndex = 0;
            // 
            // rem_authr
            // 
            this.rem_authr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rem_authr.Enabled = false;
            this.rem_authr.Font = new System.Drawing.Font("Calibri", 10F);
            this.rem_authr.Location = new System.Drawing.Point(172, 142);
            this.rem_authr.Name = "rem_authr";
            this.rem_authr.Size = new System.Drawing.Size(197, 24);
            this.rem_authr.TabIndex = 0;
            // 
            // rem_cat
            // 
            this.rem_cat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rem_cat.Enabled = false;
            this.rem_cat.Font = new System.Drawing.Font("Calibri", 10F);
            this.rem_cat.Location = new System.Drawing.Point(172, 86);
            this.rem_cat.Name = "rem_cat";
            this.rem_cat.Size = new System.Drawing.Size(197, 24);
            this.rem_cat.TabIndex = 0;
            // 
            // rem_cmb
            // 
            this.rem_cmb.CausesValidation = false;
            this.rem_cmb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.booksRecordBindingSource1, "Book", true));
            this.rem_cmb.DataSource = this.booksRecordBindingSource1;
            this.rem_cmb.DisplayMember = "Book";
            this.rem_cmb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rem_cmb.Font = new System.Drawing.Font("Calibri", 10F);
            this.rem_cmb.FormattingEnabled = true;
            this.rem_cmb.Location = new System.Drawing.Point(172, 37);
            this.rem_cmb.Name = "rem_cmb";
            this.rem_cmb.Size = new System.Drawing.Size(197, 23);
            this.rem_cmb.TabIndex = 3;
            this.rem_cmb.ValueMember = "Book";
            this.rem_cmb.SelectedIndexChanged += new System.EventHandler(this.rem_cmb_SelectedIndexChanged);
            // 
            // booksRecordBindingSource1
            // 
            this.booksRecordBindingSource1.DataMember = "Books_Record";
            this.booksRecordBindingSource1.DataSource = this.myLibraryDataSet1;
            // 
            // myLibraryDataSet1
            // 
            this.myLibraryDataSet1.DataSetName = "myLibraryDataSet1";
            this.myLibraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10F);
            this.label11.Location = new System.Drawing.Point(454, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Quantity to be Removed";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 10F);
            this.label10.Location = new System.Drawing.Point(454, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Quantity Available";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10F);
            this.label9.Location = new System.Drawing.Point(38, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Author Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10F);
            this.label7.Location = new System.Drawing.Point(38, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Category Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F);
            this.label6.Location = new System.Drawing.Point(38, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Book Name";
            // 
            // btn_exit
            // 
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_exit.Location = new System.Drawing.Point(673, 521);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(78, 29);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // books_CategoryTableAdapter
            // 
            this.books_CategoryTableAdapter.ClearBeforeFill = true;
            // 
            // books_RecordTableAdapter
            // 
            this.books_RecordTableAdapter.ClearBeforeFill = true;
            // 
            // books_RecordTableAdapter1
            // 
            this.books_RecordTableAdapter1.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F);
            this.label5.Location = new System.Drawing.Point(17, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "Welcome";
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.Location = new System.Drawing.Point(79, 48);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(41, 13);
            this.lbl_text.TabIndex = 52;
            this.lbl_text.Text = "label13";
            // 
            // addBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lbl_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "addBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Remove Books - Library Management System";
            this.Load += new System.EventHandler(this.addBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLibraryDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksRecordBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLibraryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksRecordBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox add_qnt;
        private System.Windows.Forms.TextBox add_book;
        private System.Windows.Forms.ComboBox add_cmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox add_author;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox rem_qntrem;
        private System.Windows.Forms.TextBox rem_qnt;
        private System.Windows.Forms.TextBox rem_authr;
        private System.Windows.Forms.TextBox rem_cat;
        private System.Windows.Forms.ComboBox rem_cmb;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox add_price;
        private System.Windows.Forms.Label label12;
        private myLibraryDataSet myLibraryDataSet;
        private System.Windows.Forms.BindingSource booksCategoryBindingSource;
        private myLibraryDataSetTableAdapters.Books_CategoryTableAdapter books_CategoryTableAdapter;
        private System.Windows.Forms.BindingSource booksRecordBindingSource;
        private BooksDatasetTableAdapters.Books_RecordTableAdapter books_RecordTableAdapter;
        private myLibraryDataSet1 myLibraryDataSet1;
        private System.Windows.Forms.BindingSource booksRecordBindingSource1;
        private myLibraryDataSet1TableAdapters.Books_RecordTableAdapter books_RecordTableAdapter1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_text;
    }
}