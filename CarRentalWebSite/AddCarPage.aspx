<%@ Page Language="C#" MasterPageFile="~/AdminMasterPage.master"  UnobtrusiveValidationMode="None" AutoEventWireup="true" CodeBehind="AddCarPage.aspx.cs" Inherits="CarRentalWebSite.RegisterCar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
 
    
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 95px;
        }
        .auto-style4 {
            width: 246px;
        }
        .auto-style5 {
            width: 107px;
        }
    
            .auto-style6 {
            width: 246px;
            height: 63px;
        }
        .auto-style7 {
            width: 107px;
            height: 63px;
            text-align: right;
        }
        .auto-style8 {
            height: 63px;
        }
    
            </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <table class="auto-style1">
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="LabelSession" runat="server"></asp:Label>
                </td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="LabelMessage" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">Car Make</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBoxMake" runat="server" MaxLength="25"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxMake" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>
                    Total Number of available Cars:</td>
                <td>
                    <asp:Label ID="LabelAvailableCars" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">Car Model</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBoxModel" runat="server" MaxLength="25"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxModel" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>
                    Total Number of available Cars:</td>
                <td>
                    <asp:Label ID="LabelTotalCarOnRent" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">Registration No:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBoxRegNumber" runat="server" MaxLength="25"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxRegNumber" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">Daily Rent:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBoxDailyRent" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxDailyRent" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6"></td>
                <td class="auto-style7">Description:</td>
                <td class="auto-style8" colspan="2">
                    <asp:TextBox ID="TextBoxDescription" runat="server" Height="16px" Width="123px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBoxDescription" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">Availibility:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBoxIsavailable" runat="server" Height="16px" Width="119px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBoxIsavailable" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="ButtonRegister" runat="server" OnClick="ButtonRegister_Click" Text="Register" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
   </asp:Content>