<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Bank.aspx.cs" Inherits="Bank" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 205px;
        }
        .auto-style3 {
            width: 205px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style5 {
            width: 290px;
        }
        .auto-style6 {
            height: 23px;
            width: 290px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblAccount" runat="server" Text="Select Account"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:DropDownList ID="ddlAccounts" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlAccounts_SelectedIndexChanged">
                        <asp:ListItem>101</asp:ListItem>
                        <asp:ListItem>102</asp:ListItem>
                        <asp:ListItem>103</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Label ID="lblDetails" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblAmount" runat="server" Text="Enter Amount"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style6"></td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblOp" runat="server" Text="Selection Operation To Perform"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:RadioButton ID="rdoDeposit" runat="server" GroupName="Operation" Text="Deposit" />
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">
                    <asp:RadioButton ID="rdoWithdraw" runat="server" GroupName="Operation" Text="Withdraw" />
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="btnPerform" runat="server" Text="Perform" OnClick="btnPerform_Click" />
                </td>
                <td class="auto-style6">
                    &nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblBalance" runat="server" Text="Balance"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="lblOutput" runat="server"></asp:Label>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
