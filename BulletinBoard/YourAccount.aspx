<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="YourAccount.aspx.cs" Inherits="BulletinBoard.YourAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Your Account</title>

     <%--  ITS IMPORTANT TO KNOW THAT I HAVE IMPLEMENTED THE BOOTSTRAP LIBRARY TO AID IN THE CSS ASPECTS OF THIS PROJECT --%>

     <!--Style Sheets-->
  <link rel="stylesheet" href="YourAccount.css"/>
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
         <li class="active"><a href="#"> Username:  <asp:Label ID="lUsername1" runat="server" Text="Label "></asp:Label></a></li>
        <li><a href="#"> Last Login Date: <asp:Label ID="lLLD" runat="server" Text="Label "></asp:Label></a></li>
        <li><a href="#">Last Login Time: <asp:Label ID="lLLT" runat="server" Text="Label "></asp:Label></a></li>
         <li><a href="Index.aspx"><span class="glyphicon glyphicon-remove-sign"></span> Log Out</a></li>
      </ul>
    </div>
  </div>
</nav>

    <h1>Your Account </h1>
    <h2>Change your account details if you need </h2>
   
    <div class="text-center" >
<div class="container">    
  <div class="row">
      <div class="panel panel-danger">
        <div class="panel-heading">Update Details... </div>
        <div class="panel-body">
    
 <form id="form1" runat="server">
        <div>
             <strong><asp:Label ID="lND" runat="server"></asp:Label></strong>
            <br />
            <asp:Label ID="lName" runat="server" Text="Name"></asp:Label>
            <br />
            <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
            <br />
            <strong>  <asp:Label ID="lUD" runat="server"></asp:Label></strong>
            <br />
            <asp:Label ID="lUsername" runat="server" Text="Username"></asp:Label>
            <br />
            <asp:TextBox ID="tbUsername" runat="server"></asp:TextBox>
            <br />
            <strong> <asp:Label ID="lPD" runat="server"></asp:Label></strong>
            <br />
            <asp:Label ID="lPassword" runat="server" Text="Password"></asp:Label>
            <br />
            <asp:TextBox ID="tbPassword" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="bUpdate" runat="server" Text="Update" OnClick="bUpdate_Click" />
            <asp:Button ID="bGoBack" runat="server" Text="Go Back" OnClick="bGoBack_Click"/>
        </div>
    </form>

     </div>
          </div>
        </div>
    </div>
    </div>

   <footer class="container-fluid text-center">
  <p>©By James Early</p>  
</footer>
</body>
</html>
