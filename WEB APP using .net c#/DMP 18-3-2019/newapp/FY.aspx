<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FY.aspx.cs" Inherits="newapp_FY" %>

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
        <%--header--%>
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
        <%--End of Header--%>



         <div class="bg-highlight" id="reading-progress-bar"></div>
        <div class="page-content header-clear-medium">
           <div class="content">
               <form id="form2" runat="server">
                    <caption class="style1">  
                    <strong><center>ATTENDANCE SHEET</center></strong>  
                        </caption> 
                   <%--Select Date--%>
                    <div class="form-field form-email">
<label class="contactEmailField color-theme" for="contactEmailField"><strong> Date:</strong> </label>
        <asp:TextBox  ID="TextBox1" runat="server"></asp:TextBox>
        
        <asp:ImageButton CssClass="contactEmailField color-theme" ID="ImageButton1" runat="server" Height="17px"
            ImageUrl="~/newapp/calendar.png" onclick="ImageButton1_Click" Width="21px" />
<asp:Calendar CssClass="contactEmailField color-theme" ID="Calendar1" runat="server"
            onselectionchanged="Calendar1_SelectionChanged" Visible="False">
        </asp:Calendar>

       
</div>
                     <%--   End Of Select date--%>

                    
   
    
    

  <%-- Show and Filter Attendance--%>
                   <div class="form-field form-email">
                    <div class="one-half">
                    <button class="simulate-android button button-xs button-round shadow-medium button-full bg-highlight" onserverclick="Save_ServerClick6" type="" id="Button6" name="Save" runat="server">Show  Whole Attendance</button>
                        </div>
                    <div class="one-half last-column">
                     <button class="simulate-iphones button button-xs button-round shadow-medium button-full bg-highlight" onserverclick="Save_ServerClick" type="First Sem" id="Button3" name="Save" runat="server">Only Absent Student</button>
                    </div></div>
                   
                           
             
    <%--End Show and Filter Attendance--%>                  
           
           <%-- Two Gridviews--%>
             <%-- First Gridview     --%>
         <div class="form-field form-email">             
 <asp:GridView ID="gvCustomers" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField  DataField="IDNUM" HeaderText="Roll No" />
                <asp:BoundField  DataField="Name" HeaderText="Student Name" />
              
              
                 <asp:BoundField  DataField="ENG" HeaderText="ENG" />
                 <asp:BoundField DataField="BMS" HeaderText="BMS" />
                <asp:BoundField DataField="JAVA" HeaderText="JAVA PROGRAMMING " />
                  <asp:BoundField DataField="C" HeaderText="C PROGRAMMING" />
                <asp:BoundField DataField="PHY" HeaderText="PHYSICS" />
                
            </Columns>
        </asp:GridView>
           </div> 
                  <%-- End 1st Gridview--%>
              <%--     second GridView--%>
               
<div class="form-field form-email">             
 <asp:GridView ID="gvCustomers1" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField  DataField="IDNUM" HeaderText="Roll No" />
                <asp:BoundField  DataField="Name" HeaderText="Student Name" />
              
              
                 <asp:BoundField  DataField="ENG" HeaderText="ENG" />
                 <asp:BoundField DataField="BMS" HeaderText="BMS" />
                <asp:BoundField DataField="JAVA" HeaderText="JAVA PROGRAMMING " />
                  <asp:BoundField DataField="C" HeaderText="C PROGRAMMING" />
                <asp:BoundField DataField="PHY" HeaderText="PHYSICS" />
                
            </Columns>
        </asp:GridView>
           </div>



<%--    End 2nd gridview--%>
 <%--End Two Gridviews--%>
<%--Export and Clear Data--%>
                   <div class="form-field form-email">
                   <div class="one-half">
                   <button class="simulate-android button button-xs button-round shadow-medium button-full bg-highlight" onserverclick="Save_ServerClick4" type="" id="Button5" name="Save" runat="server">Export Attendance Sheet</button>
                    </div>
                      <div class="one-half last-column">
                     <button class="simulate-iphones button button-xs button-round shadow-medium button-full bg-highlight" onserverclick="Save_ServerClick3" type="" id="Button4" name="Save" runat="server">Clear Attendance Record</button>
                     </div>
                       </div>
                       
  <%--  End Export and Clear Data     --%>

   
     



 
                   
                        
    </form>
            
            </div>
           
            
        </div>
        
        



        
            
            </div>
           
            
     
    <script type="text/javascript" src="scripts/jquery.js"></script>
    <script type="text/javascript" src="scripts/plugins.js" async></script>
    <script type="text/javascript" src="scripts/custom.js" async></script>
</body>
    </html>