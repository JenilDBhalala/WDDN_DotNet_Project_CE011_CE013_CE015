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
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                LblBlogPostedDate.Text = DateTime.Now.ToString();
                string url1 = Page.RouteData.Values["slug"] as string;
                string url2 = "\'" + url1 + "\'";
                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string sqlquery = "select * from [dbo].[blog] where Burl=" + url2;
                sqlconn.Open();
                SqlCommand sqlcomm1 = new SqlCommand(sqlquery, sqlconn);
                SqlDataReader reader = sqlcomm1.ExecuteReader();
                reader.Read();

                TxtBlogTitle.Text = reader["Btitle"].ToString();
                TxtBlogDesc.Text = reader["Bdesc"].ToString();
                URL.Text = reader["Burl"].ToString();
                string category= reader["Bcategory"].ToString();
                ListBlogCat.Items.Insert(0, category);

                if(category=="Food")
                {
                    ListBlogCat.Items.Insert(1, "Movies");
                    ListBlogCat.Items.Insert(2, "Sports");

                }
                else if (category == "Movies")
                {
                    ListBlogCat.Items.Insert(1, "Food");
                    ListBlogCat.Items.Insert(2, "Sports");
                }
                else if (category == "Sports")
                {
                    ListBlogCat.Items.Insert(1, "Food");
                    ListBlogCat.Items.Insert(2, "Movies");
                }
                TxtFullBlog.Text = reader["Bfullblog"].ToString();
                
                sqlconn.Close();
                //sqlconn.Open();

                //string sqlquery2 = "update [dbo].[blog] set [view]=@views where Burl=" + url2;

                //SqlCommand sqlcomm2 = new SqlCommand(sqlquery2, sqlconn);
                //sqlcomm2.Parameters.AddWithValue("@views", view);

                //sqlcomm2.ExecuteNonQuery();
                //sqlconn.Close();

                //sqlconn.Open();
                //string sqlquery3 = "select * from [dbo].[Comment] where blog_slug=" + url2;
                //SqlCommand sqlcomm3 = new SqlCommand(sqlquery3, sqlconn);

                //SqlDataAdapter sda = new SqlDataAdapter(sqlcomm3);
                //DataTable dt = new DataTable();
                //sda.Fill(dt);
                //CommentDetails.DataSource = dt;
                //CommentDetails.DataBind();
                //sqlconn.Close();
            }
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            confirmMessage.Visible = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //update
            string url1 = Page.RouteData.Values["slug"] as string;
            string url2 = "\'" + url1 + "\'";
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "update [dbo].[blog] set [Btitle]=@Btitle,[Bcategory]=@Bcategory,[Bdesc]=@Bdesc,[Bfullblog]=@Bfullblog,[Bposteddate]=@Bposteddate,[Burl]=@url where Burl="+url2;
            sqlconn.Open();
            

            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@Btitle", TxtBlogTitle.Text);
            sqlcomm.Parameters.AddWithValue("@Bcategory", ListBlogCat.SelectedItem.Text.ToString());
            sqlcomm.Parameters.AddWithValue("@Bdesc", TxtBlogDesc.Text);
            sqlcomm.Parameters.AddWithValue("@Bfullblog", TxtFullBlog.Text);
            sqlcomm.Parameters.AddWithValue("@Bposteddate", DateTime.Parse(LblBlogPostedDate.Text));
            sqlcomm.Parameters.AddWithValue("@url", URL.Text);
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
            Response.Redirect("/manage");
        }

        protected void Button2_Click(object sender, EventArgs e)
        { 
            confirmMessage.Visible = false;
        }
    }
}