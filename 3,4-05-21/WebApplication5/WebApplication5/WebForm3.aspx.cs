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
    public partial class WebForm3 : System.Web.UI.Page
    {
        SqlConnection connection=new SqlConnection("Data Source=LAPTOP-E0NVL0L7\\SQLEXPRESS;Initial Catalog=Craftsman;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                binddatagrid("positionid");
            }

        }
        void binddatagrid( string positionid)
        {
            SqlCommand cmd = new SqlCommand("select * from position Order By "+positionid, connection);
            connection.Open();
            DataGrid1.DataSource = cmd.ExecuteReader();
            DataGrid1.DataBind();
            connection.Close();
        }

        protected void DataGrid1_SortCommand(object source, DataGridSortCommandEventArgs e)
        {
            binddatagrid(e.SortExpression);
        }
    }
}