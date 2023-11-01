using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
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
        // hàm nhập số không được nhập chữ
        private bool IsNumeric(string value)
        {
            return long.TryParse(value, out long _);
        }

        // Hàm nhập id đã tồn tại
        private bool IsDuplicateID(string id)
        {
            foreach (DataGridViewRow row in dgvSinhVien.Rows)
            {
                if (row.Cells["Column1"].Value != null && row.Cells["Column1"].Value.ToString() == id)
                {
                    return true;
                }
            }
            return false;
        }

        // Thêm
        private void btThem_Click(object sender, EventArgs e)
        {
            if (!IsNumeric(txtId.Text))
            {
                MessageBox.Show("Vui lòng nhập lại ID");
                return;
            }
            if (IsDuplicateID(txtId.Text))
            {
                MessageBox.Show("ID đã tồn tại. Vui lòng nhập ID khác.");
                return;
            }
            try
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
         }
        // Load
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doAnMonHocDataSet1.THONGTINSINHVIEN' table. You can move, or remove it, as needed.
            this.tHONGTINSINHVIENTableAdapter1.Fill(this.doAnMonHocDataSet1.THONGTINSINHVIEN);
            dgvSinhVien.DataSource = B_SinhVien.GetAllSinhVien();
           
            
        }

        // hàm khi click vào sẽ hiển thị được thông tin 
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

        // Sửa
        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSinhVien.SelectedRows.Count > 0)
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
                else
                {
                    MessageBox.Show("Chọn một sinh viên để sửa.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Xóa
        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSinhVien.SelectedRows.Count > 0)
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
                else
                {
                    MessageBox.Show("Chọn một sinh viên để xóa.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Reset
        private void btReset_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtTen.Text = "";
            dateNS.Value = DateTime.Now;
            txtdiachi.Text = "";
            txtdiem.Text = "";
            txtxeploai.Text = "";
        }

        // Thoát
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtdiem_TextChanged(object sender, EventArgs e)
        {
            if (!txtdiem.Text.All(Char.IsDigit))
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Vui lòng nhập lại Điểm");
                // Đặt focus vào ô tên
                txtdiem.Focus();
            }
        }

        private void btexport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter ="Excel Workbook|*.xlsx" })
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using(XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(this.doAnMonHocDataSet1.THONGTINSINHVIEN.CopyToDataTable(), "THONGTINSINHVIEN");
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("You have successfully exported your data to an excel file.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch( Exception ex) 
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
        }
    }
}

