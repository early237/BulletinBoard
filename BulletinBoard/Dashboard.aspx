<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="BulletinBoard.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dashboard</title>

     <%--  ITS IMPORTANT TO KNOW THAT I HAVE IMPLEMENTED THE BOOTSTRAP LIBRARY TO AID IN THE CSS ASPECTS OF THIS PROJECT --%>

    <!--StyleSheets-->
    <link rel="stylesheet" href="Dashboard.css"/>
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
        <h1>Welcome to the Dashboard!</h1>
            <h2> Please use the buttons below to begin...</h2>
     </div>
        </div>
    </div>
    </div>


    <div class="text-center" >
<div class="container">    
  <div class="row">
        <div class="panel-heading"></div>
        <div class="panel-body" >
    <form id="form1" runat="server">

        <asp:ImageButton ID="bNewBoard" runat="server" OnClick="bNewBoard_Click" Height="112px" Width="145px" ImageUrl="img/greenplus.jpg"  />
        <asp:ImageButton ID="bViewBoards" runat="server" OnClick="bBoards_Click" Height="112px" Width="145px" ImageUrl="img/mg.png"  />
        <asp:ImageButton ID="bYourAccount" runat="server" OnClick="bViewAccount_Click" Height="112px" Width="145px" ImageUrl="img/cog.png" />
        <asp:ImageButton ID="bLogout" runat="server" OnClick="bLogOut_Click" Height="112px" Width="145px" ImageUrl="img/x.png"  />
        
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
