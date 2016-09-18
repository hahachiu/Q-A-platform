using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using Question.DAL.DataSetUserTableAdapters;

namespace Question.admin
{
    public partial class Site2 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    if (Session["AdminUserID"] == null)
            //    {

            //        lalusername.Visible = false;
            //        Label1.Visible = false;
            //        btncancel.Visible = false;
            //    }
            //    else
            //    {
            //        lalusername.Visible = true;
            //        Label1.Visible = true;
            //        btncancel.Visible = true;
            //        int id = Convert.ToInt32(Session["AdminUserID"]);
            //        T_UserTableAdapter adpter = new T_UserTableAdapter();
            //        var data = adpter.GetDataByID(id);
            //        var user = data.Single();
            //        lalusername.Text = user.UserName;

            //    }
            }

        protected void btncancel_Click(object sender, EventArgs e)
        {
            //lalusername.Visible = false;
            //Label1.Visible = false;
            //btncancel.Visible = false;
            //Session.Remove("AdminUserID");
            //Response.Redirect("AdminLogIn.aspx");
            Response.Redirect("..\\index.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserMan.aspx");
        }
    }
}