<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeptTrasfer.aspx.cs" Inherits="DeptTrasfer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 184px;
        }
        .auto-style3 {
            width: 184px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h3>Transfer Employee from Training to Development Dept</h3>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblEmp" runat="server" Text="Select Employee"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlEmps" runat="server" Width="104px">
                        <asp:ListItem Value="1">Saniya</asp:ListItem>
                        <asp:ListItem Value="2">Ayesha</asp:ListItem>
                        <asp:ListItem Value="3">Vanshika</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnTransfer" runat="server" Text="Transfer" OnClick="btnTransfer_Click" />
                </td>
                <td>
                    <asp:Label ID="lblTransfer" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
