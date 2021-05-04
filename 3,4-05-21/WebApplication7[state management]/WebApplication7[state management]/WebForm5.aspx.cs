using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7_state_management_
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie objcookie;
            objcookie = new HttpCookie(Textcookiename.Text,Textcookievalue.Text);
            Response.Cookies.Add(objcookie);

        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Label1.Text = "";
            foreach(string strkey in  Request.Cookies)
            {
                Label1.Text += "<li>" + strkey + "=" + Request.Cookies[strkey].Value;
            }

        }
    }
}