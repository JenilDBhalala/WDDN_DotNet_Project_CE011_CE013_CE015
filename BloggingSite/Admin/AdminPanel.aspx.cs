using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace BloggingSite.Admin
{
    public partial class AdminPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LblBlogPostedDate.Text = DateTime.Now.ToString();
                ListBlogCat.Items.Insert(0, "-- Select Category --");
            }
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "insert into [dbo].[blog] (Btitle,Bcategory,Bdesc,Bfullblog,Bposteddate) values (@Btitle, @Bcategory, @Bdesc, @Bfullblog, @Bposteddate)";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@Btitle", TxtBlogTitle.Text);
            sqlcomm.Parameters.AddWithValue("@Bcategory", ListBlogCat.SelectedItem.Text.ToString());
            sqlcomm.Parameters.AddWithValue("@Bdesc", TxtBlogDesc.Text);
            sqlcomm.Parameters.AddWithValue("@Bfullblog", TxtFullBlog.Text);
            sqlcomm.Parameters.AddWithValue("@Bposteddate", DateTime.Parse(LblBlogPostedDate.Text));
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
            Response.Redirect("~/Admin/AdminPanel.aspx");
        }
    }
}