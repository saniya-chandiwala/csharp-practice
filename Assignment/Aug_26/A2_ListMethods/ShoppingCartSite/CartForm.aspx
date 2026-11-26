<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CartForm.aspx.cs" Inherits="CartForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 338px;
        }
        .auto-style5 {
            width: 338px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
        }
        .auto-style7 {
            width: 262px;
        }
        .auto-style8 {
            width: 262px;
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Button ID="btnDispAll" runat="server" OnClick="btnDispAll_Click" Text="Display All Products" />
                </td>
                <td class="auto-style3">
                    <asp:Label ID="lblDisplay" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Button ID="btnMore" runat="server" Text="Add More Products" OnClick="btnMore_Click" />
                </td>
                <td class="auto-style3">
                    <asp:Label ID="lblMore" runat="server" Text=""></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="lblProdId" runat="server" Text="Enter Product Id"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="lblOutput" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Button ID="btnContains" runat="server" OnClick="btnContains_Click" Text="Check Product Exists" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="btnFindProd" runat="server" OnClick="btnFindProd_Click" Text="Find Product" />
                </td>
                <td>
                    <asp:Button ID="btnRemove" runat="server" OnClick="btnRemove_Click" Text="Remove Product" />
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Button ID="btnCost" runat="server" OnClick="btnCost_Click" Text="Products Cost &gt; 1000" />
                </td>
                <td class="auto-style3">
                    <asp:Label ID="lblCostProds" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label1" runat="server" Text="Select Index"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:DropDownList ID="ddlIndex" runat="server">
                        <asp:ListItem Value="0">0</asp:ListItem>
                        <asp:ListItem Value="1">1</asp:ListItem>
                        <asp:ListItem Value="2">2</asp:ListItem>
                        <asp:ListItem Value="3">3</asp:ListItem>
                        <asp:ListItem Value="4">4</asp:ListItem>
                        <asp:ListItem Value="5">5</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Label ID="lblIndexed" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Button ID="btnIndexRemove" runat="server" OnClick="btnIndexRemove_Click" Text="Remove From Index" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="btnInsertIdx" runat="server" OnClick="btnInsertIdx_Click" Text="Insert At Index" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear Cart" />
                </td>
                <td class="auto-style3">
                    <asp:Label ID="lblClear" runat="server"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
