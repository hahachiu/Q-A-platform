using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Data.SqlClient;
using System.Configuration;

namespace Question
{
    public class Global : System.Web.HttpApplication
    {
        public static readonly string ConnectionStringLocalTransaction = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["connection"] = new SqlConnection(ConnectionStringLocalTransaction);
            ((SqlConnection)Session["connection"]).Open();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            ((SqlConnection)Session["connection"]).Close();
            ((SqlConnection)Session["connection"]).Dispose();
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}