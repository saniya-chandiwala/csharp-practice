<%@ Page Language="C#" AutoEventWireup="true" CodeFile="App.aspx.cs" Inherits="App" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 239px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td><h2>Banking Application</h2></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnDetails" runat="server" Text="Get Details" OnClick="btnDetails_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style2">
                                <asp:Label ID="lblNameHeading" runat="server" Text="Bank Name"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblName" runat="server" Text=""></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">
                                <asp:Label ID="lblBalHeading" runat="server" Text="Minimum Balance"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblBal" runat="server" Text=""></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">
                                <asp:Label ID="lblWithdrawalHeading" runat="server" Text="Maximum Withdrawal Amount"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblWithdrawal" runat="server" Text=""></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">
                                <asp:Label ID="lblVerHeading" runat="server" Text="Application Version"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblVer" runat="server" Text=""></asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
