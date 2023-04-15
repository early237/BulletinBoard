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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void bRegister_Click(object sender, EventArgs e)
        {
            // RUNS AN SQL QUERY TO SELECT ALL DATA FROM USERS TO SEE IF THE USERNAME ENTERED HAS ALREADY BEEN TAKEN
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);     // Grab the conection string for accessing the database.
            SqlCommand cmd = new SqlCommand("select Username from [dbo].[Users] where Username = @Username");
            cmd.Connection = con;
            con.Open();
            cmd.Parameters.AddWithValue("@Username", tbUsername.Text);
            SqlDataReader dr = cmd.ExecuteReader();

            // IF IT HAS -----
            if (dr.HasRows)
            {

                MessageBox.Show("Username Taken, try another");
                Response.Redirect("Register.aspx");

            }

            // IF IT HASNT -----
            else
            {
                // RUNS AN INSERT STATEMENT TO ADD NEW USER BASED ON VALUES INPUTTED
                SQLDatabase.DatabaseTable module_table = new SQLDatabase.DatabaseTable("Users"); 

                SQLDatabase.DatabaseRow new_row = module_table.NewRow();  

                string new_id = module_table.GetNextIDUsers().ToString(); 

                string name = tbName.Text;
                string username = tbUsername.Text;
                string password = tbPassword.Text;
                
                new_row["UsersID"] = new_id;                               
                new_row["Name"] = name;            
                new_row["Username"] = username;
                new_row["Password"] = password;
                new_row["UserType"] = "Member";

                module_table.Insert(new_row);                         

                MessageBox.Show("You have now Registered");
                Response.Redirect("Index.aspx");   
            }
        }
        protected void bGoBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}