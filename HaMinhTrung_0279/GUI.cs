using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HaMinhTrung_0279.BLL;
using HaMinhTrung_0279.DTO;
using System.IO;
using excel = Microsoft.Office.Interop.Excel;
using HaMinhTrung_0279.DAL;
using OfficeOpenXml;

namespace HaMinhTrung_0279
{
    public partial class GUI : Form
    {
        
        public GUI()
        {
            InitializeComponent();
                
        }
        Modify modify = new Modify();
       DataTable dt = new DataTable("THONGTINSINHVIEN");
       SqlConnection con;
     
        

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
        private bool CheckTextBoxes()
        {
            if (txtId.Text == "") { MessageBox.Show("Vui lòng nhập đầy đủ thông tin."); return false; }
            if (txtTen.Text == "") { MessageBox.Show("Vui lòng nhập tên."); return false; }
            if (txtdiachi.Text == "") { MessageBox.Show("Vui lòng nhập địa chỉ."); return false; }
            if (txtdiem.Text == "") { MessageBox.Show("Vui lòng nhập điểm."); return false; }
            return true;
        }
        private void btThem_Click(object sender, EventArgs e)
        {
          
            if (IsDuplicateID(txtId.Text))
            {
                MessageBox.Show("ID đã tồn tại. Vui lòng nhập ID khác.");
                return;
            }
            try
            {
                if (CheckTextBoxes())
                {
                    int masv = int.Parse(txtId.Text);
                    string tensv = txtTen.Text;
                    DateTime ngays = dateNS.Value;
                    string diachi = txtdiachi.Text;
                    float diem = float.Parse(txtdiem.Text);
                    string xeploai = txtxeploai.Text;
                    tblSinhVien sinhvien = new tblSinhVien(masv, tensv, ngays, diachi, diem, xeploai);
                    if (MessageBox.Show("Bạn muốn thêm vào không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        B_SinhVien.InsertSinhVien(sinhvien);
                        MessageBox.Show("Bạn đã thêm" + "" + " " + tensv + " " + "" + "thành công");
                        dgvSinhVien.DataSource = B_SinhVien.GetAllSinhVien();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
         }
        // Load
        private void Form1_Load(object sender, EventArgs e)
        {
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

                    // Kiểm tra nếu người dùng đã sửa trường ID
                    if (masv != int.Parse(dgvSinhVien.SelectedRows[0].Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("Không được sửa ID của sinh viên.");
                        return;
                    }

                    string tensv = txtTen.Text;
                    DateTime ngays = dateNS.Value;
                    string diachi = txtdiachi.Text;
                    float diem = float.Parse(txtdiem.Text);
                    string xeploai = txtxeploai.Text;
                    tblSinhVien sinhvien = new tblSinhVien(masv, tensv, ngays, diachi, diem, xeploai);
                    B_SinhVien.UpdateSinhVien(sinhvien); // gọi phương thức update từ class b_sinhvien
                    MessageBox.Show("Bạn đã sửa" + " " + tensv + " " + "thành công");
                    dgvSinhVien.DataSource = B_SinhVien.GetAllSinhVien(); // gán dữ liệu cho thuộc tính datasource
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
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        B_SinhVien.DeleteSinhVien(masv);
                        MessageBox.Show("Bạn đã xóa " + tensv + " thành công");
                        dgvSinhVien.DataSource = B_SinhVien.GetAllSinhVien();
                    }
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

        // HÀM chỉ được nhập số, không được nhập chữ
        private void txtdiem_TextChanged(object sender, EventArgs e)
        {
            float diem;
            if (!string.IsNullOrEmpty(txtdiem.Text))
            {
                if (!float.TryParse(txtdiem.Text, out diem))
                {
                    MessageBox.Show("Vui lòng nhập lại Điểm");
                    txtdiem.Focus();
                    return;
                }
            }
            else
            {
                diem = 0; // Gán giá trị mặc định nếu không có giá trị nhập vào
            }

            // Kiểm tra điều kiện
            if (diem < 0 || diem > 10)
            {
                MessageBox.Show("Vui lòng nhập lại điểm! Điểm phải nằm trong khoảng từ 0 đến 10.");
            }
        }

        // HÀM chỉ được nhập số, không được nhập chữ
        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (!txtId.Text.All(Char.IsDigit))
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Vui lòng nhập lại ID");
                // Đặt focus vào ô
                txtId.Focus();
            }
        }

        // Export excel
        // dùng để copy nội dung từ datagirdview vào clipboard 
        private void btExport_Click(object sender, EventArgs e)
        {
            
            DataObject copydata = dgvSinhVien.GetClipboardContent();
            if (copydata != null) Clipboard.SetDataObject(copydata);
            excel.Application xlapp = new excel.Application();
            xlapp.Visible = true;
            excel.Workbook xlWbook;  // khai báo biến xlWbook để đại diện cho workbook
            excel.Worksheet xlWsheet; // khai báo biến xlwsheet để đại diện cho worksheet
            object miseddata = System.Reflection.Missing.Value; // tạo 1 đối tượng miseddata và gán giá trị
            xlWbook = xlapp.Workbooks.Add(miseddata); // tạo 1 workbook new

            xlWsheet = (excel.Worksheet)xlapp.Worksheets.get_Item(1);
            excel.Range xlr = (excel.Range)xlWsheet.Cells[1, 1];
            xlr.Select();
            xlWsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

        }
        // Import excel 

        private void ImportExcel(String path)
        {
            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0]; 
                DataTable dataTable = new DataTable();
                for (int i = excelWorksheet.Dimension.Start.Column; i <= excelWorksheet.Dimension.End.Column; i++)
                {
                    dataTable.Columns.Add(excelWorksheet.Cells[1, i].Value.ToString());
                }
                for (int i = excelWorksheet.Dimension.Start.Row + 1; i <= excelWorksheet.Dimension.End.Row; i++)
                {
                    List<string> listRows = new List<string>();
                    for (int j = excelWorksheet.Dimension.Start.Column; j <= excelWorksheet.Dimension.End.Column; j++)
                    {
                        listRows.Add(excelWorksheet.Cells[i, j].Value.ToString());
                    }
                    dataTable.Rows.Add(listRows.ToArray());
                }
                dgvSinhVien.DataSource = dataTable;
            }
        }
        private void btImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Import Excel";
            openFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImportExcel(openFileDialog.FileName);
                    MessageBox.Show("Nhap file thanh cong!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nhap file khong thanh cong!\n" + ex.Message);
                }
            }
        }


        // Hàm Tìm kiếm 
        private void txtFind_TextChanged(object sender, EventArgs e)
        {          
            if(txtFind.Text == "")
            {
                Form1_Load(sender, e);
            }
            else
            {
                string query = "Select * from THONGTINSINHVIEN WHERE MaSV Like '%"+ txtFind.Text + "%'";
                dgvSinhVien.DataSource = modify.Table(query);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             dgvSinhVien.DataSource = B_SinhVien.GetAllSinhVien();
        }
    }
}

