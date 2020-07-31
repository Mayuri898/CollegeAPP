<%@ Page Language="C#" AutoEventWireup="true" CodeFile="forjoin.aspx.cs" Inherits="newapp_forjoin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
               <div class="form-field form-email">
                   <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource1" DataTextField="Id" DataValueField="Id"></asp:DropDownList>
                   <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:DB_A46585_mayuri898ConnectionString %>' SelectCommand="SELECT * FROM [@todayDate]"></asp:SqlDataSource>
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
<label class="contactEmailField color-theme" for="contactEmailField"><strong>Submission Date:</strong> </label>
        <asp:TextBox  ID="TextBox1" runat="server"></asp:TextBox>
        
        <asp:ImageButton CssClass="contactEmailField color-theme" ID="ImageButton1" runat="server" Height="17px"
            ImageUrl="~/newapp/calendar.png" onclick="ImageButton1_Click" Width="21px" />
<asp:Calendar CssClass="contactEmailField color-theme" ID="Calendar1" runat="server"
            onselectionchanged="Calendar1_SelectionChanged" Visible="False">
        </asp:Calendar>

       
</div>
             <asp:Button CssClass="button bg-highlight button-m button-full round-tiny" ID="Button1"  runat="server" Text="Upload" onclick="Upload_ServerClick" />  
    
        </div>
    </form>
</body>
</html>
