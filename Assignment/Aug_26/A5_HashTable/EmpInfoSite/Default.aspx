<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 245px;
        }
        .auto-style4 {
            width: 283px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="lblId" runat="server" Text="Enter Id"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="lblName" runat="server" Text="Enter Name"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    &nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Button ID="btnAdd" runat="server" Text="Add Employee" OnClick="btnAdd_Click" Width="119px" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="btnChk" runat="server" OnClick="btnChk_Click" Text="Check Employee" />
                </td>
                <td>
                    <asp:Button ID="btnDisplay" runat="server" OnClick="btnDisplay_Click" Text="Display All" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Button ID="btnEmpId" runat="server" OnClick="btnEmpId_Click" Text="Find Emp Using Id" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="btnUpdName" runat="server" OnClick="btnUpdName_Click" Text="Update Name" />
                </td>
                <td>
                    <asp:Button ID="btnRemove" runat="server" OnClick="btnRemove_Click" Text="Remove Employee" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="lblOutput" runat="server"></asp:Label>
                </td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

