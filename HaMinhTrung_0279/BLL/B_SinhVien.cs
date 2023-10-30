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
    public class B_SinhVien
    {
        public static DataTable GetAllSinhVien()
        {
            return D_SinhVien.getData();
        }
        public static void InsertSinhVien(tblSinhVien sv)
        {
            D_SinhVien.InsertSV(sv);
        }
        public static void UpdateSinhVien(tblSinhVien sv)
        {
            D_SinhVien.UpdateSV(sv);
        }
        public static void DeleteSinhVien(int masv)
        {
            D_SinhVien.DeleteSV(masv);
        }
    }
}
