 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace LibraryHSE.student
{
    public partial class student_display_all_books : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\killmepls\source\repos\LibraryHSE\LibraryHSE\App_Data\lms.mdf;Integrated Security=True");
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            if (Session["student"] == null)
            {
                Response.Redirect("student_login.aspx");
            }


            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT [Id], [books_title], [books_image], [books_pdf], [books_video], [books_author_name]," +
                "[books_isbn], [avaliable_qty] FROM [books]";
            cmd.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(dataTable);
            r1.DataSource = dataTable;
            r1.DataBind();
        }
        public string checkvideo(object myvalue, object id)
        {
            if (string.IsNullOrEmpty(myvalue.ToString()))
            {
                return "Not avaliable";
            }

            else
            {
                myvalue = "../librarian/" + myvalue.ToString();
                return "<a href='"+ myvalue.ToString() + "' style='color:green'>View video</a>";
            }
        }
        public string checkpdf(object myvalue1, object id1)
        {
            if (string.IsNullOrEmpty(myvalue1.ToString()))
            {
                return "Not avaliable";
            }

            else
            {
                myvalue1 = "../librarian/" + myvalue1.ToString();
                return "<a href='" + myvalue1.ToString() + "' style='color:green'>View pdf</a";

            }
        } 
    }
}