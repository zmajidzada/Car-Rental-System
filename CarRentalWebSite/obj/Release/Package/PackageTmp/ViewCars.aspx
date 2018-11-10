<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeBehind="ViewCars.aspx.cs" Inherits="CarRentalWebSite.ViewCars1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <br />
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
</asp:Content>
