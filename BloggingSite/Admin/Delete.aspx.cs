using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace BloggingSite.Admin
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //delete blog

            string url1 = Page.RouteData.Values["slug"] as string;
            string url2 = "\'" + url1 + "\'";
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "delete from [dbo].[blog] where Burl ="+url2;

            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
            Response.Redirect("/manage");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //cancel
            Response.Redirect("/manage");
        }
    }
}