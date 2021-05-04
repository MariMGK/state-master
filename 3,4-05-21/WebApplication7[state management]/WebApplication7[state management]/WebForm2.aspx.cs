using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7_state_management_
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                Response.Write(Request.QueryString["Name"].ToString());
                Response.Write(Request.QueryString["Value"].ToString());
            }
            catch(Exception )
            {
                Response.Write(Request.QueryString["Name"].ToString());
            }
        }
    }
}