using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SRVTextToImage;
using System.Drawing;
using System.Drawing.Imaging;

namespace shopMobileOnline
{
    public partial class CaptchaImage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CaptchaRandomImage CI = new CaptchaRandomImage();
            // GetRandomString function return captcha text of your provide characters size
            string captchaText = CI.GetRandomString(5);

            // GenerateImage function return image of the provided text of provided size and color
            Session["CaptchaText"] = captchaText;
            CI.GenerateImage(captchaText, 120, 50, Color.YellowGreen, Color.White);

            this.Response.Clear();
            this.Response.ContentType = "image/jpeg";
            CI.Image.Save(this.Response.OutputStream, ImageFormat.Jpeg);
            CI.Dispose();
        }
    }
}