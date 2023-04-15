using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace BulletinBoard
{
    public partial class Index : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            try { 
            // SQL COMMANDS TO GATHER KEY INFORMATION TO LOGIN AND TO ASSIGN TO SESSIONS
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);     // Grab the conection string for accessing the database.
            SqlCommand cmd = new SqlCommand("select Count(*) from [dbo].[Users] where Username=@uname and Password=@password");
            cmd.Connection = con;
            con.Open();
            cmd.Parameters.AddWithValue("@uname", tbUsername.Text);
            cmd.Parameters.AddWithValue("@password", tbPassword.Text);

            SqlCommand cmd1 = new SqlCommand("select UserType from [dbo].[Users] where Username=@uname and Password=@password");
            cmd1.Connection = con;
            cmd1.Parameters.AddWithValue("@uname", tbUsername.Text);
            cmd1.Parameters.AddWithValue("@password", tbPassword.Text);

            SqlCommand cmd2 = new SqlCommand("select UsersID from [dbo].[Users] where Username=@uname and Password=@password");
            cmd2.Connection = con;
            cmd2.Parameters.AddWithValue("@uname", tbUsername.Text);
            cmd2.Parameters.AddWithValue("@password", tbPassword.Text);

            SqlCommand cmd22 = new SqlCommand("select UsersID from [dbo].[Users] where Username=@uname");
            cmd22.Connection = con;
            cmd22.Parameters.AddWithValue("@uname", tbUsername.Text);
            
            DateTime now = DateTime.Now;
            string date = now.GetDateTimeFormats('d')[0];
            string time = now.GetDateTimeFormats('t')[0];
            SqlCommand cmd3 = new SqlCommand("Update [dbo].[Users] SET LastLoginDate = @date, LastLoginTime = @time, SuccessfulLogin = @SL where Username=@uname and Password=@password");
            cmd3.Connection = con;
            cmd3.Parameters.AddWithValue("@uname", tbUsername.Text);
            cmd3.Parameters.AddWithValue("@password", tbPassword.Text);
            cmd3.Parameters.AddWithValue("@date", date);
            cmd3.Parameters.AddWithValue("@time", time);
            cmd3.Parameters.AddWithValue("@SL", "YES");

            SqlCommand cmd4 = new SqlCommand("select Username from [dbo].[Users] where Username=@uname and Password=@password");
            cmd4.Connection = con;
            cmd4.Parameters.AddWithValue("@uname", tbUsername.Text);
            cmd4.Parameters.AddWithValue("@password", tbPassword.Text);
         
            SqlCommand cmd5 = new SqlCommand("select LastLoginDate from [dbo].[Users] where Username=@uname and Password=@password");
            cmd5.Connection = con;
            cmd5.Parameters.AddWithValue("@uname", tbUsername.Text);
            cmd5.Parameters.AddWithValue("@password", tbPassword.Text);

            SqlCommand cmd6 = new SqlCommand("select LastLoginTime from [dbo].[Users] where Username=@uname and Password=@password");
            cmd6.Connection = con;
            cmd6.Parameters.AddWithValue("@uname", tbUsername.Text);
            cmd6.Parameters.AddWithValue("@password", tbPassword.Text);

            //EXECUTES CMD AND ASSIGNS RESULT AS DATASET
            int Result = (int)cmd.ExecuteScalar();
            
            if (Result > 0)
            {
                // IF USER LOGINS IN CORRECTLY EXECUTES THE SQL COMMANDS
                int Result2 = (int)cmd2.ExecuteScalar();
                string Result3 = (string)cmd1.ExecuteScalar();
                string Result4 = (string)cmd3.ExecuteScalar();
                string Result5 = (string)cmd4.ExecuteScalar();
                string Result6 = (string)cmd5.ExecuteScalar();
                string Result7 = (string)cmd6.ExecuteScalar();

                // SETS SESSION VARIABLES AS RESULTS FROM SQL QUERYS
                Session["UsersID"] = Result2;
                Session["Username"] = Result5;
                Session["LLD"] = Result6;
                Session["LLT"] = Result7;

                //IF USER IS MEMBER
                if (Result3 == "Member")
                {
                    MessageBox.Show("Welcome");
                    Response.Redirect("Dashboard.aspx");
                    con.Close();

                }

                // IF USER IS AN ADMIN
                if(Result3 == "Admin")
                {
                    MessageBox.Show("Welcome Admin");
                    Response.Redirect("AdminConsole.aspx");
                    con.Close();
                }
               
             
            }
            else
            {
                // EXECUTES SQL COMMAND TO FIND USERSID OF THE MISTYPED USER TO THEN RECORD FAILED ATTEMPT IN DATABASE
                int Result8 = (int)cmd22.ExecuteScalar();
                Session["UsersID"] = Result8;
                SQLDatabase.DatabaseTable module_table = new SQLDatabase.DatabaseTable("LoginAttempt");
                SQLDatabase.DatabaseRow new_row = module_table.NewRow();
                string new_id = module_table.GetNextIDLoginAttempt().ToString();
                string UsersID = Session["UsersID"].ToString();
                string Attempt = "Wrong";

                new_row["LoginAttemptsID"] = new_id;
                new_row["UsersID"] = UsersID;
                new_row["Attempt"] = Attempt;
                
               
                MessageBox.Show("Incorrect, Attempt Logged");
                
                // INSERTS INTO LOGINATTEMPT TABLE
                module_table.Insert(new_row);
            }
            }
            catch
            {

            }
        }

        protected void bRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}