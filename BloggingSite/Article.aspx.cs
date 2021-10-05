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
            string url1 = Page.RouteData.Values["slug"] as string;
            string url2 = "\'" + url1 + "\'";
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from [dbo].[blog] where Burl=" + url2;
            sqlconn.Open();
            SqlCommand sqlcomm1 = new SqlCommand(sqlquery, sqlconn);
            SqlDataReader reader = sqlcomm1.ExecuteReader();
            reader.Read();

            Label1.Text = reader["Btitle"].ToString();
            Label2.Text = reader["Bfullblog"].ToString();
            string view = reader["view"].ToString();
            int int_view = Int32.Parse(view);
            int_view++;
            view = int_view.ToString();

            sqlconn.Close();
            sqlconn.Open();

            string sqlquery2 = "update [dbo].[blog] set [view]=@views where Burl=" + url2;

            SqlCommand sqlcomm2 = new SqlCommand(sqlquery2, sqlconn);
            sqlcomm2.Parameters.AddWithValue("@views", view);

            sqlcomm2.ExecuteNonQuery();
            sqlconn.Close();

            sqlconn.Open();
            string sqlquery3 = "select * from [dbo].[Comment] where blog_slug=" + url2;
            SqlCommand sqlcomm3 = new SqlCommand(sqlquery3, sqlconn);

            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm3);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CommentDetails.DataSource = dt;
            CommentDetails.DataBind();
            sqlconn.Close();

        }
        protected void Add_Comment(object sender, EventArgs e)
        {
            if (Name.Text == "" && CommentBox.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertMessage", "alert('Please write name or Comment')", true);
                return;
            }
            string slug = Page.RouteData.Values["slug"] as string;
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "insert into [dbo].[comment] (blog_slug,blog_comment,user_name) values (@blog_slug, @blog_comment, @user_name)";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@blog_slug", slug);
            sqlcomm.Parameters.AddWithValue("@user_name", Name.Text);
            sqlcomm.Parameters.AddWithValue("@blog_comment", CommentBox.Text);

            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();

            Response.Redirect("~/" + slug);
        }
    }
}