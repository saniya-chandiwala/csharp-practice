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
            width: 225px;
        }
        .auto-style3 {
            width: 243px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add Employees" />
                </td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnDisp" runat="server" OnClick="btnDisp_Click" Text="Display All" />
                </td>
                <td class="auto-style3">
                    <asp:Label ID="lblDisp" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblId" runat="server" Text="Enter ID"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblOutput" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnExist" runat="server" OnClick="btnExist_Click" Text="Check ID Exists" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="btnSal" runat="server" Text="Find Salary" OnClick="btnSal_Click" />
                </td>
                <td>
                    <asp:Button ID="btnRemove" runat="server" OnClick="btnRemove_Click" Text="Remove Employee" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblSal" runat="server" Text="Enter Salary To Be Added"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtSal" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblOp" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnUpdateSal" runat="server" OnClick="btnUpdateSal_Click" Text="Update Salary" />
                </td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnAvg" runat="server" OnClick="btnAvg_Click" Text="Calculate Average Salary" />
                </td>
                <td class="auto-style3">
                    <asp:Label ID="lblAvg" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnGreater" runat="server" OnClick="btnGreater_Click" Text="Salary &gt; 50000" />
                </td>
                <td class="auto-style3">
                    <asp:Label ID="lblGreater" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
