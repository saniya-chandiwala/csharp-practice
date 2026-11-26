<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ConverterForm.aspx.cs" Inherits="ConverterForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 259px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lbInr" runat="server" Text="Enter INR Amount"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtInr" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnConvert" runat="server" Text="Convert To USD" OnClick="btnConvert_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lbUsd" runat="server" Text="USD Amount"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lbUsdAmount" runat="server" Text="Amount"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
