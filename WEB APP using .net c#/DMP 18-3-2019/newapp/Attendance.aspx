<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Attendance.aspx.cs" Inherits="Attendance" %>

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
    <caption class="style1">  
                    <strong><center>LOGIN HERE</center></strong>  
    </caption> 
    <div class="form-field form-email">
<label class="contactEmailField color-theme" for="contactEmailField">Username: </label>
        <asp:TextBox CssClass="contactField requiredField" ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"   
ControlToValidate="TextBox1" ErrorMessage="Please Enter Your Username"   
ForeColor="Red"></asp:RequiredFieldValidator> 
</div>
    <div class="form-field form-email">
<label class="contactEmailField color-theme" for="contactEmailField">Password: </label>

                 <asp:TextBox ID="TextBox2" TextMode="password" runat="server"></asp:TextBox> 
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"   
ControlToValidate="TextBox2" ErrorMessage="Please Enter Your Password"   
ForeColor="Red"></asp:RequiredFieldValidator>  
        </div>
 
 <br />   <asp:Button CssClass="button bg-highlight button-m button-full round-tiny" ID="Button1"  runat="server" Text="Log In" onclick="Button1_Click" />  
   
             
       <br />   <asp:Label ID="Label1" runat="server"></asp:Label>  
                     
               
                        <a href="index.aspx" style="color:#0d4d8b;"><strong>Forget Password?</strong></a>
                           &nbsp;  &nbsp;  &nbsp;  &nbsp;   &nbsp; 
                           <a href="RegistrationOfStaff.aspx" style="color:#0d4d8b;"><strong>Create new account?</strong></a>
                 
       
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
