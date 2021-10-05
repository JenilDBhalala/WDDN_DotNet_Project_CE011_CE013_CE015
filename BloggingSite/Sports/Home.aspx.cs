﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BloggingSite.Sports
{
    public partial class SportsHome : System.Web.UI.Page
    {
        int totalCount = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from [dbo].[blog] where Bcategory='Sports' order by Bposteddate DESC";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            RepBlogDetails.DataSource = dt;
            RepBlogDetails.DataBind();
            totalCount = dt.Rows.Count;
            bindData();
            sqlconn.Close();
        }

        private void bindData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Myconnection"].ToString();
            SqlConnection connection = new SqlConnection(connectionString);
            DataSet ds = new DataSet();
            String sql = "select * from [dbo].[blog] where Bcategory='Sports' order by Bposteddate DESC";
            int val = Convert.ToInt16(txtHidden.Value);
            if (val <= 0)
                val = 0;
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            adapter.Fill(ds, val, 5, "blog");

            Console.WriteLine(totalCount);
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
                Response.Redirect("/" + url);
            }
        }

    }
}