<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginType.aspx.cs" Inherits="newapp_LoginType" %>

<!DOCTYPE html>
<html>
<head>
    
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="apple-mobile-web-app-capable" content="yes">
    <meta name="viewport" content="width=device-width, initial-scale=1, minimum-scale=1, maximum-scale=1, viewport-fit=cover" />
    <title>Devi Mahalaxmi Polytechnic College</title>
    <link href="https://fonts.googleapis.com/css?family=Poppins:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i|Roboto:100,100i,300,300i,400,400i,500,500i,700,700i,900,900i" rel="stylesheet">
    <link rel="stylesheet" type="text/css" href="styles/framework.css">
    <link rel="stylesheet" type="text/css" href="fonts/css/fontawesome-all.min.css">
</head>
<body>
    <form id="form1" runat="server">

  <a href="#" class="nav-title color-theme"><span class="color-highlight">Devi Mahalaxmi Polytechnic</span>College</a>
    <span class="nav-text color-theme opacity-50"></span>
  
    
   
    <div class="nav nav-medium">
        <center>
        <div class="divider"></div>
      <div>     
      <asp:Button CssClass="button bg-highlight button-m button-full round-tiny" ID="Button1"  runat="server" Text="Faculty Login" onclick="Upload_ServerClick" />
       </div>
            <br />
        <div>  
          <asp:Button CssClass="button bg-highlight button-m button-full round-tiny" ID="Button2"  runat="server" Text="Student Login" onclick="Upload1_ServerClick" />
      </div>
            <br />

          <div>  
            <asp:Button CssClass="button bg-highlight button-m button-full round-tiny" ID="Button3"  runat="server" Text="Hod Login" onclick="Upload2_ServerClick" />
        </div>
            


            </center>
       <%-- <a href="#"><i class="fas fa-sign-in-alt color-yellow1-light"></i><span>
             onclick="lblMyLabel_Click" runat="server">View List Of Assignments</asp:Label>
            
            </span><i class="fa fa-angle-right"></i></a>--%>

       
       <%-- <a id="page-home" href="SelectSemStud.aspx">
            <i class="fa fa-globe color-green1-dark"></i><span>Add Submission</span><i class="fa fa-angle-right"></i>
        </a>
        <a id="page-components" href="Notification.aspx">
            <i class="fa fa-book color-blue2-dark"></i><span>Notification</span><i class="fa fa-angle-right"></i>
        </a>--%>
        
        
        </div>
        </form>
       
        
 <script type="text/javascript" src="scripts/jquery.js"></script>
    <script type="text/javascript" src="scripts/plugins.js" async></script>
    <script type="text/javascript" src="scripts/custom.js" async></script>
</body>
</html>


