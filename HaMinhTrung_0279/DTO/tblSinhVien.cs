using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaMinhTrung_0279.DTO
{
    public class tblSinhVien
    {
        private int MaSV;
        private string TenSV;
        private DateTime NgaySinh;
        private string DiaChi;
        private float Diem;
        private string XepLoai;

        public tblSinhVien(int maSV, string tenSV, DateTime ngaySinh, string diaChi, float diem, string xepLoai)
        {
            MaSV = maSV;
            TenSV = tenSV;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            Diem = diem;
            XepLoai = xepLoai;
        }

        public int MaSV1 { get => MaSV; set => MaSV = value; }
        public string TenSV1 { get => TenSV; set => TenSV = value; }
        public DateTime NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public float Diem1 { get => Diem; set => Diem = value; }
        public string XepLoai1 { get => XepLoai; set => XepLoai = value; }


    }
}
