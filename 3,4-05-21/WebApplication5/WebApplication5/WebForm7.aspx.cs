using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int intnum;
            DateTime dtmdate;
            dtmdate = DateTime.Now;
            Decimal decnum;
            intnum = 32001;
            decnum = 32001.9009m;
            //decimal
            Response.Write(intnum.ToString("d") + "<br>");
            //exponential
            Response.Write(intnum.ToString("e") + "<br>");
            Response.Write(decnum.ToString("e") + "<br>");
            //fixed point format
            Response.Write(intnum.ToString("f") + "<br>");
            Response.Write(intnum.ToString("f") + "<br>");
            //general format
            Response.Write(intnum.ToString("g") + "<br>");
            Response.Write(intnum.ToString("g") + "<br>");
            //short date
            Response.Write(dtmdate.ToString("d"));
            Response.Write("<br>");
            //long date
            Response.Write(dtmdate.ToString("D"));
            Response.Write("<br>");
            //long date and short time
            Response.Write(dtmdate.ToString("f"));
            Response.Write("<br>");
            //long date and long time
            Response.Write(dtmdate.ToString("F"));
            Response.Write("<br>");
            //short date and short time
            Response.Write(dtmdate.ToString("g"));
            Response.Write("<br>");
            //short date and long time
            Response.Write(dtmdate.ToString("G"));
            Response.Write("<br>");
            //month and day
            Response.Write(dtmdate.ToString("M"));
            Response.Write("<br>");
            Response.Write(dtmdate.ToString("R"));
            Response.Write("<br>");
            Response.Write(dtmdate.ToString("s"));
            Response.Write("<br>");
            //short time
            Response.Write(dtmdate.ToString("t"));
            Response.Write("<br>");
            //long time
            Response.Write(dtmdate.ToString("T"));
            Response.Write("<br>");
            //universal
            Response.Write(dtmdate.ToString("U"));
            Response.Write("<br>");
            //month and year
            Response.Write(dtmdate.ToString("Y"));
            Response.Write("<br>");





        }
    }
}