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
	public partial class _Default : Page
	{
		int totalCount = 0;
		protected void Page_Load(object sender, EventArgs e)
		{

			string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
			SqlConnection sqlconn = new SqlConnection(mainconn);
			
			string sqlquery1 = "select * from [dbo].[blog] order by Bposteddate DESC";
			string sqlquery2 = "select TOP 5 * from [dbo].[blog] order by [view] DESC";
			sqlconn.Open();
			SqlCommand sqlcomm1 = new SqlCommand(sqlquery1, sqlconn);
			SqlCommand sqlcomm2 = new SqlCommand(sqlquery2, sqlconn);
			SqlDataAdapter sda1 = new SqlDataAdapter(sqlcomm1);
			SqlDataAdapter sda2 = new SqlDataAdapter(sqlcomm2);
			DataTable dt1 = new DataTable();
			DataTable dt2 = new DataTable();
			sda1.Fill(dt1);
			sda2.Fill(dt2);
			RepBlogDetails.DataSource = dt1;
			RepBlogDetails.DataBind();
			totalCount = dt1.Rows.Count;
			bindData();
			MostViewdBlog.DataSource = dt2;
			MostViewdBlog.DataBind();
			sqlconn.Close();
		}

		private void bindData()
		{
			string connectionString = ConfigurationManager.ConnectionStrings["Myconnection"].ToString();
			SqlConnection connection = new SqlConnection(connectionString);
			DataSet ds = new DataSet();
			String sql = "select * from [dbo].[blog] order by Bposteddate DESC";
			int val = Convert.ToInt16(txtHidden.Value);
			if (val <= 0)
				val = 0;
			connection.Open();
			SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
			adapter.Fill(ds, val, 5, "blog");
			connection.Close();
			RepBlogDetails.DataSource = ds;
			RepBlogDetails.DataBind();

			if (val <= 0)
			{
				lnkBtnPrev.Visible = false;
				lnkBtnNext.Visible = true;
			}

			if (val >= 5)
			{
				lnkBtnPrev.Visible = true;
				lnkBtnNext.Visible = true;
			}

			if ((val + 5) >= totalCount)
			{
				lnkBtnNext.Visible = false;
			}
		}

		protected void lnkBtnPrev_Click(object sender, EventArgs e)
		{
			txtHidden.Value = Convert.ToString(Convert.ToInt16(txtHidden.Value) - 5);
			bindData();
		}

		protected void lnkBtnNext_Click(object sender, EventArgs e)
		{
			txtHidden.Value = Convert.ToString(Convert.ToInt16(txtHidden.Value) + 5);
			bindData();
		}

		protected void RepBlogDetails_ItemCommand(object source, RepeaterCommandEventArgs e)
		{
			if (e.CommandName == "Press")
			{
				string url = ((Label)e.Item.FindControl("LblId")).Text;
				Response.Redirect(url);
			}

		}
	}
}