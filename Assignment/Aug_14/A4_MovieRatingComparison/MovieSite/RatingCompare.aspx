<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RatingCompare.aspx.cs" Inherits="RatingCompare" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 200px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblMovie1" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblMovie2" runat="server" Text=""></asp:Label>
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
                    <asp:Button ID="btnCompare" runat="server" Text="Compare movies" OnClick="btnCompare_Click" />
                </td>
                <td>
                    <asp:Label ID="lblCompare" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
