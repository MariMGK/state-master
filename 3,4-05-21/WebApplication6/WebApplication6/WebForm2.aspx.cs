using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
namespace WebApplication6
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataGrid1.DataSource = CultureInfo.GetCultures(CultureTypes.InstalledWin32Cultures);
            DataGrid1.DataBind();

        }
    }
}