using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BloggingSite.Admin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            if(Txtname.Text == "Admin" && TxtPassword.Text == "1357")
            {
                Response.Redirect("~/Admin/AdminPanel.aspx");
            }
            else
            {
                Response.Redirect("~/Admin/AdminLogin.aspx");
            }
        }
    }
}