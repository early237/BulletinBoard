<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="BulletinBoard.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

     <%--  ITS IMPORTANT TO KNOW THAT I HAVE IMPLEMENTED THE BOOTSTRAP LIBRARY TO AID IN THE CSS ASPECTS OF THIS PROJECT --%>

     <!--Style Sheets-->
  <link rel="stylesheet" href="Register.css"/>
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

    <h1>Register </h1>
    <h2>Fill in all fields to create a new account </h2>

    <div class="text-center" >
<div class="container">    
  <div class="row">
      <div class="col-md-4 col-md-offset-4">
      <div class="panel panel-danger">
        <div class="panel-heading">Register </div>
        <div class="panel-body">
  
         <form id="form1" runat="server">
        
            <asp:Label ID="lName" runat="server" Text="Name"></asp:Label>
            <br />
            <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lUsername" runat="server" Text="Username"></asp:Label>
            <br />
            <asp:TextBox ID="tbUsername" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lPassword" runat="server" Text="Password"></asp:Label>
            <br />
            <asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="bRegister" runat="server" Text="Register" OnClick="bRegister_Click" />
            <br />
            <asp:Button ID="bGoBack" runat="server" Text="Go Back" OnClick="bGoBack_Click" />
        
    </form>
        
   </div>
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
