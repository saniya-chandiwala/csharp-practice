<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FormEleven.aspx.cs" Inherits="FormEleven" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 274px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblNum1" runat="server" Text="Enter Number 1"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblNum2" runat="server" Text="Enter Number 2"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNum2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblNum3" runat="server" Text="Enter Number 3"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNum3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblNum4" runat="server" Text="Enter Number 4"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNum4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblNum5" runat="server" Text="Enter Number 5"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNum5" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblNum6" runat="server" Text="Enter Number 6"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNum6" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblNum7" runat="server" Text="Enter Number 7"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNum7" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblNum8" runat="server" Text="Enter Number 8"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNum8" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblNum9" runat="server" Text="Enter Number 9"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNum9" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblNum10" runat="server" Text="Enter Number 10"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNum10" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblSum" runat="server" Text="Sum"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblSumOutput" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblAverage" runat="server" Text="Average"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblAverageOutput" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
