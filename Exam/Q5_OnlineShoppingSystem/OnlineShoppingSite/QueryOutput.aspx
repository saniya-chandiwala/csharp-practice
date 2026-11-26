<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QueryOutput.aspx.cs" Inherits="QueryOutput" %>

<!DOCTYPE html>

<head runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 498px;
        }
        .auto-style2 {
            width: 158px;
        }
        .auto-style3 {
            height: 42px;
        }
        .auto-style4 {
            width: 498px;
            height: 42px;
        }
        .auto-style5 {
            width: 158px;
            height: 42px;
        }
    </style>

</head>

<body>

<form id="form1" runat="server">

<div>

<table>

    <tr>
        <td>
            &nbsp;</td>

        <td class="auto-style1">
            &nbsp;</td>

        <td class="auto-style2">
            &nbsp;</td>

        <td class="output">
            &nbsp;</td>
    </tr>


    <tr>
        <td>
            <asp:Label ID="lbl1" runat="server" Text="Q1."></asp:Label>
        </td>

        <td class="auto-style1">
            <asp:Label ID="lblQ1" runat="server" Text="Products whose price is greater than ₹1,000 and arrange by Category and then Product Name."></asp:Label>
        </td>

        <td class="auto-style2">
            <asp:Button ID="btnQ1" runat="server" Text="Display Output" OnClick="btnQ1_Click" />
        </td>

        <td class="output">
            <asp:Label ID="lblQ1Op" runat="server"></asp:Label>
        </td>
    </tr>


    <tr>
        <td>
            &nbsp;</td>

        <td class="auto-style1">
            &nbsp;</td>

        <td class="auto-style2">
            &nbsp;</td>

        <td class="output">
            &nbsp;</td>
    </tr>


    <tr>
        <td>
            <asp:Label ID="lbl2" runat="server" Text="Q2."></asp:Label>
        </td>

        <td class="auto-style1">
            <asp:Label ID="lblQ2" runat="server" Text="Products in descending order of Price and then Product Name in descending order."></asp:Label>
        </td>

        <td class="auto-style2">
            <asp:Button ID="btnQ2" runat="server" Text="Display Output" OnClick="btnQ2_Click" />
        </td>

        <td class="output">
            <asp:Label ID="lblQ2Op" runat="server"></asp:Label>
        </td>
    </tr>


    <tr>
        <td>
            &nbsp;</td>

        <td class="auto-style1">
            &nbsp;</td>

        <td class="auto-style2">
            &nbsp;</td>

        <td class="output">
            &nbsp;</td>
    </tr>


    <tr>
        <td>
            <asp:Label ID="lbl3" runat="server" Text="Q3."></asp:Label>
        </td>

        <td class="auto-style1">
            <asp:Label ID="lblQ3" runat="server" Text="Product category along with the number of products available."></asp:Label>
        </td>

        <td class="auto-style2">
            <asp:Button ID="btnQ3" runat="server" Text="Display Output" OnClick="btnQ3_Click" />
        </td>

        <td class="output">
            <asp:Label ID="lblQ3Op" runat="server"></asp:Label>
        </td>
    </tr>


    <tr>
        <td>
            &nbsp;</td>

        <td class="auto-style1">
            &nbsp;</td>

        <td class="auto-style2">
            &nbsp;</td>

        <td class="output">
            &nbsp;</td>
    </tr>


    <tr>
        <td>
            <asp:Label ID="lbl4" runat="server" Text="Q4."></asp:Label>
        </td>

        <td class="auto-style1">
            <asp:Label ID="lblQ4" runat="server" Text="Product Name and Price."></asp:Label>
        </td>

        <td class="auto-style2">
            <asp:Button ID="btnQ4" runat="server" Text="Display Output" OnClick="btnQ4_Click" />
        </td>

        <td class="output">
            <asp:Label ID="lblQ4Op" runat="server"></asp:Label>
        </td>
    </tr>


    <tr>
        <td>
            &nbsp;</td>

        <td class="auto-style1">
            &nbsp;</td>

        <td class="auto-style2">
            &nbsp;</td>

        <td class="output">
            &nbsp;</td>
    </tr>


    <tr>
        <td>
            <asp:Label ID="lbl5" runat="server" Text="Q5."></asp:Label>
        </td>

        <td class="auto-style1">
            <asp:Label ID="lblQ5" runat="server" Text="Each individual tag along with its corresponding Product information."></asp:Label>
        </td>

        <td class="auto-style2">
            <asp:Button ID="btnQ5" runat="server" Text="Display Output" OnClick="btnQ5_Click" />
        </td>

        <td class="output">
            <asp:Label ID="lblQ5Op" runat="server"></asp:Label>
        </td>
    </tr>


    <tr>
        <td>
            &nbsp;</td>

        <td class="auto-style1">
            &nbsp;</td>

        <td class="auto-style2">
            &nbsp;</td>

        <td class="output">
            &nbsp;</td>
    </tr>


    <tr>
        <td>
            <asp:Label ID="lbl6" runat="server" Text="Q6."></asp:Label>
        </td>

        <td class="auto-style1">
            <asp:Label ID="lblQ6" runat="server" Text="Customer Name, Order ID, Product Name, and Order Amount "></asp:Label>
        </td>

        <td class="auto-style2">
            <asp:Button ID="btnQ6" runat="server" Text="Display Output"  OnClick="btnQ6_Click" Height="26px" />
        </td>

        <td class="output">
            <asp:Label ID="lblQ6Op" runat="server"></asp:Label>
        </td>
    </tr>


    <tr>
        <td>
            &nbsp;</td>

        <td class="auto-style1">
            &nbsp;</td>

        <td class="auto-style2">
            &nbsp;</td>

        <td class="output">
            &nbsp;</td>
    </tr>


    <tr>
        <td>
            <asp:Label ID="lbl7" runat="server" Text="Q7."></asp:Label>
        </td>

        <td class="auto-style1">
            <asp:Label ID="lblQ7" runat="server" Text="Average, minimum, maximum, and total sales amount from the available order information"></asp:Label>
        </td>

        <td class="auto-style2">
            <asp:Button ID="btnQ7" runat="server" Text="Display Output" OnClick="btnQ7_Click" />
        </td>

        <td class="output">
            <asp:Label ID="lblQ7Op" runat="server"></asp:Label>
        </td>
    </tr>


    <tr>
        <td>
            &nbsp;</td>

        <td class="auto-style1">
            &nbsp;</td>

        <td class="auto-style2">
            &nbsp;</td>

        <td class="output">
            &nbsp;</td>
    </tr>


    <tr>
        <td>
            <asp:Label ID="lbl8" runat="server" Text="Q8."></asp:Label>
        </td>

        <td class="auto-style1">
            <asp:Label ID="lblQ8" runat="server" Text="Verify Details"></asp:Label>
        </td>

        <td class="auto-style2">
            <asp:Button ID="btnQ8" runat="server" Text="Display Output" OnClick="btnQ8_Click" />
        </td>

        <td class="output">
            <asp:Label ID="lblQ8Op" runat="server"></asp:Label>
        </td>
    </tr>


    <tr>
        <td>
            &nbsp;</td>

        <td class="auto-style1">
            <asp:Label ID="lblName" runat="server" Text="Enter Product Name"></asp:Label>
        </td>

        <td class="auto-style2">
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </td>

        <td class="output">
            &nbsp;</td>
    </tr>


    <tr>
        <td>
            &nbsp;</td>

        <td class="auto-style1">
            &nbsp;</td>

        <td class="auto-style2">
            &nbsp;</td>

        <td class="output">
            &nbsp;</td>
    </tr>


    <tr>
        <td>
            <asp:Label ID="lbl9" runat="server" Text="Q9."></asp:Label>
        </td>

        <td class="auto-style1">
            <asp:Label ID="lblQ9" runat="server" Text="Retrieving an element from a specified position and handle the situation where the requested position does not exist"></asp:Label>
        </td>

        <td class="auto-style2">
            <asp:Button ID="btnQ9" runat="server" Text="Display Output" OnClick="btnQ9_Click" />
        </td>

        <td class="output">
            <asp:Label ID="lblQ9Op" runat="server"></asp:Label>
        </td>
    </tr>


    <tr>
        <td>
            &nbsp;</td>

        <td class="auto-style1">
            <asp:Label ID="lblPosition" runat="server" Text="Enter Position"></asp:Label>
        </td>

        <td class="auto-style2">
            <asp:TextBox ID="txtPosition" runat="server"></asp:TextBox>
        </td>

        <td class="output">
            &nbsp;</td>
    </tr>


    <tr>
        <td>
            &nbsp;</td>

        <td class="auto-style1">
            &nbsp;</td>

        <td class="auto-style2">
            &nbsp;</td>

        <td class="output">
            &nbsp;</td>
    </tr>


    <tr>
        <td>
            <asp:Label ID="lbl10" runat="server" Text="Q10."></asp:Label>
        </td>

        <td class="auto-style1">
            <asp:Label ID="lblQ10" runat="server" Text="Situations where no matching product exists or where the expected unique condition is not satisfied"></asp:Label>
        </td>

        <td class="auto-style2">
            <asp:Button ID="btnQ10" runat="server" Text="Display Output" OnClick="btnQ10_Click" />
        </td>

        <td class="output">
            <asp:Label ID="lblQ10Op" runat="server"></asp:Label>
        </td>
    </tr>

</table>

</div>

</form>

</body>
</html>