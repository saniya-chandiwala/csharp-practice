<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Library.aspx.cs" Inherits="Library" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style9 {
            width: 151px;
            height: 25px;
        }
        .auto-style10 {
            width: 151px;
        }
        .auto-style11 {
            width: 91px;
            height: 25px;
        }
        .auto-style12 {
            width: 91px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style11">
                    &nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11">
                    <asp:Label ID="lblSelect" runat="server" Text="Select a Book"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:DropDownList ID="ddlBooks" runat="server" Width="102px">
                        <asp:ListItem Value ="1">Lemons</asp:ListItem>
                        <asp:ListItem Value ="2">Lemonade</asp:ListItem>
                        <asp:ListItem Value ="3">Giraffe</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style11">
                    &nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11">
                    &nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:Button ID="btnIssue" runat="server" OnClick="btnIssue_Click" Text="Issue Book" />
                </td>
                <td class="auto-style10">
                    <asp:Label ID="lblIssue" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">
                    &nbsp;</td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
