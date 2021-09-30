using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopMobileOnline.Admin
{
    public partial class QLYDanhMuc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //check xem nguoi dung co dang trong phien dang nhap
            if (Session["id"] == null)
            {
                Response.Redirect("ADLogin.aspx");
            }
            else
            {
                DataAccess dataAccess = new DataAccess();

                dataAccess.MoKetNoiCSDL();

                //Lay du lieu tu dtb luu vao dataTable
                string sql = "SELECT ID_NSX, TENNSX FROM [NHASANXUAT]";

                DataTable dtDM = dataAccess.LayBangDuLieu(sql);

                if (dtDM != null && dtDM.Rows.Count > 0)
                {

                    StringBuilder sb = new StringBuilder();

                    foreach (DataRow dr in dtDM.Rows)
                    {
                        sb.Append("<tr class=\"qlsp-row\">");
                        foreach (DataColumn dc in dtDM.Columns)
                        {
                            if (dc.ColumnName == "CAPNHAT")
                            {
                                sb.Append("<th class=\"qlsp-item\">");
                                sb.Append("<a href=\"" + dr[dc.ColumnName].ToString() + "\" class=\"qlsp-btnCapNhat\">Cập nhật</a>");
                                sb.Append("</th>");
                            }

                            else if (dc.ColumnName == "TENSP")
                            {
                                sb.Append("<th class=\"qlsp-item\" id=\"qlsp-item-tensp\">");
                                sb.Append("<a href=\"/KH/TrangChiTietSP.aspx?idSP=" + dr["ID_SP"] + "\">" + dr[dc.ColumnName].ToString() + "</a");
                                sb.Append("</th>");
                            }

                        }
                        sb.Append("</tr>");
                    }
                    //Ket noi string html vao trang asp
                    Panel1.Controls.Add(new Label { Text = sb.ToString() });

                    //dong connection
                    //if (connection.State == ConnectionState.Closed)
                    //    connection.Close();
                    dataAccess.DongKetNoiCSDL();
                }
        }
    }
}