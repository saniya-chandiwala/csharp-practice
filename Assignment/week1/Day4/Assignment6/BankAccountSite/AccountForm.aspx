<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AccountForm.aspx.cs" Inherits="AccountForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="lblName" runat="server" Text="Enter Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblType" runat="server" Text="Enter Account Type"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtType" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnCreate" runat="server" Text="Create Account" OnClick="btnCreate_Click" />
                </td>
                <td class="auto-style2">
                    <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblTotal" runat="server" Text="Total Accounts"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblCount" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
