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
    public partial class QuanLyKMNSX : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("ADLogin.aspx");
            }
            if (!IsPostBack)
            {
                DataAccess dataAccess = new DataAccess();
                dataAccess.MoKetNoiCSDL();
                string sqlLoai = "select * from NHASANXUAT";
                SqlCommand cmdLoai = new SqlCommand(sqlLoai, dataAccess.getConnection());
                ddNSX.DataSource = cmdLoai.ExecuteReader();
                ddNSX.DataTextField = "TENNSX";
                ddNSX.DataValueField = "ID_NSX";
                ddNSX.DataBind();
                dataAccess.DongKetNoiCSDL();
                //ddlLoai.Items.Insert(0, new ListItem("---Chọn loại sản phẩm---", "-1"));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            try
            {
                SqlParameter[] p =
                {
                    new SqlParameter("@ID_NSX",SqlDbType.Int),
                    new SqlParameter("@PHANTRAMKHUYENMAI",SqlDbType.Int)
                };
                p[0].Value = ddNSX.SelectedValue;
                p[1].Value = Int32.Parse(txtPhanTramKH.Text);
                int a = dataAccess.ExecuteNonQuery("update_km_nsx", p);
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
            catch
            {

            }
        }
    }
}