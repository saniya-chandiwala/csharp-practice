<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EmployeeForm.aspx.cs" Inherits="EmployeeForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td id="lbEmpId">Employee Id</td>
                <td>
                    <asp:TextBox ID="txtEmpId" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td id="lbEmpName">Employee Name</td>
                <td>
                    <asp:TextBox ID="txtEmpName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td id="lbBasicSalary" class="auto-style2">Basic Salary</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtBasicSalary" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnHRA" runat="server" OnClick="btnHRA_Click" Text="Calculate HRA" />
                </td>
                <td>
                    <asp:Label ID="lbHRA" runat="server" Text="HRA"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnDA" runat="server" OnClick="btnDA_Click" Text="Calculate DA" />
                </td>
                <td>
                    <asp:Label ID="lbDA" runat="server" Text="DA"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="btnGrossSalary" runat="server" OnClick="btnGrossSalary_Click" Text="Calculate Gross Salary" />
                </td>
                <td class="auto-style3">
                    <asp:Label ID="lbGrossSalary" runat="server" Text="Gross Salary"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

