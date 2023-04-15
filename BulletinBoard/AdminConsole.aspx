<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminConsole.aspx.cs" Inherits="BulletinBoard.AdminConsole" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Console</title>

     <%--  ITS IMPORTANT TO KNOW THAT I HAVE IMPLEMENTED THE BOOTSTRAP LIBRARY TO AID IN THE CSS ASPECTS OF THIS PROJECT --%>

     <!--Style Sheets-->
  <link rel="stylesheet" href="AdminConsole.css"/>
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
            <span class="auto-style1">ALL USERS:</span><br />
            <br />
            <asp:DataList ID="DataList1" runat="server" OnItemDataBound="DataList1_ItemDataBound" OnItemCommand="DataList1_ItemCommand">
                <ItemTemplate>
                    <table>
                        <tr style="font-family:Arial, Helvetica, sans-serif;font-size:12pt;">
                                                        
                            <td style="width:100px;background-color:#f0f0f0;">
                                <asp:Label ID="UsersID_Label" runat="server" Text=""></asp:Label>
                            </td>

                            <td style="width:250px;;background-color:#f0f0f0;">
                                <asp:Label ID="Name_Label" runat="server" Text=""></asp:Label>
                            </td>

                            <td style="width:100px;;background-color:#f0f0f0;">
                                <asp:Label ID="Username_Label" runat="server" Text=""></asp:Label>
                            </td>

                            <td style="width:100px;;background-color:#f0f0f0;">
                                <asp:Label ID="Password_Label" runat="server" Text=""></asp:Label>
                            </td>

                            <td style="width:100px;;background-color:#f0f0f0;">
                                <asp:Label ID="LLD_Label" runat="server" Text=""></asp:Label>
                            </td>

                            <td style="width:100px;;background-color:#f0f0f0;">
                                <asp:Label ID="LLT_Label" runat="server" Text=""></asp:Label>
                            </td>

                            <td style="width:100px;;background-color:#f0f0f0;">
                                <asp:Button ID="ViewButton" Width="100%" runat="server" Text="View" />
                            </td>

                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
         <asp:Button ID="bGoBack" runat="server" Text="Log Out" OnClick="bGoBack_Click" />    
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
