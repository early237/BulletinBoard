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
    public partial class ViewBoard : System.Web.UI.Page
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

                // RUNS QUERY TO SELECT BOARD USING THE SESSION VARIABLE
                SQLDatabase.DatabaseRow r = (SQLDatabase.DatabaseRow)Session["Boards"]; 

                Title_Label.Text = r["Title"].ToString();
                Body_Label.Text = r["Body"].ToString();
                Username_Label.Text = "By " + r["Username"].ToString();

                Session["BoardsID"] = r["BoardsID"].ToString();

                string BoardsID = Session["BoardsID"].ToString();
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                SqlCommand cmd = new SqlCommand("select * from [dbo].[Posts] where BoardsID = @BID");
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("@BID", BoardsID );

                SqlDataReader dr = cmd.ExecuteReader();
      
                // WHILE LOOP TO DISPLAY THE DATA GATHERED FROM THE BOARDS TABLE USING COLUMN INDEXES
                while (dr.Read())
                {
               
                    tbViewComments.Text += dr.GetString(1) + "\t";
                    tbViewComments.Text += dr.GetString(3) + "\t";
                    tbViewComments.Text += dr.GetString(5) + "\t";
                    tbViewComments.Text += dr.GetString(6) + "\n";
                    tbViewComments.Text += "---------------------" + "\n";
  
                }
            }
        }

        protected void BackButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Boards.aspx");
        }

        protected void bAdd_Comment_Click(object sender, EventArgs e)
        {
            // INSERT QUERY TO ADD A COMMENT ON A POST
            SQLDatabase.DatabaseTable module_table = new SQLDatabase.DatabaseTable("Posts"); 

            SQLDatabase.DatabaseRow new_row = module_table.NewRow(); 

            string new_id = module_table.GetNextIDPosts().ToString(); 

            string body = tbAddComment.Text;
            string usersID = Session["UsersID"].ToString();
            string username = Session["Username"].ToString();
            string boardsID = Session["BoardsID"].ToString();
            DateTime now = DateTime.Now;
            string date = now.GetDateTimeFormats('d')[0];
            string time = now.GetDateTimeFormats('t')[0];

            new_row["PostsID"] = new_id;                                
            new_row["Text"] = body;          
            new_row["UsersID"] = usersID;
            new_row["Username"] = username;
            new_row["BoardsID"] = boardsID;
            new_row["DateCreated"] = date;
            new_row["TimeCreated"] = time;

            module_table.Insert(new_row);                          

            MessageBox.Show("You have added a new comment");

            Response.Redirect("ViewBoard.aspx");
        }
    }
}