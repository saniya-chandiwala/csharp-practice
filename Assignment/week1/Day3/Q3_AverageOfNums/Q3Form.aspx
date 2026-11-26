<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Q3Form.aspx.cs" Inherits="Q3Form" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 193px;
        }
        .auto-style3 {
            width: 193px;
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lbFirstValue" runat="server" Text="Enter First Value"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtFirstValue" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lbSecondValue" runat="server" Text="Enter Second Value"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSecondValue" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lbThridValue" runat="server" Text="Enter Third Value"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtThridValue" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lbFourthValue" runat="server" Text="Enter Fourth Value"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtFourthValue" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnCalculate" runat="server" Text="Calculate Average" OnClick="btnCalculate_Click" />
                </td>
                <td>
                    <asp:Label ID="lbResult" runat="server" Text="Result"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>