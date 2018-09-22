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
    public partial class ChangePassword : Form
    {
        private string p;
        public ChangePassword(string p)
        {
            InitializeComponent();
            this.p = p;
            label6.Text = p;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            adminDefault admin = new adminDefault(label6.Text);
            this.Close();
            this.Dispose();
            admin.ShowDialog();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_newpwd.Text = string.Empty;
            txt_cfmpwd.Text = string.Empty;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (txt_newpwd.Text == "" || txt_cfmpwd.Text == "")
            {
                MessageBox.Show("Please Enter Password");
            }
            else if (txt_newpwd.Text.Length < 6 || txt_cfmpwd.Text.Length < 6)
            {
                MessageBox.Show("Please Enter Minimum 6 Length Password");
                txt_newpwd.Text = string.Empty;
                txt_cfmpwd.Text = string.Empty;
            }
            else if (txt_newpwd.Text != txt_cfmpwd.Text)
            {
                MessageBox.Show("Password Does not match");
                txt_newpwd.Text = string.Empty;
                txt_cfmpwd.Text = string.Empty;
            }
            else
            {
                BusinessLayer.BAL bl = new BAL();
                int result = 0;
                result = bl.UpdateRecord(label6.Text, txt_newpwd.Text);
                if (result > 0)
                {
                    MessageBox.Show("User Password Changed");
                    txt_newpwd.Text = string.Empty;
                    txt_cfmpwd.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Password Cannot Change");
                }
            }
        }
    }
}
