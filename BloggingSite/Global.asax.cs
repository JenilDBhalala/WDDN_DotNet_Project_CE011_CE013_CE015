using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace BloggingSite
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            RouteTable.Routes.MapPageRoute("AdminLogin", "admin/login", "~/Admin/AdminLogin.aspx");
            RouteTable.Routes.MapPageRoute("ShowArticle", "{slug}", "~/Article.aspx");
            RouteTable.Routes.MapPageRoute("EditBlog", "edit/{slug}", "~/Admin/Edit.aspx");
            RouteTable.Routes.MapPageRoute("DeleteBlog", "delete/{slug}", "~/Admin/Delete.aspx");
        }
    }
}