<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="AdminAuthPage.aspx.cs" Inherits="CarRentalWebSite.AdminAuthPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 207px;
        }
        .auto-style3 {
            width: 207px;
            text-align: right;
        }
        .auto-style4 {
            width: 124px;
        }
        .auto-style5 {
            width: 173px;
            text-align: right;
        }
        .auto-style6 {
            width: 127px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>
                <asp:Label ID="LabelMSG" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp; Admin Login details:</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style5">Register admin details:</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">UserName:</td>
            <td class="auto-style4">
                <asp:TextBox ID="TextBoxLoginUsername" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style5">UserName:</td>
            <td>
                <asp:TextBox ID="TextBoxRegisterUserName" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Password:</td>
            <td class="auto-style4">
                <asp:TextBox ID="TextBoxLoginPassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style5">Password:</td>
            <td>
                <asp:TextBox ID="TextBoxRegisterPassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4">
                <asp:Button ID="ButtonLogIn" runat="server" OnClick="ButtonLogIn_Click" style="text-align: right; margin-left: 52px" Text="LogIn" Width="78px" />
            </td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>
                <asp:Button ID="ButtonRegister" runat="server" OnClick="ButtonRegister_Click" style="text-align: right; margin-left: 52px" Text="Register" Width="78px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
