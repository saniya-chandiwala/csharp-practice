<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FormTwelve.aspx.cs" Inherits="FormTwelve" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 228px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblNum" runat="server" Text="Enter a number"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNum" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblCubeHeading" runat="server" Text="Cube upto the given value"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblCube" runat="server" Text="Cube"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
