<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FormSix.aspx.cs" Inherits="FormSix" %>

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
        <h2>sum of two given integers, if values are equal triple of their sum </h2>
    
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="lbFirst" runat="server" Text="Enter First Integer"></asp:Label>
                </td>
                <td>
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
                    <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbResultHeading" runat="server" Text="Summation"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lbResult" runat="server" Text="Calculated Value"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
