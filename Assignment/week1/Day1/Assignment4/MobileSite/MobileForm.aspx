<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MobileForm.aspx.cs" Inherits="MobileForm" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 257px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" id="lbMobileNumber">Enter Mobile Number</td>
                <td>
                    <asp:TextBox ID="txtMobileNumber" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" id="lbPlanAmount">Enter Plan Amount</td>
                <td>
                    <asp:TextBox ID="txtPlanAmount" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button  runat="server" Text="Calculate GST" ID="btnGST" OnClick="btnGST_Click" />
                </td>
                <td>
                    <asp:Label ID="lbGST" runat="server" Text="GST"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button  runat="server" Text="Calculate Total Amount" ID="btnTotalAmount" OnClick="btnTotalAmount_Click" />
                </td>
                <td>
                    <asp:Label ID="lbTotalAmount" runat="server" Text="Amount"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

