using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BulletinBoard
{
    public partial class Boards : System.Web.UI.Page
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

                SQLDatabase.DatabaseTable module_table = new SQLDatabase.DatabaseTable("Boards");

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
                Label Title_LBL = (Label)e.Item.FindControl("Title_Label");
                Label Username_LBL = (Label)e.Item.FindControl("Username_Label");
                Label Date_LBL = (Label)e.Item.FindControl("Date_Label");      
                Label Time_LBL = (Label)e.Item.FindControl("Time_Label"); 

                Title_LBL.Text = r["Title"].ToString();
                Username_LBL.Text = r["Username"].ToString();  
                Date_LBL.Text = r["DateCreated"].ToString();   
                Time_LBL.Text = r["TimeCreated"].ToString();     

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

                SQLDatabase.DatabaseTable module_table = new SQLDatabase.DatabaseTable("Boards"); 

                SQLDatabase.DatabaseRow row = module_table.GetRow(index); 
               
                Session["Boards"] = row;

                Response.Redirect("ViewBoard.aspx");
            }
        }

        protected void bGoBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dashboard.aspx");
        }
    }
}