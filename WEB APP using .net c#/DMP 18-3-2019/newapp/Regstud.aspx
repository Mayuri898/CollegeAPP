<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Regstud.aspx.cs" Inherits="Regstud" %>

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
  <a href="index.aspx" class="header-title ultrabold"><span class="color-highlight">Devi Mahalaxmi Polytechnic</span>College</a>
  <a href="#" class="header-icon header-icon-1" data-menu="menu-1"><i class="fas fa-bars"></i></a>

<a href="#" class="header-icon header-icon-3" data-toggle-theme><i class="fas fa-moon"></i></a>
</div>
<div id="menu-1" class="menu menu-box-left" 
         data-menu-width="250"
         data-menu-load="menu.aspx"
         data-menu-effect="menu-over"
         data-menu-select="page-components">
</div>
<div class="page-content header-clear">

<div class="content">
<div class="contact-form">
    			 <form id="form1" runat="server">  
                 <div >  
                  <table style="width:100%;">  
                     <caption class="style1">  
                    <strong>Register Here..</strong>  
                      </caption>  
                     <tr>  
                            <td class="style2">  
                            </td>  
                  
                    </tr>  
                     <tr>  <br /><br /><br /><br /><br />
                   <td class="style2">  
<br />First Name:</td>  
                    <td>  
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>  
                    </td>  
                    <td>  
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"   
ControlToValidate="TextBox1" ErrorMessage="Please Enter  Your First Name"   
ForeColor="Red"></asp:RequiredFieldValidator>  
                    </td>
                </tr>  
                <tr>  
                     <td class="style2">  
<br />Last Name:</td>  
                    <td>  
                        <asp:TextBox ID="TextBox2"  runat="server"></asp:TextBox>  
                    </td>  
                    <td>  
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"   
ControlToValidate="TextBox2" ErrorMessage="Please Enter Your Last Name"   
ForeColor="Red"></asp:RequiredFieldValidator>  
                    </td>  
                </tr>
                <tr>  
                     <td class="style2">  
<br />Mobile No:</td>  
                    <td>  
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>  
                    </td>  
                    <td>  
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"   
ControlToValidate="TextBox3" ErrorMessage="Please Enter Your Mobile No"   
ForeColor="Red"></asp:RequiredFieldValidator>  
                    </td>  
                </tr> 
                <tr>  
                     <td class="style2">  
<br />E-mail Id:</td>  
                    <td>  
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>  
                    </td>  
                    <td>  
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"   
ControlToValidate="TextBox4" ErrorMessage="Please Enter Your E-mail Id"   
ForeColor="Red"></asp:RequiredFieldValidator>  
                    </td>  
                </tr>
                      <tr>  
                     <td class="style2">  
<br />Unique Id :</td>  
                    <td>  
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>  
                    </td>  
                    <td>  
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"   
ControlToValidate="TextBox5" ErrorMessage="Please Enter Your Unique Id"   
ForeColor="Red"></asp:RequiredFieldValidator>  
                    </td>  
                </tr>
                      <tr>  
                     <td class="style2">  
<br />User Name :</td>  
                    <td>  
                        <asp:TextBox ID="TextBox6"  runat="server"></asp:TextBox>  
                    </td>  
                    <td>  
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server"   
ControlToValidate="TextBox6" ErrorMessage="Please Enter Username"   
ForeColor="Red"></asp:RequiredFieldValidator>  
                    </td>  
                </tr>
                      <tr>  
                     <td class="style2">  
<br />Password :</td>  
                    <td>  
                        <asp:TextBox ID="TextBox7" TextMode="password" runat="server"></asp:TextBox>  
                    </td>  
                    <td>  
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server"   
ControlToValidate="TextBox7" ErrorMessage="Please Enter Your Password"   
ForeColor="Red"></asp:RequiredFieldValidator>  
                    </td>  
                </tr>
                <tr>  
                     <tr>  
                    <td class="style2">  
 </td>  
                    <td>  
 <br />                       <asp:Button ID="Button1"  runat="server" Text="Register" onclick="Button1_Click" />  
                    </td> 

                  
                     
                   
                    <td>  
       <br />                 <asp:Label ID="Label1" runat="server"></asp:Label>  
                    </td>  
                </tr> 
               
              
                  
            </table>  
        </div>  
    </form> 

</div>


</div>
<div class="divider"></div>
<div class="contact-information last-column">
<div class="container no-bottom">
<h2 class="bolder">Contact</h2>
<p class="contact-information">
<strong class="color-theme">Postal Information</strong>
<br> Titwala, Tal.
<br>  Kalyan, Dist Thane, 
<br> Mumbai, Maharashtra 42160
</p>

</div>
</div>
</div>

</div>


<div class="menu-hider"></div>
</div>
<script type="text/javascript" src="scripts/jquery.js"></script>
<script type="text/javascript" src="scripts/plugins.js" async></script>
<script type="text/javascript" src="scripts/custom.js" async></script>
</body>
    </html>