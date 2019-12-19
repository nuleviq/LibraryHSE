using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace LibraryHSE.librarian
{
    public partial class add_books : System.Web.UI.Page
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

        protected void b1_Click(object sender, EventArgs e)
        {
            string path = "";
            f1.SaveAs(Request.PhysicalApplicationPath + "/librarian/books_images/" + f1.FileName.ToString());
            path = "books_images/" + f1.FileName.ToString(); 
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into books values('"+ booktitle.Text +"','"+ path.ToString() +"','"+ authorname.Text +"','"+ isbn.Text +"','"+ quantity.Text +"')";
            cmd.ExecuteNonQuery();
            msg.Style.Add("display", "block");

        }
    }
}