<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EmpSalaryForm.aspx.cs" Inherits="EmpSalaryForm" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 231px;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            height: 30px;
        }
        .auto-style4 {
            width: 365px;
        }
        .auto-style5 {
            height: 26px;
            width: 365px;
        }
        .auto-style6 {
            height: 30px;
            width: 365px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td id="lbEmpId" class="auto-style4">Employee Id</td>
                <td>
                    <asp:TextBox ID="txtEmpId" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td id="lbEmpName" class="auto-style4">Employee Name</td>
                <td>
                    <asp:TextBox ID="txtEmpName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td id="lbBasicSalary" class="auto-style5">Basic Salary</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtBasicSalary" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Button ID="btnCalculateSalary" runat="server" OnClick="btnCalculateSalary_Click" Text="Calculate Salary" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="lbHraHeading" runat="server" Text="HRA"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lbHraAmount" runat="server" Text="HRA Amount"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="lbDaHeading" runat="server" Text="DA"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:Label ID="lbDaAmount" runat="server" Text="DA Amount"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="lbGrossSalaryHeading" runat="server" Text="Gross Salary"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:Label ID="lbGrossSalaryAmount" runat="server" Text="Gross Salary Amount"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

