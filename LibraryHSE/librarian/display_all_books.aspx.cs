﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace LibraryHSE.librarian
{
    public partial class display_all_books : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\killmepls\source\repos\LibraryHSE\LibraryHSE\App_Data\lms.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

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
            if(string.IsNullOrEmpty(myvalue.ToString()))
            {
                return myvalue.ToString();
            }

            else
            {
                return "<a href='delete_files.aspx?id="+ id +"' style='color:red'>delete video</a";
            }
        }
        public string checkpdf(object myvalue1, object id1)
        {
            if (string.IsNullOrEmpty(myvalue1.ToString()))
            {
                return myvalue1.ToString(); 
            }

            else
            {
                return "<a href='delete_files.aspx?id1=" + id1 + "' style='color:red'>delete pdf</a";

            }
        }
    }
}