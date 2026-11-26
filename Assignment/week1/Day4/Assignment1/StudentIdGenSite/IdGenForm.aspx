<%@ Page Language="C#" AutoEventWireup="true" CodeFile="IdGenForm.aspx.cs" Inherits="IdGenForm" %>

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
            width: 285px;
        }
        .auto-style4 {
            height: 26px;
            width: 285px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lbName" runat="server" Text="Enter Student Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="lbCourse" runat="server" Text="Enter Course Name"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtCourse" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="btnGenerateId" runat="server" Text="Generate Student Id" OnClick="btnGenerateId_Click" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lbIdHeading" runat="server" Text="Student Id"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lbId" runat="server" Text="Id"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
