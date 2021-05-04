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
    public partial class WebForm6 : System.Web.UI.Page
    {
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-E0NVL0L7\\SQLEXPRESS;Initial Catalog=Craftsman;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            bindmastergrid();

        }
        void bindmastergrid()
        {
            SqlCommand cmd = new SqlCommand("select * from employee1  ", connection);
            connection.Open();
            DataGrid1.DataSource = cmd.ExecuteReader();
            DataGrid1.DataBind();
            connection.Close();
        }
        void binddetailsgrid(int positionid)
        {
            string q= "select * from position where positionid=@pos";
            SqlCommand cmd = new SqlCommand(q, connection);

            cmd.Parameters.AddWithValue("@pos", positionid);
            connection.Open();
            DataGrid2.DataSource = cmd.ExecuteReader();
            DataGrid2.DataBind();
            connection.Close();


        }

        protected void DataGrid1_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            int posid;
            posid = Convert.ToInt32(DataGrid1.DataKeys[e.Item.ItemIndex]);
            DataGrid1.SelectedIndex = e.Item.ItemIndex;
            binddetailsgrid(posid);


        }
    }
}