<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CalcForm.aspx.cs" Inherits="CalcForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="lbAmount" runat="server" Text="Enter an Amount"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnCalc" runat="server" Text="Calculate Tax" OnClick="btnCalc_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbGst" runat="server" Text="Amount of GST Applied"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lbGstAmount" runat="server" Text="Amount"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbTotal" runat="server" Text="Total Amount"></asp:Label>
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