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
            width: 179px;
        }
        .auto-style3 {
            width: 179px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style5 {
            height: 23px;
            width: 255px;
        }
        .auto-style6 {
            width: 255px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style5"></td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblData" runat="server" Text="Enter Data"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtData" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="lblOutput" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add Data" />
                </td>
                <td class="auto-style6">
                    <asp:Button ID="btnDisplay" runat="server" OnClick="btnDisplay_Click" Text="Display Data" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblIndx" runat="server" Text="Enter Index"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtIndex" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Insert At Index" />
                </td>
                <td class="auto-style6">
                    <asp:Button ID="btnDelIndx" runat="server" OnClick="btnDelIndx_Click" Text="Delete From Index" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style6">
                    &nbsp;</td>
                <td>
                    <asp:Label ID="lblOtherOutput" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblValue" runat="server" Text="Enter Value"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtValue" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnCheck" runat="server" OnClick="btnCheck_Click" Text="Check Value Exists" />
                </td>
                <td class="auto-style6">
                    <asp:Button ID="btnDelVal" runat="server" OnClick="btnDelVal_Click" Text="Delete Using Value" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
