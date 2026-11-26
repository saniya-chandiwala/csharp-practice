<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MngmntSys.aspx.cs" Inherits="MngmntSys" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 189px;
        }
        .auto-style5 {
            width: 189px;
            height: 30px;
        }
        .auto-style7 {
            width: 225px;
        }
        .auto-style8 {
            width: 225px;
            height: 30px;
        }
        .auto-style10 {
            width: 189px;
            height: 23px;
        }
        .auto-style11 {
            width: 225px;
            height: 23px;
        }
        .auto-style12 {
            width: 183px;
        }
        .auto-style13 {
            width: 183px;
            height: 23px;
        }
        .auto-style14 {
            width: 183px;
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style12">
                    &nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:Label ID="lblId" runat="server" Text="Student Id"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:Label ID="lblName" runat="server" Text="Student Name"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:Label ID="lblMarks" runat="server" Text="Marks"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtMarks" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:Button ID="btnAdd" runat="server" Text="Add Student" OnClick="btnAdd_Click" />
                </td>
                <td class="auto-style3">
                    <asp:Label ID="lblMsg" runat="server"></asp:Label>
                </td>
                <td class="auto-style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style13"></td>
                <td class="auto-style10"></td>
                <td class="auto-style11"></td>
            </tr>
            <tr>
                <td class="auto-style14">
                    <asp:Label ID="lblFind" runat="server" Text="Enter Student ID"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtFindId" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style8">
                    <asp:Label ID="lblStudent" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style14">
                    <asp:Button ID="btnFind" runat="server" Text="Find Student" OnClick="btnFind_Click" />
                </td>
                <td class="auto-style5">
                    <asp:Button ID="btnDelete" runat="server" Text="Delete Student" OnClick="btnDelete_Click" />
                </td>
                <td class="auto-style8">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style8"></td>
            </tr>
            <tr>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:Button ID="btnDisplay" runat="server" Text="Display Students" OnClick="btnDisplay_Click"  />
                </td>
                <td class="auto-style3">
                    <asp:Label ID="lblAllStudents" runat="server"></asp:Label>
                </td>
                <td class="auto-style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">
                    &nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:Button ID="btnMrks" runat="server" OnClick="btnMrks_Click" Text="Mrks &gt; 75" />
                </td>
                <td class="auto-style3">
                    <asp:Label ID="lblMrksGreater" runat="server"></asp:Label>
                </td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">
                    &nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:Button ID="btnSorted" runat="server" OnClick="btnSorted_Click" Text="Sorted By Marks" />
                </td>
                <td class="auto-style3">
                    <asp:Label ID="lblSortedStudents" runat="server"></asp:Label>
                </td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
