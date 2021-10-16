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
        }   
    }
}