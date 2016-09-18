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
    public partial class AskQuestion : System.Web.UI.Page
    {
        SqlCommand Command;
        protected void Page_Load(object sender, EventArgs e)
        {
            Command = new SqlCommand();
            Command.Connection = (SqlConnection)Session["connection"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int Who_ask = int.Parse(UserID.Text.ToString());
            string Tital = tital.Text.ToString();
            string Substance = substance.Text.ToString();
            string insertinfo;

            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "proc_insertQuestion";
            Command.Parameters.Add("@Who_ask", SqlDbType.Int).Value = Who_ask;
            Command.Parameters.Add("@Tital", SqlDbType.NChar, 10).Value = Tital;
            Command.Parameters.Add("@Substance", SqlDbType.NChar, 30).Value = Substance;
            Command.Parameters.Add("@insertinfo", SqlDbType.NChar, 20);
            Command.Parameters["@insertinfo"].Direction = ParameterDirection.Output;
            Command.ExecuteNonQuery();
            insertinfo = Command.Parameters["@insertinfo"].Value.ToString().Trim();
            Response.Redirect("StudentAsk.aspx");
        }
    }
}