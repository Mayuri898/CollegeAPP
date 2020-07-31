<%@ Page Language="C#" AutoEventWireup="true" CodeFile="timetable.aspx.cs" Inherits="newapp_timetable" %>

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
           <div class="content">
               
               <form id="form1" runat="server">
    <p align="right">
<a href="#" data-menu="menu-demo-modal-medium" class="button bg-highlight button-m  round-tiny">Change Operation</a>


              </p> 
    <br />
    <caption class="style1">  
                    <strong><center>Time Table</center></strong>  
    </caption> 
     <table border="1" style="width:100%" >
            <tr>
                <td  colspan="2">Day/Class</td>
                <td>8.00-9.00</td>
                <td>9.00-10.00</td>
                <td>10.00-11.00</td>
                <td>11.00-12.00</td>
                <td>12.00-12.30</td>
                <td>12.30-1.30</td>
                <td>1.30-2.30</td>
                <td>2.30-2.45</td>
                <td>2.45-3.45</td>
                <td>3.45-4.45</td>

            </tr>
                 
                <tr>
                <td class="hide" rowspan="3">Monday</td>
                
            
                <td class="hide">FY</td>
                    <td></td>
                     
                <td> <asp:CheckBox  ID="CheckBox1" runat="server"  /> </td>
                <td>  <asp:CheckBox  ID="CheckBox2" runat="server" /></td>
                <td><asp:CheckBox ID="CheckBox3" runat="server"  /></td>
                <td></td>
                <td ><asp:CheckBox ID="CheckBox4" runat="server"   /></td>
                
                <td><asp:CheckBox ID="CheckBox5" runat="server"  /></td>
                    <td></td>
                <td ><asp:CheckBox ID="CheckBox6" runat="server"   /></td>
                
                <td><asp:CheckBox ID="CheckBox7" runat="server"  /></td>
            </tr>
            <tr>
                <td>SY</td>
                    <td></td>
                     
                <td> <asp:CheckBox  ID="CheckBox8" runat="server"  /> </td>
                <td>  <asp:CheckBox  ID="CheckBox9" runat="server" /></td>
                <td><asp:CheckBox ID="CheckBox10" runat="server"  /></td>
                <td></td>
                <td ><asp:CheckBox ID="CheckBox11" runat="server"   /></td>
                
                <td><asp:CheckBox ID="CheckBox12" runat="server"  /></td>
                    <td></td>
                <td ><asp:CheckBox ID="CheckBox13" runat="server"   /></td>
                
                <td><asp:CheckBox ID="CheckBox14" runat="server"  /></td>
                <%--<td></td>--%>

            </tr>
         
             <tr>
                <td>TY</td>
                    <td></td>
                     
                <td> <asp:CheckBox  ID="CheckBox15" runat="server"  /> </td>
                <td>  <asp:CheckBox  ID="CheckBox16" runat="server" /></td>
                <td><asp:CheckBox ID="CheckBox17" runat="server"  /></td>
                <td></td>
                <td ><asp:CheckBox ID="CheckBox18" runat="server"   /></td>
                
                <td><asp:CheckBox ID="CheckBox19" runat="server"  /></td>
                    <td></td>
                <td ><asp:CheckBox ID="CheckBox20" runat="server"   /></td>
                
                <td><asp:CheckBox ID="CheckBox21" runat="server"  /></td>
            </tr>
                 
                <tr>
                <td rowspan="3">Tuesday</td>
                
            
                <td>FY</td>
                    <td></td>
                     
                <td> <asp:CheckBox  ID="CheckBox22" runat="server"  /> </td>
                <td>  <asp:CheckBox  ID="CheckBox23" runat="server" /></td>
                <td><asp:CheckBox ID="CheckBox24" runat="server"  /></td>
                <td></td>
                <td ><asp:CheckBox ID="CheckBox25" runat="server"   /></td>
                
                <td><asp:CheckBox ID="CheckBox26" runat="server"  /></td>
                    <td></td>
                <td ><asp:CheckBox ID="CheckBox27" runat="server"   /></td>
                
                <td><asp:CheckBox ID="CheckBox28" runat="server"  /></td>
            </tr>
            <tr>
                <td>SY</td>
                    <td></td>
                     
                <td> <asp:CheckBox  ID="CheckBox29" runat="server"  /> </td>
                <td>  <asp:CheckBox  ID="CheckBox30" runat="server" /></td>
                <td><asp:CheckBox ID="CheckBox31" runat="server"  /></td>
                <td></td>
                <td ><asp:CheckBox ID="CheckBox32" runat="server"   /></td>
                
                <td><asp:CheckBox ID="CheckBox33" runat="server"  /></td>
                    <td></td>
                <td ><asp:CheckBox ID="CheckBox34" runat="server"   /></td>
                
                <td><asp:CheckBox ID="CheckBox35" runat="server"  /></td>
                <%--<td></td>--%>

            </tr>
         
             <tr>
                <td>TY</td>
                    <td></td>
                     
                <td> <asp:CheckBox  ID="CheckBox36" runat="server"  /> </td>
                <td>  <asp:CheckBox  ID="CheckBox37" runat="server" /></td>
                <td><asp:CheckBox ID="CheckBox38" runat="server"  /></td>
                <td></td>
                <td ><asp:CheckBox ID="CheckBox39" runat="server"   /></td>
                
                <td><asp:CheckBox ID="CheckBox40" runat="server"  /></td>
                    <td></td>
                <td ><asp:CheckBox ID="CheckBox41" runat="server"   /></td>
                
                <td><asp:CheckBox ID="CheckBox42" runat="server"  /></td>
            </tr>
                 
                <tr>
                <td rowspan="3">Wednesday</td>
                
            
                <td>FY</td>
                    <td></td>
                     
                <td> <asp:CheckBox  ID="CheckBox43" runat="server"  /> </td>
                <td>  <asp:CheckBox  ID="CheckBox44" runat="server" /></td>
                <td><asp:CheckBox ID="CheckBox45" runat="server"  /></td>
                <td></td>
                <td ><asp:CheckBox ID="CheckBox46" runat="server"   /></td>
                
                <td><asp:CheckBox ID="CheckBox47" runat="server"  /></td>
                    <td></td>
                <td ><asp:CheckBox ID="CheckBox48" runat="server"   /></td>
                
                <td><asp:CheckBox ID="CheckBox49" runat="server"  /></td>
            </tr>
            <tr>
                <td>SY</td>
                    <td></td>
                     
                <td> <asp:CheckBox  ID="CheckBox50" runat="server"  /> </td>
                <td>  <asp:CheckBox  ID="CheckBox51" runat="server" /></td>
                <td><asp:CheckBox ID="CheckBox52" runat="server"  /></td>
                <td></td>
                <td ><asp:CheckBox ID="CheckBox53" runat="server"   /></td>
                
                <td><asp:CheckBox ID="CheckBox54" runat="server"  /></td>
                    <td></td>
                <td ><asp:CheckBox ID="CheckBox55" runat="server"   /></td>
                
                <td><asp:CheckBox ID="CheckBox56" runat="server"  /></td>
                <%--<td></td>--%>

            </tr>
         
             <tr>
                <td>TY</td>
                    <td></td>
                     
                <td> <asp:CheckBox  ID="CheckBox57" runat="server"  /> </td>
                <td>  <asp:CheckBox  ID="CheckBox58" runat="server" /></td>
                <td><asp:CheckBox ID="CheckBox59" runat="server"  /></td>
                <td></td>
                <td ><asp:CheckBox ID="CheckBox60" runat="server"   /></td>
                
                <td><asp:CheckBox ID="CheckBox61" runat="server"  /></td>
                    <td></td>
                <td ><asp:CheckBox ID="CheckBox62" runat="server"   /></td>
                
                <td><asp:CheckBox ID="CheckBox63" runat="server"  /></td>
            </tr>
                 
                <tr>
                <td rowspan="3">Thursday</td>
                
            
                <td>FY</td>
                    <td></td>
                     
                <td> <asp:CheckBox  ID="CheckBox64" runat="server"  /> </td>
                <td>  <asp:CheckBox  ID="CheckBox65" runat="server" /></td>
                <td><asp:CheckBox ID="CheckBox66" runat="server"  /></td>
                <td></td>
                <td ><asp:CheckBox ID="CheckBox67" runat="server"   /></td>
                
                <td><asp:CheckBox ID="CheckBox68" runat="server"  /></td>
                    <td></td>
                <td ><asp:CheckBox ID="CheckBox69" runat="server"   /></td>
                
                <td><asp:CheckBox ID="CheckBox70" runat="server"  /></td>
            </tr>
            <tr>
                <td>SY</td>
                    <td></td>
                     
                <td> <asp:CheckBox  ID="CheckBox71" runat="server"  /> </td>
                <td>  <asp:CheckBox  ID="CheckBox72" runat="server" /></td>
                <td><asp:CheckBox ID="CheckBox73" runat="server"  /></td>
                <td></td>
                <td ><asp:CheckBox ID="CheckBox74" runat="server"   /></td>
                
                <td><asp:CheckBox ID="CheckBox75" runat="server"  /></td>
                    <td></td>
                <td ><asp:CheckBox ID="CheckBox76" runat="server"   /></td>
                
                <td><asp:CheckBox ID="CheckBox77" runat="server"  /></td>
                <%--<td></td>--%>

            </tr>
         
             <tr>
                <td>TY</td>
                    <td></td>
                     
                <td> <asp:CheckBox  ID="CheckBox78" runat="server"  /> </td>
                <td>  <asp:CheckBox  ID="CheckBox79" runat="server" /></td>
                <td><asp:CheckBox ID="CheckBox80" runat="server"  /></td>
                <td></td>
                <td ><asp:CheckBox ID="CheckBox81" runat="server"   /></td>
                
                <td><asp:CheckBox ID="CheckBox82" runat="server"  /></td>
                    <td></td>
                <td ><asp:CheckBox ID="CheckBox83" runat="server"   /></td>
                
                <td><asp:CheckBox ID="CheckBox84" runat="server"  /></td>
            </tr>
                 
                <tr>
                <td rowspan="3">Friday</td>
                
            
                <td>FY</td>
                    <td></td>
                     
                <td> <asp:CheckBox  ID="CheckBox85" runat="server"  /> </td>
                <td>  <asp:CheckBox  ID="CheckBox86" runat="server" /></td>
                <td><asp:CheckBox ID="CheckBox87" runat="server"  /></td>
                <td></td>
                <td ><asp:CheckBox ID="CheckBox88" runat="server"   /></td>
                
                <td><asp:CheckBox ID="CheckBox89" runat="server"  /></td>
                    <td></td>
                <td ><asp:CheckBox ID="CheckBox90" runat="server"   /></td>
                
                <td><asp:CheckBox ID="CheckBox91" runat="server"  /></td>
            </tr>
            <tr>
                <td>SY</td>
                    <td></td>
                     
                <td> <asp:CheckBox  ID="CheckBox92" runat="server"  /> </td>
                <td>  <asp:CheckBox  ID="CheckBox93" runat="server" /></td>
                <td><asp:CheckBox ID="CheckBox94" runat="server"  /></td>
                <td></td>
                <td ><asp:CheckBox ID="CheckBox95" runat="server"   /></td>
                
                <td><asp:CheckBox ID="CheckBox96" runat="server"  /></td>
                    <td></td>
                <td ><asp:CheckBox ID="CheckBox97" runat="server"   /></td>
                
                <td><asp:CheckBox ID="CheckBox98" runat="server"  /></td>
                <%--<td></td>--%>

            </tr>
         
             <tr>
                <td>TY</td>
                    <td></td>
                     
                <td> <asp:CheckBox  ID="CheckBox99" runat="server"  /> </td>
                <td>  <asp:CheckBox  ID="CheckBox100" runat="server" /></td>
                <td><asp:CheckBox ID="CheckBox101" runat="server"  /></td>
                <td></td>
                <td ><asp:CheckBox ID="CheckBox102" runat="server"   /></td>
                
                <td><asp:CheckBox ID="CheckBox103" runat="server"  /></td>
                    <td></td>
                <td ><asp:CheckBox ID="CheckBox104" runat="server"   /></td>
                
                <td><asp:CheckBox ID="CheckBox105" runat="server"  /></td>
            </tr>


               
              
           
                
    </table>
             <asp:Button CssClass="button bg-highlight button-m button-full round-tiny"  ID="Button12" runat="server" Text="Fill Attendance Chart " OnClick="SaveStudentAttendance3" />
       
 <br />  <%-- <asp:Button CssClass="button bg-highlight button-m button-full round-tiny" ID="Button1"  runat="server" Text="Log In" onclick="Button1_Click" />  
   --%>
             
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
