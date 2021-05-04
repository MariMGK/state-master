using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication5
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds;
            SqlConnection connection;
            SqlDataAdapter dapt;
            DataView viewpro;
            ds = new DataSet();
            connection = new SqlConnection("Data Source=LAPTOP-E0NVL0L7\\SQLEXPRESS;Initial Catalog=Craftsman;Integrated Security=True");
            dapt = new SqlDataAdapter("select * from position", connection);
            dapt.Fill(ds, "position");
            viewpro = ds.Tables["position"].DefaultView;
            viewpro.RowFilter = "positionid='" + Convert.ToInt32(TextBox1.Text)+"'";
            DataGrid1.DataSource = viewpro;
            DataGrid1.DataBind();

        }
    }
}