using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Question.admin
{
    public partial class UserMan : System.Web.UI.Page
    {
        SqlCommand Command;
        SqlCommand deleteCommand;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string UserName = TexUserName.Text.ToString();
            string UserPassword = TexUserPassword.Text.ToString();
            if (UserName == null||UserPassword==null) 
            {
                Response.Redirect(Request.Url.ToString());
                return;
            }
            Command = new SqlCommand();
            Command.Connection = (SqlConnection)Session["connection"];
            string insertinfo;

            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "proc_insertStudent";
            Command.Parameters.Add("@UserName", SqlDbType.NChar, 10).Value = UserName;
            Command.Parameters.Add("@UserPassword", SqlDbType.NChar, 10).Value = UserPassword;
            Command.Parameters.Add("@insertinfo", SqlDbType.NChar, 20);
            Command.Parameters["@insertinfo"].Direction = ParameterDirection.Output;
            Command.ExecuteNonQuery();
            insertinfo = Command.Parameters["@insertinfo"].Value.ToString().Trim();
            Response.Redirect(Request.Url.ToString());
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            deleteCommand = new SqlCommand();
            deleteCommand.Connection = (SqlConnection)Session["connection"];
            int UserID = int.Parse(this.GridView1.DataKeys[e.RowIndex].Value.ToString());
            string deleteinfo;

            deleteCommand.CommandType = CommandType.StoredProcedure;
            deleteCommand.CommandText = "proc_deleteStudent";
            deleteCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;
            deleteCommand.Parameters.Add("@deleteinfo", SqlDbType.NChar, 20);
            deleteCommand.Parameters["@deleteinfo"].Direction = ParameterDirection.Output;
            deleteCommand.ExecuteNonQuery();
            deleteinfo = deleteCommand.Parameters["@deleteinfo"].Value.ToString().Trim();
            Response.Redirect(Request.Url.ToString());
        }
    }
}