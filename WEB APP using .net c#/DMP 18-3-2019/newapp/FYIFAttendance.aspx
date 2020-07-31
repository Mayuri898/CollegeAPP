<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FYIFAttendance.aspx.cs" Inherits="newapp_FYIFAttendance" %>

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
        <%-- content of header--%>
    <div id="page">
        <div class="header header-fixed header-logo-app">
            <a href="index.aspx" class="header-title ultrabold"><span class="color-highlight">DM</span>P</a>
            <a href="#" class="header-icon header-icon-1" data-menu="menu-1"><i class="fas fa-bars"></i></a>
           <asp:Label  CssClass="header-icon header-icon-3" ID="Labelname" runat="server"></asp:Label>
            
            <a href="Login.aspx" class="header-icon header-icon-2"><i class="fa fa-power-off"></i></a>
            
        </div>
        
        
        <div id="menu-1" class="menu menu-box-left"
             data-menu-width="250"
             data-menu-load="menu.aspx"
             data-menu-effect="menu-over"
             data-menu-select="page-media">
        </div>
        <div id="menu-demo-modal-medium" class="menu menu-box-modal" 
         data-menu-width="300"
         data-menu-height="350"
         data-menu-load="AfterFacultyLogin.aspx"
         data-menu-select="page-menus">
        </div>
              </div>
    <%--End content of header--%>
        <div class="bg-highlight" id="reading-progress-bar"></div>
        <div class="page-content header-clear-medium">
           <div class="content"> <form id="form1" runat="server">
             
     <p align="right">              
<a href="#" data-menu="menu-demo-modal-medium" class="button bg-highlight button-m round-tiny">Change Operation</a>
   </p> 
              
    
    <caption class="style1">  
                    <strong><center>Mark Attendane Here</center></strong>  
    </caption> 
    
    <div class="form-field form-email">
        <label class="contactEmailField color-theme" for="contactEmailField"><strong>Semister:</strong> </label>
          <asp:DropDownList  ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True"   
 Height="32px"   
style="text-align: center" Width="145px">  
                            <asp:ListItem Value="0">-- Select Semister--</asp:ListItem>  
                            <asp:ListItem  Text="I"></asp:ListItem>  
                            <asp:ListItem Text="II"></asp:ListItem>  
                             
                        </asp:DropDownList>  <br />
</div>
<div class="form-field form-email">
        <label class="contactEmailField color-theme" for="contactEmailField"><strong>Subject:</strong> </label>
          <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True"   
 Height="32px"   
style="text-align: center" Width="145px"></asp:DropDownList>  <br />
</div>


    <div>
<label class="contactEmailField color-theme" for="contactEmailField"><strong>Date:</strong> </label>
        <asp:TextBox  ID="TextBox1" runat="server"></asp:TextBox>
        
        <asp:ImageButton CssClass="contactEmailField color-theme" ID="ImageButton1" runat="server" Height="17px"
            ImageUrl="~/newapp/calendar.png" onclick="ImageButton1_Click" Width="21px" />
<asp:Calendar CssClass="contactEmailField color-theme" ID="Calendar1" runat="server"
            onselectionchanged="Calendar1_SelectionChanged" Visible="False">
        </asp:Calendar>

       
</div>
    <div>
                 <asp:GridView ID="gvStudents" runat="server" AutoGenerateColumns="false">
           <Columns>
               <asp:TemplateField HeaderText="Roll No">
                   <ItemTemplate>
                       <asp:Label CssClass="contactEmailField color-theme"  ID="lblRollNo" runat="server" Text='<%#Eval("IDNUM") %>'></asp:Label>
                   </ItemTemplate>
               </asp:TemplateField>
               <asp:TemplateField HeaderText="Roll No">
                   <ItemTemplate>
                       <asp:Label CssClass="contactEmailField color-theme"  ID="lblRollName" runat="server" Text='<%#Eval("Name") %>'></asp:Label>
                   </ItemTemplate>
               </asp:TemplateField>
               
               <asp:TemplateField HeaderText="Select Only Absent Student">
                   <ItemTemplate>
                       <asp:CheckBox ID="chkAttendence" runat="server" />
                   </ItemTemplate>
               </asp:TemplateField>
           </Columns>
       </asp:GridView>
        </div>
 <%--buttons gridview--%>

             <div class="one-half last-column">
                       <asp:Button CssClass="button bg-highlight button-m button-full round-tiny" ID="btnSave"  runat="server" Text="Save" onclick="SaveStudentAttendance" />  
               </div>
               <div class="one-half last-column">
                  <asp:Button CssClass="button bg-highlight button-m button-full round-tiny" ID="btnBack"  runat="server" Text="Back To TimeTable" onclick="btn_click" />  

                  </div>   
                 
          
              <%-- End buttons gridview--%>
 <br />      
        
                     
               
                        
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
