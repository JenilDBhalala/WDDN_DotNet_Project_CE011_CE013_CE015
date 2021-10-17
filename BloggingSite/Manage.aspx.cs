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
    public partial class Manage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			if (!Page.IsPostBack)
            {
				string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
				SqlConnection sqlconn = new SqlConnection(mainconn);

				string sqlquery1 = "select * from [dbo].[blog] order by Bposteddate DESC";

				sqlconn.Open();
				SqlCommand sqlcomm1 = new SqlCommand(sqlquery1, sqlconn);
				SqlDataAdapter sda1 = new SqlDataAdapter(sqlcomm1);
				DataTable dt1 = new DataTable();
				sda1.Fill(dt1);
				TableRows.DataSource = dt1;
				TableRows.DataBind();
				int lCount = dt1.Rows.Count;
				sqlconn.Close();
            }
		}

		protected void TableRows_ItemCommand(object source, RepeaterCommandEventArgs e)
		{
			if (e.CommandName == "Press1")
			{
				string url = ((Label)e.Item.FindControl("Blogurl")).Text;
				Response.Redirect("/"+url);
			}
			else if (e.CommandName == "Press2")
			{
				string url = ((Label)e.Item.FindControl("Blogurl")).Text;
				Response.Redirect("/edit/"+url);
			}
			else if (e.CommandName == "Press3")
			{
				string url = ((Label)e.Item.FindControl("Blogurl")).Text;
				Response.Redirect("/delete/"+url);
			}
            else
            {
				Response.Redirect("/");
			}


		}
	}
}