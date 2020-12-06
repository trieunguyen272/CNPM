using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gk2
{
    public class BHang
    {
        private string maMH, maKH;
        private DateTime ngayBan;
        private int soLuongBan;
        public BHang(string mh, string kh, DateTime nb, int sl)
        {
            maMH = mh;
            maKH = kh;
            ngayBan = nb;
            soLuongBan = sl;
        }
        public string MatHang
        {
            get { return maMH; }
            set { maMH = value; }
        }
        public string KhachHang
        {
            get { return maKH; }
            set { maKH = value; }
        }
        public DateTime NgayBan
        {
            get { return ngayBan; }
            set { ngayBan = value; }
        }
        public int SoLuongBan
        {
            get { return soLuongBan; }
            set { soLuongBan = value; }
        }
    }
}