<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeBehind="CustomerListPage.aspx.cs" Inherits="CarRentalWebSite.CustomerListPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br/>
     <br />
     <asp:GridView ID="GridView1" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White"
                    RowStyle-BackColor="#A1DCF2" AlternatingRowStyle-BackColor="White" AlternatingRowStyle-ForeColor="#000"
                    runat="server" AutoGenerateColumns="false" CellPadding="10" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" >

            <Columns>
                
                <asp:BoundField DataField="CustomerId" HeaderText="Customer Id"/>
                <asp:BoundField DataField="Email" HeaderText="Email"/>
                <asp:BoundField DataField="FirstName" HeaderText="First Name"/>
                <asp:BoundField DataField="LastName" HeaderText="Last Name"/>
                <asp:BoundField DataField="PhoneNo" HeaderText="Phone No"/>
                <asp:BoundField DataField="DateOfBirth" HeaderText="Date of Birth"/>
                
          
            </Columns>
            
        
        </asp:GridView>
     <br />
</asp:Content>
