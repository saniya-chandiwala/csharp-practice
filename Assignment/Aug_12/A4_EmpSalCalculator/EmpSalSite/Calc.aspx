<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Calc.aspx.cs" Inherits="Calc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 227px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>


    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblSal" runat="server" Text="Enter Salary"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSal" runat="server" Text="0" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblAllowance" runat="server" Text="Enter Allowance"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtAllowance" runat="server" Text="0" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblBonus" runat="server" Text="Enter Bonus"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtBonus" runat="server" Text="0"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblDeduction" runat="server" Text="Enter Deduction"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDeduction" runat="server" Text="0" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblType" runat="server" Text="Select Calculation Type"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlOptions" runat="server" Width="300px">
                        <asp:ListItem Value ="1">Basic Salary</asp:ListItem>
                        <asp:ListItem Value ="2">Basic Salary + Allowance</asp:ListItem>
                        <asp:ListItem Value ="3">Basic Salary + Allowance + Bonus</asp:ListItem>
                        <asp:ListItem Value ="4">Basic Salary + Allowance + Bonus + Deduction</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />
                </td>
                <td>
                    <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>


    
    </div>
    </form>
</body>
</html>
