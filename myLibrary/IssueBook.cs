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
    public partial class IssueBook : Form
    {
        private string p;
        public IssueBook(string p)
        {
            InitializeComponent();
            this.p = p;
            label5.Text = p;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            adminDefault def = new adminDefault(label5.Text);
            this.Close();
            this.Dispose();
            def.ShowDialog();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            BusinessLayer.BAL bl = new BAL();
            if (txt_book.Text != "")
            {
                this.gridview.DataSource = bl.LoadBookData(txt_book.Text);
            }
            else if (txt_cat.Text != "")
            {
                this.gridview.DataSource = bl.LoadCatData(txt_cat.Text);
            }
            else
            {
                MessageBox.Show("Enter Book/Category Name");
            }
        }

        private void Issue_Click(object sender, EventArgs e)
        {
            if (gridview.RowCount == 0)
            {
                MessageBox.Show("Please Select any Book");
            }
            else
            {
                BusinessLayer.BAL bl = new BAL();
                int Row = gridview.CurrentRow.Index;
                string book = Convert.ToString(gridview[1, Row].Value);
                string user = label5.Text;
                int result = 0;
                result = bl.CheckBooks(user, book);
                if (result == 0)
                {
                    MessageBox.Show("You Have Already Issued 3 Books");
                }
                else if (result == 1)
                {
                    MessageBox.Show("Book Issued Successfully");
                }
                else if (result == 2)
                {
                    MessageBox.Show("User does not have sufficient Amount Left");
                }
                else if (result == 3)
                {
                    MessageBox.Show("User Already Issued Selected Book");
                }
                else
                {
                    MessageBox.Show("Error Occured, Try again Later");
                }
            }
        }
    }
}
