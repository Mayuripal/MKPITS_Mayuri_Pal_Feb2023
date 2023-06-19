<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Transaction.aspx.cs" Inherits="TrustProject.Transaction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        Transaction Details</p>
    <table class="w-50">
        <tr>
            <td class="text-center" style="width: 302px">
                <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" GroupName="mode" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Issue" />
            </td>
            <td class="text-center">
                <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" GroupName="mode" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Purchase" />
            </td>
        </tr>
        <tr>
            <td class="text-center" style="width: 302px">Transaction Id</td>
            <td class="text-center">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="width: 302px">Item Id</td>
            <td class="text-center">
                <asp:DropDownList ID="DropDownList1" runat="server" Width="178px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="width: 302px">Transaction Date</td>
            <td class="text-center">
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="width: 302px">
                <asp:Label ID="Label1" runat="server" Text="Department Id"></asp:Label>
            </td>
            <td class="text-center">
                <asp:DropDownList ID="DropDownList2" runat="server" Width="176px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="width: 302px">
                <asp:Label ID="Label2" runat="server" Text="Vendor Id"></asp:Label>
            </td>
            <td class="text-center">
                <asp:DropDownList ID="DropDownList3" runat="server" Width="174px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="width: 302px">Quantity</td>
            <td class="text-center">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
</asp:Content>
