using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BulletinBoard
{
    public partial class Dashboard : System.Web.UI.Page
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

        // USED IMAGE BUTTONS TO REDIRECT TO DIFFERENT PAGES
        protected void bNewBoard_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewBoard.aspx");
        }

        protected void bLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void bBoards_Click(object sender, EventArgs e)
        {
            Response.Redirect("Boards.aspx");
        }

        protected void bViewAccount_Click(object sender, EventArgs e)
        {
            Response.Redirect("YourAccount.aspx");
        }

    }
}