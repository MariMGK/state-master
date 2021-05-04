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
    
    public partial class WebForm1 : System.Web.UI.Page
    {
        int strtindex;
        int endindex;
        SqlCommand cmd;
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-E0NVL0L7\\SQLEXPRESS;Initial Catalog=Craftsman;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("select * from signup", connection);
            connection.Open();
            GridView1.DataSource = cmd.ExecuteReader();
            GridView1.DataBind();
            connection.Close();
            if(!IsPostBack)
            {
                string sttrselect = "select count(*) from signup ";
                cmd = new SqlCommand(sttrselect, connection);
                connection.Open();
                DataGrid1.VirtualItemCount = ((int)cmd.ExecuteScalar());
                bind();
            }


        }

        protected void DataGrid1_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            if(e.CommandName=="select")
            {
                e.Item.BackColor = System.Drawing.Color.LightGreen;
                e.Item.Font.Bold = true;
            }
            else
            {
                e.Item.BackColor = System.Drawing.Color.White;
                e.Item.Font.Bold = false;
            }
        }
        void bind()
        {
            SqlDataAdapter dataproduct;
            DataSet dstproduct;
            endindex = strtindex + DataGrid1.PageSize;
                
             string strSelect = "Select * From signup Where regid > @startIndex And regid <= @endIndex Order By regid";
            dataproduct = new SqlDataAdapter(strSelect, connection);
            dataproduct.SelectCommand.Parameters.Add("@startIndex", strtindex);
            dataproduct.SelectCommand.Parameters.Add("@endIndex", endindex);
            dstproduct = new DataSet();
            dataproduct.Fill(dstproduct);

            DataGrid1.DataSource = dstproduct;
            DataGrid1.DataBind();

        }

        protected void DataGrid1_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            SqlDataAdapter dataproduct;
            strtindex = (e.NewPageIndex * DataGrid1.PageSize);
            DataGrid1.CurrentPageIndex = e.NewPageIndex;
            bind();

        }
    }
}