using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace LibraryHSE.librarian
{
    public partial class delete_files : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\killmepls\source\repos\LibraryHSE\LibraryHSE\App_Data\lms.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            if (Request.QueryString["Id"] != null)
            {
                sql_query("UPDATE [books] SET [books_video]='' WHERE Id='" + Request.QueryString["id"].ToString() + "'");
            }
            else if (Request.QueryString["id1"] != null)
            {
                sql_query("UPDATE [books] SET [books_pdf]='' WHERE Id='" + Request.QueryString["id1"].ToString() + "'");
            }

            else
            {
                sql_query("DELETE [books] WHERE Id='" + Request.QueryString["id2"].ToString() + "'");
            }


            Response.Redirect("display_all_books.aspx");

        }
        private void sql_query(string command)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = command;
            cmd.ExecuteNonQuery();
        }
    }
}