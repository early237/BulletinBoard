<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewBoard.aspx.cs" Inherits="BulletinBoard.NewBoard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>New Board</title>

     <%--  ITS IMPORTANT TO KNOW THAT I HAVE IMPLEMENTED THE BOOTSTRAP LIBRARY TO AID IN THE CSS ASPECTS OF THIS PROJECT --%>

     <!--StyleSheets-->
  <link rel="stylesheet" href="NewBoard.css"/>
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
  
     <h1>Create New Board</h1>
            <h2>Whats on your mind? </h2>

    <div class="text-center" >
<div class="container">    
  <div class="row">
      <div class="panel panel-danger">
        <div class="panel-heading">New Board... </div>
  
        <div class="panel-body">
  
        <form id="form1" runat="server">
 
            <asp:Label ID="lTitle" runat="server" Text="Title"></asp:Label>
            <br />
            <asp:TextBox ID="tbTitle" runat="server"></asp:TextBox>
            <br />
        </div>

        <div>
            <asp:Label ID="lContent" runat="server" Text="Body"></asp:Label>
            <br /> 
            <asp:TextBox ID="tbContent" runat="server" Height="182px" Width="355px" TextMode="MultiLine"></asp:TextBox>
            <br /> 
            <asp:Button ID="bSubmit" runat="server" Text="Submit" OnClick="bSubmit_Click" />
            <br /> 
            <asp:Button ID="bGoBack" runat="server" Text="Go Back" OnClick="bGoBack_Click" />
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
