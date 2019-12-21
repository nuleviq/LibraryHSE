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
    public partial class student_login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\killmepls\source\repos\libraryhse\LibraryHSE\App_Data\lms.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

        }
        
        protected void b1_Click1(object sender, EventArgs e)
        {
            int i = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT [Id], [firstname], [lastname], [enrollment_no], [username], [password], [email]," +
                        "[contact], [student_img], [approved] FROM [student_registration] WHERE [username]='" + username.Text + "' AND [password]='" + password.Text + "' AND [approved]='yes'";
            cmd.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(dataTable);
            i = Convert.ToInt32(dataTable.Rows.Count.ToString());
            if (i > 0)
            {
                Session["student"] = username.Text;
                Response.Redirect("student_display_all_books.aspx");
            }
            else
            {
                error.Style.Add("display", "block");
            }
        }
    }
}