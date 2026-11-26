<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShoppingForm.aspx.cs" Inherits="ShoppingForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 188px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblProd1" runat="server">Select Product 1</asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblProd2" runat="server">Select Product 2</asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:DropDownList ID="ddlProd1" runat="server">
                        <asp:ListItem Value ="1">Phone</asp:ListItem>
                        <asp:ListItem Value ="2">Laptop</asp:ListItem>
                        <asp:ListItem Value ="3">TV</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:DropDownList ID="ddlProd2" runat="server">
                        <asp:ListItem Value ="1">Phone</asp:ListItem>
                        <asp:ListItem Value ="2">Laptop</asp:ListItem>
                        <asp:ListItem Value ="3">TV</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnCompare" runat="server" OnClick="btnCompare_Click" Text="Compare" />
                </td>
                <td>
                    <asp:Label ID="lblResult" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
