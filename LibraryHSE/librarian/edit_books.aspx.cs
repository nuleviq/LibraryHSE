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
    public partial class edit_books : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\killmepls\source\repos\libraryhse\LibraryHSE\App_Data\lms.mdf;Integrated Security=True");
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            id = Convert.ToInt32(Request.QueryString["id"].ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from books where id="+id+"";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                bookstitle.Text = dr["books_title"].ToString();
                authorname.Text = dr["books_author_name"].ToString();
                isbn.Text = dr["books_isbn"].ToString();
                qty.Text = dr["available_qty"].ToString();
                booksimage.Text = dr["books_image"].ToString();
                bookspdf.Text = dr["books_pdf"].ToString();
                booksvideo.Text = dr["books_video"].ToString();
            }

        }
        protected void b1_Click(object sender, EventArgs e)
        {
            string books_image_name = "";
            string books_pdf = "";
            string books_videos = "";
            string path = "";
            string path2 = "";
            string path3 = "";
            
            if(f1.FileName.ToString()!="")
            {
                books_image_name = RandomPassword.GetRandomPassword(10) + ".jpg";
                f1.SaveAs(Request.PhysicalApplicationPath + "/librarian/books_images/" + books_image_name.ToString());
                path = "books_images/" + books_image_name.ToString();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into books values('" + booktitle.Text + "','" + path.ToString() + "','" + path2.ToString() + "','" + path3.ToString() + authorname.Text + "','" + isbn.Text + "','" + quantity.Text + "')";
                cmd.ExecuteNonQuery();
            }

            if (f2.FileName.ToString() != "")
            {
                books_pdf = RandomPassword.GetRandomPassword(10) + ".pfd";

                f2.SaveAs(Request.PhysicalApplicationPath + "/librarian/books_pdf/" + books_pdf.ToString());
                path2 = "books_pdf/" + books_pdf.ToString();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into books values('" + booktitle.Text + "','" + path.ToString() + "','" + path2.ToString() + "','" + path3.ToString() + authorname.Text + "','" + isbn.Text + "','" + quantity.Text + "')";
                cmd.ExecuteNonQuery();
            }
            if (f3.FileName.ToString() != "")
            {
                books_videos = RandomPassword.GetRandomPassword(10) + ".mp4";

                f3.SaveAs(Request.PhysicalApplicationPath + "/librarian/books_videos/" + books_videos.ToString());
                path3 = "books_videos/" + books_videos.ToString();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into books values('" + booktitle.Text + "','" + path.ToString() + "','" + path2.ToString() + "','" + path3.ToString() + authorname.Text + "','" + isbn.Text + "','" + quantity.Text + "')";
                cmd.ExecuteNonQuery();
            }

            if(f1.FileName.ToString()=="" && f2.FileName.ToString() == "" && f3.FileName.ToString() == "")


          

            msg.Style.Add("display", "block");



        }
    }
}