<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LibraryForm.aspx.cs" Inherits="LibraryForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style6 {
            height: 26px;
        }
        .auto-style7 {
            width: 212px;
        }
        .auto-style8 {
            height: 26px;
            width: 212px;
        }
        .auto-style10 {
            margin-left: 0px;
        }
        .auto-style18 {
            width: 212px;
            height: 30px;
        }
        .auto-style21 {
            height: 30px;
        }
        .auto-style26 {
            width: 201px;
        }
        .auto-style27 {
            height: 26px;
            width: 201px;
        }
        .auto-style28 {
            width: 201px;
            height: 30px;
        }
        .auto-style30 {
            width: 172px;
        }
        .auto-style31 {
            height: 26px;
            width: 172px;
        }
        .auto-style32 {
            width: 172px;
            height: 30px;
        }
        .auto-style33 {
            width: 229px;
        }
        .auto-style34 {
            height: 26px;
            width: 229px;
        }
        .auto-style35 {
            width: 229px;
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style26">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style30">
                    <asp:Label ID="lblHeadingId" runat="server" Text="Book Id"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style26">
                    <asp:Button ID="btnLoad" runat="server" OnClick="btnLoad_Click" Text="Load Book" />
                </td>
                <td class="auto-style33">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style31">
                    <asp:Label ID="lblHeadingTitle" runat="server" Text="Title"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style27">
                    &nbsp;</td>
                <td class="auto-style34">
                    &nbsp;</td>
                <td class="auto-style6">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style30">
                    <asp:Label ID="lblHeadingAuthor" runat="server" Text="Author"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtAuthor" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style26">
                    &nbsp;</td>
                <td class="auto-style33">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style30">
                    <asp:Label ID="lblHeadingCategory" runat="server" Text="Category"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtCategory" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style26">
                    &nbsp;</td>
                <td class="auto-style33">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style30">
                    <asp:Label ID="lblHeadingPrice" runat="server" Text="Price"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style26">
                    &nbsp;</td>
                <td class="auto-style33">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style26">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style32">
                    <asp:Button ID="btnAdd" runat="server" Text="Add Book" OnClick="btnAdd_Click" />
                </td>
                <td class="auto-style18">
                    <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update Based on Id" />
                </td>
                <td class="auto-style28">
                    <asp:Button ID="btnRemove" runat="server" OnClick="btnRemove_Click" Text="Remove Based on Id" />
                </td>
                <td class="auto-style35">
                    <asp:Label ID="lblMsg" runat="server"></asp:Label>
                </td>
                <td class="auto-style21">
                </td>
            </tr>
            <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style26">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style30">
                    <asp:Label ID="lblHeadingFind" runat="server" Text="Find Book By"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:DropDownList ID="ddlCriteria" runat="server">
                        <asp:ListItem Value="id">Book ID</asp:ListItem>
                        <asp:ListItem Value="title">Title</asp:ListItem>
                        <asp:ListItem Value="author">Author</asp:ListItem>
                        <asp:ListItem Value="category">Category</asp:ListItem>
                        <asp:ListItem Value="price">Price</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style26">
                    <asp:TextBox ID="txtSearchData" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style33">
                    <asp:Button ID="btnFind" runat="server" CssClass="auto-style10" OnClick="btnFind_Click" Text="Find Book" />
                </td>
                <td>
                    <asp:Label ID="lblFindMsg" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style26">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            </table>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Button ID="btnDisplay" runat="server" OnClick="btnDisplay_Click" Text="Display All Books" />
                </td>
                <td>
                    <asp:Button ID="btnArranged" runat="server" OnClick="btnArranged_Click" Text="Arranged Based on Title" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDisplay" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblArranged" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
