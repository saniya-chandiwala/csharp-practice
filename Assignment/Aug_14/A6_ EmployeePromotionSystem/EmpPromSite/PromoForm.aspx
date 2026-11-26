<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PromoForm.aspx.cs" Inherits="PromoForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 197px;
        }
        .auto-style3 {
            width: 197px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style5 {
            width: 181px;
        }
        .auto-style6 {
            width: 181px;
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblEmp" runat="server" Text="Select Employee"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:DropDownList ID="ddlEmps" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlEmps_SelectedIndexChanged">
                        <asp:ListItem Value="1">Saniya</asp:ListItem>
                        <asp:ListItem Value="2">Ayesha</asp:ListItem>
                        <asp:ListItem Value="3">Vanshika</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Label ID="lblDetails" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="BtnPromote" runat="server" Text="Promote Employee" OnClick="BtnPromote_Click" />
                </td>
                <td class="auto-style5">
                    <asp:Label ID="lblNewDetails" runat="server"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style6"></td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style6">
                    &nbsp;</td>
                <td class="auto-style4">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
