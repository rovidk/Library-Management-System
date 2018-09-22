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
    public partial class addCategory : Form
    {
        public addCategory()
        {
            InitializeComponent();
            try
            {
                cmbobox.DataSource = LoadData();
                cmbobox.DisplayMember = LoadData().Columns["Id"].ToString();
            }
            catch
            {
                MessageBox.Show("Cannot Load");
            }
        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (txt_cat.Text == "")
            {
                MessageBox.Show("Please enter Category");
            }
            else
            {
                BusinessLayer.BAL bl = new BAL();
                int result = 0;
                result = bl.AddCategory(txt_cat.Text);
                if (result > 0)
                {
                    MessageBox.Show("Category Succefully Added");
                    txt_cat.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Already present Category");
                }
            }
        }
        private void btn_remove_Click(object sender, EventArgs e)
        {
            BusinessLayer.BAL bl = new BAL();
            int result = bl.RemCategory(Convert.ToInt32(cmbobox.Text));
            if (result > 0)
            {
                MessageBox.Show("Category Removed");
            }
            else
            {
                MessageBox.Show("Cannot Removed");
            }
        }
        public DataTable LoadData()
        {
            BusinessLayer.BAL bl = new BAL();
            DataTable dt;
            dt = bl.LoadCategory();
            return dt;
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            Login log = new Login();
            log.ShowDialog();
        }
        private void btn_load_Click(object sender, EventArgs e)
        {
            BusinessLayer.BAL bl = new BAL();
            this.dataGridView1.DataSource = bl.LoadCategory();
        }
    }
}
