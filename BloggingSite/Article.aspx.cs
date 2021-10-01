using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BloggingSite
{
    public partial class Article : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from [dbo].[blog] where Bid=" + Request.QueryString["id"].ToString();
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataReader reader = sqlcomm.ExecuteReader();
            reader.Read();

            Label1.Text = reader["Btitle"].ToString();
            //Label1.Text = reader["Bfullblog
            Label2.Text = reader["Bfullblog"].ToString();
            
            sqlconn.Close();
        }
    }
}