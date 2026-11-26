<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ServiceForm.aspx.cs" Inherits="ServiceForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 186px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblSelect" runat="server" Text="Select A Car"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlOptions" runat="server">
                        <asp:ListItem>Mercedes</asp:ListItem>
                        <asp:ListItem>Honda</asp:ListItem>
                        <asp:ListItem>Nissan</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;<asp:Label ID="lblService" runat="server" Text="Select Service"></asp:Label>
                    &nbsp;</td>
                <td>
                    <asp:CheckBox ID="chkOil" runat="server" Text="Oil Change" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:CheckBox ID="chkWash" runat="server" Text="Car Wash" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:CheckBox ID="chkTyre" runat="server" Text="Tyre Change" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnCalculate" runat="server" Text="Calculate Charges" OnClick="btnCalculate_Click" />
                </td>
                <td>
                    <asp:Label ID="lblOgCost" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Label ID="lblUpdCost" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
