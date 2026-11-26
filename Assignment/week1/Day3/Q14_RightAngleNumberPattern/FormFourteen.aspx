<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FormFourteen.aspx.cs" Inherits="FormFourteen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            margin-left: 0px;
        }
        .auto-style3 {
            width: 310px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lbHeading" runat="server" Text="Right Angled Triangle Using Numbers"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btnGenerate" runat="server" CssClass="auto-style2" OnClick="btnGenerate_Click" Text="Generate" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
