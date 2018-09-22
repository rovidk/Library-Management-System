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
    public partial class RechargeUserAccount : Form
    {
        private string p;
        public RechargeUserAccount(string p)
        {
            InitializeComponent();
            this.p = p;
            label3.Text = p.ToString();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            adminDefault admin = new adminDefault(label3.Text);
            this.Close();
            this.Dispose();
            admin.ShowDialog();
        }

        private void btn_listusers_Click(object sender, EventArgs e)
        {
            BusinessLayer.BAL bl = new BAL();
            dataGridView1.DataSource = bl.GetUsersAmount();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_amount.Text == null ||txt_amount.Text == "")
            {
                MessageBox.Show("Please Enter Amount to Add");
            }
            else
            {
                if (dataGridView1.RowCount == 0)
                {
                    MessageBox.Show("Please Select User to Add");
                    txt_amount.Text = string.Empty;
                }
                else
                {
                    int row = dataGridView1.CurrentRow.Index;
                    string user = Convert.ToString(dataGridView1[1, row].Value);
                    int amount = Convert.ToInt32(txt_amount.Text);
                    BusinessLayer.BAL bl = new BAL();
                    int result = 0;
                    result = bl.AddUserAmount(user, amount);
                    if (result > 0)
                    {
                        MessageBox.Show("Amount Added Successfully");
                        txt_amount.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Error Occured! Try After Sometime");
                        txt_amount.Text = string.Empty;
                    }
                }
            }
        }
    }
}
