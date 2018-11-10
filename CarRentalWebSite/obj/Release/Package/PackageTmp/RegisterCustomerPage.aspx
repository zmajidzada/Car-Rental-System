<%@ Page Title="" Language="C#"UnobtrusiveValidationMode="None" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="RegisterCustomerPage.aspx.cs" Inherits="CarRentalWebSite.RegisterCustomerPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 617px;
        }
        .auto-style2 {            height: 29px;
        }
        .auto-style3 {
            width: 135px;
        }
        .auto-style9 {
            width: 189px;
        }
        .auto-style12 {
            width: 197px;
        }
        .auto-style13 {
            width: 170px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style13">&nbsp;</td>
        <td class="auto-style12">&nbsp;</td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style9">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2" colspan="5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>Please enter your details:</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="LabelReturnMessage" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style13">&nbsp;</td>
        <td class="auto-style12">
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Invalid e-mail address" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style9">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style13">&nbsp;</td>
        <td class="auto-style12">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Email is required" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style9">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBoxHouseNumber" ErrorMessage="House Number is required" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style13">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Your E-mail:</td>
        <td class="auto-style12">
            <asp:TextBox ID="TextBoxEmail" runat="server" TextMode="Email"></asp:TextBox>
        </td>
        <td class="auto-style3">&nbsp; House Number:</td>
        <td class="auto-style9">
            <asp:TextBox ID="TextBoxHouseNumber" runat="server"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style13">&nbsp;</td>
        <td class="auto-style12">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxPassword" ErrorMessage="Password is required" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style9">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style13">&nbsp;</td>
        <td class="auto-style12">
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBoxPassword" ControlToValidate="TextBoxRepeatPSWD" ErrorMessage="Passwords do not match" ForeColor="Red"></asp:CompareValidator>
        </td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style9">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBoxStreetName" ErrorMessage="Street name is required" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style13">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Your password:</td>
        <td class="auto-style12">
            <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password"></asp:TextBox>
        </td>
        <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Street Name:</td>
        <td class="auto-style9">
            <asp:TextBox ID="TextBoxStreetName" runat="server"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style13">&nbsp;</td>
        <td class="auto-style12">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxRepeatPSWD" ErrorMessage="Repeat password is required" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style9">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TextBoxTown" ErrorMessage="City is required field" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style13">&nbsp; Your re-password:</td>
        <td class="auto-style12">
            <asp:TextBox ID="TextBoxRepeatPSWD" runat="server" TextMode="Password"></asp:TextBox>
        </td>
        <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Town/City:</td>
        <td class="auto-style9">
            <asp:TextBox ID="TextBoxTown" runat="server"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style13">&nbsp;</td>
        <td class="auto-style12">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxFirstName" ErrorMessage="First name is required" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style9">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="TextBoxPostCode" ErrorMessage="Post code is required" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style13">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Your first name:</td>
        <td class="auto-style12">
            <asp:TextBox ID="TextBoxFirstName" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Post Code:</td>
        <td class="auto-style9">
            <asp:TextBox ID="TextBoxPostCode" runat="server"></asp:TextBox>
        </td>
        <td>
            <br />
        </td>
    </tr>
    <tr>
        <td class="auto-style13">&nbsp;</td>
        <td class="auto-style12">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBoxLastName" ErrorMessage="Last name is required" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style9">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBoxPhoneNumber" ErrorMessage="Phone is required" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style13">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Your last name:</td>
        <td class="auto-style12">
            <asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style3">&nbsp;&nbsp;&nbsp; Your phone No:</td>
        <td class="auto-style9">
            <asp:TextBox ID="TextBoxPhoneNumber" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style13">&nbsp;</td>
        <td class="auto-style12">
            &nbsp;</td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style9">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="TextBoxDateOfBirth" ErrorMessage="DOB is required" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style13">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
        <td class="auto-style12">
            &nbsp;</td>
        <td class="auto-style3">&nbsp;Your Date of Birth:&nbsp;</td>
        <td class="auto-style9">
            <asp:TextBox ID="TextBoxDateOfBirth" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style13">&nbsp;</td>
        <td class="auto-style12">&nbsp;</td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style9">
            <asp:Button ID="BTNRegister" runat="server" OnClick="BTNRegister_Click" Text="Register" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style13">&nbsp;</td>
        <td class="auto-style12">&nbsp;</td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style9">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style13">&nbsp;</td>
        <td class="auto-style12">&nbsp;</td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style9">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style13">&nbsp;</td>
        <td class="auto-style12">&nbsp;</td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style9">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
