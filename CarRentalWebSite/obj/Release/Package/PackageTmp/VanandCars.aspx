<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VanandCars.aspx.cs" Inherits="CarRentalWebSite.VanandCars" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Selected="True">Select</asp:ListItem>
            <asp:ListItem>Car</asp:ListItem>
            <asp:ListItem>Van</asp:ListItem>
        </asp:DropDownList>
    <div>
    
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
