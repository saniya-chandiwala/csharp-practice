<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegForm.aspx.cs" Inherits="RegForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            width: 191px;
        }
        .auto-style4 {
            height: 26px;
            width: 191px;
        }
        .auto-style5 {
            width: 214px;
        }
        .auto-style6 {
            height: 26px;
            width: 214px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <h3>Customer Registration</h3>
                    <td class="auto-style5">
                    
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblUsing" runat="server" Text="Register Using"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:CheckBox ID="chkName" runat="server" Text="Name" />
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    &nbsp;</td>
                <td class="auto-style6">
                    <asp:CheckBox ID="chkEmail" runat="server" Text="Email" />
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style5">
                    <asp:CheckBox ID="chkNumber" runat="server" Text="Contact Number" />
                </td>
                <td>
                    <asp:TextBox ID="txtNumber" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style5">
                    <asp:CheckBox ID="chkAddress" runat="server" Text="Address" />
                </td>
                <td>
                    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style5">
                    <asp:Button ID="btnCreate" runat="server" Text="Create Account" OnClick="btnCreate_Click" style="height: 26px" />
                </td>
                <td>
                    <asp:Label ID="lblDetails" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
