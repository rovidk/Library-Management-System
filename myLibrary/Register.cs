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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (txt_uname.Text == "" || txt_pwd.Text == "" || txt_cpwd.Text == "")
            {
                MessageBox.Show("Please fill all details");
            }
            else if(txt_pwd.Text != txt_cpwd.Text)
            {
                MessageBox.Show("Password Does not Match");
                txt_pwd.Text = string.Empty;
                txt_cpwd.Text = string.Empty;
            }
            else
            {
                BusinessLayer.BAL bl = new BAL();
                int result = bl.User_Register(txt_uname.Text, txt_pwd.Text);
                if (result == 0 || txt_uname.Text == "Administrator" || txt_uname.Text == "admin" || txt_uname.Text == "administrator")
                {
                    MessageBox.Show("Cannot create Administrator Account");
                }
                else if (result == 1)
                {
                    MessageBox.Show("You have Successfully Registered and get an Rs.1000 Security Amount for issuing book");
                    this.Close();
                    //txt_uname.Text = string.Empty;
                    //txt_pwd.Text = string.Empty;
                    //txt_cpwd.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("User Already Registered! Try another username");
                }
            }
        }
    }
}
