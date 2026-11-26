<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FormNine.aspx.cs" Inherits="FormNine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 206px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h3>Sum of First 10 Natural Numbers</h3>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnCalculate" runat="server" Height="26px" Text="Calulate" OnClick="btnCalculate_Click" />
                </td>
                <td>
                    <asp:Label ID="lbSum" runat="server" Text="Sum"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
