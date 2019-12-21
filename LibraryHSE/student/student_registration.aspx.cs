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
            con.Open();
        }

        protected void b1_Click(object sender, EventArgs e)
        {
            int count_enrollment = 0;
            int count_username = 0;
            if (IsReCaptchValid())
            {

                //sql command for checking unique enrollment number
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "SELECT [Id], [firstname], [lastname], [enrollment_no], [username], [password], [email]," +
                    "[contact], [student_img], [approved] FROM [student_registration] WHERE [enrollment_no]='" + enrollmentno.Text+"'";
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(dt1);
                count_enrollment = Convert.ToInt32(dt1.Rows.Count.ToString());



                // checking unique enrollment number
                if (count_enrollment > 0)
                {
                    Response.Write("<script>alert('This enrollment number is already exist');</script>");
                }
                else
                {
                    //sql command for checking unique username
                    SqlCommand cmd2 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "SELECT [Id], [firstname], [lastname], [enrollment_no], [username], [password], [email]," +
                        "[contact], [student_img], [approved] FROM [student_registration] WHERE [username]='" + username.Text + "'";
                    cmd1.ExecuteNonQuery();
                    DataTable dt2 = new DataTable();
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd1);
                    da1.Fill(dt2);
                    count_username = Convert.ToInt32(dt2.Rows.Count.ToString());
                    string randomno = RandomPassword.GetRandomPassword(10) + ".jpg";
                    string path = "";
                    f1.SaveAs(Request.PhysicalApplicationPath + "/student/student_img/" + randomno.ToString());
                    path = "student/student_img" + randomno.ToString();
                    if (count_username > 0)
                    {
                        Response.Write("<script>alert('This username already exist, please try again');</script>");
                    }
                    else
                    {
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "INSERT INTO [student_registration] VALUES ('" + firstname.Text + "','" + lastname.Text + "','" + enrollmentno.Text + "','" +
                            username.Text + "','" + password.Text + "','" + email.Text + "','" + contact.Text + "','" + path.ToString() + "','no')"; ;
                        cmd.ExecuteNonQuery();

                        Response.Write("<script>alert('Record inserted successfully');</script>");
                    }
                }
                
            }
            else
            {
                lblMessage1.Text = "Invalid captcha";
            }
            


        }
        public bool IsReCaptchValid()
        {
            var result = false;
            var captchaResponse = Request.Form["g-recaptcha-response"];
            var secretKey = "6Lew3MgUAAAAAABPGN4uwXGGATu5Ga6H5aqalu4f";
            var apiUrl = "https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}";
            var requestUri = string.Format(apiUrl, secretKey, captchaResponse);
            var request = (HttpWebRequest)WebRequest.Create(requestUri);

            using (WebResponse response = request.GetResponse())
            {
                using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                {
                    JObject jResponse = JObject.Parse(stream.ReadToEnd());
                    var isSuccess = jResponse.Value<bool>("success");
                    result = (isSuccess) ? true : false;
                }
            }
            return result;
        }
    }
    
}