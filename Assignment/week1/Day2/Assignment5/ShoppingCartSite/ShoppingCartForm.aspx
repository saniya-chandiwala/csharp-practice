<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShoppingCartForm.aspx.cs" Inherits="ShoppingCartForm" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 337px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lbName" runat="server" Text="Product Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td id="lb" class="auto-style2">
                    <asp:Label ID="lbPrice" runat="server" Text="Product Price"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lbQuantity" runat="server" Text="Product Quantity"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnTotal" runat="server" OnClick="btnTotal_Click" Text="Calculate Total" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lbTotalAmountHeading" runat="server" Text="Total Amount"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lbTotalAmount" runat="server" Text="Total Amount"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lbDiscountedAmountHeading" runat="server" Text="After Discount"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lbDiscountedAmount" runat="server" Text="Discounted Amount"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

