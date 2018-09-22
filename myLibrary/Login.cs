using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;
using myLibrary.BusinessLayer;

namespace myLibrary
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            BusinessLayer.BAL bl = new BAL();
            int result = 0;
            result = bl.Validate_login(txt_uname.Text, txt_pwd.Text);
            if (result > 0)
            {
                adminDefault admin = new adminDefault(txt_uname.Text);
                admin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username/Password does not match");
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
        }
    }
}
