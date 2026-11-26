<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BankForm.aspx.cs" Inherits="BankForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 327px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblNum" runat="server" Text="Enter Account Number"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNum" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblName" runat="server" Text="Enter Customers Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblType" runat="server" Text="Select Account Type"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlAccountType" runat="server">
                        <asp:ListItem Text="Savings" Value="Savings"></asp:ListItem>
                        <asp:ListItem Text="Salary" Value="Salary"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblBalance" runat="server" Text="Deposit Money"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtBalance" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnCreate" runat="server" Text="Create Account" OnClick="btnCreate_Click" />
                </td>
                <td>
                    <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblVerifiedDetails" runat="server" Text=""></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
