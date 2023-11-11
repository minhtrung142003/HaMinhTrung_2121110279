using HaMinhTrung_0279.LoginTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaMinhTrung_0279
{
    public partial class ĐangNhap : Form
    {
        public ĐangNhap()
        {
            InitializeComponent();
        }

        private void btLOGIN_Click(object sender, EventArgs e)
        {
            QueriesTableAdapter dn = new QueriesTableAdapter();
            if(dn.checklogin(txtTK.Text, txtMK.Text) == 1)
            { 
                GUI gUI = new GUI();
                gUI.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoàn hoặc mật khẩu!");
                txtTK.ResetText();
                txtMK.ResetText();
            }
        }

        private void btOUT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
