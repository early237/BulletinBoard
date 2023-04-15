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
    public partial class YourAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // FINDS THE SESSION VARIABLES TO SET AS HTML LABELS
            string Username = Session["Username"].ToString();
            string LLD = Session["LLD"].ToString();
            string LLT = Session["LLT"].ToString();
            lUsername1.Text = Username;
            lLLD.Text = LLD;
            lLLT.Text = LLT;

            // SELECTS THE DETAILS OF THE USER CURRENTLY LOGGED IN
            string UsersID = Session["UsersID"].ToString();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from [dbo].[Users] where UsersID = @UID");
            cmd.Connection = con;
            con.Open();
            cmd.Parameters.AddWithValue("@UID", UsersID);
          
            SqlDataReader dr = cmd.ExecuteReader();
            
            // WHILE LOOP TO DISPLAY DATA
            while (dr.Read())
            {
                lND.Text += dr.GetString(1);
                lUD.Text += dr.GetString(2);
                lPD.Text += dr.GetString(3);
            }
        }

        protected void bUpdate_Click(object sender, EventArgs e)
        {
            // UPDATE QUERY TO CHANGE DETAILS OF CURRENT USER BASED ON TEXTBOX VALUES
            string UsersID = Session["UsersID"].ToString();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Update [dbo].[Users] SET Name = @name, Username = @Username, Password = @Pass where UsersID = @ID");
            cmd.Connection = con;
            con.Open();
            cmd.Parameters.AddWithValue("@Name", tbName.Text);
            cmd.Parameters.AddWithValue("@Username", tbUsername.Text);
            cmd.Parameters.AddWithValue("@Pass", tbPassword.Text);
            cmd.Parameters.AddWithValue("@ID", UsersID);
            string Result = (string)cmd.ExecuteScalar();

            MessageBox.Show("Details Updated");
            Response.Redirect("YourAccount.aspx");
        }

        protected void bGoBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dashboard.aspx");
        }
    }
}