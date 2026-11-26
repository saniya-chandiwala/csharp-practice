<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CalcForm.aspx.cs" Inherits="CalcForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 156px;
        }
        .auto-style3 {
            width: 156px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblSelect" runat="server" Text="Select Employee"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlEmp" runat="server" Height="18px" Width="176px">
                        <asp:ListItem Value="Permanent">Permanent Employee</asp:ListItem>
                        <asp:ListItem Value="Contract">Contract Employee</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnSalary" runat="server" Text="Calculate Salary" OnClick="btnSalary_Click" />
                </td>
                <td>
                    <asp:Label ID="lblSalary" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
