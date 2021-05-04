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
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlCommand cmd;
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-E0NVL0L7\\SQLEXPRESS;Initial Catalog=Craftsman;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                DataGrid1.CurrentPageIndex =0;
                binddatagrid();

            }

        }
        void binddatagrid()
        {
            SqlCommand cmd = new SqlCommand("select * from position", connection);
            connection.Open();
            DataGrid1.DataSource = cmd.ExecuteReader();
            DataGrid1.DataBind();
            connection.Close();
        }

        protected void DataGrid1_EditCommand(object source, DataGridCommandEventArgs e)
        {
            DataGrid1.EditItemIndex = e.Item.ItemIndex;
            binddatagrid();

        }

        protected void DataGrid1_UpdateCommand(object source, DataGridCommandEventArgs e)
        {
            int positionid;
            string positionname;
            positionid = e.Item.ItemIndex;
            TextBox txtposname = (TextBox)e.Item.Cells[1].Controls[0];
            positionname = txtposname.Text;
            string query = "Update position set positionname=@positionname " + " where positionid=@posid";
            SqlCommand cmdSql = new SqlCommand(query, connection);
            cmdSql.Parameters.AddWithValue("@positionname", positionname);
            cmdSql.Parameters.AddWithValue("@posid", positionid);
            connection.Open();
            cmdSql.ExecuteNonQuery();
            connection.Close();
            DataGrid1.EditItemIndex = -1;
            binddatagrid();



        }

        protected void DataGrid1_CancelCommand(object source, DataGridCommandEventArgs e)
        {
            DataGrid1.EditItemIndex = -1;
            binddatagrid();
        }
    }
}