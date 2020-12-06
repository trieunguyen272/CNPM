using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gk2
{
    public partial class MatHang : System.Web.UI.Page
    {
        QLBHADO qlbh = new QLBHADO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grvMatHang.DataSource = qlbh.getTable("select * from MATHANG");
                grvMatHang.DataBind();
            }
        }
    }
}