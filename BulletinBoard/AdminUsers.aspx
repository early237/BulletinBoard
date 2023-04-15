<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminUsers.aspx.cs" Inherits="BulletinBoard.AdminUsers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Users</title>

     <%--  ITS IMPORTANT TO KNOW THAT I HAVE IMPLEMENTED THE BOOTSTRAP LIBRARY TO AID IN THE CSS ASPECTS OF THIS PROJECT --%>
     
     <!--Style Sheets-->
  <link rel="stylesheet" href="AdminUsers.css"/>
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
  
  <!--Scripts-->
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
   
    <div class="text-center" >
<div class="container">    
  <div class="row">

        <div class="panel-body">
   <form id="form1" runat="server">
        <span class="auto-style1">

        <strong>View User</strong></span><br /><br />
      <strong>  <asp:Label ID="lUserIDView" runat="server" Text="ID: "></asp:Label>   </strong>                       
        <asp:Label ID="UsersID_Label" runat="server" Font-Names="Arial"></asp:Label>&nbsp;
            <br />
        <strong><asp:Label ID="lNameView" runat="server" Text="Name: "></asp:Label> </strong>
        <asp:Label ID="Name_Label" runat="server" Font-Names="Arial"></asp:Label>&nbsp;
            <br />
       <strong> <asp:Label ID="lUsernameView" runat="server" Text="Username: "></asp:Label> </strong>
       <asp:Label ID="Username_Label" runat="server" Font-Names="Arial"></asp:Label>&nbsp;
            <br />
       <strong> <asp:Label ID="lPasswordView" runat="server" Text="Password: "></asp:Label> </strong>
        <asp:Label ID="Password_Label" runat="server" Font-Names="Arial"></asp:Label>&nbsp;
            <br />
       <strong> <asp:Label ID="lLLDView" runat="server" Text="Last Login Date: "></asp:Label> </strong>
             <asp:Label ID="LLD_Label" runat="server" Font-Names="Arial"></asp:Label>&nbsp;
            <br />
       <strong><asp:Label ID="lLLTView" runat="server" Text="Last Login Time: "></asp:Label> </strong>
        <asp:Label ID="LLT_Label" runat="server" Font-Names="Arial"></asp:Label>&nbsp;
            <br />
            </div>
        <br />
        
        <br />
        <div>
            <asp:Label ID="lChangePass" runat="server" Text="Change Password"></asp:Label>
            <br />
            <asp:TextBox ID="tbChangePass" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Button ID="bChangePass" runat="server" Text="Submit" OnClick="bChangePass_Click" />
            <br />
          
            <asp:Button ID="bDelete_User" runat="server" Text="Delete User" OnClick="bDelete_User_Click" />
        
        <asp:Button ID="BackButton" runat="server" Text="Back" OnClick="BackButton_Click"  />
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
