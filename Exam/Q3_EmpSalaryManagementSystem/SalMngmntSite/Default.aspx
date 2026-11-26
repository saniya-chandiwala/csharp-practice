<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 766px;
        }
        .auto-style2 {
            width: 212px;
        }
        .auto-style3 {
            width: 212px;
            height: 23px;
        }
        .auto-style4 {
            width: 766px;
            height: 23px;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">

        <div>

            <table>

                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblId" runat="server"
                            Text="Employee ID"></asp:Label>
                    </td>

                    <td class="auto-style1">
                        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblName" runat="server"
                            Text="Employee Name"></asp:Label>
                    </td>

                    <td class="auto-style1">
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblDepartment" runat="server"
                            Text="Department"></asp:Label>
                    </td>

                    <td class="auto-style1">
                        <asp:TextBox ID="txtDepartment" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblSalary" runat="server"
                            Text="Basic Salary"></asp:Label>
                    </td>

                    <td class="auto-style1">
                        <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style2"></td>

                    <td class="auto-style1">
                        <asp:Button ID="btnCalculate" runat="server"
                            Text="Calculate Salary"
                            OnClick="btnCalculate_Click" />
                    </td>
                </tr>

                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>

                    <td class="auto-style1">
                        &nbsp;</td>
                </tr>

                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblResult" runat="server"
                            Text="Salary Details: "></asp:Label>
                    </td>

                    <td class="auto-style1">
                        <asp:Label ID="lblError" runat="server"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>

                    <td class="auto-style1">
                        &nbsp;</td>
                </tr>

                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblHousing" runat="server" Text="Housing Allowance"></asp:Label>
                    </td>

                    <td class="auto-style1">
                        <asp:Label ID="lblHousingOutput" runat="server"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblTransportation" runat="server" Text="Transportation Allowance"></asp:Label>
                    </td>

                    <td class="auto-style1">
                        <asp:Label ID="lblTransportationOutput" runat="server" Text=""></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblSpecial" runat="server" Text="Special Allowance"></asp:Label>
                    </td>

                    <td class="auto-style1">
                        <asp:Label ID="lblSpecialOutput" runat="server" Text=""></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style3">
                        </td>

                    <td class="auto-style4">
                        </td>
                </tr>

                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblTotal" runat="server" Text="Total Earnings"></asp:Label>
                    </td>

                    <td class="auto-style1">
                        <asp:Label ID="lblTotalOutput" runat="server" Text=""></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblTax" runat="server" Text="Tax"></asp:Label>
                    </td>

                    <td class="auto-style1">
                        <asp:Label ID="lblTaxOutput" runat="server" Text=""></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblNetSalary" runat="server" Text="Net Salary"></asp:Label>
                    </td>

                    <td class="auto-style1">
                        <asp:Label ID="lblNetSalaryOutput" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>

                    <td class="auto-style1">
                        &nbsp;</td>
                </tr>

                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>

                    <td class="auto-style1">
                        &nbsp;</td>
                </tr>

                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>

                    <td class="auto-style1">
                        &nbsp;</td>
                </tr>

                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>

                    <td class="auto-style1">
                        &nbsp;</td>
                </tr>

            </table>

        </div>

    </form>
</body>
</html>
