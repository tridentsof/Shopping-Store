using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopMobileOnline.admin
{
    public partial class TrangDanhSachSP : System.Web.UI.Page
    {
        //Tri code login with Google
        //Van chua xong vi chua get duoc session KH tu` googleOAuth
        string clientid = "294304503360-1r37p7pcl022fnarjeldackdm13hanb4.apps.googleusercontent.com";
        string clientsecret = "Z9GF0FFKvfuKdkFT9XAYKH2Y";
        string redirection_url = "http://localhost:53508/KH/KHTrangChu.aspx";
        string url = "https://accounts.google.com/o/oauth2/token";
        public class Tokenclass
        {
            public string access_token
            {
                get;
                set;
            }
            public string token_type
            {
                get;
                set;
            }
            public int expires_in
            {
                get;
                set;
            }
            public string refresh_token
            {
                get;
                set;
            }
        }
        public class Userclass
        {
            public string id
            {
                get;
                set;
            }
            public string name
            {
                get;
                set;
            }
            public string given_name
            {
                get;
                set;
            }
            public string family_name
            {
                get;
                set;
            }
            public string link
            {
                get;
                set;
            }
            public string picture
            {
                get;
                set;
            }
            public string gender
            {
                get;
                set;
            }
            public string locale
            {
                get;
                set;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["code"] != null)
                {
                    GetToken(Request.QueryString["code"].ToString());
                }
            }

            DataAccess dataAccess = new DataAccess();
            dataAccess.MoKetNoiCSDL();

            string sql = "SELECT SP.ID_SP, ID_NSX, ID_LOAI, TENSP, HINH, SOLUONG, CAST((100 - PHANTRAMKHUYENMAI)*DONGIA/100 AS INT) AS GIAKM, DONGIA, CAST(CAST((100 - PHANTRAMKHUYENMAI)*DONGIA/100 AS INT)*0.4 AS INT) AS GIATRATRUOC FROM SANPHAM SP WHERE TINHTRANG = 1 AND SOLUONG > 0";  

            DataTable dt = dataAccess.LayBangDuLieu(sql);

            if(dt != null && dt.Rows.Count >0)
            {
                this.rptItem.DataSource = dt;
                this.rptItem.DataBind();
            }

            dataAccess.DongKetNoiCSDL();
        }
        public void GetToken(string code)
        {
            string poststring = "grant_type=authorization_code&code=" + code + "&client_id=" + clientid + "&client_secret=" + clientsecret + "&redirect_uri=" + redirection_url + "";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "application/x-www-form-urlencoded";
            request.Method = "POST";
            UTF8Encoding utfenc = new UTF8Encoding();
            byte[] bytes = utfenc.GetBytes(poststring);
            Stream outputstream = null;
            try
            {
                request.ContentLength = bytes.Length;
                outputstream = request.GetRequestStream();
                outputstream.Write(bytes, 0, bytes.Length);
            }
            catch { }
            var response = (HttpWebResponse)request.GetResponse();
            var streamReader = new StreamReader(response.GetResponseStream());
            string responseFromServer = streamReader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Tokenclass obj = js.Deserialize<Tokenclass>(responseFromServer);
            GetuserProfile(obj.access_token);
        }
        public void GetuserProfile(string accesstoken)
        {
            string url = "https://www.googleapis.com/oauth2/v1/userinfo?alt=json&access_token=" + accesstoken + "";
            WebRequest request = WebRequest.Create(url);
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            response.Close();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Userclass userinfo = js.Deserialize<Userclass>(responseFromServer);
            
        }
    }
}