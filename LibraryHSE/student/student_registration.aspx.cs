using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json.Linq;
using System.Configuration;
using System.Net;
using System.IO;

namespace LibraryHSE.student
{
    public partial class student_registration : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\lms.mdf;Integrated Security=True"); 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open()
        }

        protected void b1_Click(object sender, EventArgs e)
        {
            string randomno = RandomPassword.GetRandomPassword(10) + ".jpg";
            string path = "";
            f1.SaveAs(Request.PhysicalApplicationPath + "/student/student_img/" + randomno.ToString());
            path = "student/student_img." + randomno.ToString();
           
            


            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "";
            cmd.ExecuteNonQuery();

            Response.Write("<script>alert('record inserted successfully');</script>");


        }
    }
    
}