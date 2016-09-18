using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Question
{
    public partial class index : System.Web.UI.Page
    {
        SqlCommand loginCommand;
        protected void Page_Load(object sender, EventArgs e)
        {
            loginCommand = new SqlCommand();
            loginCommand.Connection = (SqlConnection)Session["connection"];
        }

        protected void Login1_LoggingIn(object sender, LoginCancelEventArgs e)
        {
            int UserID = int.Parse(Login1.UserName);
            string UserPassword = Login1.Password;
            string checkinfo;
            loginCommand.CommandType = CommandType.StoredProcedure;
            loginCommand.CommandText = "proc_checkin";
            loginCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;
            loginCommand.Parameters.Add("@UserPassword", SqlDbType.NChar, 10).Value = UserPassword;
            loginCommand.Parameters.Add("@checkinfo", SqlDbType.NChar, 20);
            loginCommand.Parameters["@checkinfo"].Direction = ParameterDirection.Output;
            loginCommand.Parameters["@UserID"].Direction = ParameterDirection.Input;
            loginCommand.Parameters["@UserPassword"].Direction = ParameterDirection.Input;
            loginCommand.ExecuteNonQuery();
            checkinfo = loginCommand.Parameters["@checkinfo"].Value.ToString().Trim();
            if (checkinfo.ToString() == "验证成功")
            {
                if (UserID == 1 || UserID == 2)
                {
                    Response.Redirect("admin\\AdminQuestionList.aspx");
                }
                else
                {
                    Response.Redirect("StudentAsk.aspx");
                }
            }
            else
            {
                Response.Redirect(Request.Url.ToString());
            }
        }
    }
}