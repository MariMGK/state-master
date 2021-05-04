using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7_state_management_
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ViewState["ename"] = TextBox1.Text;
            Session["ename"] = TextBox1.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox2.Text = ViewState["ename"].ToString();
            Response.Write(Session["ename"].ToString());
        }
    }
}