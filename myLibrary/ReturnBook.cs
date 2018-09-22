using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using myLibrary.BusinessLayer;

namespace myLibrary
{
    public partial class ReturnBook : Form
    {
        private string p;
        public ReturnBook(string p)
        {
            InitializeComponent();
            this.p = p;
            label3.Text = p.ToString();
        }
        private void btn_return_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Please select any book to return");
            }
            else
            {
                BusinessLayer.BAL bl = new BAL();
                int result = 0;
                result = bl.ReturnBook(comboBox1.SelectedValue.ToString(), label3.Text);
                if (result == 1)
                {
                    MessageBox.Show("Book Return Successfully");
                    adminDefault admin = new adminDefault(label3.Text);
                    this.Close();
                    this.Dispose();
                    admin.ShowDialog();
                }
                else if (result == 0)
                {
                    MessageBox.Show("This Book is not Issued To User");
                    adminDefault admin = new adminDefault(label3.Text);
                    this.Close();
                    this.Dispose();
                    admin.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Try After Sometime.");
                    adminDefault admin = new adminDefault(label3.Text);
                    this.Close();
                    this.Dispose();
                    admin.ShowDialog();
                }
            }
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Does not issue book");
            }
            else
            {
                BusinessLayer.BAL bl = new BAL();
                DataTable dt = bl.LoadBookData(comboBox1.SelectedValue.ToString());
                txt_auth.Text = dt.Rows[0][3].ToString();
                txt_cat.Text = dt.Rows[0][2].ToString();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            adminDefault def = new adminDefault(label3.Text);
            this.Close();
            this.Dispose();
            def.ShowDialog();
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myLibraryDataSet2.Books_Issue' table. You can move, or remove it, as needed.
            this.books_IssueTableAdapter.Fill(this.myLibraryDataSet2.Books_Issue);
            this.books_IssueTableAdapter.FillBy(this.myLibraryDataSet2.Books_Issue, label3.Text);
        }
    }
}
