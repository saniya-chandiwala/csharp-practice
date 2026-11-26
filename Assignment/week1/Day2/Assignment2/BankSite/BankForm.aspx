<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BankForm.aspx.cs" Inherits="BankForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style type="text/css">
        .auto-style1 {
            width: 778px;
        }
        .auto-style8 {
            width: 78px;
        }
        .auto-style9 {
            width: 78px;
            height: 30px;
        }
        .auto-style11 {
            width: 78px;
            height: 26px;
        }
        .auto-style12 {
            width: 120px;
            height: 26px;
        }
        .auto-style14 {
            width: 120px;
            height: 30px;
        }
        .auto-style15 {
            width: 120px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style12">
                    <asp:Label ID="lbAccountNumber" runat="server" Text="Account Number"></asp:Label>
                </td>
                <td class="auto-style11">
                    <asp:TextBox ID="txtAccountNumber" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style15">
                    <asp:Label ID="lbAccountName" runat="server" Text="Account Name"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtAccountName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style14">
                    <asp:Label ID="lbAmount" runat="server" Text="Amount"></asp:Label>
&nbsp;</td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style15">
                    <asp:Button ID="btnDeposit" runat="server" Text="Deposit" OnClick="btnDeposit_Click" />
                </td>
                <td class="auto-style8">
                    <asp:Button ID="btnWithdraw" runat="server" Text="Withdraw" OnClick="btnWithdraw_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style15">
                    <asp:Button ID="btnCheckBalance" runat="server" OnClick="btnCheckBalance_Click" Text="Check Balance" />
                </td>
                <td class="auto-style8">
                    <asp:Label ID="lbCheckBalance" runat="server" Text="Amount "></asp:Label>
                </td>
            </tr>
            </table>
    
    </div>
    </form>
</body>
</html>
