<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FormFour.aspx.cs" Inherits="FormFour" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 151px;
        }
        .auto-style3 {
            width: 271px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h3>Pattern Using Given Number</h3>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lbNumber" runat="server" Text="Enter A Number"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtNumber" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnPattern" runat="server" Text="Generate Pattern" OnClick="btnPattern_Click" />
                </td>
            </tr>
            </table>
    
    </div>
    </form>
</body>
</html>
