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
            string books_image_name = RandomPassword.GetRandomPassword(10) + ".jpg";
            string books_pdf = "";
            string books_videos = "";
            string path = "";
            string path2 = "";
            string path3 = "";
            f1.SaveAs(Request.PhysicalApplicationPath + "/librarian/books_images/" + books_image_name.ToString());
            path = "books_images/" + books_image_name.ToString();

            if (f2.FileName.ToString() != "")
            {
                books_pdf = RandomPassword.GetRandomPassword(10) + ".pfd";  
                
                f2.SaveAs(Request.PhysicalApplicationPath + "/librarian/books_pdf/" + books_pdf.ToString());
                path2 = "books_pdf/" + books_pdf.ToString();
            }
            if (f3.FileName.ToString() != "")
            {
                books_videos = RandomPassword.GetRandomPassword(10) + ".mp4";
                 
                f3.SaveAs(Request.PhysicalApplicationPath + "/librarian/books_videos/" + books_videos.ToString());
                path3 = "books_videos/" + books_videos.ToString();
            } 




            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into books values('"+ booktitle.Text +"','"+ path.ToString() +"','"+ path2.ToString() + "','" + path3.ToString() +  authorname.Text +"','"+ isbn.Text +"','"+ quantity.Text +"')";
            cmd.ExecuteNonQuery();
            msg.Style.Add("display", "block");

        }
    }
}