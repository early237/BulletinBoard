using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BulletinBoard
{
    public partial class AdminConsole : System.Web.UI.Page
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

                // LOADS TABLE TO SHOW ALL USERS
                SQLDatabase.DatabaseTable module_table = new SQLDatabase.DatabaseTable("Users");   
                module_table.Bind(DataList1);

            }
        }
        protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                DataListItem i = e.Item;
                System.Data.DataRowView r = ((System.Data.DataRowView)e.Item.DataItem); 

                // FINDS THE LABELS INSIDE MY DATALIST TO DISPLAY DATABASE ATTRIBUTE DATA
                Label UserID_LBL = (Label)e.Item.FindControl("UsersID_Label");
                Label Name_LBL = (Label)e.Item.FindControl("Name_Label"); 
                Label Username_LBL = (Label)e.Item.FindControl("Username_Label");       
                Label Password_LBL = (Label)e.Item.FindControl("Password_Label");
                Label LastLoginDate_LBL = (Label)e.Item.FindControl("LLD_Label");
                Label LastLoginTime_LBL = (Label)e.Item.FindControl("LLT_Label");

                UserID_LBL.Text = r["UsersID"].ToString();             
                Name_LBL.Text = r["Name"].ToString();           
                Username_LBL.Text = r["Username"].ToString();    
                Password_LBL.Text = r["Password"].ToString();
                LastLoginDate_LBL.Text = r["LastLoginDate"].ToString();
                LastLoginTime_LBL.Text = r["LastLoginTime"].ToString();

                Button ViewButton = (Button)e.Item.FindControl("ViewButton");  
                ViewButton.CommandArgument = i.ItemIndex.ToString(); 
                ViewButton.CommandName = "View";
            }
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "View")   
            {
                // WHEN VIEW BUTTON CLICKED WE GO TO THAT SPECIFIC RECORD TO BE DISPLAYED ON THE NEXT SCREEN
                int index = int.Parse((string)e.CommandArgument);  

                SQLDatabase.DatabaseTable module_table = new SQLDatabase.DatabaseTable("Users"); 

                SQLDatabase.DatabaseRow row = module_table.GetRow(index); 

                Session["Users"] = row;   

                Response.Redirect("AdminUsers.aspx"); 
            }
        }

        protected void bGoBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}