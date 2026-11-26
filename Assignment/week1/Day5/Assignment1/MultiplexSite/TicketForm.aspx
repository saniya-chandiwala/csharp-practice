<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TicketForm.aspx.cs" Inherits="TicketForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 317px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblName" runat="server" Text="Enter Movie Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblPrice" runat="server" Text="Enter Ticket Price"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblQuantity" runat="server" Text="Enter Ticket Quantity"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnPrice" runat="server" Text="Calculate Price" OnClick="btnPrice_Click" />
                </td>
                <td>
                    <asp:Label ID="lblMessage" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblSubTotalAmount" runat="server" Text="SubTotal Amount"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblSubTotal" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblGstApplied" runat="server" Text="Gst Applied"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblGst" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblTotalAmount" runat="server" Text="Total Amount"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblTotal" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
