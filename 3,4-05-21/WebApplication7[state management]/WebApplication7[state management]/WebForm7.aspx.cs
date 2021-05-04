using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7_state_management_
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            hdn1.Value = TextBox1.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            Server.Transfer("WebForm6.aspx");

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox2.Text = hdn1.Value;
        }
    }
}