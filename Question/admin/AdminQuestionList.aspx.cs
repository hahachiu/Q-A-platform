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
    public partial class AdminQuestionList : System.Web.UI.Page
    {
        SqlCommand Command;
        SqlCommand deleteCommand;
        protected void Page_Load(object sender, EventArgs e)
        {
            Command = new SqlCommand();
            Command.Connection = (SqlConnection)Session["connection"];
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridView1.PageIndex = e.NewSelectedIndex; 
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string Who_ans = ((TextBox)(this.GridView1.Rows[e.RowIndex].Cells[2].Controls[0])).Text.Trim();
            string Answer = ((TextBox)(this.GridView1.Rows[e.RowIndex].Cells[5].Controls[0])).Text.Trim();
            int QuestionID = int.Parse(this.GridView1.DataKeys[e.RowIndex].Value.ToString());

            string answerinfo;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "proc_answerQuestion";
            Command.Parameters.Add("@QuestionID", SqlDbType.Int).Value = QuestionID;
            Command.Parameters.Add("@Who_ans", SqlDbType.Int).Value = Who_ans;
            Command.Parameters.Add("@Answer", SqlDbType.NChar, 40).Value = Answer;
            Command.Parameters.Add("@answerinfo", SqlDbType.NChar, 20);
            Command.Parameters["@answerinfo"].Direction = ParameterDirection.Output;
            Command.ExecuteNonQuery();
            answerinfo = Command.Parameters["@answerinfo"].Value.ToString().Trim();
            Response.Redirect(Request.Url.ToString());
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            deleteCommand = new SqlCommand();
            deleteCommand.Connection = (SqlConnection)Session["connection"];
            int QuestionID = int.Parse(this.GridView1.DataKeys[e.RowIndex].Value.ToString());

            string deleteinfo;
            deleteCommand.CommandType = CommandType.StoredProcedure;
            deleteCommand.CommandText = "proc_deleteQuestion";
            deleteCommand.Parameters.Add("@QuestionID", SqlDbType.Int).Value = QuestionID;
            deleteCommand.Parameters.Add("@deleteinfo", SqlDbType.NChar, 20);
            deleteCommand.Parameters["@deleteinfo"].Direction = ParameterDirection.Output;
            deleteCommand.ExecuteNonQuery();
            deleteinfo = deleteCommand.Parameters["@deleteinfo"].Value.ToString().Trim();
            Response.Redirect(Request.Url.ToString());
        }
    }
}