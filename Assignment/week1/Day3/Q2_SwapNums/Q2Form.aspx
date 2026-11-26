<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Q2Form.aspx.cs" Inherits="Q2Form" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="lbValueA" runat="server" Text="Enter value for A"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtValueA" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbValueB" runat="server" Text="Enter value for B"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtValueB" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSwap" runat="server" Text="Swap Values" OnClick="btnSwap_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbSwapA" runat="server" Text="Value of A after swapping"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lbAfterSwapA" runat="server" Text="Output"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbSwapB" runat="server" Text="Value of B after swapping"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lbAfterSwapB" runat="server" Text="Output"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
