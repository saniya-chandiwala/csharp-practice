<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 239px;
        }
        .auto-style3 {
            width: 213px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblAccount" runat="server" Text="Select Account"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:DropDownList ID="ddlAccounts" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlAccounts_SelectedIndexChanged">
                        <asp:ListItem>101</asp:ListItem>
                        <asp:ListItem>102</asp:ListItem>
                        <asp:ListItem>103</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Label ID="lblDetails" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblWithdraw" runat="server" Text="Enter Amount to Withdraw"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnWithdraw" runat="server" Text="Withdraw" OnClick="btnWithdraw_Click" />
                </td>
                <td class="auto-style3">
                    <asp:Label ID="lblOutput" runat="server" Text=""></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
