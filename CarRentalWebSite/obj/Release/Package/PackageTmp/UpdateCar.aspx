<%@ Page Language="C#" UnobtrusiveValidationMode="None" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeBehind="UpdateCar.aspx.cs" Inherits="CarRentalWebSite.UpdateCar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
 
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 168px;
        }
        .auto-style3 {
            width: 164px;
        }
        .auto-style4 {
            height: 18px;
        }
        .auto-style5 {
            width: 168px;
            height: 18px;
        }
        .auto-style6 {
            width: 164px;
            height: 18px;
        }
        .auto-style7 {
            width: 53px;
        }
        .auto-style8 {
            width: 82px;
        }
    </style>
<<style type="text/css">     .auto-style1 {
         width: 10px;
     }
     .auto-style2 {
         width: 240px;
     }
     .auto-style3 {
         width: 162px;
     }
     .auto-style4 {
         width: 364px;
     }
     .auto-style5 {
         height: 26px;
     }
     .auto-style6 {
         width: 204px;
         height: 26px;
     }
     .auto-style7 {
         width: 162px;
         height: 26px;
     }
     .auto-style8 {
         width: 287px;
         height: 26px;
     }
     .auto-style9 {
         width: 364px;
         height: 26px;
     }
     .auto-style10 {
         width: 240px;
         height: 26px;
     }
 </style><style type="text/css">             .auto-style1 {
                 width: 136px;
             }
             .auto-style3 {
                 width: 142px;
             }
             .auto-style4 {
                 width: 239px;
             }
             .auto-style5 {
                 width: 148px;
             }
         </style><style type="text/css">                     .auto-style1 {
                         width: 486px;
                     }
                     .auto-style2 {
                         width: 196px;
                     }
                     .auto-style3 {
                         width: 85px;
                     }
                     .auto-style4 {
                         width: 79px;
                     }
                     .auto-style5 {
                         height: 31px;
                         width: 368px;
                     }
                     .auto-style6 {
                         width: 196px;
                         height: 31px;
                     }
                     .auto-style7 {
                         height: 32px;
                     }
                     .auto-style8 {
                         width: 196px;
                         height: 32px;
                     }
                     .auto-style9 {
                         height: 35px;
                     }
                     .auto-style10 {
                         width: 196px;
                         height: 35px;
                     }
                     .auto-style11 {
                         height: 35px;
                         width: 368px;
                     }
                 </style></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <table class="auto-style1">
            <tr>
                <td class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                <td class="auto-style3" colspan="2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxCarId" ErrorMessage="Enter car id " ForeColor="#CC0000"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">Enter car ID:</td>
                <td class="auto-style3" colspan="2">
                    <asp:TextBox ID="TextBoxCarId" runat="server" Width="130px" style="margin-left: 0px; text-align: left;" Height="22px"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search Car" Width="82px" style="margin-left: 16px" Height="28px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style3" colspan="2">
                    <asp:Label ID="LabelUpdateMessage" runat="server"></asp:Label>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">Make</td>
                <td class="auto-style3" colspan="2">
                    <asp:TextBox ID="TextBoxMake" runat="server" Width="130px" Height="22px"></asp:TextBox>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">Model</td>
                <td class="auto-style7" colspan="2">
                    <asp:TextBox ID="TextBoxModel" runat="server" Width="130px" Height="22px"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    </td>
            </tr>
            <tr>
                <td class="auto-style5">Registration Number:</td>
                <td class="auto-style3" colspan="2">
                    <asp:TextBox ID="TextBoxRegNumber" runat="server" Width="132px" Height="22px"></asp:TextBox>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11">Daily Rent:</td>
                <td class="auto-style9" colspan="2">
                
                    <asp:TextBox ID="TextBoxDailyRent" runat="server" Width="130px" Height="21px"></asp:TextBox>
                
                </td>
                <td class="auto-style10"></td>
            </tr>
            <tr>
                <td class="auto-style5">Description</td>
                <td class="auto-style6" colspan="2">
                    <asp:TextBox ID="TextBoxDescription" runat="server" Width="130px" Height="22px"></asp:TextBox>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">Availablity:</td>
                <td class="auto-style6" colspan="2">
                    <asp:TextBox ID="TextBoxIsavailable" runat="server" Width="130px" Height="22px"></asp:TextBox>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6" colspan="2">
                    &nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style8">
                    <asp:Button ID="ButtonUpdate" runat="server" OnClick="ButtonUpdate_Click" Text="Update" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="ButtonDelete" runat="server" Height="23px" OnClick="ButtonDelete_Click" style="margin-left: 2px" Text="Delete" Width="77px" />
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
        </table>
           
    </asp:Content>