using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace BulletinBoard
{
    public partial class AdminUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // FINDS THE SESSION VARIABLES TO SET AS HTML LABELS
                string Username = Session["Username"].ToString();
                string LLD = Session["LLD"].ToString();
                string LLT = Session["LLT"].ToString();
                lName.Text = Username;
                lLLD.Text = LLD;
                lLLT.Text = LLT;

                // DISPLAYS THE USER BASED ON THE INFORMATION FROM PREVIOUS FORM - SHOWS DATA BASED ON THE SESSION VARIABLE (r)
                SQLDatabase.DatabaseRow r = (SQLDatabase.DatabaseRow)Session["Users"];
             
                UsersID_Label.Text = r["UsersID"].ToString();
                Name_Label.Text = r["Name"].ToString();
                Username_Label.Text = r["Username"].ToString();
                Password_Label.Text = r["Password"].ToString();
                LLD_Label.Text = r["LastLoginDate"].ToString();
                LLT_Label.Text = r["LastLoginTime"].ToString();

                Session["UsersID"] = r["UsersID"].ToString();
        
            }
        }

        protected void BackButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminConsole.aspx");
        }

        protected void bChangePass_Click(object sender, EventArgs e)
        {

            // RUNS UPDATE QUERY TO CHANGE CURRENT USERS PASSWORD USING VALUE IN TEXTBOX
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);     // Grab the conection string for accessing the database.
            SqlCommand cmd = new SqlCommand("Update [dbo].[Users] SET Password = @Pass where UsersID = @ID");
            cmd.Connection = con;
            con.Open();
            cmd.Parameters.AddWithValue("@Pass", tbChangePass.Text);
            cmd.Parameters.AddWithValue("@ID", Session["UsersID"]);
            string Result = (string)cmd.ExecuteScalar();

            MessageBox.Show("Password Changed");
            Response.Redirect("AdminUsers.aspx");
        }

        protected void bDelete_User_Click(object sender, EventArgs e)
        {
            // SAME APPROACH -- DELETES CURRENT USER BASED ON SESSION USERSID GATHERED BEFORE
            string UserID = Session["UsersID"].ToString();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("DELETE from [dbo].[Users] where UsersID = @UID");
            cmd.Connection = con;
            con.Open();
            cmd.Parameters.AddWithValue("@UID", UserID);
            string Result = (string)cmd.ExecuteScalar();
            MessageBox.Show("User Deleted");
            Response.Redirect("AdminConsole.aspx");
        }
    }
}