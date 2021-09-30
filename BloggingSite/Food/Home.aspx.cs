using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BloggingSite.Food
{
    public partial class FoodHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from [dbo].[blog] where Bcategory='Food' order by Bposteddate DESC";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            RepBlogDetails.DataSource = dt;
            RepBlogDetails.DataBind();
            sqlconn.Close();
        }

      
        protected void RepBlogDetails_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if(e.CommandName == "Press")
            {
                string Lbl = ((Label)e.Item.FindControl("LblId")).Text;
                Response.Redirect("Article.aspx?id=" + Lbl);
            }
            
        }
    }
}