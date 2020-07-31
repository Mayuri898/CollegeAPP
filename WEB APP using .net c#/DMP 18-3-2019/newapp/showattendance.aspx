<%@ Page Language="C#" AutoEventWireup="true" CodeFile="showattendance.aspx.cs" Inherits="newapp_showattendance" %>

<!DOCTYPE HTML>
<html lang="en">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="apple-mobile-web-app-capable" content="yes">
    <meta name="viewport" content="width=device-width, initial-scale=1, minimum-scale=1, maximum-scale=1, viewport-fit=cover" />
    <title>Devi Mahalaxmi Polytechnic College</title>
    <link href="https://fonts.googleapis.com/css?family=Poppins:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i|Roboto:100,100i,300,300i,400,400i,500,500i,700,700i,900,900i" rel="stylesheet">
    <link rel="stylesheet" type="text/css" href="styles/framework.css">
    <link rel="stylesheet" type="text/css" href="fonts/css/fontawesome-all.min.css">
</head>
<body class="theme-light" data-highlight="blue2">
    <div id="page-preloader">
        <div class="loader-main"><div class="preload-spinner border-highlight"></div></div>
    </div>
    <div id="page">
        <div class="header header-fixed header-logo-app">
            <a href="index.aspx" class="header-title ultrabold"><span class="color-highlight">DM</span>P</a>
            <a href="#" class="header-icon header-icon-1" data-menu="menu-1"><i class="fas fa-bars"></i></a>
           <asp:Label  CssClass="header-icon header-icon-2" ID="Labelname" runat="server"></asp:Label>
         
            <a href="#" class="header-icon header-icon-3" data-toggle-theme><i class="fas fa-moon"></i></a>
        </div>
        <div id="menu-1" class="menu menu-box-left"
             data-menu-width="250"
             data-menu-load="menu.aspx"
             data-menu-effect="menu-over"
             data-menu-select="page-media">
        </div>
        <div class="bg-highlight" id="reading-progress-bar"></div>
        <div class="page-content header-clear-medium">
           <div class="content"> <form id="form1" runat="server">
    
    <br />
     <center>
    
 <div class="demo-buttons">
               <asp:Button CssClass="button button-m shadow-small button-circle bg-blue1-dark" ID="Button3"  runat="server" Text="FIRST YEAR" onclick="Save_ServerClick1" />  
  
 
               <asp:Button CssClass="button button-m shadow-small button-circle bg-blue1-dark" ID="Button2"  runat="server" Text="SECOND YEAR" onclick="Save_ServerClick2" />  
   
    
               <asp:Button CssClass="button button-m shadow-small button-circle bg-blue1-dark" ID="Button4"  runat="server" Text="THIRD YEAR" onclick="Save_ServerClick3" />  
   
    </div>
         </center>
 
 <br />  
                        

               
             
       <br />   <asp:Label ID="Label1" runat="server"></asp:Label>  
                     
               
                     
    </form>
            
            </div>
           
            
        </div>
        
        
        <div class="menu-hider"></div>
    </div>
    <script type="text/javascript" src="scripts/jquery.js"></script>
    <script type="text/javascript" src="scripts/plugins.js" async></script>
    <script type="text/javascript" src="scripts/custom.js" async></script>
</body>
    </html>
