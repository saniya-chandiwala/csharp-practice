<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderForm.aspx.cs" Inherits="OrderForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 238px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblTitle" runat="server" Text="Select Products"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblQty" runat="server" Text="Enter Quantity"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:CheckBox ID="chkApple" runat="server" Text="Apple" />
                </td>
                <td>
                    <asp:TextBox ID="txtApple" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:CheckBox ID="chkOnion" runat="server" Text="Onion" />
                </td>
                <td>
                    <asp:TextBox ID="txtOnion" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:CheckBox ID="chkBrocolli" runat="server" Text="Brocolli" />
                </td>
                <td>
                    <asp:TextBox ID="txtBrocolli" runat="server"></asp:TextBox>
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
                    <asp:Button ID="btnGenerateBill" runat="server" Text="Generate Bill" OnClick="btnGenerateBill_Click" />
                </td>
                <td>
                    <asp:Label ID="lbMsg" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lbBill" runat="server" Text=""></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
