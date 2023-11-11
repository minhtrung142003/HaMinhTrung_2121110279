using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaMinhTrung_0279.DTO;
namespace HaMinhTrung_0279.DAL
{
    public class D_SinhVien
    {
        // phương thức này dùng để lấy dữ liệu từ csdl và trả về dữ liệu dưới dạng 1 đối tượng database
        public static DataTable getData()
        {
            SqlConnection Conn = dbConnectionData.Hamketnoi();  // tạo kết nối csdl bằng sqlconnection thông qua hamketnoi trong class db
            SqlCommand command = new SqlCommand("sp_GetAllSinhVien", Conn); // Tạo một đối tượng SqlCommand để gọi một thủ tục lưu trữ stored procedure sp_GetAllSinhVien
            command.CommandType = CommandType.StoredProcedure; // đối tưởng sqlcommand sử dụng để thực hiện truy vấn đến csdl
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(); // thực hiện câu lệnh truy vấn và điền dữ liệu vào datatable
            da.SelectCommand = command;  // xác định câu truy vấn sẽ thực thi dc
            DataTable dt = new DataTable(); // lưu trữ dữ liệu để trả về csdl
            da.Fill(dt);    
            Conn.Close();
            return dt;
        }

        //-------Thêm--------- 
        public static void InsertSV(tblSinhVien sv)
        {
            SqlConnection Conn = dbConnectionData.Hamketnoi();
            SqlCommand command = new SqlCommand("sp_InsertSinhVien", Conn); // truy vấn đến csdl
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaSV", SqlDbType.Int);
            command.Parameters.Add("@TenSV", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@NgaySinh", SqlDbType.Date);
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@Diem", SqlDbType.Float);
            command.Parameters.Add("@XepLoai", SqlDbType.NVarChar, 50);

            command.Parameters["@MaSV"].Value = sv.MaSV1;
            command.Parameters["@TenSV"].Value = sv.TenSV1;
            command.Parameters["@NgaySinh"].Value = sv.NgaySinh1;
            command.Parameters["@DiaChi"].Value = sv.DiaChi1;
            command.Parameters["@Diem"].Value = sv.Diem1;
            command.Parameters["@XepLoai"].Value = sv.XepLoai1;


            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        //-------sửa---------
        public static void UpdateSV(tblSinhVien sv)
        {
            SqlConnection Conn = dbConnectionData.Hamketnoi();
            SqlCommand command = new SqlCommand("sp_UpdateSinhVien", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaSV", SqlDbType.Int);
            command.Parameters.Add("@TenSV", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@NgaySinh", SqlDbType.Date);
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@Diem", SqlDbType.Float);
            command.Parameters.Add("@XepLoai", SqlDbType.NVarChar, 50);

            command.Parameters["@MaSV"].Value = sv.MaSV1;
            command.Parameters["@TenSV"].Value = sv.TenSV1;
            command.Parameters["@NgaySinh"].Value = sv.NgaySinh1;
            command.Parameters["@DiaChi"].Value = sv.DiaChi1;
            command.Parameters["@Diem"].Value = sv.Diem1;
            command.Parameters["@XepLoai"].Value = sv.XepLoai1;


            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }




        //-------xóa---------

        public static void DeleteSV(int  masv)
        {
            SqlConnection Conn = dbConnectionData.Hamketnoi();
            SqlCommand command = new SqlCommand("sp_DeleteSinhVien", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaSV", SqlDbType.Int);
            command.Parameters["@MaSV"].Value = masv;
          

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
