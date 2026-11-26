<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LeaveForm.aspx.cs" Inherits="LeaveForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            width: 198px;
        }
        .auto-style4 {
            height: 23px;
            width: 198px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblName" runat="server" Text="Enter Employee Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblType" runat="server" Text="Select Leave Type"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlType" runat="server">
                        <asp:ListItem>Casual</asp:ListItem>
                        <asp:ListItem>Paid</asp:ListItem>
                        <asp:ListItem>Sick</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblDays" runat="server" Text="Number Of Days"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDays" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                </td>
                <td>
                    <asp:Label ID="lblOutput" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
