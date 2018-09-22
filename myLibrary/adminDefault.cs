using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace myLibrary
{
    public partial class adminDefault : Form
    {
        private string p;
        public adminDefault(string p)
        {
            InitializeComponent();
            this.p = p;
            label3.Text = p;
            if (label3.Text != "admin")
            {
                rbtn_addcat.Enabled = false;
                rbtn_addbook.Enabled = false;
                rbtn_userrpt.Enabled = false;
                rbtn_recharge.Enabled = false;
            }
        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (rbtn_addbook.Checked)
            {
                addBook book = new addBook(label3.Text);
                this.Dispose();
                this.Close();
                book.ShowDialog();
            }
            else if (rbtn_addcat.Checked)
            {
                addCategory cat = new addCategory();
                this.Dispose();
                this.Close();
                cat.ShowDialog();
            }
            else if (rbtn_issue.Checked)
            {
                IssueBook issue = new IssueBook(label3.Text);
                this.Dispose();
                this.Close();
                issue.ShowDialog();
            }
            else if (rbtn_retbook.Checked)
            {
                ReturnBook retbook = new ReturnBook(label3.Text);
                this.Dispose();
                this.Close();
                retbook.ShowDialog();
            }
            else if (rbtn_rpt.Checked)
            {
                Report rpt = new Report(label3.Text);
                this.Dispose();
                this.Close();
                rpt.ShowDialog();
            }
            else if (rbtn_chpwd.Checked)
            {
                ChangePassword chpwd = new ChangePassword(label3.Text);
                this.Dispose();
                this.Close();
                chpwd.ShowDialog();
            }
            else if (rbtn_userrpt.Checked)
            {
                UserReport usrpt = new UserReport(label3.Text);
                this.Dispose();
                this.Close();
                usrpt.ShowDialog();
            }
            else if (rbtn_recharge.Checked)
            {
                RechargeUserAccount rchg = new RechargeUserAccount(label3.Text);
                this.Dispose();
                this.Close();
                rchg.ShowDialog();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Close();
            this.Dispose();
            log.ShowDialog();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Login form = new Login();
            form.ShowDialog();
        }

    }
}
