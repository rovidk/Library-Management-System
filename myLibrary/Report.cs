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
    public partial class Report : Form
    {
        private string p;
        public Report(string p)
        {
            InitializeComponent();
            this.p = p;
            label3.Text = p.ToString();
        }

        private void btn_showdata_Click(object sender, EventArgs e)
        {
            BusinessLayer.BAL bl = new BAL();
            dataGridView1.DataSource = bl.GetAllData();
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            BusinessLayer.BAL bl = new BAL();
            dataGridView2.DataSource = bl.ReadDataUser(label3.Text);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            adminDefault admin = new adminDefault(label3.Text);
            this.Dispose();
            this.Close();
            admin.ShowDialog();
        }
    }
}
