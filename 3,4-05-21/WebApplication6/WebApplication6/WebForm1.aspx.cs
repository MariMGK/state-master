using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace WebApplication6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Regex objregex;
            objregex = new Regex(textregularexpression.Text);
            DataGrid1.DataSource = objregex.Matches(matchingregularexpression.Text);
            DataGrid1.DataBind();
        }
    }
}