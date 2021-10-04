using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopMobileOnline.Admin
{
    public partial class QuanLyKMTheoMua : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("ADLogin.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            dataAccess.MoKetNoiCSDL();
            string sqlLoai = "UPDATE SANPHAM SET PHANTRAMKHUYENMAI = 20";
            SqlCommand cmd = new SqlCommand(sqlLoai, dataAccess.getConnection());
            int a = cmd.ExecuteNonQuery();
            if(a > 0)
            {
                Label1.Style.Add("display", "block");
                Label1.Text = "Áp dụng thành công";
            }
            else
            {
                Label1.Style.Add("display", "block");
                Label1.Text = "Áp dụng thất bại";
                Label1.Style.Add("color", "red");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            dataAccess.MoKetNoiCSDL();
            string sqlLoai = "UPDATE SANPHAM SET PHANTRAMKHUYENMAI = 10";
            SqlCommand cmd = new SqlCommand(sqlLoai, dataAccess.getConnection());
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                
                Label1.Style.Add("display", "block");
                Label1.Text = "Áp dụng thành công";
            }
            else
            {
                Label1.Style.Add("display", "block");
                Label1.Text = "Áp dụng thất bại";
                Label1.Style.Add("color", "red");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            dataAccess.MoKetNoiCSDL();
            string sqlLoai = "UPDATE SANPHAM SET PHANTRAMKHUYENMAI = 30";
            SqlCommand cmd = new SqlCommand(sqlLoai, dataAccess.getConnection());
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                Label1.Style.Add("display", "block");
                Label1.Text = "Áp dụng thành công";
            }
            else
            {
                Label1.Style.Add("display", "block");
                Label1.Text = "Áp dụng thất bại";
                Label1.Style.Add("color", "red");
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            dataAccess.MoKetNoiCSDL();
            string sqlLoai = "UPDATE SANPHAM SET PHANTRAMKHUYENMAI = 50";
            SqlCommand cmd = new SqlCommand(sqlLoai, dataAccess.getConnection());
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                Label1.Text = "Áp dụng thành công";
            }
            else
            {
                Label1.Text = "Áp dụng thất bại";
                Label1.Style.Add("color", "red");
            }
        }
    }
}