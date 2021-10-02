using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace shopMobileOnline.KH
{
    public partial class MailActive : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Request.QueryString["emailadd"];
        }

        //Tri code kiem tra ma xac nhan
        protected void Button1_Click(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            dataAccess.MoKetNoiCSDL();
            SqlCommand cmd = new SqlCommand("get_email", dataAccess.getConnection());
            cmd.Parameters.AddWithValue("@EMAIL", Request.QueryString["emailadd"]);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            dataAccess.DongKetNoiCSDL();
          
            if (ds.Tables[0].Rows.Count > 0)
            {
                String activationcode;
                activationcode = ds.Tables[0].Rows[0]["ACTIVATIONCODE"].ToString();
                if (activationcode == TextBox1.Text)
                {
                    changestatus(); 
                    Response.Redirect("MailActiveDone.aspx");
                }
                else
                {
                    Label2.Text = "Sai mã xác nhận";
                }
            }

        }
        private void changestatus()
        {
            String mycon = "Data Source = DESKTOP-7ETUE6K; Initial Catalog=SHOPMOBILE;Integrated Security=true";
            String updatedata = "Update TAIKHOAN set status='Verified' where EMAIL='" + Request.QueryString["emailadd"] + "'";
            SqlConnection con = new SqlConnection(mycon);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = updatedata;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
        }
    }
}