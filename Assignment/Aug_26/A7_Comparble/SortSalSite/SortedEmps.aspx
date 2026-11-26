<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SortedEmps.aspx.cs" Inherits="SortedEmps" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 30px;
        }
        .auto-style3 {
            width: 318px;
        }
        .auto-style4 {
            height: 30px;
            width: 318px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Button ID="btnEmps" runat="server" OnClick="btnEmps_Click" Text="Employees Before Sorting" />
                </td>
                <td class="auto-style2">
                    <asp:Label ID="lblBefore" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="btnSort" runat="server" OnClick="btnSort_Click" Text="Sort Employees" />
                </td>
                <td>
                    <asp:Label ID="lblAfter" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
