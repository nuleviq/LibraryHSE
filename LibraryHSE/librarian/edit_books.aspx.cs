using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

namespace LibraryHSE.librarian
{
    public partial class edit_books : System.Web.UI.Page
    {
        string book_image_name = "";
        string book_pdf = "";
        string book_video = "";
        string path = "";
        string path2 = "";
        string path3 = "";
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
            if (IsPostBack)
                return;

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT[Id], [books_title], [books_image], [books_pdf], [books_video], [books_author_name]," +
                "[books_isbn], [avaliable_qty] FROM [books] WHERE Id="+id+"";
            cmd.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(dataTable);
            
            foreach (DataRow  dr in dataTable.Rows)
            {
                booktitle.Text = dr["books_title"].ToString();
                authorname.Text = dr["books_author_name"].ToString();
                isbn.Text = dr["books_isbn"].ToString();
                quantity.Text = dr["avaliable_qty"].ToString();
                bookimage.Text = dr["books_image"].ToString();
                bookpdf.Text = dr["books_pdf"].ToString();
                bookvideo.Text = dr["books_video"].ToString();
            }
        }

        protected void b1_Click(object sender, EventArgs e)
        {
            
           
            if (string.IsNullOrEmpty(f1.FileName.ToString()))
            {
                book_image_name = RandomPassword.GetRandomPassword(10) + ".jpg";
                f1.SaveAs(Request.PhysicalApplicationPath.ToString() + "/librarian/books_images/" + book_image_name.ToString());
                path = "books_images/" + book_image_name.ToString();
                insert_to_database("update [books] set [books_title]='"+ booktitle.Text +"'," +
                    "[books_image]='"+ path.ToString() +"',[books_author_name]='"+ authorname.Text +"',[books_isbn]='"+ isbn.Text 
                    +"',[avaliable_qty]='"+ quantity.Text+"'");
            }

            if (!string.IsNullOrEmpty(f2.FileName.ToString()))
            {
                book_video = RandomPassword.GetRandomPassword(10) + ".mp4";
                f3.SaveAs(Request.PhysicalApplicationPath + "/librarian/books_videos/" + book_video.ToString());
                path3 = "books_videos/" + book_video.ToString();
                insert_to_database("update [books] set [books_title]='" + booktitle.Text + "'," +
                    "[books_pdf]='" + path2.ToString() + "',[books_author_name]='" + authorname.Text + "',[books_isbn]='" + isbn.Text
                    + "',[avaliable_qty]='" + quantity.Text + "'");
            }
            if (!string.IsNullOrEmpty(f3.FileName.ToString()))
            {
                book_video = RandomPassword.GetRandomPassword(10) + ".mp4";
                f3.SaveAs(Request.PhysicalApplicationPath + "/librarian/books_videos/" + book_video.ToString());
                path3 = "books_videos/" + book_video.ToString();
                insert_to_database("update [books] set [books_title]='" + booktitle.Text + "'," +
                    "[books_video]='" + path3.ToString() + "',[books_author_name]='" + authorname.Text + "',[books_isbn]='" + isbn.Text
                    + "',[avaliable_qty]='" + quantity.Text + "'");
            }

            if (string.IsNullOrEmpty(f1.FileName.ToString()) && string.IsNullOrEmpty(f2.FileName.ToString()) && string.IsNullOrEmpty(f3.FileName.ToString())){
                insert_to_database("update [books] set [books_title]='" + booktitle.Text
                    + "',[books_author_name]='" + authorname.Text + "',[books_isbn]='" + isbn.Text
                    + "',[avaliable_qty]='" + quantity.Text + "'");
            }

            Response.Redirect("display_all_books.aspx");
        }
        private void insert_to_database(string command)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = command;
            cmd.ExecuteNonQuery();
        }
    }
}