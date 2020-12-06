using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gk2
{
    public partial class KhachHang : System.Web.UI.Page
    {
        QLBHADO qlbh = new QLBHADO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grvKhachHang.DataSource = qlbh.getTable("select * from KHACHHANG");
                Page.DataBind();
            }
            
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            if (qlbh.checkMaKH(txtMaKH.Text))
            {
                lblThongBao.Text = "Mã khách hàng đã tồn tại!";
            }
            else
            {
                KHang kh = new KHang(txtMaKH.Text, txtTenKH.Text, txtSDT.Text);
                if (qlbh.insertKH(kh))
                {
                    lblThongBao.Text = "Thêm thành công!";
                    grvKhachHang.DataSource = qlbh.getTable("select * from KHACHHANG");
                    grvKhachHang.DataBind();
                }
                else
                {
                    lblThongBao.Text = "Không thêm được!";
                }
            }
        }

        protected void grvKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaKH.Text = grvKhachHang.SelectedRow.Cells[0].Text;
            txtMaKH.ReadOnly = true;
            txtTenKH.Text = grvKhachHang.SelectedRow.Cells[1].Text.ToString();
            txtSDT.Text = grvKhachHang.SelectedRow.Cells[2].Text; ;
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            KHang kh = new KHang(txtMaKH.Text, txtTenKH.Text, txtSDT.Text);
            if (qlbh.updateKH(kh))
            {
                lblThongBao.Text = "Sửa thành công!";
                grvKhachHang.DataSource = qlbh.getTable("select * from KHACHHANG");
                grvKhachHang.DataBind();
            }
            else
            {
                lblThongBao.Text = "Không sửa được!";
            }
        }

        protected void btnTim_Click(object sender, EventArgs e)
        {
            if (qlbh.searchTenKH(txtTenKH.Text))
            {
                lblThongBao.Text = "Tìm thành công!";
                
            }
            else
            {
                lblThongBao.Text = "Không tìm thấy!";
            }
            grvKhachHang.DataSource = qlbh.getTable("select * from KHACHHANG where HOTEN = N'"+txtTenKH.Text+"'");
            grvKhachHang.DataBind();
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            if (qlbh.deleteKH(txtMaKH.Text))
            {
                txtMaKH.Text = "";
                txtTenKH.Text = "";
                txtSDT.Text = "";
                lblThongBao.Text = "Xóa thành công!";
                grvKhachHang.DataSource = qlbh.getTable("select * from KHACHHANG");
                grvKhachHang.DataBind();
            }
            else
            {
                lblThongBao.Text = "Xóa không thành công!";
            }
        }
    }
}