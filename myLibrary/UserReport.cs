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
    public partial class UserReport : Form
    {
        private string p;
        public UserReport(string p)
        {
            InitializeComponent();
            this.p = p;
            label3.Text = p.ToString();
        }

        private void UserReport_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_showdata_Click(object sender, EventArgs e)
        {
            BusinessLayer.BAL bl = new BAL();
            dataGridView1.DataSource = bl.GetBooksIssued();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            adminDefault admin = new adminDefault(label3.Text);
            this.Close();
            this.Dispose();
            admin.ShowDialog();
        }

        private void btn_loaduser_Click(object sender, EventArgs e)
        {
            BusinessLayer.BAL bl = new BAL();
            dataGridView2.DataSource = bl.GetSecurityAmountList(label3.Text);
        }
    }
}
