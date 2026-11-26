<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Rental.aspx.cs" Inherits="Rental" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 150px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblSelect" runat="server" Text="Select Vehicle To Rent"></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList ID="rblVehicle" runat="server">
                        <asp:ListItem>Car</asp:ListItem>
                        <asp:ListItem>Bike</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblDays" runat="server" Text="Days to Rent"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDays" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnCalc" runat="server" Text="Calculate Rent" OnClick="btnCalc_Click" />
                </td>
                <td>
                    <asp:Label ID="lblOutput" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
