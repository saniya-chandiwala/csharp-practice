<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ManagementForm.aspx.cs" Inherits="ManagementForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style type="text/css">
        .auto-style1 {
            width: 649px;
        }
        .auto-style4 {
            width: 121px;
        }
        .auto-style5 {
            width: 149px;
        }
        .auto-style6 {
            width: 121px;
            height: 30px;
        }
        .auto-style7 {
            width: 149px;
            height: 30px;
        }
        .auto-style8 {
            width: 78px;
        }
        .auto-style9 {
            width: 78px;
            height: 30px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="lbAccountNumber" runat="server" Text="AccountNumber"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtAccountNumber" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="lbAccountName" runat="server" Text="Account Name"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtAccountName" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="lbDepositAmount" runat="server" Text="Deposit Amount"></asp:Label>
&nbsp;</td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtDepositAmount" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:Button ID="btnDeposit" runat="server" Text="Deposit" OnClick="btnDeposit_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="lbWithdrawAmount" runat="server" Text="WithdrawAmount"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtWithdrawAmount" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:Button ID="btnWithdraw" runat="server" Text="Withdraw" OnClick="btnWithdraw_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Button ID="btnCheckBalance" runat="server" OnClick="btnCheckBalance_Click" Text="CheckBalance" />
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style5">
                    <asp:Label ID="lbCheckBalance" runat="server" Text="Available Amount"></asp:Label>
                </td>
            </tr>
            </table>
    
    </div>
    </form>
</body>
</html>
