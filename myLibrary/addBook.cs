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
    public partial class addBook : Form
    {
        private string p;
        public addBook(string p)
        {
            InitializeComponent();
            this.p = p;
            lbl_text.Text = p.ToString();
        }
        private void addBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myLibraryDataSet1.Books_Record' table. You can move, or remove it, as needed.
            this.books_RecordTableAdapter1.Fill(this.myLibraryDataSet1.Books_Record);
            // TODO: This line of code loads data into the 'myLibraryDataSet.Books_Category' table. You can move, or remove it, as needed.
            this.books_CategoryTableAdapter.Fill(this.myLibraryDataSet.Books_Category);
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (add_book.Text == "" || add_author.Text == "" || add_price.Text == "" || add_qnt.Text == "")
            {
                MessageBox.Show("Please Enter all Details Properly");
            }
            else
            {
                Login log = new Login();
                BusinessLayer.BAL bl = new BAL();
                int result = 0;
                result = bl.AddBook(add_book.Text, Convert.ToInt32(add_cmb.SelectedValue), Convert.ToDecimal(add_price.Text), add_qnt.Text, add_author.Text);
                if (result > 0)
                {
                    MessageBox.Show("Book Added Successfully");
                    adminDefault admin = new adminDefault(lbl_text.Text);
                    this.Hide();
                    admin.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Book Already Present");
                }
                
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            adminDefault admin = new adminDefault(lbl_text.Text);
            BusinessLayer.BAL bl = new BAL();
            int result = 0;
            result = bl.RemoveBook(rem_cmb.SelectedValue.ToString(), Convert.ToInt32(rem_qntrem.Text));
            if (result > 0)
            {
                MessageBox.Show("Selected Quantity Removed");
                this.Hide();
                admin.ShowDialog();
            }
            else if (result == 0)
            {
                MessageBox.Show("Books Removed");
                this.Hide();
                admin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Quantity is more than available");
            }
        }

        private void rem_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            BusinessLayer.BAL bl = new BAL();
            DataTable dt = bl.LoadBookData(rem_cmb.SelectedValue.ToString());
            rem_cat.Text = dt.Rows[0][2].ToString();
            rem_authr.Text = dt.Rows[0][3].ToString();
            rem_qnt.Text = dt.Rows[0][4].ToString();
            
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            adminDefault admin = new adminDefault(lbl_text.Text);
            this.Hide();
            admin.ShowDialog();
        }

    }
}
