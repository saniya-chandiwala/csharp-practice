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
            height: 23px;
        }
        .auto-style3 {
            width: 251px;
        }
        .auto-style4 {
            height: 23px;
            width: 251px;
        }
        .auto-style5 {
            margin-left: 0px;
        }
        .auto-style6 {
            width: 251px;
            height: 26px;
        }
        .auto-style7 {
            height: 26px;
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
                <td class="auto-style3">
                    <asp:Label ID="lblId" runat="server" Text="Enter Transaction Id"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="lblAmount" runat="server" Text="Enter Amount"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="lblPay" runat="server" Text="Select Payment Mode"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:DropDownList ID="ddlPayment" runat="server" CssClass="auto-style5" Height="16px" Width="174px">
                        <asp:ListItem>Credit Card</asp:ListItem>
                        <asp:ListItem>Net Banking</asp:ListItem>
                        <asp:ListItem>UPI</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="btnCheckout" runat="server" OnClick="btnCheckout_Click" Text="Checkout" />
                </td>
                <td>
                    <asp:Label ID="lblBill" runat="server"></asp:Label>
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
