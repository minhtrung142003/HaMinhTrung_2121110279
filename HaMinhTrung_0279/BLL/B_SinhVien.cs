using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaMinhTrung_0279.DTO;
using HaMinhTrung_0279.DAL;
using System.Data;

namespace HaMinhTrung_0279.BLL
{
    // đây là lớp xử lý nghiệp vụ cho đối tượng sinh viên
    public class B_SinhVien
    {
        // phương thức này trả vế 1 đối tượng database chứa all thông tin sv.
        public static DataTable GetAllSinhVien()
        {
            return D_SinhVien.getData();
        }
       
        // thêm một 1 đối tượng tblsinhvien làm tham số 
        public static void InsertSinhVien(tblSinhVien sv)
        {
            D_SinhVien.InsertSV(sv);
        }
        // cập nhật 1 sv đã có sẵn 
        public static void UpdateSinhVien(tblSinhVien sv)
        {
            D_SinhVien.UpdateSV(sv);
        }
        // xóa 1 sinh viên khỏi dữ liệu.
        public static void DeleteSinhVien(int masv)
        {
            D_SinhVien.DeleteSV(masv);
        }
    }
}
