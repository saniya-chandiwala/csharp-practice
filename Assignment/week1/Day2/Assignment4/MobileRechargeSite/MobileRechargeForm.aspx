<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MobileRechargeForm.aspx.cs" Inherits="MobileRechargeForm" %>


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
                    <asp:Button ID="lbCalculatePrice" runat="server" OnClick="lbCalculatePrice_Click" Text="Calculate Price" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lbGstHeading" runat="server" Text="Amount of GST Applied"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lbGst" runat="server" Text="GST"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lbAmountHeading" runat="server" Text="Final Amount"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lbAmount" runat="server" Text="Amount"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>


