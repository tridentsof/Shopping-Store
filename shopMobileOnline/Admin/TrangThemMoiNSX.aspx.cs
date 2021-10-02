using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopMobileOnline.Admin
{
    public partial class TrangThemMoiNSX : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            dataAccess.MoKetNoiCSDL();
            string sql = "INSERT INTO NHASANXUAT(TENNSX)" +
                "VALUES(N'" + txtTenNSX.Text.ToString().Trim() + "')";
            SqlCommand cmd = new SqlCommand(sql, dataAccess.getConnection());
            try
            {
                cmd.ExecuteNonQuery();
                dataAccess.DongKetNoiCSDL();
                Response.Redirect("QLYDanhMuc.aspx");
            }
            catch
            {
                Response.Write("<script>alert('Đã xảy ra lỗi. Vui lòng thực hiện lại')</script>");
                dataAccess.DongKetNoiCSDL();
            }
        }

        protected void btnHuy_Click(object sender, EventArgs e)
        {
            Response.Redirect("QLYDanhMuc.aspx");
        }
    }
}