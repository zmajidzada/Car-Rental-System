<%@ Page Language="C#"  MasterPageFile="~/MasterPage1.master"  AutoEventWireup="true" CodeBehind="BookingPage.aspx.cs" Inherits="CarRentalWebSite.ViewCars" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        }
    .auto-style3 {
            width: 130px;
        }
        .auto-style6 {
            width: 24px;
        }
        .auto-style7 {
        }
        .auto-style8 {
        }
        .auto-style9 {
            width: 167px;
        }
        .auto-style10 {
            width: 112px;
        }
        .auto-style11 {
            width: 143px;
        }
    </style>
    </asp:Content>



  <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <br/>
     
      <asp:GridView ID="GridView1" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White"
                    RowStyle-BackColor="#A1DCF2" AlternatingRowStyle-BackColor="White" AlternatingRowStyle-ForeColor="#000"
                    runat="server" AutoGenerateColumns="false" CellPadding="10" >

            <Columns>
                
                <asp:BoundField DataField="CarId" HeaderText="Car ID"/>
                <asp:BoundField DataField="Make" HeaderText="Car Make"/>
                <asp:BoundField DataField="Model" HeaderText="Car Model"/>
                <asp:BoundField DataField="RegNumber" HeaderText="Registration Number"/>
                <asp:BoundField DataField="DailyRent" HeaderText="Daily Rent"/>
                <asp:BoundField DataField="Description" HeaderText="Description"/>
                 <asp:BoundField DataField="Isavailable" HeaderText="Availability"/>
          
            </Columns>
            
        
        </asp:GridView>

          <br />
<br />
<table class="auto-style1">
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style3">
            &nbsp;</td>
        <td class="auto-style6">
            &nbsp;</td>
        <td class="auto-style10">
            &nbsp;</td>
        <td class="auto-style11">
            <asp:Label ID="LabelTotal" runat="server"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style9">Enter your account ID:</td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBoxAccountID" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style6">
            <asp:Button ID="ButtonSearch" runat="server" OnClick="ButtonSearch_Click" Text="Search" />
        </td>
        <td class="auto-style10">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Enter Car Id:</td>
        <td class="auto-style11">
            <asp:TextBox ID="TextBoxCarId" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:Button ID="ButtonCarSearch" runat="server" OnClick="ButtonCarSearch_Click" Text="Search" />
        </td>
    </tr>
    <tr>
        <td class="auto-style9">Customer Email Address:</td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBoxEmail" runat="server" Enabled="False"></asp:TextBox>
        </td>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style10">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Car Make:</td>
        <td class="auto-style11">
            <asp:TextBox ID="TextBoxMake" runat="server" Enabled="False"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style9">Customer Firstname:</td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBoxFirstName" runat="server" Enabled="False"></asp:TextBox>
        </td>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style10">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Car Model:</td>
        <td class="auto-style11">
            <asp:TextBox ID="TextBoxModel" runat="server" Enabled="False"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style9">Customer LastName:</td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBoxLastName" runat="server" Enabled="False"></asp:TextBox>
        </td>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style10">&nbsp; Registration No:</td>
        <td class="auto-style11">
            <asp:TextBox ID="TextBoxRegistration" runat="server" Enabled="False"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style9">Customer Phone No:</td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBoxPhoneNo" runat="server" Enabled="False"></asp:TextBox>
        </td>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style10">&nbsp;&nbsp;&nbsp;&nbsp; Price per Day:</td>
        <td class="auto-style11">
            <asp:TextBox ID="TextBoxDailyPrice" runat="server" Enabled="False"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style9">Customer Age:</td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBoxAge" runat="server" Enabled="False"></asp:TextBox>
        </td>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style10">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Description:</td>
        <td class="auto-style11">
            <asp:TextBox ID="TextBoxDescription" runat="server" Enabled="False"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2" colspan="3"><strong>Customer Address Details:</strong></td>
        <td class="auto-style7" colspan="3">Enter Booking Details please:</td>
    </tr>
    <tr>
        <td class="auto-style9">House/Flat No:</td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBoxHouseNo" runat="server" Enabled="False"></asp:TextBox>
        </td>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style10">Collection Date:</td>
        <td class="auto-style11">
            <asp:TextBox ID="TextBoxCollectionDate" runat="server" ></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style9">Street Name</td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBoxStreetName" runat="server" Enabled="False"></asp:TextBox>
        </td>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style10">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Return Date:</td>
        <td class="auto-style11">
            <asp:TextBox ID="TextBoxReturnDate" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style9">Town:</td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBoxTown" runat="server" Enabled="False"></asp:TextBox>
        </td>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style10">Number of Days:</td>
        <td class="auto-style11">
            <asp:TextBox ID="TextBoxNumDay" runat="server" Enabled="False"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style9">PostCode</td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBoxPostCode" runat="server" Enabled="False"></asp:TextBox>
        </td>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style10">&nbsp;&nbsp;&nbsp;&nbsp; Booking Date:</td>
        <td class="auto-style11">
            <asp:TextBox ID="TextBoxBookingDate" runat="server" Enabled="False"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style3">
            &nbsp;</td>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style10">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Total Cost:&nbsp;</td>
        <td class="auto-style11">
            <asp:TextBox ID="TextBoxTotalCost" runat="server" Enabled="False"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style3">
            &nbsp;</td>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style10">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Booking No:&nbsp;</td>
        <td class="auto-style11">
            <asp:TextBox ID="TextBoxBookingID" runat="server" Enabled="False"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style10">&nbsp;</td>
        <td class="auto-style11">&nbsp;</td>
        <td>
            <asp:Button ID="ButtonBook" runat="server" OnClick="ButtonBook_Click" Text="Book" />
        </td>
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style10">&nbsp;</td>
        <td class="auto-style8" colspan="2">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style10">&nbsp;</td>
        <td class="auto-style11">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style10">&nbsp;</td>
        <td class="auto-style11">&nbsp;</td>
       
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style10">&nbsp;</td>
        <td class="auto-style11">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
<br />
<br />
<br />
<br />

          <br/>
</asp:Content>