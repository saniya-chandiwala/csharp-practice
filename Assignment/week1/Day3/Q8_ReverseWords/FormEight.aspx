<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FormEight.aspx.cs" Inherits="FormEight" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="lbSentence" runat="server" Text="Enter a sentence"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSentence" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnReverse" runat="server" Text="Reverse Sentence" OnClick="btnReverse_Click" />
                </td>
                <td>
                    <asp:Label ID="lbReverse" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
