<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentForm.aspx.cs" Inherits="StudentForm" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 30px;
        }
        .auto-style2 {
            height: 30px;
            width: 476px;
        }
        .auto-style3 {
            height: 30px;
            width: 207px;
        }
    </style>
</head>
<body>
     <form id="form1" runat="server">
        <table class="auto-style2">
            <tr>
                <td class="auto-style3" id="lbStudentId">Student Id</td>
                <td>
                    <asp:TextBox ID="txtStudentId" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" id="lbStudentName">Student Name</td>
                <td>
                    <asp:TextBox ID="txtStudentName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" id="lbEnglishMarks">English Marks</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtEnglishMarks" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" id="lbMathsMarks">Maths Marks</td>
                <td>
                    <asp:TextBox ID="txtMathsMarks" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" id="lbScienceMarks">Science Marks</td>
                <td>
                    <asp:TextBox ID="txtScienceMarks" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="btnResult" runat="server" OnClick="btnResult_Click" Text="Result" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lbTotalMarksHeading" runat="server" Text="Total Marks"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lbTotalMarks" runat="server" Text="0"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lbAverageMarksHeading" runat="server" Text="Average Marks"></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:Label ID="lbAverageMarks" runat="server" Text="0"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lbResultHeading" runat="server" Text="Result"></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:Label ID="lbResult" runat="server" Text="Not Calculated"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>

