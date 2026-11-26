<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FormTen.aspx.cs" Inherits="FormTen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="lbNumber" runat="server" Text="Enter a Number"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNumber" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnSum" runat="server" Text="Sum" OnClick="btnSum_Click" />
                </td>
                <td class="auto-style2">
                    <asp:Label ID="lbSum" runat="server" Text="Sum of Entered Number"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
