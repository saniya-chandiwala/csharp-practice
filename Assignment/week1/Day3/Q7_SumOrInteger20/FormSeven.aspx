<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FormSeven.aspx.cs" Inherits="FormSeven" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 261px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3> Enter an integer as 20 or integers which sum upto 20</h3>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lbFirst" runat="server" Text="Enter First Integer"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtFirst" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lbSecond" runat="server" Text="Enter Second Integer"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSecond" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnResult" runat="server" Text="Result" OnClick="btnResult_Click" />
                </td>
                <td>
                    <asp:Label ID="lbResult" runat="server" Text="Output"></asp:Label>
                </td>
            </tr>
            </table>
    
    </div>
    </form>
</body>
</html>
