<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 277px;
        }
        .auto-style3 {
            margin-left: 0px;
        }
        .auto-style4 {
            width: 246px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnDisplay" runat="server" Text="Display All Employees" OnClick="btnDisplay_Click" />
                </td>
                <td class="auto-style4">
                    <asp:Label ID="lblDisplay" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblSearch" runat="server" Text="Search For Skills"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtSkill" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnSearch" runat="server" CssClass="auto-style3" OnClick="btnSearch_Click" Text="Search" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
