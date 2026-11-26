<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Q1Form.aspx.cs" Inherits="Q1Form" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 261px;
        }
        .auto-style3 {
            width: 261px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lbQuestion1" runat="server" Text="-1 + 4 * 6"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="lbSolution1" runat="server" Text="Answer"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lbQuestion2" runat="server" Text="(35 + 5) % 7"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lbSolution2" runat="server" Text="Answer"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lbQuestion3" runat="server" Text="14 + -4 * 6 % 11"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lbSolution3" runat="server" Text="Answer"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lbQuestion4" runat="server" Text="2 + 15/ 6 * 1 - 7 % 2"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lbSolution4" runat="server" Text="Answer"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="btnCalculate" runat="server" OnClick="btnCalculate_Click" Text="Calculate" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

