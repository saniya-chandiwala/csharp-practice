<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Q5Form.aspx.cs" Inherits="Q5Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h3>Enter a Positive and Negative Integer</h3>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lbFirst" runat="server" Text="Enter First Integer"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtFirst" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbSecond" runat="server" Text="Enter Second Integer"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSecond" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnCheck" runat="server" Text="Check" OnClick="btnCheck_Click" />
                </td>
                <td>
                    <asp:Label ID="lbOutput" runat="server" Text="Output"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
