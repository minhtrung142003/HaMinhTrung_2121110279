using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HaMinhTrung_0279.BLL;
using HaMinhTrung_0279.DTO;
namespace HaMinhTrung_0279
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }
        private void btThem_Click(object sender, EventArgs e)
        {
        
            int masv = int.Parse(txtId.Text);
            string tensv = txtTen.Text;
            DateTime ngays = dateNS.Value;
            string diachi = txtdiachi.Text;
            float diem = float.Parse(txtdiem.Text);
            string xeploai = txtxeploai.Text;
            tblSinhVien sinhvien = new tblSinhVien(masv, tensv, ngays, diachi, diem, xeploai);
            B_SinhVien.InsertSinhVien(sinhvien);
            MessageBox.Show("Bạn đã thêm" + "" + " " + tensv + " " + "" + "thành công");
            dgvSinhVien.DataSource = B_SinhVien.GetAllSinhVien();
           
        }
        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvSinhVien.DataSource = B_SinhVien.GetAllSinhVien();
        }

        private void dateNS_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvSinhVien.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtTen.Text = row.Cells[1].Value.ToString();
                dateNS.Text = row.Cells[2].Value.ToString();
                txtdiachi.Text = row.Cells[3].Value.ToString();
                txtdiem.Text = row.Cells[4].Value.ToString();
                txtxeploai.Text = row.Cells[5].Value.ToString();
            }
            catch { }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                int masv = int.Parse(txtId.Text);
                string tensv = txtTen.Text;
                DateTime ngays = dateNS.Value;
                string diachi = txtdiachi.Text;
                float diem = float.Parse(txtdiem.Text);
                string xeploai = txtxeploai.Text;
                tblSinhVien sinhvien = new tblSinhVien(masv, tensv, ngays, diachi, diem, xeploai);
                B_SinhVien.UpdateSinhVien(sinhvien);
                MessageBox.Show("Bạn đã sửa" + " " + tensv + " " + "thành công");
                dgvSinhVien.DataSource = B_SinhVien.GetAllSinhVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int masv = int.Parse(txtId.Text);
                string tensv = txtTen.Text;
                DateTime ngays = dateNS.Value;
                string diachi = txtdiachi.Text;
                float diem = float.Parse(txtdiem.Text);
                string xeploai = txtxeploai.Text;
                tblSinhVien sinhvien = new tblSinhVien(masv, tensv, ngays, diachi, diem, xeploai);
                B_SinhVien.DeleteSinhVien(masv);
                MessageBox.Show("Bạn đã xóa" + "" + tensv + " " + "thành công");
                dgvSinhVien.DataSource = B_SinhVien.GetAllSinhVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

