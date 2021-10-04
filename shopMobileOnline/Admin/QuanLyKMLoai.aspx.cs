using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace shopMobileOnline.Admin
{
    public partial class QuanLyKM : System.Web.UI.Page
    {
        DataAccess dataAccess = new DataAccess();
        protected void Page_Load(object sender, EventArgs e)
        {
            //check xem nguoi dung co dang trong phien dang nhap
            if (Session["id"] == null)
            {
                Response.Redirect("ADLogin.aspx");
            }
            if (!IsPostBack)
            {             
                dataAccess.MoKetNoiCSDL();
                string sqlLoai = "select * from LOAI";
                SqlCommand cmdLoai = new SqlCommand(sqlLoai, dataAccess.getConnection());
                ddlLoai.DataSource = cmdLoai.ExecuteReader();
                ddlLoai.DataTextField = "TENLOAI";
                ddlLoai.DataValueField = "ID_LOAI";
                ddlLoai.DataBind();
                dataAccess.DongKetNoiCSDL();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            try
            {
                SqlParameter[] p =
                {
                    new SqlParameter("@ID_LOAI",SqlDbType.Int),
                    new SqlParameter("@PHANTRAMKHUYENMAI",SqlDbType.Int)
                };
                p[0].Value = ddlLoai.SelectedValue;
                p[1].Value = Int32.Parse(txtPhanTramKH.Text);
                int a = dataAccess.ExecuteNonQuery("update_km_loai", p);
                if (a > 0)
                {
                    Label1.Style.Remove("display");
                    Label1.Style.Add("display", "block");
                    Label1.Text = "Áp dụng thành công";
                }
                else
                {
                    Label1.Text = "Áp dụng thất bại";
                    Label1.Style.Add("color", "red");
                }
            }
            catch
            {

            }
        }
    }
}