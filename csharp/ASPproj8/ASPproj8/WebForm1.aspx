<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASPproj8.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
            border-collapse: collapse;
            border-style: solid;
            border-width: 1px;
        }
        .auto-style4 {
            width: 252px;
            background-color: #CCFFFF;
        }
        .auto-style5 {
            background-color: #CCFFFF;
        }
        .auto-style6 {
            width: 255px;
            text-align: center;
            background-color: #CCFFFF;
        }
        .auto-style7 {
            width: 255px;
            background-color: #CCFFFF;
        }
    </style>
</head>
<body style="height: 519px">
    <form id="form1" runat="server">
        <div class="auto-style1">
            Validation
            <br />
        </div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style6">User Name</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Fill name in textbox1">Enter first name</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">New Password</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="Password doesnot match">Enter correct Password</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Re-enter Password</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">Age</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox4" Display="Dynamic" ErrorMessage="Age should be between 18 &amp; 100" MaximumValue="100" MinimumValue="18" Type="Integer">Enter proper age</asp:RangeValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox4" Display="Dynamic" ErrorMessage="Enter Age">Age cannot be empty</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Email</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="Email should be in correct format" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Enter proper mail</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Date of Birth</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox6" ErrorMessage="Enter  dob in correct format" OnServerValidate="CustomValidator1_ServerValidate">Enter proper dob</asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Submit" />
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
        </table>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
