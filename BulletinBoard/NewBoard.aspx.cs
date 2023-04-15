using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BulletinBoard
{
    public partial class NewBoard : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            // FINDS THE SESSION VARIABLES TO SET AS HTML LABELS
            string Username = Session["Username"].ToString();
            string LLD = Session["LLD"].ToString();
            string LLT = Session["LLT"].ToString();
            lName.Text = Username;
            lLLD.Text = LLD;
            lLLT.Text = LLT;
        }

        protected void bSubmit_Click(object sender, EventArgs e)
        {
            // EXECUTES AN INSERT STATEMENT TO CREATE A NEW BOARD IN THE DATABASE
            SQLDatabase.DatabaseTable module_table = new SQLDatabase.DatabaseTable("Boards");   

            SQLDatabase.DatabaseRow new_row = module_table.NewRow();    
       
            // USES SESSIONS VALUES TO DETERMINE WHAT BOARD BELONGS TO WHO
            string new_id = module_table.GetNextIDBoards().ToString();   
            string title = tbTitle.Text;
            string body = tbContent.Text;
            DateTime now = DateTime.Now;
            string date = now.GetDateTimeFormats('d')[0];
            string time = now.GetDateTimeFormats('t')[0];
            string valueFromSession = Session["UsersID"].ToString();
            string Username = Session["Username"].ToString();

            // ROWS TO INSERT
            new_row["BoardsID"] = new_id;                                 
            new_row["Title"] = title;
            new_row["Body"] = body;  
            new_row["UsersID"] = valueFromSession;
            new_row["Username"] = Username;
            new_row["DateCreated"] = date;
            new_row["TimeCreated"] = time;

            module_table.Insert(new_row);                          

            MessageBox.Show("New Board Created");
        }

        protected void bGoBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dashboard.aspx"); 
        }
    }
}