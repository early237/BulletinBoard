<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewBoard.aspx.cs" Inherits="BulletinBoard.ViewBoard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>View Board</title>

     <%--  ITS IMPORTANT TO KNOW THAT I HAVE IMPLEMENTED THE BOOTSTRAP LIBRARY TO AID IN THE CSS ASPECTS OF THIS PROJECT --%>
   
 
     <!--Style Sheets-->
  <link rel="stylesheet" href="ViewBoard.css"/>
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
  
  <!--Script-->
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body>

    <!--Logo-->
<div class="jumbotron">
  <div class="container text-center">
   <img src="img/bulletin-board.jpg">
  </div>
</div>

    <nav class="navbar navbar-inverse">
  <div class="container-fluid">
    <div class="navbar-header">
      <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#myNavbar">
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>                        
      </button>
      <a class="navbar-brand" href="#">Bulletin Board</a>
    </div>
    <div class="collapse navbar-collapse" id="myNavbar">
      <ul class="nav navbar-nav">
         <li class="active"><a href="#"> Username:  <asp:Label ID="lName" runat="server" Text="Label "></asp:Label></a></li>
        <li><a href="#"> Last Login Date: <asp:Label ID="lLLD" runat="server" Text="Label "></asp:Label></a></li>
        <li><a href="#">Last Login Time: <asp:Label ID="lLLT" runat="server" Text="Label "></asp:Label></a></li>
         <li><a href="Index.aspx"><span class="glyphicon glyphicon-remove-sign"></span> Log Out</a></li>
      </ul>
    </div>
  </div>
</nav>
   
    <h1>Post</h1>
    <h2>Leave a comment! </h2>

    <div class="text-center" >
<div class="container">    
  <div class="row">

        <div class="panel-body">
  
         <form id="form1" runat="server">
        <div>
        <span class="auto-style1">                       
          <strong><asp:Label ID="Title_Label" runat="server" Font-Names="Arial"></asp:Label>&nbsp;</strong>
            <br />
        <asp:Label ID="Body_Label" runat="server" Font-Names="Arial"></asp:Label>&nbsp;
             <br />
        <asp:Label ID="Username_Label" runat="server" Font-Names="Arial"></asp:Label>&nbsp;
            <br />
            </div>
        <br />
        <div>
            <asp:Label ID="lComments" runat="server" Text="Comments"></asp:Label>
            <br />
            <asp:TextBox ID="tbViewComments" runat="server" Height="147px" Width="708px" ReadOnly="True" TextMode="MultiLine"></asp:TextBox>
            <br />
            </div>
        <br />
        <div>
            <asp:Label ID="lAddComment" runat="server" Text="Add Comment"></asp:Label>
            <br />
            <asp:TextBox ID="tbAddComment" runat="server"></asp:TextBox>

        <br />
            <asp:Button ID="bAdd_Comment" runat="server" Text="Add Comment" OnClick="bAdd_Comment_Click" />
        <br />
        <asp:Button ID="BackButton" runat="server" Text="Back" OnClick="BackButton_Click" />

    </div>
    </form>
     </div>
        </div>
    </div>
    </div>

    <footer class="container-fluid text-center">
  <p>©By James Early</p>  
</footer>
</body>
</html>
