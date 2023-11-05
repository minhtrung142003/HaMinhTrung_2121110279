using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using HaMinhTrung_0279.BLL;
using HaMinhTrung_0279.DTO;
using excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System.Reflection;
using System.ComponentModel;

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
        // export
        private void btexport_Click(object sender, EventArgs e)
        {
            
            DataObject copydata = dgvSinhVien.GetClipboardContent();
            if(copydata != null) Clipboard.SetDataObject(copydata);
            excel.Application xlapp = new excel.Application();
            xlapp.Visible = true;
            excel.Workbook xlWbook;
            excel.Worksheet xlWsheet;
            object miseddata = System.Reflection.Missing.Value;
            xlWbook = xlapp.Workbooks.Add(miseddata);

            xlWsheet = (excel.Worksheet)xlapp.Worksheets.get_Item(1);
            excel.Range xlr = (excel.Range)xlWsheet.Cells[1, 1];
            xlr.Select();
            xlWsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        // Phương thức để truyền đường dẫn tệp vào excel

        private void ImportDataFromExcel(string excelFilePath)
        {
           // ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            try
            {
                using (var package = new ExcelPackage(new FileInfo(excelFilePath)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; 

                    int rowCount = worksheet.Dimension.Rows;
                    int columnCount = worksheet.Dimension.Columns;

                    DataTable dataTable = new DataTable();

                    // Add columns to the DataTable
                    for (int col = 1; col <= columnCount; col++)
                    {
                        dataTable.Columns.Add($"Column{col}");
                    }

                    // Add rows to the DataTable
                    for (int row = 2; row <= rowCount; row++) // Assuming the data starts from the second row
                    {
                        DataRow newRow = dataTable.NewRow();

                        for (int col = 1; col <= columnCount; col++)
                        {
                            newRow[col - 1] = worksheet.Cells[row, col].Value?.ToString();
                        }

                        dataTable.Rows.Add(newRow);
                    }

                    // Bind DataTable to DataGridView
                    dgvSinhVien.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while importing data: " + ex.Message);
            }
        }

        // import
    
        private void btImport_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls;*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string excelFilePath = openFileDialog.FileName;
                ImportDataFromExcel(excelFilePath);
            }*/

            
            // cách 2
            try
            {

                if (openFD.ShowDialog() == DialogResult.OK)
                {
                  
                    using (OleDbConnection myConnect = new OleDbConnection(string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 8.0;", openFD.FileName)))
                    {
                        openFD.Filter = "Excel Files|*.xlsx;*.xls;*.csv";
                        DataTable dt = new DataTable();
                        OleDbDataAdapter cmd = new OleDbDataAdapter("select * from [Sheet1$]", myConnect);
                        cmd.Fill(dt);
                        dgvSinhVien.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void btSave_Click(object sender, EventArgs e)
        {
          
            
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
           /* OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Select File";
            fdlg.FileName = txtTextbox.Text;
            fdlg.Filter = "Excel Sheet (*.xlsx)|*.xlsx|All Files(*.*)|*.*";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if(fdlg.ShowDialog()== DialogResult.OK)
            {
                txtTextbox.Text = fdlg.FileName;
            }*/
        }
    }
}

