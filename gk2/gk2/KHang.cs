using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gk2
{
    public class KHang
    {
        private string maKH, tenKH, sdt;
        public KHang (string ma, string ten, string so)
        {
            maKH = ma;
            tenKH = ten;
            sdt = so;
        }
        public string MAKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        public string TENKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }
        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }
    }
}