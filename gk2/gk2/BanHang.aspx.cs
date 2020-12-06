using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gk2
{
    public partial class BanHang : System.Web.UI.Page
    {
        QLBHADO qlbh = new QLBHADO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlMatHang.DataSource = qlbh.getTable("select * from MATHANG");
                ddlMatHang.DataTextField = "TENMH";
                ddlMatHang.DataValueField = "MAMH";
                ddlKhachHang.DataSource = qlbh.getTable("select * from KHACHHANG");
                ddlKhachHang.DataTextField = "HOTEN";
                ddlKhachHang.DataValueField = "MAKH";
                Page.DataBind();
            }
            
        }

        protected void cldNgayBan_SelectionChanged(object sender, EventArgs e)
        {
            txtNgayBan.Text = cldNgayBan.SelectedDate.Date.ToShortDateString();
            cldNgayBan.Visible = false;
        }

        protected void lnkNgayBan_Click(object sender, EventArgs e)
        {
            cldNgayBan.Visible = true;
        }

        protected void btnBanHang_Click(object sender, EventArgs e)
        {
            BHang bh = new BHang(ddlMatHang.SelectedValue.ToString(), ddlKhachHang.SelectedValue.ToString(), Convert.ToDateTime(txtNgayBan.Text), Convert.ToInt32(txtSoLuong.Text));
            if (qlbh.checkSL(ddlMatHang.SelectedValue.ToString()) >= Convert.ToInt32(txtSoLuong.Text))
            {
                if (qlbh.insertBH(bh))
                {
                    lblThongBao.Text = "Thêm thành công!";
                    double tt = Convert.ToInt32(txtSoLuong.Text) * qlbh.checkDG(ddlMatHang.SelectedValue.ToString());
                    lblThanhTien.Text = "Tiền phải trả: " + tt.ToString();
                    int sl = qlbh.checkSL(ddlMatHang.SelectedValue.ToString());
                    int slm = sl - Convert.ToInt32(txtSoLuong.Text);
                    if (qlbh.updateMH(slm, ddlMatHang.SelectedValue.ToString()))
                    {
                        lbl.Text = "Sửa thành công!";
                    }
                    
                }
                else
                {
                    lblThongBao.Text = "Không thêm được!";
                }
            }
            else
            {
                lblThongBao.Text = "Số lượng bán phải nhỏ hơn số lượng còn!";
            }
        }
    }
}