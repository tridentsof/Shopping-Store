using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopMobileOnline.Admin
{
    public partial class TrangCapNhatNSX : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("ADLogin.aspx");
            }
            //hien thi ten nguoi dung o goc tren phai
            else
            {

            }
            if (!IsPostBack)
            {
                string idNSX = Request.QueryString.Get("idNSX").ToString();
                DataAccess dataAccess = new DataAccess();
                string sqlNSX = "SELECT * FROM NHASANXUAT where ID_NSX=" +idNSX;

                dataAccess.MoKetNoiCSDL();

                DataTable dtNSX = dataAccess.LayBangDuLieu(sqlNSX);
                if (dtNSX != null && dtNSX.Rows.Count > 0)
                {
                    //Set du lieu cho cac field html
                    txtTenNSX.Text = dtNSX.Rows[0]["TENNSX"].ToString();
                    SqlCommand cmdNSX = new SqlCommand(sqlNSX, dataAccess.getConnection());
                }
                //dong connection
                dataAccess.DongKetNoiCSDL();
            }
        }

        protected void btnCapNhat_Click(object sender, EventArgs e)
        {
            string idNSX = Request.QueryString.Get("idNSX").ToString();

            DataAccess dataAccess = new DataAccess();
            dataAccess.MoKetNoiCSDL();
            //sql cap nhat dl
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE NHASANXUAT SET TENNSX = N'" +txtTenNSX.Text.Trim() + "' "+ "WHERE ID_NSX= " +idNSX;
            cmd.Connection = dataAccess.getConnection();
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